using CLICDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLICC
{
    public partial class frmViewApplicant : Form
    {
        public frmViewApplicant()
        {
            InitializeComponent();

            this.AcceptButton = this.btnSearch;
        }

      

        List<Applicant> applications = new List<Applicant>();
        List<ApplicantInfoStatus> applicantInfoStatuses = new List<ApplicantInfoStatus>();


        private void frmModifyApplicant_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;//formating the form
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            refreshBinding();

        }

        // Load the data from the database
        public void refreshBinding()
        {
            try
            {
                //applications = ApplicantDB.GetAllApplicants();
                //dgvApplicants.DataSource = applications;

                List<ApplicantInfoStatus> app = new List<ApplicantInfoStatus>();
                app = ApplicantInfoStatusDB.GetAllTest();
                dgvApplicants.DataSource = app;
                if (dgvApplicants.Rows.Count == 0) { }
                else
                {
                    dgvApplicants.FirstDisplayedScrollingRowIndex = dgvApplicants.RowCount - 1;
                }
            }
            catch (Exception ex)
            {//If there was an error loading, give message
                MessageBox.Show("The error is " + ex.Message, ex.GetType().ToString());
            }
            
            ApplicantListFormat(dgvApplicants);
            txtSearch.Clear();
            txtSearch.Focus();
        }

        // Formatting the grid view list
        public static void ApplicantListFormat(DataGridView dgv)
        {
            dgv.RowHeadersVisible = false;
            dgv.Columns[0].Visible = false;
            dgv.Columns[1].HeaderText = "Date Requested";
            dgv.Columns[2].Visible = false;
            dgv.Columns[3].Visible = false;
            dgv.Columns[4].HeaderText = "Name";
            dgv.Columns[5].Visible = false;
            dgv.Columns[6].HeaderText = "Phone";
            dgv.Columns[7].HeaderText = "Sec Phone";
            dgv.Columns[8].Visible = false;
            dgv.Columns[9].Visible = false;
            dgv.Columns[10].Visible = false;
            dgv.Columns[11].Visible = false;
            dgv.Columns[12].Visible = false;
            dgv.Columns[13].Visible = false;
            dgv.Columns[14].HeaderText = "Case Manager";
            dgv.Columns[15].HeaderText = "Agency";
            dgv.Columns[16].HeaderText = "Requested Item";
            dgv.Columns[17].Visible = false;
            dgv.Columns[18].HeaderText = "Call Status";
            dgv.Columns[19].Visible = false;
            dgv.Columns[20].Visible = false;
            dgv.Columns[21].Visible = false;
            dgv.Columns[22].Visible = false;
            dgv.Columns[23].Visible = false;
            dgv.Columns[24].Visible = false;
            dgv.Columns[25].Visible = false;
            dgv.Columns[26].Visible = false;
            dgv.Columns[27].HeaderText = "Pickup No";
            dgv.Columns[28].Visible = false;

          
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Columns[27].Width = 80;           
            dgv.Columns[16].Width = 100;    
            dgv.Columns[18].Width = 110;    
            dgv.Columns[14].Width = 110;    
            dgv.Columns[14].Width = 110;    
            dgv.Columns[4].Width = 160;    
            dgv.Columns[6].Width = 110;    
            dgv.Columns[7].Width = 110;    
            dgv.Columns[15].Width = 80;    
            dgv.Columns[16].Width = 80;    
            
            dgv.BackgroundColor = System.Drawing.SystemColors.Control;

        }


        // Pass id to the modify form
        public static int id;

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvApplicants.Rows.Count == 0)
            {
                MessageBox.Show("No application yet.");
            }
            else
            {
                id = getSelectedCellValue(dgvApplicants, 0);
                frmEditApplicant frmEdit = new frmEditApplicant();
                //this.Hide();

                frmEdit.ShowDialog();
                //frmEdit.Show();

                refreshBinding();
            }
        }

        // Open the modify form when double click
        private void DgvApplicants_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = getSelectedCellValue(dgvApplicants, 0);
            frmEditApplicant frmEdit = new frmEditApplicant();
            //this.Hide();

            frmEdit.ShowDialog();
            //frmEdit.Show();

            refreshBinding();
        }


        private void BtnDelete_Click(object sender, EventArgs e)
        {
            id = getSelectedCellValue(dgvApplicants, 0);

            var confirm = MessageBox.Show("Do you want to delete this application?", "Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    ApplicantInfoStatusDB.DeleteApplicationByID(id);
                    refreshBinding();
                }
                catch (Exception ex)
                {//if there was an error loading, give message
                    MessageBox.Show("The error is " + ex.Message, ex.GetType().ToString());
                }

            }
        }

        // Get the id from the selected row
        public int getSelectedCellValue(DataGridView dataGridView, int column)
        {
            int rw = dataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView.Rows[rw];
            return Convert.ToInt32(selectedRow.Cells[column].Value);
        }

        // Search the input value from the table string columns
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string name = txtSearch.Text;
            try
            {
                applications = ApplicantDB.GetApplicantsByName(name);
                dgvApplicants.DataSource = applications;
            }
            catch (Exception ex)
            {
                MessageBox.Show("The error is " + ex.Message, ex.GetType().ToString());
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.Focus();

        }

        private void BtnWaitingCase_Click(object sender, EventArgs e)
        {
            try
            {
                applications = ApplicantDB.GetWaitingApplication();
                dgvApplicants.DataSource = applications;
                if (dgvApplicants.Rows.Count == 0) { }
                else
                {
                    dgvApplicants.FirstDisplayedScrollingRowIndex = dgvApplicants.RowCount - 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The error is " + ex.Message, ex.GetType().ToString());
            }

        }

        private void BtnFollowingUpCase_Click(object sender, EventArgs e)
        {
            try
            {
                applications = ApplicantDB.GetFollowingUpApplication();
                dgvApplicants.DataSource = applications;
                if (dgvApplicants.Rows.Count == 0) { }
                else
                {
                    dgvApplicants.FirstDisplayedScrollingRowIndex = dgvApplicants.RowCount - 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The error is " + ex.Message, ex.GetType().ToString());
            }
        }

        private void BtnClosedCase_Click(object sender, EventArgs e)
        {
            try
            {
                //applications = ApplicantDB.GetClosedApplication();
                //dgvApplicants.DataSource = applications;
                applicantInfoStatuses = ApplicantInfoStatusDB.GetClosedTest();
                dgvApplicants.DataSource = applicantInfoStatuses;
                ApplicantListFormat(dgvApplicants);
                if (dgvApplicants.Rows.Count == 0) { }
                else
                {
                    dgvApplicants.FirstDisplayedScrollingRowIndex = dgvApplicants.RowCount - 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The error is " + ex.Message, ex.GetType().ToString());
            }
        }

        private void BtnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                //applications = ApplicantDB.GetAllApplicants();
                applicantInfoStatuses = ApplicantInfoStatusDB.GetAllTest();
                dgvApplicants.DataSource = applicantInfoStatuses;
                ApplicantListFormat(dgvApplicants);
                if (dgvApplicants.Rows.Count == 0) { }
                else
                {
                    dgvApplicants.FirstDisplayedScrollingRowIndex = dgvApplicants.RowCount - 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The error is " + ex.Message, ex.GetType().ToString());
            }
        }

        private void copyAlltoClipboard()
        {
            dgvApplicants.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvApplicants.SelectAll();
            DataObject dataObj = dgvApplicants.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void BtnBackUp_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void DgvApplicants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvApplicants.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
        }
    }
}
