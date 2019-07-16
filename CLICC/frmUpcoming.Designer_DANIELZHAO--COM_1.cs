namespace CLICC
{
    partial class frmUpcoming
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvScheduled = new System.Windows.Forms.DataGridView();
            this.btnModify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduled)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(304, 52);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(318, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Applicants Scheduled for Pick Up";
            // 
            // dgvScheduled
            // 
            this.dgvScheduled.AllowUserToResizeRows = false;
            this.dgvScheduled.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvScheduled.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvScheduled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScheduled.Location = new System.Drawing.Point(48, 102);
            this.dgvScheduled.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.dgvScheduled.Name = "dgvScheduled";
            this.dgvScheduled.ReadOnly = true;
            this.dgvScheduled.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScheduled.Size = new System.Drawing.Size(850, 227);
            this.dgvScheduled.TabIndex = 1;
            this.dgvScheduled.Tag = "";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(406, 395);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(98, 37);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "&Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // frmUpcoming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CLICC.Properties.Resources.Bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 560);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.dgvScheduled);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.Name = "frmUpcoming";
            this.Text = "frmUpcoming";
            this.Load += new System.EventHandler(this.FrmUpcoming_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduled)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvScheduled;
        private System.Windows.Forms.Button btnModify;
    }
}