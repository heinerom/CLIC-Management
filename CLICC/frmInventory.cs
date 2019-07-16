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
    public partial class frmInventory : Form
    {
        List<Inventory> inventories = new List<Inventory>();
        public static int id;
        public frmInventory()
        {
            InitializeComponent();
        }

        private void FrmInventory_Load(object sender, EventArgs e)
        {
            refreshBinding();
        }

        // Refresh the gridview list
        public void refreshBinding()
        {
            try
            {
                inventories = InventoryDB.GetAllInventories();
                dgvInv.DataSource = inventories;
                if (dgvInv.Rows.Count == 0) { }
                else
                {
                    dgvInv.FirstDisplayedScrollingRowIndex = dgvInv.RowCount - 1;
                }
            }
            catch (Exception ex)
            {//if there was an error loading, give message
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            
            ApplicantListFormat(dgvInv);

        }

        public static void ApplicantListFormat(DataGridView dgv)
        {
            dgv.RowHeadersVisible = false;
            dgv.Columns[0].HeaderText = "PC PickUp#";
            dgv.Columns[1].HeaderText = "PC Type";
            dgv.Columns[2].HeaderText = "Make/Model";
            dgv.Columns[3].Visible = false;
            dgv.Columns[4].Visible = false;
            dgv.Columns[5].HeaderText = "Date Built";
            dgv.Columns[6].Visible = false;
            dgv.Columns[7].Visible = false;
            dgv.Columns[8].HeaderText = "Status";
            dgv.Columns[9].HeaderText = "Details";
            dgv.Columns[10].HeaderText = "Client/Recipient";


            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Columns[0].Width = 60;           //set the width to 50px  

        }


        // Delete the inventory by id
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var instance = new frmViewApplicant();
            id = instance.getSelectedCellValue(dgvInv, 0);

            var confirm = MessageBox.Show("Do you want to delete this PC?", "Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    InventoryDB.DeleteInventoryByID(id);
                    refreshBinding();
                }
                catch (Exception ex)
                {//if there was an error loading, give message
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        // Get to the modify page
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvInv.Rows.Count == 0)
            {
                MessageBox.Show("No inventory yet.");
            }
            else
            {
                var instance = new frmViewApplicant();
                id = instance.getSelectedCellValue(dgvInv, 0);

                frmModifyInv frmMod = new frmModifyInv();
                frmMod.ShowDialog();

                refreshBinding();
            }
        }
        private void DgvInv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var instance = new frmViewApplicant();
            id = instance.getSelectedCellValue(dgvInv, 0);

            frmModifyInv frmMod = new frmModifyInv();
            frmMod.ShowDialog();

            refreshBinding();
        }

        // Add a new inventory
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            id = 0;

            frmModifyInv frmMod = new frmModifyInv();
            //this.Hide();
            frmMod.ShowDialog();

            refreshBinding();
        }

        private void BtnStorage_Click(object sender, EventArgs e)
        {
            if (dgvInv.Rows.Count == 0)
            {                
            }
            else
            {
                try
                {
                    inventories = InventoryDB.GetInstorageInventories();
                    dgvInv.DataSource = inventories;
                    if (dgvInv.Rows.Count == 0) { }
                    else
                    {
                        dgvInv.FirstDisplayedScrollingRowIndex = dgvInv.RowCount - 1;
                    }
                }
                catch (Exception ex)
                {//if there was an error loading, give message
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }

            ApplicantListFormat(dgvInv);
        }

        private void BtnGetAll_Click(object sender, EventArgs e)
        {
            refreshBinding();
        }

        private void BtnClaimed_Click(object sender, EventArgs e)
        {
            try
            {
                inventories = InventoryDB.GetClaimedInventories();
                dgvInv.DataSource = inventories;
                if (dgvInv.Rows.Count == 0) { }
                else
                {
                    dgvInv.FirstDisplayedScrollingRowIndex = dgvInv.RowCount - 1;
                }
            }
            catch (Exception ex)
            {//if there was an error loading, give message
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

            ApplicantListFormat(dgvInv);
        }

        private void BtnDeployed_Click(object sender, EventArgs e)
        {
            try
            {
                inventories = InventoryDB.GetDIInventories();
                dgvInv.DataSource = inventories;
                if (dgvInv.Rows.Count == 0) { }
                else
                {
                    dgvInv.FirstDisplayedScrollingRowIndex = dgvInv.RowCount - 1;
                }
            }
            catch (Exception ex)
            {//if there was an error loading, give message
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

            ApplicantListFormat(dgvInv);
        }

        private void BtnBusted_Click(object sender, EventArgs e)
        {
            try
            {
               
                inventories = InventoryDB.GetBustedInventories();
                dgvInv.DataSource = inventories;
                if (dgvInv.Rows.Count == 0) { }
                else
                {
                    dgvInv.FirstDisplayedScrollingRowIndex = dgvInv.RowCount - 1;
                }               
            }
            catch (Exception ex)
            {//if there was an error loading, give message
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

            ApplicantListFormat(dgvInv);
        }

        private void BtnUnable_Click(object sender, EventArgs e)
        {
            try
            {
                inventories = InventoryDB.GetNotWorkingInventories();
                dgvInv.DataSource = inventories;
                if (dgvInv.Rows.Count == 0) { }
                else
                {
                    dgvInv.FirstDisplayedScrollingRowIndex = dgvInv.RowCount - 1;
                }
            }
            catch (Exception ex)
            {//if there was an error loading, give message
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

            ApplicantListFormat(dgvInv);
        }

        private void copyAlltoClipboard()
        {
            dgvInv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvInv.SelectAll();
            DataObject dataObj = dgvInv.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void BtnBackup_Click(object sender, EventArgs e)
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

        private void DgvInv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvInv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
        }
    }
}
