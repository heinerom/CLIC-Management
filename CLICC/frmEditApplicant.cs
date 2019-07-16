using CLICDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLICC
{
    public partial class frmEditApplicant : Form
    {

        DateTime? dateAttempt1 = null;
        DateTime? dateAttempt2 = null;
        DateTime? dateAttempt3 = null;
        DateTime? dateScheduled = null;
        DateTime? datePickedUp = null;
        DateTime? dateBirth = null;

        public int appid;

        public frmEditApplicant()
        {
            InitializeComponent();

            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEditApplicant_Load(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile = Application.StartupPath + "//MidsummerColor1.ssk";

            Sunisoft.IrisSkin.SkinEngine se = null;
            se = new Sunisoft.IrisSkin.SkinEngine();
            se.SkinAllForm = true;

            // check if the form open from the upcoming form or the view form
            if (Application.OpenForms.OfType<frmViewApplicant>().Count() == 1)
            {
                // From viewApplicant form
                appid = frmViewApplicant.id;
            }
            if (Application.OpenForms.OfType<frmUpcoming>().Count() == 1)
            {
                // from upcoming form
                appid = frmUpcoming.id;
            }
            if (Application.OpenForms.OfType<frmNewApplicant>().Count() == 1)
            {
                // from add applicant form
                appid = frmNewApplicant.id;
            }

            frm_load();

            dtp_load();

            txtFirstName.Focus();
            lblValidPostal.Visible = false;
        }

        private void frm_load()
        {
            comboLoad();
            try
            {
                ApplicantInfoStatus App = ApplicantInfoStatusDB.GetInfoStatusesByID(appid);

                dtpRequestDate.Text = App.DateRequested.ToString();
                txtFirstName.Text = App.FirstName;
                txtLastName.Text = App.LastName;
                dtpBirth.Text = App.DateOfBirth.ToString();
                txtPrimaryPhone.Text = App.PrimaryPhone;
                txtSecPhone.Text = App.SecondaryPhone;
                txtEmail.Text = App.Email;
                txtAdd.Text = App.AppAddress;
                txtPostalCode.Text = App.PostalCode;
                txtChild.Text = App.NoOfChildren.ToString();
                txtCaseManager.Text = App.CaseManager;
                txtAgency.Text = App.Agency;
                txtNote.Text = App.RequestedNote;
                if (App.Remarks1 == "" || App.Remarks1 == null)
                {
                    cboRemark1.SelectedIndex = 14;
                }
                else
                {
                    cboRemark1.SelectedIndex = Convert.ToInt32(App.Remarks1);
                }
                if (App.Remarks2 == "" || App.Remarks2 == null)
                {
                    cboRemark2.SelectedIndex = 14;
                }
                else
                {
                    cboRemark2.SelectedIndex = Convert.ToInt32(App.Remarks2);
                }
                if (App.Remarks3 == "" || App.Remarks3 == null)
                {
                    cboRemark3.SelectedIndex = 14;
                }
                else
                {
                    cboRemark3.SelectedIndex = Convert.ToInt32(App.Remarks3);
                }
                
                dtpAttempt1.Text = App.Attempt1.ToString();
                dtpAttempt2.Text = App.Attempt2.ToString();
                dtpAttempt3.Text = App.Attempt3.ToString();
                dtpScheduled.Text = App.ScheduledPickUp.ToString();
                dtpDatePickedUp.Text = App.DatePickedUp.ToString();
                txtPickUpNo.Text = App.PickUpNo;
                txtStatus.Text = App.Comments;
                cboCallStatus.SelectedIndex = Convert.ToInt32(App.CallStatus);
                cboItem.SelectedIndex = Convert.ToInt32(App.RequestedItem);


            }
            catch (Exception ex)
            {//if there was an error loading, give message
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        private void comboLoad()
        {
            SqlConnection Conn = DBConnection.GetConnection();
            // define the select query command
            String queryRemark = "SELECT Id, Remark FROM DropDownList " +
                            "WHERE Id < 16 ORDER BY Id";

            SqlDataAdapter da = new SqlDataAdapter(queryRemark, Conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataTable dt2 = new DataTable();
            da.Fill(dt2);
            DataTable dt3 = new DataTable();
            da.Fill(dt3);
            cboRemark1.DataSource = dt;
            cboRemark1.DisplayMember = "Remark";
            cboRemark1.ValueMember = "Id";
            cboRemark2.DataSource = dt2;
            cboRemark2.DisplayMember = "Remark";
            cboRemark2.ValueMember = "Id";
            cboRemark3.DataSource = dt3;
            cboRemark3.DisplayMember = "Remark";
            cboRemark3.ValueMember = "Id";

            //==================================//            
            String queryStatus = "SELECT Id, Status FROM DropDownList " +
                            "WHERE Id < 4 ORDER BY Id";

            SqlDataAdapter da2 = new SqlDataAdapter(queryStatus, Conn);
            DataTable dt4 = new DataTable();
            da2.Fill(dt4);

            cboCallStatus.DataSource = dt4;
            cboCallStatus.DisplayMember = "Status";
            cboCallStatus.ValueMember = "Id";

        }


        // Datetimepicker change
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
            /*===================Birth Date============================*/
            dtpBirth.ValueChanged += new System.EventHandler(this.Dtp_ValueChanged);
            dtpBirth.ShowCheckBox = true;

            if (dtpBirth.Text == null || dtpBirth.Text == " ")
            {
                dtpBirth.Checked = false;
                dateBirth = null;
            }
            else
            {
                dtpBirth.Checked = true;
                dateBirth = Convert.ToDateTime(dtpBirth.Text);
            }

            /*===================Attempt1============================*/
            dtpAttempt1.ValueChanged += new System.EventHandler(this.Dtp_ValueChanged);
            dtpAttempt1.ShowCheckBox = true;

            if (dtpAttempt1.Text == null || dtpAttempt1.Text == " ")
            {
                dtpAttempt1.Checked = false;
                dateAttempt1 = null;
            }
            else
            {
                dtpAttempt1.Checked = true;
                dateAttempt1 = Convert.ToDateTime(dtpAttempt1.Text);
            }

            /*===================Attempt2============================*/
            dtpAttempt2.ValueChanged += new System.EventHandler(this.Dtp_ValueChanged);
            dtpAttempt2.ShowCheckBox = true;
            if (dtpAttempt2.Text == null || dtpAttempt2.Text == " ")
            {
                dtpAttempt2.Checked = false;
                dateAttempt2 = null;
            }
            else
            {
                dtpAttempt2.Checked = true;
                dateAttempt2 = Convert.ToDateTime(dtpAttempt2.Text);
            }

            /*===================Attempt3============================*/
            dtpAttempt3.ValueChanged += new System.EventHandler(this.Dtp_ValueChanged);
            dtpAttempt3.ShowCheckBox = true;
            if (dtpAttempt3.Text == null || dtpAttempt3.Text == " ")
            {
                dtpAttempt3.Checked = false;
                dateAttempt3 = null;
            }
            else
            {
                dtpAttempt3.Checked = true;
                dateAttempt3 = Convert.ToDateTime(dtpAttempt3.Text);
            }

            /*===================Scheduled Date============================*/
            dtpScheduled.ValueChanged += new System.EventHandler(this.Dtp_ValueChanged);
            dtpScheduled.ShowCheckBox = true;
            if (dtpScheduled.Text == null || dtpScheduled.Text == " ")
            {
                dtpScheduled.Checked = false;
                dateScheduled = null;
            }
            else
            {
                dtpScheduled.Checked = true;
                dateScheduled = Convert.ToDateTime(dtpScheduled.Text);
            }

            /*===================Pickup Date============================*/
            dtpDatePickedUp.ValueChanged += new System.EventHandler(this.Dtp_ValueChanged);
            dtpDatePickedUp.ShowCheckBox = true;
            if (dtpDatePickedUp.Text == null || dtpDatePickedUp.Text == " ")
            {
                dtpDatePickedUp.Checked = false;
                datePickedUp = null;
            }
            else
            {
                dtpDatePickedUp.Checked = true;
                datePickedUp = Convert.ToDateTime(dtpDatePickedUp.Text);
            }
        }

        // Reset the form before editing
        private void BtnReset_Click(object sender, EventArgs e)
        {
            frm_load();
        }

       
        // Save the updated data
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Validator.IsProvided(txtFirstName, "First Name ") &&
                    Validator.IsProvided(txtLastName, "Last Name") &&
                    Validator.IsProvided(txtPrimaryPhone, "Primary Phone") &&
                    Validator.IsNonString(txtPrimaryPhone, "Primary Phone") &&
                    Validator.IsProvided(txtAdd, "Address") &&
                    Validator.IsProvided(txtPostalCode, "Postal Code") &&
                    Validator.IsProvided(txtChild, "No Of Child") &&
                    Validator.IsNonString(txtChild, "No Of Child") &&
                    Validator.IsNonStringEmpty(txtSecPhone, "Secondary Phone")))
                {
                    dtp_load();

                    ApplicantInfoStatus newa = new ApplicantInfoStatus();
                    ApplicantInfoStatus olda = new ApplicantInfoStatus();


                    olda.ApplicationId = appid;
                    newa.DateRequested = Convert.ToDateTime(dtpRequestDate.Text);
                    newa.FirstName = txtFirstName.Text;
                    newa.LastName = txtLastName.Text;
                    newa.PrimaryPhone = txtPrimaryPhone.Text;
                    newa.AppAddress = txtAdd.Text;
                    newa.DateOfBirth = dateBirth;
                    newa.SecondaryPhone = txtSecPhone.Text;

                    if (txtEmail.Text == "")
                    {
                        newa.Email = txtEmail.Text.ToString();
                    }
                    else if (!(Regex.Match(txtEmail.Text, @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                                + @"([-a-zA-Z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                                + @"@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$").Success))
                    //    else if (!(Regex.Match(txtEmail.Text, @"^(?("")("".+?(?<!\\)""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
                    //@"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-0-9a-zA-Z]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9][\-a-z-A-Z0-9]{0,22}[a-zA-Z0-9]))$").Success))

                    {
                        MessageBox.Show("Invalid Email", "Message", MessageBoxButtons.OK);
                        txtEmail.Focus();
                        return;
                    }
                    else
                    {
                        newa.Email = txtEmail.Text.ToString();
                    }


                    if (!(Regex.Match(txtPostalCode.Text, @"^[A-Za-z]{1}[0-9]{1}[A-Za-z]{1}[ ]?[0-9]{1}[A-Za-z]{1}[0-9]{1}$").Success))
                    {
                        MessageBox.Show("Invalid Postal Code. It should be in 'T3J1Y4' format.!", "Message", MessageBoxButtons.OK);
                        txtPostalCode.Focus();
                        return;
                    }
                    else
                    {
                        newa.PostalCode = txtPostalCode.Text;
                    }
                    newa.NoOfChildren = Convert.ToInt32(txtChild.Text);
                    newa.CaseManager = Convert.ToString(txtCaseManager.Text);
                    newa.Agency = Convert.ToString(txtAgency.Text);
                    newa.RequestedItem = Convert.ToString(cboItem.SelectedIndex);
                    newa.RequestedNote = txtNote.Text;
                    newa.CallStatus = Convert.ToString(cboCallStatus.SelectedIndex);
                    newa.Attempt1 = dateAttempt1;
                    newa.Attempt2 = dateAttempt2;
                    newa.Attempt3 = dateAttempt3;
                    newa.Remarks1 = Convert.ToString(cboRemark1.SelectedIndex);
                    newa.Remarks2 = Convert.ToString(cboRemark2.SelectedIndex);
                    newa.Remarks3 = Convert.ToString(cboRemark3.SelectedIndex);
                    newa.ScheduledPickUp = dateScheduled;
                    newa.DatePickedUp = datePickedUp;
                    newa.PickUpNo = txtPickUpNo.Text;
                    newa.Comments = txtStatus.Text;

                    var confirm = MessageBox.Show("Are you sure to update this application?", "Update", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        ApplicantInfoStatusDB.UpdateApplicant(newa, olda);
                        this.Close();
                    }
                }                              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unanticipated error occurred: " + ex.Message, ex.GetType().ToString());
            }
        }


        private void TxtPostalCode_TextChanged(object sender, EventArgs e)
        {
            lblValidPostal.Visible = true;
        }
    }



       
}


