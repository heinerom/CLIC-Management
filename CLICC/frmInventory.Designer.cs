namespace CLICC
{
    partial class frmInventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvInv = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnStorage = new System.Windows.Forms.Button();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.btnClaimed = new System.Windows.Forms.Button();
            this.btnDeployed = new System.Windows.Forms.Button();
            this.btnBusted = new System.Windows.Forms.Button();
            this.btnUnable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBackup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInv
            // 
            this.dgvInv.AllowUserToResizeRows = false;
            this.dgvInv.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInv.Location = new System.Drawing.Point(61, 154);
            this.dgvInv.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInv.Name = "dgvInv";
            this.dgvInv.ReadOnly = true;
            this.dgvInv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInv.Size = new System.Drawing.Size(831, 305);
            this.dgvInv.TabIndex = 2;
            this.dgvInv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvInv_CellClick);
            this.dgvInv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvInv_CellDoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(124, 494);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 32);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(328, 494);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 32);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(533, 494);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 32);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnStorage
            // 
            this.btnStorage.Location = new System.Drawing.Point(188, 87);
            this.btnStorage.Name = "btnStorage";
            this.btnStorage.Size = new System.Drawing.Size(94, 35);
            this.btnStorage.TabIndex = 6;
            this.btnStorage.Text = "&In Storage";
            this.btnStorage.UseVisualStyleBackColor = true;
            this.btnStorage.Click += new System.EventHandler(this.BtnStorage_Click);
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(61, 87);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(90, 35);
            this.btnGetAll.TabIndex = 7;
            this.btnGetAll.Text = "&Get All";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.BtnGetAll_Click);
            // 
            // btnClaimed
            // 
            this.btnClaimed.Location = new System.Drawing.Point(315, 87);
            this.btnClaimed.Name = "btnClaimed";
            this.btnClaimed.Size = new System.Drawing.Size(95, 35);
            this.btnClaimed.TabIndex = 8;
            this.btnClaimed.Text = "&Claimed";
            this.btnClaimed.UseVisualStyleBackColor = true;
            this.btnClaimed.Click += new System.EventHandler(this.BtnClaimed_Click);
            // 
            // btnDeployed
            // 
            this.btnDeployed.Location = new System.Drawing.Point(452, 87);
            this.btnDeployed.Name = "btnDeployed";
            this.btnDeployed.Size = new System.Drawing.Size(133, 35);
            this.btnDeployed.TabIndex = 9;
            this.btnDeployed.Text = "&Deployed to DI";
            this.btnDeployed.UseVisualStyleBackColor = true;
            this.btnDeployed.Click += new System.EventHandler(this.BtnDeployed_Click);
            // 
            // btnBusted
            // 
            this.btnBusted.Location = new System.Drawing.Point(627, 87);
            this.btnBusted.Name = "btnBusted";
            this.btnBusted.Size = new System.Drawing.Size(113, 35);
            this.btnBusted.TabIndex = 10;
            this.btnBusted.Text = "&Recycled";
            this.btnBusted.UseVisualStyleBackColor = true;
            this.btnBusted.Click += new System.EventHandler(this.BtnBusted_Click);
            // 
            // btnUnable
            // 
            this.btnUnable.Location = new System.Drawing.Point(779, 87);
            this.btnUnable.Name = "btnUnable";
            this.btnUnable.Size = new System.Drawing.Size(113, 35);
            this.btnUnable.TabIndex = 11;
            this.btnUnable.Text = "&Not Working";
            this.btnUnable.UseVisualStyleBackColor = true;
            this.btnUnable.Click += new System.EventHandler(this.BtnUnable_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(391, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory";
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(732, 494);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(112, 32);
            this.btnBackup.TabIndex = 12;
            this.btnBackup.Text = "&Back Up";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.BtnBackup_Click);
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CLICC.Properties.Resources.Bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 560);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnUnable);
            this.Controls.Add(this.btnBusted);
            this.Controls.Add(this.btnDeployed);
            this.Controls.Add(this.btnClaimed);
            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.btnStorage);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvInv);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.FrmInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvInv;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnStorage;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btnClaimed;
        private System.Windows.Forms.Button btnDeployed;
        private System.Windows.Forms.Button btnBusted;
        private System.Windows.Forms.Button btnUnable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackup;
    }
}