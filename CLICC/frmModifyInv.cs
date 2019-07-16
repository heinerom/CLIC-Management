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
    public partial class frmModifyInv : Form
    {
        public int invId = 0;
        public frmModifyInv()
        {
            InitializeComponent();

            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmModifyInv_Load(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile = Application.StartupPath + "//MidsummerColor1.ssk";

            Sunisoft.IrisSkin.SkinEngine se = null;
            se = new Sunisoft.IrisSkin.SkinEngine();
            se.SkinAllForm = true;



            // If the passed id is not equal to 0, means that it already exists, load the data then
            if (frmInventory.id != 0)
            {
                invId = frmInventory.id;
                frm_load();
                dtp_load();
                txtPCType.Focus();
                lblTitle.Text = "Modify Inventory";
                btnReset.Text = "&Reset";
               
            }
            // If the passed id is 0, load an empty form 
            else
            {
                lblTitle.Text = "New Inventory";
                btnReset.Text = "&Clear";
                dtp_load();
                comboLoad();
            }
            
        }

        //=======//
        private void comboLoad()
        {
            SqlConnection Conn = DBConnection.GetConnection();
            // define the select query command
            String queryPC = "SELECT Id, PCStatus FROM DropDownList " +
                            "WHERE Id < 6 ORDER BY Id";

            SqlDataAdapter da = new SqlDataAdapter(queryPC, Conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboStatus.DataSource = dt;
            cboStatus.DisplayMember = "PCStatus";
            cboStatus.ValueMember = "Id";

            //=================================================================//
            String queryOldOS = "SELECT Id, OldOS FROM DropDownList " +
                            "WHERE Id < 7 ORDER BY Id";

            SqlDataAdapter da2 = new SqlDataAdapter(queryOldOS, Conn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cboOldOS.DataSource = dt2;
            cboOldOS.DisplayMember = "OldOS";
            cboOldOS.ValueMember = "Id";
        }

        private void frm_load()
        {
            try
            {
                //=======//
                comboLoad();

                Inventory inventory = InventoryDB.GetInventoryByID(invId);

                txtPickUpNO.Text = inventory.PCPickUpNo.ToString();
                txtPCType.Text = inventory.PCType.ToString();
                txtModel.Text = inventory.Model.ToString();
                txtOldCOA.Text = inventory.OldCOA.ToString();
                dtpDateBuilt.Text = inventory.DateBuilt.ToString();
                dtpMar.Text = inventory.MarCreated.ToString();
                txtNewCOA.Text = inventory.NewCOA.ToString();
                txtRecipient.Text = inventory.Recipient.ToString();
                txtDetails.Text = inventory.Details.ToString();

                //===ComboBox loaded from the database====//
                cboStatus.SelectedIndex = Convert.ToInt32(inventory.PCStatus);
                cboOldOS.SelectedIndex = Convert.ToInt32(inventory.OldOS);
            }
            catch (Exception ex)
            {

                MessageBox.Show("The error is " + ex.Message, ex.GetType().ToString());
            }
        }

        // Date time picker change
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

        DateTime? dateMar = null;
        public void dtp_load()
        {
            // when the date is null, leave it blank and unchecked
            dtpMar.ValueChanged += new System.EventHandler(this.Dtp_ValueChanged);
            dtpMar.ShowCheckBox = true;

            if (dtpMar.Text == null || dtpMar.Text == " ")
            {
                dtpMar.Checked = false;
                dateMar = null;
            }
            else
            {
                dtpMar.Checked = true;
                dateMar = Convert.ToDateTime(dtpMar.Text);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            if(invId != 0)
            {
                frm_load();
                dtp_load();
            }
            else
            {
                txtPickUpNO.Text = "";
                txtPCType.Text = "";
                txtModel.Text = "";
                cboOldOS.SelectedIndex = 0;
                txtOldCOA.Text = "";
                dtpDateBuilt.Text = "";
                dtpMar.Text = "";
                txtNewCOA.Text = "";
                cboStatus.SelectedIndex = 0;
                txtRecipient.Text = "";
                txtDetails.Text = "";
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Update
            if (invId != 0)
            {
                try
                {
                    if ((Validator.IsProvided(txtPickUpNO, "PickUp Number ") &&
                        Validator.IsNonString(txtPickUpNO, "PickUp Number ") &&
                        Validator.IsProvided(txtModel, "Model Number ") &&
                        Validator.IsProvided(cboOldOS, "Old OS ") &&
                        Validator.IsProvided(txtOldCOA, "Old COA ") &&
                        Validator.IsProvided(cboStatus, "Status ") &&
                        Validator.IsProvided(txtPCType, "PC Type ")))
                    {
                        dtp_load();
                        Inventory oldi = new Inventory();
                        Inventory newi = new Inventory();
                        oldi.PCPickUpNo = invId;

                        newi.Model = txtModel.Text;
                        newi.OldCOA = txtOldCOA.Text;
                        newi.PCType = txtPCType.Text;
                        newi.NewCOA = txtNewCOA.Text;
                        newi.Details = txtDetails.Text;
                        newi.Recipient = txtRecipient.Text;
                        newi.DateBuilt = Convert.ToDateTime(dtpDateBuilt.Text);
                        newi.MarCreated = dateMar;
                        //newi.OldOS = Convert.ToString(cboOldOS.SelectedIndex);
                        //=======//
                        newi.PCStatus = Convert.ToString(cboStatus.SelectedIndex);
                        newi.OldOS = Convert.ToString(cboOldOS.SelectedIndex);

                        var confirm = MessageBox.Show("Are you sure to update this Inventory?", "Update", MessageBoxButtons.YesNo);
                        if (confirm == DialogResult.Yes)
                        {
                            InventoryDB.UpdateInventory(newi, oldi);

                        }
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unanticipated error occurred: " + ex.Message, ex.GetType().ToString());
                }
            }

            // Insert
            if (invId == 0)
            {
                try
                {
                    if ((Validator.IsProvided(txtPickUpNO, "PickUp Number ") &&
                        Validator.IsNonString(txtPickUpNO, "PickUp Number ") &&
                        Validator.IsProvided(txtModel, "Model Number ") &&
                        Validator.IsProvided(txtOldCOA, "Old COA ") &&
                        Validator.IsProvided(cboOldOS, "Old OS ") &&
                        Validator.IsProvided(cboStatus, "PC Status ") &&
                        Validator.IsProvided(txtPCType, "PC Type ")))
                    {
                        dtp_load();

                        Inventory newInv = new Inventory();
                        newInv.PCPickUpNo = Convert.ToInt32(txtPickUpNO.Text);
                        newInv.Model = txtModel.Text;
                        newInv.OldCOA = txtOldCOA.Text;
                        newInv.PCType = txtPCType.Text;
                        newInv.NewCOA = txtNewCOA.Text;
                        newInv.Details = txtDetails.Text;
                        newInv.Recipient = txtRecipient.Text;
                        newInv.DateBuilt = Convert.ToDateTime(dtpDateBuilt.Text);
                        newInv.MarCreated = dateMar;
                        //newInv.OldOS = Convert.ToString(cboOldOS.SelectedIndex);
                        //newInv.PCStatus = Convert.ToString(cboStatus.SelectedIndex);
                        //=======//
                        newInv.PCStatus = Convert.ToString(cboStatus.SelectedIndex);
                        newInv.OldOS = Convert.ToString(cboOldOS.SelectedIndex);

                        InventoryDB.InsertInventory(newInv);
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
}
  