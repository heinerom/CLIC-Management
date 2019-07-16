using CLICDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLICC
{
    public partial class Admin_Registration : Form
    {
        public Admin_Registration()
        {
            InitializeComponent();
            this.skinEngine2 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
        }

        private void Admin_Registration_Load(object sender, EventArgs e)
        {
            this.skinEngine2.SkinFile = Application.StartupPath + "//PageColor1.ssk";

            Sunisoft.IrisSkin.SkinEngine se = null;
            se = new Sunisoft.IrisSkin.SkinEngine();
            se.SkinAllForm = true;
        }


        private void BtnBack_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhone.Text = "";
            txtPass.Text = "";
            txtconfirmPass.Text = "";
            txtUsername.Text = "";

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Validator.IsProvided(txtFirstName, "First Name ") &&
                    Validator.IsProvided(txtLastName, "Last Name ") &&
                    Validator.IsProvided(txtPhone, "Phone ") &&
                    Validator.IsProvided(txtUsername, "Username ") &&
                    Validator.IsProvided(txtPass, "Password ")))
                {

                    Admin admin = new Admin();
                    admin.FirstName = txtFirstName.Text;
                    admin.LastName = txtLastName.Text;
                    admin.Phone = txtPhone.Text;
                    admin.Username = txtUsername.Text;
                    if (txtPass.Text != txtconfirmPass.Text)
                    {
                        MessageBox.Show("Password must be same as Confirm Password");
                        txtconfirmPass.Clear();
                        txtconfirmPass.Focus();
                        return;
                    }

                    admin.Password = txtPass.Text;


                    AdminDB.InsertAdminUser(admin);
                    Index form = new Index();
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unanticipated error occurred: " + ex.Message, ex.GetType().ToString());
            }

        }
    }
}
