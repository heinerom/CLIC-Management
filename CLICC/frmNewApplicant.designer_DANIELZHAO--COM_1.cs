namespace CLICC
{
    partial class frmNewApplicant
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
            this.rdYes = new System.Windows.Forms.RadioButton();
            this.lblWhen = new System.Windows.Forms.Label();
            this.txtWhen = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdNo = new System.Windows.Forms.RadioButton();
            this.dtBirth = new System.Windows.Forms.DateTimePicker();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblstay = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSecondaryPhone = new System.Windows.Forms.Label();
            this.lblPrimaryPhone = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.dtPApplication = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtAgency = new System.Windows.Forms.TextBox();
            this.lblAgency = new System.Windows.Forms.Label();
            this.txtCaseManager = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.lblCase = new System.Windows.Forms.Label();
            this.rdNoClient = new System.Windows.Forms.RadioButton();
            this.rdYesClient = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrimaryPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSecPhone = new System.Windows.Forms.TextBox();
            this.txtChild = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCall = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtReqNotes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbReqItem = new System.Windows.Forms.ComboBox();
            this.lbldesktop = new System.Windows.Forms.Label();
            this.lblValidPostal = new System.Windows.Forms.Label();
            this.lblrequired = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdYes
            // 
            this.rdYes.AutoSize = true;
            this.rdYes.BackColor = System.Drawing.Color.Transparent;
            this.rdYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.rdYes.Location = new System.Drawing.Point(0, 4);
            this.rdYes.Margin = new System.Windows.Forms.Padding(4);
            this.rdYes.Name = "rdYes";
            this.rdYes.Size = new System.Drawing.Size(50, 21);
            this.rdYes.TabIndex = 51;
            this.rdYes.TabStop = true;
            this.rdYes.Tag = "9999";
            this.rdYes.Text = "Yes";
            this.rdYes.UseVisualStyleBackColor = false;
            this.rdYes.CheckedChanged += new System.EventHandler(this.RdYes_CheckedChanged_1);
            // 
            // lblWhen
            // 
            this.lblWhen.AutoSize = true;
            this.lblWhen.BackColor = System.Drawing.Color.Transparent;
            this.lblWhen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.lblWhen.Location = new System.Drawing.Point(96, 10);
            this.lblWhen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWhen.Name = "lblWhen";
            this.lblWhen.Size = new System.Drawing.Size(57, 17);
            this.lblWhen.TabIndex = 54;
            this.lblWhen.Tag = "9999";
            this.lblWhen.Text = "When ?";
            this.lblWhen.Visible = false;
            // 
            // txtWhen
            // 
            this.txtWhen.Location = new System.Drawing.Point(195, 5);
            this.txtWhen.Margin = new System.Windows.Forms.Padding(4);
            this.txtWhen.Name = "txtWhen";
            this.txtWhen.Size = new System.Drawing.Size(175, 23);
            this.txtWhen.TabIndex = 8;
            this.txtWhen.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.rdYes);
            this.panel1.Controls.Add(this.lblWhen);
            this.panel1.Controls.Add(this.txtWhen);
            this.panel1.Controls.Add(this.rdNo);
            this.panel1.Location = new System.Drawing.Point(140, 265);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 38);
            this.panel1.TabIndex = 103;
            // 
            // rdNo
            // 
            this.rdNo.AutoSize = true;
            this.rdNo.BackColor = System.Drawing.Color.Transparent;
            this.rdNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.rdNo.Location = new System.Drawing.Point(456, 6);
            this.rdNo.Margin = new System.Windows.Forms.Padding(4);
            this.rdNo.Name = "rdNo";
            this.rdNo.Size = new System.Drawing.Size(44, 21);
            this.rdNo.TabIndex = 52;
            this.rdNo.TabStop = true;
            this.rdNo.Tag = "9999";
            this.rdNo.Text = "No";
            this.rdNo.UseVisualStyleBackColor = false;
            this.rdNo.CheckedChanged += new System.EventHandler(this.RdNo_CheckedChanged);
            // 
            // dtBirth
            // 
            this.dtBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBirth.Location = new System.Drawing.Point(282, 92);
            this.dtBirth.Margin = new System.Windows.Forms.Padding(4);
            this.dtBirth.Name = "dtBirth";
            this.dtBirth.Size = new System.Drawing.Size(180, 23);
            this.dtBirth.TabIndex = 86;
            this.dtBirth.Tag = "9999";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.BackColor = System.Drawing.Color.Transparent;
            this.lblPostalCode.ForeColor = System.Drawing.Color.Black;
            this.lblPostalCode.Location = new System.Drawing.Point(518, 196);
            this.lblPostalCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(88, 17);
            this.lblPostalCode.TabIndex = 85;
            this.lblPostalCode.Text = "Postal Code:";
            // 
            // lblstay
            // 
            this.lblstay.AutoSize = true;
            this.lblstay.BackColor = System.Drawing.Color.Transparent;
            this.lblstay.ForeColor = System.Drawing.Color.Black;
            this.lblstay.Location = new System.Drawing.Point(137, 244);
            this.lblstay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstay.Name = "lblstay";
            this.lblstay.Size = new System.Drawing.Size(614, 17);
            this.lblstay.TabIndex = 84;
            this.lblstay.Text = "Have you stayed (former client) at the Calgary Drop-In & Rehab Centre within the " +
    "last (6) months?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(137, 175);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 83;
            this.label6.Text = "Address:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(518, 138);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEmail.TabIndex = 82;
            this.lblEmail.Text = "Email:";
            // 
            // lblSecondaryPhone
            // 
            this.lblSecondaryPhone.AutoSize = true;
            this.lblSecondaryPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblSecondaryPhone.ForeColor = System.Drawing.Color.Black;
            this.lblSecondaryPhone.Location = new System.Drawing.Point(137, 138);
            this.lblSecondaryPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecondaryPhone.Name = "lblSecondaryPhone";
            this.lblSecondaryPhone.Size = new System.Drawing.Size(125, 17);
            this.lblSecondaryPhone.TabIndex = 81;
            this.lblSecondaryPhone.Text = "Secondary Phone:";
            // 
            // lblPrimaryPhone
            // 
            this.lblPrimaryPhone.AutoSize = true;
            this.lblPrimaryPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPrimaryPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPrimaryPhone.Location = new System.Drawing.Point(518, 95);
            this.lblPrimaryPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrimaryPhone.Name = "lblPrimaryPhone";
            this.lblPrimaryPhone.Size = new System.Drawing.Size(105, 17);
            this.lblPrimaryPhone.TabIndex = 80;
            this.lblPrimaryPhone.Text = "Primary Phone:";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.BackColor = System.Drawing.Color.Transparent;
            this.lblDob.ForeColor = System.Drawing.Color.Black;
            this.lblDob.Location = new System.Drawing.Point(137, 98);
            this.lblDob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(94, 17);
            this.lblDob.TabIndex = 79;
            this.lblDob.Text = "Date Of Birth:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(661, 52);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(180, 23);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Location = new System.Drawing.Point(281, 53);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(181, 23);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.ForeColor = System.Drawing.Color.Black;
            this.lblLastName.Location = new System.Drawing.Point(518, 55);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(80, 17);
            this.lblLastName.TabIndex = 76;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.ForeColor = System.Drawing.Color.Black;
            this.lblFirstName.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblFirstName.Location = new System.Drawing.Point(137, 55);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(80, 17);
            this.lblFirstName.TabIndex = 75;
            this.lblFirstName.Text = "First Name:";
            // 
            // dtPApplication
            // 
            this.dtPApplication.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPApplication.Location = new System.Drawing.Point(282, 13);
            this.dtPApplication.Margin = new System.Windows.Forms.Padding(4);
            this.dtPApplication.Name = "dtPApplication";
            this.dtPApplication.Size = new System.Drawing.Size(180, 23);
            this.dtPApplication.TabIndex = 74;
            this.dtPApplication.Tag = "9999";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(137, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 73;
            this.label1.Text = "Date Of Application:";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.Control;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(510, 525);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 30);
            this.btnReset.TabIndex = 102;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.Control;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(306, 525);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 30);
            this.btnSubmit.TabIndex = 101;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // txtAgency
            // 
            this.txtAgency.Location = new System.Drawing.Point(460, 33);
            this.txtAgency.Margin = new System.Windows.Forms.Padding(4);
            this.txtAgency.Name = "txtAgency";
            this.txtAgency.Size = new System.Drawing.Size(167, 23);
            this.txtAgency.TabIndex = 11;
            this.txtAgency.Visible = false;
            // 
            // lblAgency
            // 
            this.lblAgency.AutoSize = true;
            this.lblAgency.BackColor = System.Drawing.Color.Transparent;
            this.lblAgency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.lblAgency.Location = new System.Drawing.Point(361, 33);
            this.lblAgency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgency.Name = "lblAgency";
            this.lblAgency.Size = new System.Drawing.Size(59, 17);
            this.lblAgency.TabIndex = 99;
            this.lblAgency.Tag = "9999";
            this.lblAgency.Text = "Agency:";
            this.lblAgency.Visible = false;
            // 
            // txtCaseManager
            // 
            this.txtCaseManager.Location = new System.Drawing.Point(163, 33);
            this.txtCaseManager.Margin = new System.Windows.Forms.Padding(4);
            this.txtCaseManager.Name = "txtCaseManager";
            this.txtCaseManager.Size = new System.Drawing.Size(167, 23);
            this.txtCaseManager.TabIndex = 10;
            this.txtCaseManager.Visible = false;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(661, 192);
            this.txtPostalCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtPostalCode.MaxLength = 6;
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(180, 23);
            this.txtPostalCode.TabIndex = 7;
            this.txtPostalCode.Enter += new System.EventHandler(this.TxtPostalCode_Enter);
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(281, 173);
            this.txtAdd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdd.Multiline = true;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(180, 57);
            this.txtAdd.TabIndex = 6;
            // 
            // lblCase
            // 
            this.lblCase.AutoSize = true;
            this.lblCase.BackColor = System.Drawing.Color.Transparent;
            this.lblCase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.lblCase.Location = new System.Drawing.Point(1, 30);
            this.lblCase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCase.Name = "lblCase";
            this.lblCase.Size = new System.Drawing.Size(159, 17);
            this.lblCase.TabIndex = 95;
            this.lblCase.Tag = "9999";
            this.lblCase.Text = "Case Manager\'s Name?";
            this.lblCase.Visible = false;
            // 
            // rdNoClient
            // 
            this.rdNoClient.AutoSize = true;
            this.rdNoClient.BackColor = System.Drawing.Color.Transparent;
            this.rdNoClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.rdNoClient.Location = new System.Drawing.Point(252, 4);
            this.rdNoClient.Margin = new System.Windows.Forms.Padding(4);
            this.rdNoClient.Name = "rdNoClient";
            this.rdNoClient.Size = new System.Drawing.Size(44, 21);
            this.rdNoClient.TabIndex = 94;
            this.rdNoClient.TabStop = true;
            this.rdNoClient.Tag = "9999";
            this.rdNoClient.Text = "No";
            this.rdNoClient.UseVisualStyleBackColor = false;
            this.rdNoClient.CheckedChanged += new System.EventHandler(this.RdNoClient_CheckedChanged);
            // 
            // rdYesClient
            // 
            this.rdYesClient.AutoSize = true;
            this.rdYesClient.BackColor = System.Drawing.Color.Transparent;
            this.rdYesClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.rdYesClient.Location = new System.Drawing.Point(4, 4);
            this.rdYesClient.Margin = new System.Windows.Forms.Padding(4);
            this.rdYesClient.Name = "rdYesClient";
            this.rdYesClient.Size = new System.Drawing.Size(50, 21);
            this.rdYesClient.TabIndex = 93;
            this.rdYesClient.TabStop = true;
            this.rdYesClient.Tag = "9999";
            this.rdYesClient.Text = "Yes";
            this.rdYesClient.UseVisualStyleBackColor = false;
            this.rdYesClient.CheckedChanged += new System.EventHandler(this.RdYesClient_CheckedChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(137, 344);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(463, 17);
            this.label4.TabIndex = 92;
            this.label4.Text = "Are you a Case Manager representing a Client? (Applying on behalf of?)";
            // 
            // txtPrimaryPhone
            // 
            this.txtPrimaryPhone.Location = new System.Drawing.Point(661, 92);
            this.txtPrimaryPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrimaryPhone.Name = "txtPrimaryPhone";
            this.txtPrimaryPhone.Size = new System.Drawing.Size(180, 23);
            this.txtPrimaryPhone.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(661, 132);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 23);
            this.txtEmail.TabIndex = 5;
            // 
            // txtSecPhone
            // 
            this.txtSecPhone.Location = new System.Drawing.Point(281, 132);
            this.txtSecPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtSecPhone.Name = "txtSecPhone";
            this.txtSecPhone.Size = new System.Drawing.Size(180, 23);
            this.txtSecPhone.TabIndex = 4;
            // 
            // txtChild
            // 
            this.txtChild.Location = new System.Drawing.Point(546, 311);
            this.txtChild.Margin = new System.Windows.Forms.Padding(4);
            this.txtChild.Name = "txtChild";
            this.txtChild.Size = new System.Drawing.Size(180, 23);
            this.txtChild.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(137, 313);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 17);
            this.label2.TabIndex = 87;
            this.label2.Text = "If applicable, how many children are living with you? ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(518, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 105;
            this.label5.Text = "Call Status:";
            // 
            // cbCall
            // 
            this.cbCall.FormattingEnabled = true;
            this.cbCall.Items.AddRange(new object[] {
            "Waiting",
            "Follow-Up",
            "Closed"});
            this.cbCall.Location = new System.Drawing.Point(661, 14);
            this.cbCall.Name = "cbCall";
            this.cbCall.Size = new System.Drawing.Size(180, 25);
            this.cbCall.TabIndex = 106;
            this.cbCall.Text = "Select Status";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.rdYesClient);
            this.panel3.Controls.Add(this.lblCase);
            this.panel3.Controls.Add(this.txtCaseManager);
            this.panel3.Controls.Add(this.lblAgency);
            this.panel3.Controls.Add(this.txtAgency);
            this.panel3.Controls.Add(this.rdNoClient);
            this.panel3.Location = new System.Drawing.Point(140, 372);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(701, 63);
            this.panel3.TabIndex = 107;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.txtReqNotes);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.cbReqItem);
            this.panel4.Controls.Add(this.lbldesktop);
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panel4.Location = new System.Drawing.Point(140, 442);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(701, 73);
            this.panel4.TabIndex = 108;
            // 
            // txtReqNotes
            // 
            this.txtReqNotes.Location = new System.Drawing.Point(422, 11);
            this.txtReqNotes.Multiline = true;
            this.txtReqNotes.Name = "txtReqNotes";
            this.txtReqNotes.Size = new System.Drawing.Size(194, 59);
            this.txtReqNotes.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.label8.Location = new System.Drawing.Point(290, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 17);
            this.label8.TabIndex = 2;
            this.label8.Tag = "9999";
            this.label8.Text = "Requested Notes:";
            // 
            // cbReqItem
            // 
            this.cbReqItem.FormattingEnabled = true;
            this.cbReqItem.Items.AddRange(new object[] {
            "Desktop",
            "Laptop"});
            this.cbReqItem.Location = new System.Drawing.Point(118, 11);
            this.cbReqItem.Name = "cbReqItem";
            this.cbReqItem.Size = new System.Drawing.Size(121, 25);
            this.cbReqItem.TabIndex = 1;
            // 
            // lbldesktop
            // 
            this.lbldesktop.AutoSize = true;
            this.lbldesktop.BackColor = System.Drawing.Color.Transparent;
            this.lbldesktop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.lbldesktop.Location = new System.Drawing.Point(-3, 14);
            this.lbldesktop.Name = "lbldesktop";
            this.lbldesktop.Size = new System.Drawing.Size(111, 17);
            this.lbldesktop.TabIndex = 0;
            this.lbldesktop.Tag = "9999";
            this.lbldesktop.Text = "Requested Item:";
            // 
            // lblValidPostal
            // 
            this.lblValidPostal.AutoSize = true;
            this.lblValidPostal.BackColor = System.Drawing.Color.Transparent;
            this.lblValidPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidPostal.ForeColor = System.Drawing.Color.Red;
            this.lblValidPostal.Location = new System.Drawing.Point(531, 165);
            this.lblValidPostal.Name = "lblValidPostal";
            this.lblValidPostal.Size = new System.Drawing.Size(307, 16);
            this.lblValidPostal.TabIndex = 109;
            this.lblValidPostal.Text = "Postal Code Should be in \"T3J1P2\" Format.";
            // 
            // lblrequired
            // 
            this.lblrequired.AutoSize = true;
            this.lblrequired.BackColor = System.Drawing.Color.Transparent;
            this.lblrequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrequired.ForeColor = System.Drawing.Color.Red;
            this.lblrequired.Location = new System.Drawing.Point(465, 55);
            this.lblrequired.Name = "lblrequired";
            this.lblrequired.Size = new System.Drawing.Size(16, 20);
            this.lblrequired.TabIndex = 110;
            this.lblrequired.Tag = "9999";
            this.lblrequired.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(848, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 20);
            this.label7.TabIndex = 111;
            this.label7.Tag = "9999";
            this.label7.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(848, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 20);
            this.label9.TabIndex = 112;
            this.label9.Tag = "9999";
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(848, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 20);
            this.label10.TabIndex = 113;
            this.label10.Tag = "9999";
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(465, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 20);
            this.label11.TabIndex = 114;
            this.label11.Tag = "9999";
            this.label11.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(758, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 115;
            this.label3.Tag = "9999";
            this.label3.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(740, 313);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 20);
            this.label12.TabIndex = 116;
            this.label12.Tag = "9999";
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(624, 344);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 20);
            this.label13.TabIndex = 117;
            this.label13.Tag = "9999";
            this.label13.Text = "*";
            // 
            // frmNewApplicant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = global::CLICC.Properties.Resources.Bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 560);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblrequired);
            this.Controls.Add(this.lblValidPostal);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cbCall);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtBirth);
            this.Controls.Add(this.lblPostalCode);
            this.Controls.Add(this.lblstay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSecondaryPhone);
            this.Controls.Add(this.lblPrimaryPhone);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.dtPApplication);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrimaryPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSecPhone);
            this.Controls.Add(this.txtChild);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNewApplicant";
            this.Text = "NewApplicant";
            this.Load += new System.EventHandler(this.FrmNewApplicant_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdYes;
        private System.Windows.Forms.Label lblWhen;
        private System.Windows.Forms.TextBox txtWhen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdNo;
        private System.Windows.Forms.DateTimePicker dtBirth;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblstay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSecondaryPhone;
        private System.Windows.Forms.Label lblPrimaryPhone;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.DateTimePicker dtPApplication;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtAgency;
        private System.Windows.Forms.Label lblAgency;
        private System.Windows.Forms.TextBox txtCaseManager;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Label lblCase;
        private System.Windows.Forms.RadioButton rdNoClient;
        private System.Windows.Forms.RadioButton rdYesClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrimaryPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSecPhone;
        private System.Windows.Forms.TextBox txtChild;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCall;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtReqNotes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbReqItem;
        private System.Windows.Forms.Label lbldesktop;
        private System.Windows.Forms.Label lblValidPostal;
        private System.Windows.Forms.Label lblrequired;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}