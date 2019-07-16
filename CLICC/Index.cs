
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
    public partial class Index : Form
    {
        frmNewApplicant newApplicantForm = null;
        frmViewApplicant modifyApplicantForm = null;
        frmInventory inventoryForm = null;
        frmUpcoming upcomingForm = null;
        frmReport reportForm = null;
        Cover coverForm = null;

        public Index()
        {
            InitializeComponent();
            
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));

           
        }
        
        private void Menu_Load(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile = Application.StartupPath + "//MidsummerColor1.ssk";

            Sunisoft.IrisSkin.SkinEngine se = null;
            se = new Sunisoft.IrisSkin.SkinEngine();
            se.SkinAllForm = true;

            miNewApplicant.Visible = false;
            miEditApplicant.Visible = false;

            Cover newForm = new Cover();
            newForm.MdiParent = this;
            newForm.Dock = DockStyle.Fill;
            newForm.Show();
        }

       

        private void miApplicant_Click(object sender, EventArgs e)
        {   
            if (miNewApplicant.Visible == false)
            {
                miNewApplicant.Visible = true;
                miEditApplicant.Visible = true;
            }

            else
            {
                miNewApplicant.Visible = false;
                miEditApplicant.Visible = false;
            }
        }

        private void MiEditApplicant_Click(object sender, EventArgs e)
        {
            if (newApplicantForm != null)
            {
                newApplicantForm.Close();
            }
            if (inventoryForm != null)
            {
                inventoryForm.Close();
            }
            if (upcomingForm != null)
            {
                upcomingForm.Close();
            }
            if (reportForm != null)
            {
                reportForm.Close();
            }
            if (coverForm != null)
            {
                coverForm.Close();
            }
            modifyApplicantForm = new frmViewApplicant();
            modifyApplicantForm.MdiParent = this;
            modifyApplicantForm.Dock = DockStyle.Fill;
            modifyApplicantForm.Show();
        }

        private void MiNewApplicant_Click(object sender, EventArgs e)
        {
            if (modifyApplicantForm != null)
            {
                modifyApplicantForm.Close();
            }
            if (inventoryForm != null)
            {
                inventoryForm.Close();
            }
            if (upcomingForm != null)
            {
                upcomingForm.Close();
            }
            if (reportForm != null)
            {
                reportForm.Close();
            }
            if (coverForm != null)
            {
                coverForm.Close();
            }
            newApplicantForm = new frmNewApplicant();
            newApplicantForm.MdiParent = this;
            newApplicantForm.Dock = DockStyle.Fill;
            newApplicantForm.Show();          
           
        }

        private void MiInventory_Click(object sender, EventArgs e)
        {
            if (modifyApplicantForm != null)
            {
                modifyApplicantForm.Close();
            }
            if (newApplicantForm != null)
            {
                newApplicantForm.Close();
            }
            if (upcomingForm != null)
            {
                upcomingForm.Close();
            }
            if (reportForm != null)
            {
                reportForm.Close();
            }
            if (coverForm != null)
            {
                coverForm.Close();
            }
            miNewApplicant.Visible = false;
            miEditApplicant.Visible = false;

            inventoryForm = new frmInventory();
            inventoryForm.MdiParent = this;
            inventoryForm.Dock = DockStyle.Fill;
            inventoryForm.Show();

        }

        private void MiUpcomingDays_Click(object sender, EventArgs e)
        {
            if (modifyApplicantForm != null)
            {
                modifyApplicantForm.Close();
            }
            if (newApplicantForm != null)
            {
                newApplicantForm.Close();
            }
            if (inventoryForm != null)
            {
                inventoryForm.Close();
            }
            if (reportForm != null)
            {
                reportForm.Close();
            }
            if (coverForm != null)
            {
                coverForm.Close();
            }
            miNewApplicant.Visible = false;
            miEditApplicant.Visible = false;

            upcomingForm = new frmUpcoming();
            upcomingForm.MdiParent = this;
            upcomingForm.Dock = DockStyle.Fill;
            upcomingForm.Show();
        }

        private void MiReport_Click(object sender, EventArgs e)
        {
            if (modifyApplicantForm != null)
            {
                modifyApplicantForm.Close();
            }
            if (newApplicantForm != null)
            {
                newApplicantForm.Close();
            }
            if (inventoryForm != null)
            {
                inventoryForm.Close();
            }
            if (upcomingForm != null)
            {
                upcomingForm.Close();
            }
            if (coverForm != null)
            {
                coverForm.Close();
            }
            miNewApplicant.Visible = false;
            miEditApplicant.Visible = false;

            reportForm = new frmReport();
            reportForm.MdiParent = this;
            reportForm.Dock = DockStyle.Fill;
            reportForm.Show();
        }

        private void MiSignOut_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void MiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {
            if (modifyApplicantForm != null)
            {
                modifyApplicantForm.Close();
            }
            if (newApplicantForm != null)
            {
                newApplicantForm.Close();
            }
            if (inventoryForm != null)
            {
                inventoryForm.Close();
            }
            if (upcomingForm != null)
            {
                upcomingForm.Close();
            }
            if (reportForm != null)
            {
                reportForm.Close();
            }

            miNewApplicant.Visible = false;
            miEditApplicant.Visible = false;

            Cover newForm = new Cover();
            newForm.MdiParent = this;
            newForm.Dock = DockStyle.Fill;
            newForm.Show();
        }

        
    }
}
