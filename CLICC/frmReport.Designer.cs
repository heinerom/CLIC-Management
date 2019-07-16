using CLICC.Properties;

namespace CLICC
{
    partial class frmReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.pdocForm = new System.Drawing.Printing.PrintDocument();
            this.ppdForm = new System.Windows.Forms.PrintPreviewDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpApp = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpToP = new System.Windows.Forms.DateTimePicker();
            this.dtpFromP = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUnclaimLap = new System.Windows.Forms.TextBox();
            this.txtUnclaimDesk = new System.Windows.Forms.TextBox();
            this.txtClaimLap = new System.Windows.Forms.TextBox();
            this.txtClaimDesk = new System.Windows.Forms.TextBox();
            this.txtDeny = new System.Windows.Forms.TextBox();
            this.txtUnclaim = new System.Windows.Forms.TextBox();
            this.txtClaim = new System.Windows.Forms.TextBox();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnGivenOut = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblAlert = new System.Windows.Forms.Label();
            this.lblAlert2 = new System.Windows.Forms.Label();
            this.grpApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // pdocForm
            // 
            this.pdocForm.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdocForm_PrintPage);
            // 
            // ppdForm
            // 
            this.ppdForm.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdForm.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdForm.ClientSize = new System.Drawing.Size(700, 800);
            this.ppdForm.Document = this.pdocForm;
            this.ppdForm.Enabled = true;
            this.ppdForm.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdForm.Icon")));
            this.ppdForm.Name = "ppdForm";
            this.ppdForm.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(148, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Date From:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(282, 42);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(110, 24);
            this.dtpFrom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(148, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Date To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(31, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Received :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(31, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Claimed:";
            // 
            // grpApp
            // 
            this.grpApp.BackColor = System.Drawing.Color.Transparent;
            this.grpApp.Controls.Add(this.label12);
            this.grpApp.Controls.Add(this.dtpToP);
            this.grpApp.Controls.Add(this.dtpFromP);
            this.grpApp.Controls.Add(this.label11);
            this.grpApp.Controls.Add(this.txtUnclaimLap);
            this.grpApp.Controls.Add(this.txtUnclaimDesk);
            this.grpApp.Controls.Add(this.txtClaimLap);
            this.grpApp.Controls.Add(this.txtClaimDesk);
            this.grpApp.Controls.Add(this.txtDeny);
            this.grpApp.Controls.Add(this.txtUnclaim);
            this.grpApp.Controls.Add(this.txtClaim);
            this.grpApp.Controls.Add(this.txtReceive);
            this.grpApp.Controls.Add(this.label10);
            this.grpApp.Controls.Add(this.label8);
            this.grpApp.Controls.Add(this.label9);
            this.grpApp.Controls.Add(this.label7);
            this.grpApp.Controls.Add(this.label6);
            this.grpApp.Controls.Add(this.label5);
            this.grpApp.Controls.Add(this.label3);
            this.grpApp.Controls.Add(this.label4);
            this.grpApp.Location = new System.Drawing.Point(200, 135);
            this.grpApp.Name = "grpApp";
            this.grpApp.Size = new System.Drawing.Size(569, 357);
            this.grpApp.TabIndex = 6;
            this.grpApp.TabStop = false;
            this.grpApp.Text = "Applications";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(203, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 18);
            this.label12.TabIndex = 23;
            this.label12.Text = "to";
            // 
            // dtpToP
            // 
            this.dtpToP.Enabled = false;
            this.dtpToP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToP.Location = new System.Drawing.Point(233, 38);
            this.dtpToP.Name = "dtpToP";
            this.dtpToP.Size = new System.Drawing.Size(110, 24);
            this.dtpToP.TabIndex = 22;
            // 
            // dtpFromP
            // 
            this.dtpFromP.Enabled = false;
            this.dtpFromP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromP.Location = new System.Drawing.Point(81, 38);
            this.dtpFromP.Name = "dtpFromP";
            this.dtpFromP.Size = new System.Drawing.Size(110, 24);
            this.dtpFromP.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(31, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 18);
            this.label11.TabIndex = 20;
            this.label11.Text = "From";
            // 
            // txtUnclaimLap
            // 
            this.txtUnclaimLap.BackColor = System.Drawing.Color.Azure;
            this.txtUnclaimLap.Location = new System.Drawing.Point(427, 256);
            this.txtUnclaimLap.Name = "txtUnclaimLap";
            this.txtUnclaimLap.ReadOnly = true;
            this.txtUnclaimLap.Size = new System.Drawing.Size(110, 24);
            this.txtUnclaimLap.TabIndex = 19;
            // 
            // txtUnclaimDesk
            // 
            this.txtUnclaimDesk.BackColor = System.Drawing.Color.Azure;
            this.txtUnclaimDesk.Location = new System.Drawing.Point(427, 222);
            this.txtUnclaimDesk.Name = "txtUnclaimDesk";
            this.txtUnclaimDesk.ReadOnly = true;
            this.txtUnclaimDesk.Size = new System.Drawing.Size(110, 24);
            this.txtUnclaimDesk.TabIndex = 18;
            // 
            // txtClaimLap
            // 
            this.txtClaimLap.BackColor = System.Drawing.Color.Azure;
            this.txtClaimLap.Location = new System.Drawing.Point(427, 169);
            this.txtClaimLap.Name = "txtClaimLap";
            this.txtClaimLap.ReadOnly = true;
            this.txtClaimLap.Size = new System.Drawing.Size(110, 24);
            this.txtClaimLap.TabIndex = 17;
            // 
            // txtClaimDesk
            // 
            this.txtClaimDesk.BackColor = System.Drawing.Color.Azure;
            this.txtClaimDesk.Location = new System.Drawing.Point(427, 135);
            this.txtClaimDesk.Name = "txtClaimDesk";
            this.txtClaimDesk.ReadOnly = true;
            this.txtClaimDesk.Size = new System.Drawing.Size(110, 24);
            this.txtClaimDesk.TabIndex = 16;
            // 
            // txtDeny
            // 
            this.txtDeny.BackColor = System.Drawing.Color.Azure;
            this.txtDeny.Location = new System.Drawing.Point(131, 306);
            this.txtDeny.Name = "txtDeny";
            this.txtDeny.ReadOnly = true;
            this.txtDeny.Size = new System.Drawing.Size(110, 24);
            this.txtDeny.TabIndex = 15;
            // 
            // txtUnclaim
            // 
            this.txtUnclaim.BackColor = System.Drawing.Color.Azure;
            this.txtUnclaim.Location = new System.Drawing.Point(131, 219);
            this.txtUnclaim.Name = "txtUnclaim";
            this.txtUnclaim.ReadOnly = true;
            this.txtUnclaim.Size = new System.Drawing.Size(110, 24);
            this.txtUnclaim.TabIndex = 14;
            // 
            // txtClaim
            // 
            this.txtClaim.BackColor = System.Drawing.Color.Azure;
            this.txtClaim.Location = new System.Drawing.Point(131, 129);
            this.txtClaim.Name = "txtClaim";
            this.txtClaim.ReadOnly = true;
            this.txtClaim.Size = new System.Drawing.Size(110, 24);
            this.txtClaim.TabIndex = 13;
            // 
            // txtReceive
            // 
            this.txtReceive.BackColor = System.Drawing.Color.Azure;
            this.txtReceive.Location = new System.Drawing.Point(131, 82);
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.ReadOnly = true;
            this.txtReceive.Size = new System.Drawing.Size(110, 24);
            this.txtReceive.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(31, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 18);
            this.label10.TabIndex = 11;
            this.label10.Text = "Ineligible: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(271, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "Unclaimed Laptop:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(271, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "Unclaimed Desktop:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(31, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Unclaimed:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(271, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Claimed Laptop:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(271, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Claimed Desktop:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FloralWhite;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(451, 35);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(97, 31);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "&Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FloralWhite;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(451, 78);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 31);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnGivenOut
            // 
            this.btnGivenOut.BackColor = System.Drawing.Color.FloralWhite;
            this.btnGivenOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGivenOut.Location = new System.Drawing.Point(578, 35);
            this.btnGivenOut.Name = "btnGivenOut";
            this.btnGivenOut.Size = new System.Drawing.Size(233, 31);
            this.btnGivenOut.TabIndex = 9;
            this.btnGivenOut.Text = "&Given Out On Pick Up Date";
            this.btnGivenOut.UseVisualStyleBackColor = false;
            this.btnGivenOut.Click += new System.EventHandler(this.btnGivenOut_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FloralWhite;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(626, 79);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(97, 31);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(282, 78);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(110, 24);
            this.dtpTo.TabIndex = 11;
            // 
            // lblAlert
            // 
            this.lblAlert.AutoSize = true;
            this.lblAlert.BackColor = System.Drawing.Color.Transparent;
            this.lblAlert.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlert.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAlert.Location = new System.Drawing.Point(729, 90);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(137, 19);
            this.lblAlert.TabIndex = 12;
            this.lblAlert.Tag = "9999";
            this.lblAlert.Text = "Click me to open File";
            this.lblAlert.Click += new System.EventHandler(this.LblAlert_Click);
            // 
            // lblAlert2
            // 
            this.lblAlert2.AutoSize = true;
            this.lblAlert2.BackColor = System.Drawing.Color.Transparent;
            this.lblAlert2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlert2.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAlert2.Location = new System.Drawing.Point(729, 113);
            this.lblAlert2.Name = "lblAlert2";
            this.lblAlert2.Size = new System.Drawing.Size(157, 19);
            this.lblAlert2.TabIndex = 13;
            this.lblAlert2.Tag = "9999";
            this.lblAlert2.Text = "if printer is not working!";
            this.lblAlert2.Click += new System.EventHandler(this.LblAlert_Click);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CLICC.Properties.Resources.Bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 560);
            this.Controls.Add(this.lblAlert2);
            this.Controls.Add(this.lblAlert);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnGivenOut);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.grpApp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.FrmReport_Load);
            this.grpApp.ResumeLayout(false);
            this.grpApp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpApp;
        private System.Windows.Forms.TextBox txtUnclaimLap;
        private System.Windows.Forms.TextBox txtUnclaimDesk;
        private System.Windows.Forms.TextBox txtClaimLap;
        private System.Windows.Forms.TextBox txtClaimDesk;
        private System.Windows.Forms.TextBox txtDeny;
        private System.Windows.Forms.TextBox txtUnclaim;
        private System.Windows.Forms.TextBox txtClaim;
        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnGivenOut;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument pdocForm;
        private System.Windows.Forms.PrintPreviewDialog ppdForm;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpToP;
        private System.Windows.Forms.DateTimePicker dtpFromP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.Label lblAlert2;
    }
}