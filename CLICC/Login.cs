using CLICC.Properties;
using CLICDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLICC
{
    public partial class Login : Form
    {
        public Login()
        {

            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.AcceptButton = this.btnLogin;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            ckbRemember.Tag = 9999;
            this.skinEngine1.SkinFile = Application.StartupPath + "//PageColor1.ssk";

            Sunisoft.IrisSkin.SkinEngine se = null;
            se = new Sunisoft.IrisSkin.SkinEngine();
            se.SkinAllForm = true;

            lblWarningP.Visible = false;
            lblWarningU.Visible = false;

            if (Settings.Default.UserName != "")
            {
                txtUsername.Text = Settings.Default.UserName;
                txtPassword.Text = Settings.Default.Password;
                ckbRemember.Checked = true;
            }
            else
            {
                txtUsername.Focus();
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            lblWarningP.Visible = false;
            lblWarningU.Visible = false;

            if (txtPassword.Text == "" && txtUsername.Text == "")
            {
                lblWarningU.Visible = true;
                lblWarningP.Visible = true;
                txtUsername.Focus();
                return;
            }
            if (txtUsername.Text == "")
            {
                lblWarningU.Visible = true;
                txtUsername.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                lblWarningP.Visible = true;
                txtPassword.Focus();
                return;
            }

                try
            {
                // define connection
                SqlConnection con = DBConnection.GetConnection();
                // define the select query command
                String query = "SELECT Username, Password FROM Users " +
                                "WHERE Username = @UserName " +
                                "AND Password = @Password";

                SqlCommand cmd = new SqlCommand(query, con);

                SqlParameter uname = new SqlParameter("@UserName", SqlDbType.VarChar);
                SqlParameter upassword = new SqlParameter("@Password", SqlDbType.VarChar);
                // get the input
                uname.Value = txtUsername.Text;
                upassword.Value = txtPassword.Text;

                cmd.Parameters.Add(uname);
                cmd.Parameters.Add(upassword);
                // open the connection
                cmd.Connection.Open();
                // execute the query
                SqlDataReader myReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                if (myReader.Read() == true)
                {
                    // if user checks the remember me checkbox, username and password will be saved
                    if (ckbRemember.Checked == true)
                    {
                        Settings.Default.UserName = txtUsername.Text;
                        Settings.Default.Password = txtPassword.Text;
                        Settings.Default.Save();
                    }

                    //MessageBox.Show("You have logged in successfully " + txtUsername.Text);
             
                    Index form = new Index();
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login Failed... Try again!", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                        
        }

        // Save or reset username and password while changed
        private void CkbRemember_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbRemember.Checked == true)
            {
                Settings.Default.UserName = txtUsername.Text;
                Settings.Default.Password = txtPassword.Text;
                Settings.Default.Save();
            }
            else
            {
                Settings.Default.Reset();
            }
        }

        private void LblReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
            ckbRemember.Checked = false;
            lblWarningP.Visible = false;
            lblWarningU.Visible = false;

            Settings.Default.Reset();
        }

        private void Lblreg_Click(object sender, EventArgs e)
        {
            Admin_Registration form = new Admin_Registration();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
