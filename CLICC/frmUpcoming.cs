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
    public partial class frmUpcoming : Form
    {
        List<ApplicantInfoStatus> applicantsScheduled = new List<ApplicantInfoStatus>();
        public frmUpcoming()
        {
            InitializeComponent();
        }

        // Load the applicants list with scheduled date later than current date
        private void FrmUpcoming_Load(object sender, EventArgs e)
        {
            try
            {
                applicantsScheduled = ApplicantInfoStatusDB.GetApplicantScheduled();
                dgvScheduled.DataSource = applicantsScheduled;
            }
            catch (Exception ex)
            {
                MessageBox.Show("The error is " + ex.Message, ex.GetType().ToString());
            }

            frmUpcoming.ApplicantListFormat(dgvScheduled);
        }

        public static void ApplicantListFormat(DataGridView dgv)
        {//formatting the list
            dgv.RowHeadersVisible = false;
            dgv.Columns[0].Visible = false; //name the first column id            
            dgv.Columns[1].HeaderText = "Date Requested";//name the second column name
            dgv.Columns[2].Visible = false;
            dgv.Columns[3].Visible = false;
            dgv.Columns[4].HeaderText = "Name";
            dgv.Columns[5].Visible = false;
            dgv.Columns[6].HeaderText = "Phone";
            dgv.Columns[7].Visible = false;
            dgv.Columns[8].Visible = false;
            dgv.Columns[9].Visible = false;
            dgv.Columns[10].Visible = false;
            dgv.Columns[11].Visible = false;
            dgv.Columns[12].Visible = false;
            dgv.Columns[13].Visible = false;
            dgv.Columns[14].Visible = false;
            dgv.Columns[15].Visible = false;
            dgv.Columns[16].HeaderText = "Requested Item";
            dgv.Columns[17].HeaderText = "Requested Note";
            dgv.Columns[18].HeaderText = "Call Status";
            dgv.Columns[19].Visible = false;
            dgv.Columns[20].Visible = false;
            dgv.Columns[21].Visible = false;
            dgv.Columns[22].Visible = false;
            dgv.Columns[23].Visible = false;
            dgv.Columns[24].Visible = false;
            dgv.Columns[25].HeaderText = "Date Scheduled";
            dgv.Columns[26].Visible = false;
            dgv.Columns[27].Visible = false;
            dgv.Columns[28].HeaderText = "Comments";


            //dgv.Columns[0].Width = 50;           //set the width to 50px  

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Columns[4].Width = 160;
        }

        // Pass the id and go to modify page
        public static int id;
        private void BtnModify_Click(object sender, EventArgs e)
        {
            if (dgvScheduled.Rows.Count == 0)
            {
                MessageBox.Show("No scheduled pickup yet.");
            }
            else
            {
                var instance = new frmViewApplicant();
                id = instance.getSelectedCellValue(dgvScheduled, 0);

                frmEditApplicant frmEdit = new frmEditApplicant();
                //this.Hide();
                frmEdit.ShowDialog();

                applicantsScheduled = ApplicantInfoStatusDB.GetApplicantScheduled();
                dgvScheduled.DataSource = applicantsScheduled;
            }
        }
    }
}
