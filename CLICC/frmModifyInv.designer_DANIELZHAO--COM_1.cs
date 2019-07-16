namespace CLICC
{
    partial class frmModifyInv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifyInv));
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cboOldOS = new System.Windows.Forms.ComboBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtPickUpNO = new System.Windows.Forms.TextBox();
            this.txtPCType = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtOldCOA = new System.Windows.Forms.TextBox();
            this.txtNewCOA = new System.Windows.Forms.TextBox();
            this.txtRecipient = new System.Windows.Forms.TextBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.dtpDateBuilt = new System.Windows.Forms.DateTimePicker();
            this.dtpMar = new System.Windows.Forms.DateTimePicker();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(363, 47);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(186, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Modify Inventory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(105, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "PC PickUp #";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(105, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "PC Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(105, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Old OS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(105, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Old COA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(512, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date Built";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(512, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mar Created";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(105, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "Make/Model";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(512, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "Recipient";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(512, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Details";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(512, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 18);
            this.label11.TabIndex = 8;
            this.label11.Text = "Status";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(512, 208);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 18);
            this.label12.TabIndex = 7;
            this.label12.Text = "New COA";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(213, 409);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 42);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(405, 409);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(111, 42);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(597, 409);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(111, 42);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // cboOldOS
            // 
            this.cboOldOS.FormattingEnabled = true;
            this.cboOldOS.Items.AddRange(new object[] {
            "Windows 8 Pro",
            "Windows 7 Pro",
            "Windows 7 Home Premium",
            "Windows Vista Pro",
            "Windows Vista Home",
            "No Registered OS"});
            this.cboOldOS.Location = new System.Drawing.Point(233, 234);
            this.cboOldOS.Name = "cboOldOS";
            this.cboOldOS.Size = new System.Drawing.Size(170, 26);
            this.cboOldOS.TabIndex = 15;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Claimed/Given-Out",
            "In Storage",
            "Deployed to DI Downtown",
            "Busted-Recycling",
            "Unable to Locate Unit"});
            this.cboStatus.Location = new System.Drawing.Point(627, 234);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(181, 26);
            this.cboStatus.TabIndex = 16;
            // 
            // txtPickUpNO
            // 
            this.txtPickUpNO.Location = new System.Drawing.Point(233, 133);
            this.txtPickUpNO.Name = "txtPickUpNO";
            this.txtPickUpNO.Size = new System.Drawing.Size(170, 24);
            this.txtPickUpNO.TabIndex = 1;
            // 
            // txtPCType
            // 
            this.txtPCType.Location = new System.Drawing.Point(233, 164);
            this.txtPCType.Name = "txtPCType";
            this.txtPCType.Size = new System.Drawing.Size(170, 24);
            this.txtPCType.TabIndex = 2;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(233, 201);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(170, 24);
            this.txtModel.TabIndex = 3;
            // 
            // txtOldCOA
            // 
            this.txtOldCOA.Location = new System.Drawing.Point(233, 273);
            this.txtOldCOA.Name = "txtOldCOA";
            this.txtOldCOA.Size = new System.Drawing.Size(170, 24);
            this.txtOldCOA.TabIndex = 4;
            // 
            // txtNewCOA
            // 
            this.txtNewCOA.Location = new System.Drawing.Point(627, 202);
            this.txtNewCOA.Name = "txtNewCOA";
            this.txtNewCOA.Size = new System.Drawing.Size(181, 24);
            this.txtNewCOA.TabIndex = 6;
            // 
            // txtRecipient
            // 
            this.txtRecipient.Location = new System.Drawing.Point(627, 315);
            this.txtRecipient.Name = "txtRecipient";
            this.txtRecipient.Size = new System.Drawing.Size(181, 24);
            this.txtRecipient.TabIndex = 8;
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(627, 276);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(181, 24);
            this.txtDetails.TabIndex = 7;
            // 
            // dtpDateBuilt
            // 
            this.dtpDateBuilt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateBuilt.Location = new System.Drawing.Point(627, 133);
            this.dtpDateBuilt.Name = "dtpDateBuilt";
            this.dtpDateBuilt.Size = new System.Drawing.Size(181, 24);
            this.dtpDateBuilt.TabIndex = 30;
            this.dtpDateBuilt.Tag = "9999";
            // 
            // dtpMar
            // 
            this.dtpMar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMar.Location = new System.Drawing.Point(627, 165);
            this.dtpMar.Name = "dtpMar";
            this.dtpMar.Size = new System.Drawing.Size(181, 24);
            this.dtpMar.TabIndex = 31;
            this.dtpMar.Tag = "9999";
            this.dtpMar.ValueChanged += new System.EventHandler(this.Dtp_ValueChanged);
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // frmModifyInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CLICC.Properties.Resources.Bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 521);
            this.Controls.Add(this.dtpMar);
            this.Controls.Add(this.dtpDateBuilt);
            this.Controls.Add(this.txtRecipient);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.txtNewCOA);
            this.Controls.Add(this.txtOldCOA);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtPCType);
            this.Controls.Add(this.txtPickUpNO);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.cboOldOS);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmModifyInv";
            this.Text = "frmModifyInv";
            this.Load += new System.EventHandler(this.FrmModifyInv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cboOldOS;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.TextBox txtPickUpNO;
        private System.Windows.Forms.TextBox txtPCType;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtOldCOA;
        private System.Windows.Forms.TextBox txtNewCOA;
        private System.Windows.Forms.TextBox txtRecipient;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.DateTimePicker dtpDateBuilt;
        private System.Windows.Forms.DateTimePicker dtpMar;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}