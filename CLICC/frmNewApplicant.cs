using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using CLICDB;
using System.Text.RegularExpressions;

namespace CLICC
{
    public partial class frmNewApplicant : Form
    {
        String Client, Manager;
        String ReqNote;
        DateTime? dateBirth = null;
        //int Child = 0;
        public static int id;
        public static int ccid;


        public frmNewApplicant()
        {

            InitializeComponent();
        }
        //On Form_Load it will load all functions  
        private void FrmNewApplicant_Load(object sender, EventArgs e)
        {
            panel1.Tag = 9999;
            panel3.Tag = 9999;
            panel4.Tag = 9999;
            lblValidPostal.Tag = 9999;
            cbReqItem.SelectedIndex = 0;
            cbCall.SelectedIndex = 0;
            dtp_load();
            lblValidPostal.Visible = false;

        }

        private void Dtp_ValueChanged(object sender, EventArgs e)
        {

            if (((DateTimePicker)sender).Checked == false)
            {
                ((DateTimePicker)sender).CustomFormat = " ";
                ((DateTimePicker)sender).Format = DateTimePickerFormat.Custom;
            }
            else
            {
                ((DateTimePicker)sender).Format = DateTimePickerFormat.Short;
            }

            dtp_load();

        }

        private void dtp_load()
        {
            // when the date is null, leave it blank and unchecked
            dtBirth.ValueChanged += new System.EventHandler(this.Dtp_ValueChanged);
            dtBirth.ShowCheckBox = true;

            if (dtBirth.Text == null || dtBirth.Text == " ")
            {
                dtBirth.Checked = false;
                dateBirth = null;
            }
            else
            {
                dtBirth.Checked = true;
                dateBirth = Convert.ToDateTime(dtBirth.Text);
            }
        }

