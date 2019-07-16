namespace CLICC
{
    partial class frmEditApplicant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditApplicant));
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSecondaryPhone = new System.Windows.Forms.Label();
            this.lblPrimaryPhone = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.dtpRequestDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAgency = new System.Windows.Forms.TextBox();
            this.lblAgency = new System.Windows.Forms.Label();
            this.txtCaseManager = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.lblCase = new System.Windows.Forms.Label();
            this.txtPrimaryPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtChild = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAttempt1 = new System.Windows.Forms.Label();
            this.lblAttempt2 = new System.Windows.Forms.Label();
            this.lblAttempt3 = new System.Windows.Forms.Label();
            this.lblRemarks1 = new System.Windows.Forms.Label();
            this.lblRemarks2 = new System.Windows.Forms.Label();
            this.lblRemarks3 = new System.Windows.Forms.Label();
            this.dtpAttempt1 = new System.Windows.Forms.DateTimePicker();
            this.dtpAttempt2 = new System.Windows.Forms.DateTimePicker();
            this.dtpAttempt3 = new System.Windows.Forms.DateTimePicker();
            this.lblScheduled = new System.Windows.Forms.Label();
            this.lblDatePickedUp = new System.Windows.Forms.Label();
            this.lblPickupNo = new System.Windows.Forms.Label();
            this.lblCallStatus = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cboRemark1 = new System.Windows.Forms.ComboBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.dtpScheduled = new System.Windows.Forms.DateTimePicker();
            this.dtpDatePickedUp = new System.Windows.Forms.DateTimePicker();
            this.cboCallStatus = new System.Windows.Forms.ComboBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtPickUpNo = new System.Windows.Forms.TextBox();
            this.cboItem = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtSecPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblrequired = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblValidPostal = new System.Windows.Forms.Label();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.label9 = new System.Windows.Forms.Label();
            this.cboRemark2 = new System.Windows.Forms.ComboBox();
            this.cboRemark3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dtpBirth
            // 
            this.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirth.Location = new System.Drawing.Point(224, 145);
            this.dtpBirth.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(174, 24);
            this.dtpBirth.TabIndex = 117;
            this.dtpBirth.Tag = "9999";
            this.dtpBirth.ValueChanged += new System.EventHandler(this.Dtp_ValueChanged);
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.BackColor = System.Drawing.Color.Transparent;
            this.lblPostalCode.Location = new System.Drawing.Point(64, 325);
            this.lblPostalCode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(94, 18);
            this.lblPostalCode.TabIndex = 116;
            this.lblPostalCode.Text = "Postal Code:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(64, 290);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 114;
            this.label6.Text = "Address:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Location = new System.Drawing.Point(64, 255);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 18);
            this.lblEmail.TabIndex = 113;
            this.lblEmail.Text = "Email:";
            // 
            // lblSecondaryPhone
            // 
            this.lblSecondaryPhone.AutoSize = true;
            this.lblSecondaryPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblSecondaryPhone.Location = new System.Drawing.Point(64, 220);
            this.lblSecondaryPhone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSecondaryPhone.Name = "lblSecondaryPhone";
            this.lblSecondaryPhone.Size = new System.Drawing.Size(130, 18);
            this.lblSecondaryPhone.TabIndex = 112;
            this.lblSecondaryPhone.Text = "Secondary Phone:";
            // 
            // lblPrimaryPhone
            // 
            this.lblPrimaryPhone.AutoSize = true;
            this.lblPrimaryPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPrimaryPhone.Location = new System.Drawing.Point(64, 185);
            this.lblPrimaryPhone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrimaryPhone.Name = "lblPrimaryPhone";
            this.lblPrimaryPhone.Size = new System.Drawing.Size(110, 18);
            this.lblPrimaryPhone.TabIndex = 111;
            this.lblPrimaryPhone.Text = "Primary Phone:";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.BackColor = System.Drawing.Color.Transparent;
            this.lblDob.Location = new System.Drawing.Point(64, 150);
            this.lblDob.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(97, 18);
            this.lblDob.TabIndex = 110;
            this.lblDob.Text = "Date Of Birth:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(225, 108);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(174, 24);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Location = new System.Drawing.Point(225, 74);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(174, 24);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Location = new System.Drawing.Point(64, 115);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(84, 18);
            this.lblLastName.TabIndex = 107;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFirstName.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblFirstName.Location = new System.Drawing.Point(64, 80);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(85, 18);
            this.lblFirstName.TabIndex = 106;
            this.lblFirstName.Text = "First Name:";
            // 
            // dtpRequestDate
            // 
            this.dtpRequestDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRequestDate.Location = new System.Drawing.Point(224, 41);
            this.dtpRequestDate.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dtpRequestDate.Name = "dtpRequestDate";
            this.dtpRequestDate.Size = new System.Drawing.Size(174, 24);
            this.dtpRequestDate.TabIndex = 105;
            this.dtpRequestDate.Tag = "9999";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(64, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 104;
            this.label1.Text = "Date Of Application:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(166, 558);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 38);
            this.btnBack.TabIndex = 133;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(411, 558);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 38);
            this.btnSave.TabIndex = 132;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtAgency
            // 
            this.txtAgency.Location = new System.Drawing.Point(224, 427);
            this.txtAgency.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtAgency.Name = "txtAgency";
            this.txtAgency.Size = new System.Drawing.Size(173, 24);
            this.txtAgency.TabIndex = 10;
            // 
            // lblAgency
            // 
            this.lblAgency.AutoSize = true;
            this.lblAgency.BackColor = System.Drawing.Color.Transparent;
            this.lblAgency.Location = new System.Drawing.Point(64, 430);
            this.lblAgency.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAgency.Name = "lblAgency";
            this.lblAgency.Size = new System.Drawing.Size(60, 18);
            this.lblAgency.TabIndex = 130;
            this.lblAgency.Text = "Agency:";
            // 
            // txtCaseManager
            // 
            this.txtCaseManager.Location = new System.Drawing.Point(225, 392);
            this.txtCaseManager.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtCaseManager.Name = "txtCaseManager";
            this.txtCaseManager.Size = new System.Drawing.Size(174, 24);
            this.txtCaseManager.TabIndex = 9;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(224, 319);
            this.txtPostalCode.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(174, 24);
            this.txtPostalCode.TabIndex = 7;
            this.txtPostalCode.TextChanged += new System.EventHandler(this.TxtPostalCode_TextChanged);
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(224, 283);
            this.txtAdd.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtAdd.Multiline = true;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(174, 25);
            this.txtAdd.TabIndex = 6;
            // 
            // lblCase
            // 
            this.lblCase.AutoSize = true;
            this.lblCase.BackColor = System.Drawing.Color.Transparent;
            this.lblCase.Location = new System.Drawing.Point(64, 395);
            this.lblCase.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCase.Name = "lblCase";
            this.lblCase.Size = new System.Drawing.Size(109, 18);
            this.lblCase.TabIndex = 126;
            this.lblCase.Text = "Case Manager:";
            // 
            // txtPrimaryPhone
            // 
            this.txtPrimaryPhone.Location = new System.Drawing.Point(224, 179);
            this.txtPrimaryPhone.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPrimaryPhone.Name = "txtPrimaryPhone";
            this.txtPrimaryPhone.Size = new System.Drawing.Size(174, 24);
            this.txtPrimaryPhone.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(225, 249);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(172, 24);
            this.txtEmail.TabIndex = 5;
            // 
            // txtChild
            // 
            this.txtChild.Location = new System.Drawing.Point(224, 357);
            this.txtChild.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtChild.Name = "txtChild";
            this.txtChild.Size = new System.Drawing.Size(174, 24);
            this.txtChild.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(64, 360);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 118;
            this.label2.Text = "Number Of Children:";
            // 
            // lblAttempt1
            // 
            this.lblAttempt1.AutoSize = true;
            this.lblAttempt1.BackColor = System.Drawing.Color.Transparent;
            this.lblAttempt1.Location = new System.Drawing.Point(541, 80);
            this.lblAttempt1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAttempt1.Name = "lblAttempt1";
            this.lblAttempt1.Size = new System.Drawing.Size(103, 18);
            this.lblAttempt1.TabIndex = 134;
            this.lblAttempt1.Text = "Call Attempt 1:";
            // 
            // lblAttempt2
            // 
            this.lblAttempt2.AutoSize = true;
            this.lblAttempt2.BackColor = System.Drawing.Color.Transparent;
            this.lblAttempt2.Location = new System.Drawing.Point(541, 148);
            this.lblAttempt2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAttempt2.Name = "lblAttempt2";
            this.lblAttempt2.Size = new System.Drawing.Size(103, 18);
            this.lblAttempt2.TabIndex = 135;
            this.lblAttempt2.Text = "Call Attempt 2:";
            // 
            // lblAttempt3
            // 
            this.lblAttempt3.AutoSize = true;
            this.lblAttempt3.BackColor = System.Drawing.Color.Transparent;
            this.lblAttempt3.Location = new System.Drawing.Point(541, 218);
            this.lblAttempt3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAttempt3.Name = "lblAttempt3";
            this.lblAttempt3.Size = new System.Drawing.Size(103, 18);
            this.lblAttempt3.TabIndex = 136;
            this.lblAttempt3.Text = "Call Attempt 3:";
            // 
            // lblRemarks1
            // 
            this.lblRemarks1.AutoSize = true;
            this.lblRemarks1.BackColor = System.Drawing.Color.Transparent;
            this.lblRemarks1.Location = new System.Drawing.Point(541, 113);
            this.lblRemarks1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRemarks1.Name = "lblRemarks1";
            this.lblRemarks1.Size = new System.Drawing.Size(85, 18);
            this.lblRemarks1.TabIndex = 137;
            this.lblRemarks1.Text = "Remarks 1:";
            // 
            // lblRemarks2
            // 
            this.lblRemarks2.AutoSize = true;
            this.lblRemarks2.BackColor = System.Drawing.Color.Transparent;
            this.lblRemarks2.Location = new System.Drawing.Point(541, 184);
            this.lblRemarks2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRemarks2.Name = "lblRemarks2";
            this.lblRemarks2.Size = new System.Drawing.Size(85, 18);
            this.lblRemarks2.TabIndex = 138;
            this.lblRemarks2.Text = "Remarks 2:";
            // 
            // lblRemarks3
            // 
            this.lblRemarks3.AutoSize = true;
            this.lblRemarks3.BackColor = System.Drawing.Color.Transparent;
            this.lblRemarks3.Location = new System.Drawing.Point(541, 253);
            this.lblRemarks3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRemarks3.Name = "lblRemarks3";
            this.lblRemarks3.Size = new System.Drawing.Size(85, 18);
            this.lblRemarks3.TabIndex = 139;
            this.lblRemarks3.Text = "Remarks 3:";
            // 
            // dtpAttempt1
            // 
            this.dtpAttempt1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAttempt1.Location = new System.Drawing.Point(694, 78);
            this.dtpAttempt1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dtpAttempt1.Name = "dtpAttempt1";
            this.dtpAttempt1.Size = new System.Drawing.Size(174, 24);
            this.dtpAttempt1.TabIndex = 140;
            this.dtpAttempt1.Tag = "9999";
            this.dtpAttempt1.ValueChanged += new System.EventHandler(this.Dtp_ValueChanged);
            // 
            // dtpAttempt2
            // 
            this.dtpAttempt2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAttempt2.Location = new System.Drawing.Point(694, 143);
            this.dtpAttempt2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dtpAttempt2.Name = "dtpAttempt2";
            this.dtpAttempt2.Size = new System.Drawing.Size(174, 24);
            this.dtpAttempt2.TabIndex = 141;
            this.dtpAttempt2.Tag = "9999";
            this.dtpAttempt2.ValueChanged += new System.EventHandler(this.Dtp_ValueChanged);
            // 
            // dtpAttempt3
            // 
            this.dtpAttempt3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAttempt3.Location = new System.Drawing.Point(694, 212);
            this.dtpAttempt3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dtpAttempt3.Name = "dtpAttempt3";
            this.dtpAttempt3.Size = new System.Drawing.Size(174, 24);
            this.dtpAttempt3.TabIndex = 142;
            this.dtpAttempt3.Tag = "9999";
            this.dtpAttempt3.ValueChanged += new System.EventHandler(this.Dtp_ValueChanged);
            // 
            // lblScheduled
            // 
            this.lblScheduled.AutoSize = true;
            this.lblScheduled.BackColor = System.Drawing.Color.Transparent;
            this.lblScheduled.Location = new System.Drawing.Point(541, 288);
            this.lblScheduled.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblScheduled.Name = "lblScheduled";
            this.lblScheduled.Size = new System.Drawing.Size(138, 18);
            this.lblScheduled.TabIndex = 143;
            this.lblScheduled.Text = "Scheduled Pick-Up:";
            // 
            // lblDatePickedUp
            // 
            this.lblDatePickedUp.AutoSize = true;
            this.lblDatePickedUp.BackColor = System.Drawing.Color.Transparent;
            this.lblDatePickedUp.Location = new System.Drawing.Point(543, 326);
            this.lblDatePickedUp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDatePickedUp.Name = "lblDatePickedUp";
            this.lblDatePickedUp.Size = new System.Drawing.Size(116, 18);
            this.lblDatePickedUp.TabIndex = 144;
            this.lblDatePickedUp.Text = "Date Picked-Up:";
            // 
            // lblPickupNo
            // 
            this.lblPickupNo.AutoSize = true;
            this.lblPickupNo.BackColor = System.Drawing.Color.Transparent;
            this.lblPickupNo.Location = new System.Drawing.Point(539, 466);
            this.lblPickupNo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPickupNo.Name = "lblPickupNo";
            this.lblPickupNo.Size = new System.Drawing.Size(122, 18);
            this.lblPickupNo.TabIndex = 145;
            this.lblPickupNo.Text = "Pick-Up Number:";
            // 
            // lblCallStatus
            // 
            this.lblCallStatus.AutoSize = true;
            this.lblCallStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblCallStatus.Location = new System.Drawing.Point(541, 499);
            this.lblCallStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCallStatus.Name = "lblCallStatus";
            this.lblCallStatus.Size = new System.Drawing.Size(83, 18);
            this.lblCallStatus.TabIndex = 146;
            this.lblCallStatus.Text = "Call Status:";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.BackColor = System.Drawing.Color.Transparent;
            this.lblComment.Location = new System.Drawing.Point(543, 398);
            this.lblComment.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(86, 18);
            this.lblComment.TabIndex = 147;
            this.lblComment.Text = "Comments:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(65, 466);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 18);
            this.label15.TabIndex = 148;
            this.label15.Text = "Requested Item:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(66, 499);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 18);
            this.label16.TabIndex = 149;
            this.label16.Text = "Requested Note:";
            // 
            // cboRemark1
            // 
            this.cboRemark1.FormattingEnabled = true;
            this.cboRemark1.Items.AddRange(new object[] {
            "Talked to applicant",
            "Talked to Case Manager/social worker/Teacher",
            "No longer interested",
            "Left voice mail",
            "Voice mail box is full",
            "Left message to Receptionist",
            "Not yet in service /busy",
            "Wrong number",
            "Number is not assigned",
            "Long distance charges needed",
            "Sent Email",
            "Duplicate Application / Has prior application",
            "Existing client",
            "No longer in the address/apartment/housing",
            "                                                                      "});
            this.cboRemark1.Location = new System.Drawing.Point(695, 109);
            this.cboRemark1.Name = "cboRemark1";
            this.cboRemark1.Size = new System.Drawing.Size(173, 26);
            this.cboRemark1.TabIndex = 150;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(224, 499);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(173, 24);
            this.txtNote.TabIndex = 11;
            // 
            // dtpScheduled
            // 
            this.dtpScheduled.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpScheduled.Location = new System.Drawing.Point(694, 282);
            this.dtpScheduled.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dtpScheduled.Name = "dtpScheduled";
            this.dtpScheduled.Size = new System.Drawing.Size(174, 24);
            this.dtpScheduled.TabIndex = 152;
            this.dtpScheduled.Tag = "9999";
            this.dtpScheduled.ValueChanged += new System.EventHandler(this.Dtp_ValueChanged);
            // 
            // dtpDatePickedUp
            // 
            this.dtpDatePickedUp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatePickedUp.Location = new System.Drawing.Point(694, 327);
            this.dtpDatePickedUp.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dtpDatePickedUp.Name = "dtpDatePickedUp";
            this.dtpDatePickedUp.Size = new System.Drawing.Size(174, 24);
            this.dtpDatePickedUp.TabIndex = 153;
            this.dtpDatePickedUp.Tag = "9999";
            this.dtpDatePickedUp.ValueChanged += new System.EventHandler(this.Dtp_ValueChanged);
            // 
            // cboCallStatus
            // 
            this.cboCallStatus.FormattingEnabled = true;
            this.cboCallStatus.Items.AddRange(new object[] {
            "Waiting",
            "Following-Up",
            "Closed"});
            this.cboCallStatus.Location = new System.Drawing.Point(692, 496);
            this.cboCallStatus.Name = "cboCallStatus";
            this.cboCallStatus.Size = new System.Drawing.Size(176, 26);
            this.cboCallStatus.TabIndex = 156;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(692, 395);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(176, 53);
            this.txtStatus.TabIndex = 12;
            // 
            // txtPickUpNo
            // 
            this.txtPickUpNo.Location = new System.Drawing.Point(692, 463);
            this.txtPickUpNo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPickUpNo.Name = "txtPickUpNo";
            this.txtPickUpNo.Size = new System.Drawing.Size(176, 24);
            this.txtPickUpNo.TabIndex = 13;
            // 
            // cboItem
            // 
            this.cboItem.FormattingEnabled = true;
            this.cboItem.Items.AddRange(new object[] {
            "Desktop",
            "Laptop"});
            this.cboItem.Location = new System.Drawing.Point(224, 463);
            this.cboItem.Name = "cboItem";
            this.cboItem.Size = new System.Drawing.Size(173, 26);
            this.cboItem.TabIndex = 159;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.Control;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(660, 558);
            this.btnReset.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 38);
            this.btnReset.TabIndex = 166;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // txtSecPhone
            // 
            this.txtSecPhone.Location = new System.Drawing.Point(223, 215);
            this.txtSecPhone.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtSecPhone.Name = "txtSecPhone";
            this.txtSecPhone.Size = new System.Drawing.Size(174, 24);
            this.txtSecPhone.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(580, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 35);
            this.label3.TabIndex = 168;
            this.label3.Text = "Modify Application";
            // 
            // lblrequired
            // 
            this.lblrequired.AutoSize = true;
            this.lblrequired.BackColor = System.Drawing.Color.Transparent;
            this.lblrequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrequired.ForeColor = System.Drawing.Color.Red;
            this.lblrequired.Location = new System.Drawing.Point(407, 75);
            this.lblrequired.Name = "lblrequired";
            this.lblrequired.Size = new System.Drawing.Size(16, 20);
            this.lblrequired.TabIndex = 169;
            this.lblrequired.Tag = "9999";
            this.lblrequired.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(407, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 20);
            this.label4.TabIndex = 170;
            this.label4.Tag = "9999";
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(407, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 20);
            this.label5.TabIndex = 171;
            this.label5.Tag = "9999";
            this.label5.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(407, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 20);
            this.label7.TabIndex = 172;
            this.label7.Tag = "9999";
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(407, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 20);
            this.label8.TabIndex = 173;
            this.label8.Tag = "9999";
            this.label8.Text = "*";
            // 
            // lblValidPostal
            // 
            this.lblValidPostal.AutoSize = true;
            this.lblValidPostal.BackColor = System.Drawing.Color.Transparent;
            this.lblValidPostal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblValidPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidPostal.ForeColor = System.Drawing.Color.Red;
            this.lblValidPostal.Location = new System.Drawing.Point(400, 328);
            this.lblValidPostal.Name = "lblValidPostal";
            this.lblValidPostal.Size = new System.Drawing.Size(134, 13);
            this.lblValidPostal.TabIndex = 174;
            this.lblValidPostal.Tag = "9999";
            this.lblValidPostal.Text = "Use \"T3J1P2\" Format.";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(407, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 20);
            this.label9.TabIndex = 175;
            this.label9.Tag = "9999";
            this.label9.Text = "*";
            // 
            // cboRemark2
            // 
            this.cboRemark2.FormattingEnabled = true;
            this.cboRemark2.Items.AddRange(new object[] {
            "Talked to applicant",
            "Talked to Case Manager/social worker/Teacher",
            "No longer interested",
            "Left voice mail",
            "Voice mail box is full",
            "Left message to Receptionist",
            "Not yet in service /busy",
            "Wrong number",
            "Number is not assigned",
            "Long distance charges needed",
            "Sent Email",
            "Duplicate Application / Has prior application",
            "Existing client",
            "No longer in the address/apartment/housing",
            "                                                                      "});
            this.cboRemark2.Location = new System.Drawing.Point(695, 176);
            this.cboRemark2.Name = "cboRemark2";
            this.cboRemark2.Size = new System.Drawing.Size(173, 26);
            this.cboRemark2.TabIndex = 176;
            // 
            // cboRemark3
            // 
            this.cboRemark3.FormattingEnabled = true;
            this.cboRemark3.Items.AddRange(new object[] {
            "Talked to applicant",
            "Talked to Case Manager/social worker/Teacher",
            "No longer interested",
            "Left voice mail",
            "Voice mail box is full",
            "Left message to Receptionist",
            "Not yet in service /busy",
            "Wrong number",
            "Number is not assigned",
            "Long distance charges needed",
            "Sent Email",
            "Duplicate Application / Has prior application",
            "Existing client",
            "No longer in the address/apartment/housing",
            "                                                                      "});
            this.cboRemark3.Location = new System.Drawing.Point(694, 247);
            this.cboRemark3.Name = "cboRemark3";
            this.cboRemark3.Size = new System.Drawing.Size(173, 26);
            this.cboRemark3.TabIndex = 177;
            // 
            // frmEditApplicant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CLICC.Properties.Resources.Bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(964, 648);
            this.Controls.Add(this.cboRemark3);
            this.Controls.Add(this.cboRemark2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblValidPostal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblrequired);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSecPhone);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cboItem);
            this.Controls.Add(this.txtPickUpNo);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.cboCallStatus);
            this.Controls.Add(this.dtpDatePickedUp);
            this.Controls.Add(this.dtpScheduled);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.cboRemark1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.lblCallStatus);
            this.Controls.Add(this.lblPickupNo);
            this.Controls.Add(this.lblDatePickedUp);
            this.Controls.Add(this.lblScheduled);
            this.Controls.Add(this.dtpAttempt3);
            this.Controls.Add(this.dtpAttempt2);
            this.Controls.Add(this.dtpAttempt1);
            this.Controls.Add(this.lblRemarks3);
            this.Controls.Add(this.lblRemarks2);
            this.Controls.Add(this.lblRemarks1);
            this.Controls.Add(this.lblAttempt3);
            this.Controls.Add(this.lblAttempt2);
            this.Controls.Add(this.lblAttempt1);
            this.Controls.Add(this.dtpBirth);
            this.Controls.Add(this.lblPostalCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSecondaryPhone);
            this.Controls.Add(this.lblPrimaryPhone);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.dtpRequestDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAgency);
            this.Controls.Add(this.lblAgency);
            this.Controls.Add(this.txtCaseManager);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.lblCase);
            this.Controls.Add(this.txtPrimaryPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtChild);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmEditApplicant";
            this.Tag = "";
            this.Text = "frmEditApplicant";
            this.Load += new System.EventHandler(this.FrmEditApplicant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSecondaryPhone;
        private System.Windows.Forms.Label lblPrimaryPhone;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.DateTimePicker dtpRequestDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAgency;
        private System.Windows.Forms.Label lblAgency;
        private System.Windows.Forms.TextBox txtCaseManager;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Label lblCase;
        private System.Windows.Forms.TextBox txtPrimaryPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtChild;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAttempt1;
        private System.Windows.Forms.Label lblAttempt2;
        private System.Windows.Forms.Label lblAttempt3;
        private System.Windows.Forms.Label lblRemarks1;
        private System.Windows.Forms.Label lblRemarks2;
        private System.Windows.Forms.Label lblRemarks3;
        private System.Windows.Forms.DateTimePicker dtpAttempt1;
        private System.Windows.Forms.DateTimePicker dtpAttempt2;
        private System.Windows.Forms.DateTimePicker dtpAttempt3;
        private System.Windows.Forms.Label lblScheduled;
        private System.Windows.Forms.Label lblDatePickedUp;
        private System.Windows.Forms.Label lblPickupNo;
        private System.Windows.Forms.Label lblCallStatus;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboRemark1;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.DateTimePicker dtpScheduled;
        private System.Windows.Forms.DateTimePicker dtpDatePickedUp;
        private System.Windows.Forms.ComboBox cboCallStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtPickUpNo;
        private System.Windows.Forms.ComboBox cboItem;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtSecPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblrequired;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblValidPostal;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboRemark2;
        private System.Windows.Forms.ComboBox cboRemark3;
    }
}