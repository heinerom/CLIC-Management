namespace CLICC
{
    partial class Index
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miApplicant = new System.Windows.Forms.ToolStripMenuItem();
            this.miNewApplicant = new System.Windows.Forms.ToolStripMenuItem();
            this.miEditApplicant = new System.Windows.Forms.ToolStripMenuItem();
            this.miInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.miUpcomingDays = new System.Windows.Forms.ToolStripMenuItem();
            this.miReport = new System.Windows.Forms.ToolStripMenuItem();
            this.miSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.lblMenu = new System.Windows.Forms.Label();
            this.timerSlide = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Teal;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Constantia", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miApplicant,
            this.miNewApplicant,
            this.miEditApplicant,
            this.miInventory,
            this.miUpcomingDays,
            this.miReport,
            this.miSignOut,
            this.miExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(158, 557);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miApplicant
            // 
            this.miApplicant.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.miApplicant.Margin = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.miApplicant.Name = "miApplicant";
            this.miApplicant.Size = new System.Drawing.Size(145, 25);
            this.miApplicant.Text = "Applicant";
            this.miApplicant.Click += new System.EventHandler(this.miApplicant_Click);
            // 
            // miNewApplicant
            // 
            this.miNewApplicant.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.miNewApplicant.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.miNewApplicant.Name = "miNewApplicant";
            this.miNewApplicant.Size = new System.Drawing.Size(145, 25);
            this.miNewApplicant.Text = "New Applicant";
            this.miNewApplicant.Click += new System.EventHandler(this.MiNewApplicant_Click);
            // 
            // miEditApplicant
            // 
            this.miEditApplicant.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.miEditApplicant.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.miEditApplicant.Name = "miEditApplicant";
            this.miEditApplicant.Size = new System.Drawing.Size(145, 25);
            this.miEditApplicant.Text = "Modify Applicant";
            this.miEditApplicant.Click += new System.EventHandler(this.MiEditApplicant_Click);
            // 
            // miInventory
            // 
            this.miInventory.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.miInventory.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.miInventory.Name = "miInventory";
            this.miInventory.Size = new System.Drawing.Size(145, 25);
            this.miInventory.Text = "Inventory";
            this.miInventory.Click += new System.EventHandler(this.MiInventory_Click);
            // 
            // miUpcomingDays
            // 
            this.miUpcomingDays.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.miUpcomingDays.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.miUpcomingDays.Name = "miUpcomingDays";
            this.miUpcomingDays.Size = new System.Drawing.Size(145, 25);
            this.miUpcomingDays.Text = "Upcoming Days";
            this.miUpcomingDays.Click += new System.EventHandler(this.MiUpcomingDays_Click);
            // 
            // miReport
            // 
            this.miReport.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.miReport.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.miReport.Name = "miReport";
            this.miReport.Size = new System.Drawing.Size(145, 25);
            this.miReport.Text = "Report";
            this.miReport.Click += new System.EventHandler(this.MiReport_Click);
            // 
            // miSignOut
            // 
            this.miSignOut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.miSignOut.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.miSignOut.Name = "miSignOut";
            this.miSignOut.Size = new System.Drawing.Size(145, 25);
            this.miSignOut.Text = "Sign Out";
            this.miSignOut.Click += new System.EventHandler(this.MiSignOut_Click);
            // 
            // miExit
            // 
            this.miExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.miExit.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(145, 25);
            this.miExit.Text = "Exit";
            this.miExit.Click += new System.EventHandler(this.MiExit_Click);
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
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(57)))), ((int)(((byte)(77)))));
            this.lblMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMenu.Location = new System.Drawing.Point(50, 15);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(50, 22);
            this.lblMenu.TabIndex = 2;
            this.lblMenu.Tag = "9999";
            this.lblMenu.Text = "Menu";
            this.lblMenu.Click += new System.EventHandler(this.lblMenu_Click);
            // 
            // timerSlide
            // 
            this.timerSlide.Enabled = true;
            this.timerSlide.Interval = 1500;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 557);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Index";
            this.Text = "CLIC Management System";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miApplicant;
        private System.Windows.Forms.ToolStripMenuItem miInventory;
        private System.Windows.Forms.ToolStripMenuItem miUpcomingDays;
        private System.Windows.Forms.ToolStripMenuItem miReport;
        private System.Windows.Forms.ToolStripMenuItem miSignOut;
        private System.Windows.Forms.ToolStripMenuItem miNewApplicant;
        private System.Windows.Forms.ToolStripMenuItem miEditApplicant;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Timer timerSlide;
    }
}