        // On submit button click it will send all data to the database 
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Validator.IsProvided(txtFirstName, "First Name ") &&
                    Validator.IsProvided(txtLastName, "Last Name") &&
                    Validator.IsProvided(txtPrimaryPhone, "Primary Phone") &&
                    Validator.IsNonString(txtPrimaryPhone, "Primary Phone")  &&
                    Validator.IsProvided(txtAdd, "Address") &&
                    Validator.IsProvided(txtPostalCode, "Postal Code") &&
                    Validator.IsProvided(txtChild, "No Of Child") &&
                    Validator.IsNonString(txtChild, "No Of Child") &&
                    Validator.IsNonStringEmpty(txtSecPhone, "Secondary Phone")))
                {
                    dtp_load();

                    Applicant applicant = new Applicant();

                    applicant.DateRequested = Convert.ToDateTime(dtPApplication.Text);
                    applicant.FirstName = txtFirstName.Text.ToString();
                    applicant.LastName = txtLastName.Text.ToString();
                    applicant.DateOfBirth = dateBirth;
                    applicant.PrimaryPhone = txtPrimaryPhone.Text.ToString();
                    applicant.SecondaryPhone = txtSecPhone.Text.ToString();

                    if (txtEmail.Text == "")
                    {
                        applicant.Email = txtEmail.Text.ToString();
                    }
                    else if (!(Regex.Match(txtEmail.Text, @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                                + @"([-a-zA-Z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$").Success))
                    {
                        MessageBox.Show("Invalid Email", "Message", MessageBoxButtons.OK);
                        txtEmail.Focus();
                        return;
                    }
                    else
                    {
                        applicant.Email = txtEmail.Text.ToString();
                    }

                   // applicant.Email = txtEmail.Text.ToString();
                    applicant.AppAddress = txtAdd.Text.ToString();



                    if (!(Regex.Match(txtPostalCode.Text, @"^[A-Za-z]{1}[0-9]{1}[A-Za-z]{1}[ ]?[0-9]{1}[A-Za-z]{1}[0-9]{1}$").Success))
                    {
                        MessageBox.Show("Invalid Postal Code. It should be in 'T3J1Y4' format.!", "Message", MessageBoxButtons.OK);
                        txtPostalCode.Focus();
                        return;
                    }
                    else
                    {
                        applicant.PostalCode = txtPostalCode.Text.ToString();
                    }


                    if (rdYes.Checked == false && rdNo.Checked == false)
                    {
                        MessageBox.Show("Please Select Valid Option for Former Client.");
                        return;
                    }
                    else
                    {
                        applicant.FormerClient = Client.ToString();
                    }

                    if (Client == "Yes")
                    {
                        applicant.LastVisit = txtWhen.Text.ToString();
                    }
                    else if (Client == "No")
                    {
                        applicant.FormerClient = "No";
                        applicant.LastVisit = "No";
                    }
                    applicant.NoOfChildren = Convert.ToInt32(txtChild.Text.ToString());
                    if (rdYesClient.Checked == false && rdNoClient.Checked == false)
                    {
                        MessageBox.Show("Please Select Valid Option for Case Manager.");
                        return;
                    }
                    else
                    {
                        if (Manager == "Yes")
                        {
                            applicant.CaseManager = txtCaseManager.Text.ToString();
                            applicant.Agency = txtAgency.Text.ToString();
                        }
                        else if (Manager == "No")
                        {
                            applicant.CaseManager = "No";
                            applicant.Agency = "No";
                        }
                    }


                    applicant.RequestedItem = cbReqItem.SelectedIndex.ToString();

                    if (txtReqNotes.Text == "")
                    {
                        ReqNote = "No Special Request";
                        applicant.RequestedNote = ReqNote;
                    }
                    else
                    {
                        applicant.RequestedNote = txtReqNotes.Text.ToString();
                    }


                    applicant.CallStatus = cbCall.SelectedIndex.ToString();

                    ApplicantDB.InsertApplicant(applicant);
                    id = ApplicantDB.id;
                    Applicant ap = ApplicantDB.getId(id);
                    ccid = ap.ApplicationId;

                    if (ccid == 0)
                    {
                        var confirm = MessageBox.Show("Applicant Already exist.! Are you sure to update this application?", "Update Client Details", MessageBoxButtons.YesNo);
                        if (confirm == DialogResult.Yes)
                        {
                            //ccid = ap.ApplicationId;
                            id = ApplicantDB.id;
                            frmEditApplicant frmEdit = new frmEditApplicant();
                            frmEdit.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show(" New Applicant added Successfully.");
                        reset();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unanticipated error occurred: " + ex.Message, ex.GetType().ToString());
            }
        }


        // on reset button click it will clear all the data from the form
        private void BtnReset_Click(object sender, EventArgs e)
        {
            reset();
        }


        private void reset()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPrimaryPhone.Text = "";
            txtSecPhone.Text = "";
            txtEmail.Text = "";
            txtAdd.Text = "";
            txtPostalCode.Text = "";
            lblValidPostal.Visible = false;
            txtChild.Text = "";
            txtReqNotes.Text = "";
            if (txtCaseManager.Visible == true)
            {
                txtCaseManager.Text = "";

            }
            if (txtAgency.Visible == true)
            {
                txtAgency.Text = "";
            }
            if (txtWhen.Visible == true)
            {
                txtWhen.Text = "";
            }
            if (rdYes.Checked == true || rdNo.Checked == true)
            {
                rdNo.Checked = false;
                rdYes.Checked = false;
            }
            if (rdYesClient.Checked == true || rdNoClient.Checked == true)
            {
                rdYesClient.Checked = false;
                rdNoClient.Checked = false;
            }
            dtBirth.Text = "";
            dtPApplication.Text = "";
            cbReqItem.SelectedIndex = 0;
            cbCall.SelectedIndex = 0;
            ApplicantDB.id = 0;
            ccid = 0;
        }
        private void RdYes_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdYes.Checked == true)
            {
                Client = "Yes";
                lblWhen.Visible = true;
                txtWhen.Visible = true;
            }
            else
            {

                lblWhen.Visible = false;
                txtWhen.Visible = false;
            }
        }

        private void RdNo_CheckedChanged(object sender, EventArgs e)
        {
            Client = "No";
        }

        private void RdNoClient_CheckedChanged(object sender, EventArgs e)
        {
            Manager = "No";
        }

        private void TxtPostalCode_Enter(object sender, EventArgs e)
        {
            lblValidPostal.Visible = true;
        }

        

        private void RdYesClient_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdYesClient.Checked == true)
            {
                Manager = "Yes";
                lblCase.Visible = true;
                txtCaseManager.Visible = true;
                lblAgency.Visible = true;
                txtAgency.Visible = true;
            }
            else
            {
                Manager = "No";
                lblCase.Visible = false;
                txtCaseManager.Visible = false;
                lblAgency.Visible = false;
                txtAgency.Visible = false;
            }

        }


    }
}
