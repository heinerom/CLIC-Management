namespace CLICC
{
    partial class frmViewApplicant
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClosedCase = new System.Windows.Forms.Button();
            this.btnFollowingUpCase = new System.Windows.Forms.Button();
            this.btnWaitingCase = new System.Windows.Forms.Button();
            this.dgvApplicants = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBackUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicants)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(96, 55);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(195, 26);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(96, 94);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(206, 94);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 30);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnClosedCase
            // 
            this.btnClosedCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClosedCase.Location = new System.Drawing.Point(729, 42);
            this.btnClosedCase.Name = "btnClosedCase";
            this.btnClosedCase.Size = new System.Drawing.Size(142, 39);
            this.btnClosedCase.TabIndex = 7;
            this.btnClosedCase.Text = "&Closed Case";
            this.btnClosedCase.UseVisualStyleBackColor = true;
            this.btnClosedCase.Click += new System.EventHandler(this.BtnClosedCase_Click);
            // 
            // btnFollowingUpCase
            // 
            this.btnFollowingUpCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFollowingUpCase.Location = new System.Drawing.Point(558, 42);
            this.btnFollowingUpCase.Name = "btnFollowingUpCase";
            this.btnFollowingUpCase.Size = new System.Drawing.Size(142, 39);
            this.btnFollowingUpCase.TabIndex = 8;
            this.btnFollowingUpCase.Text = "&Following Up Case";
            this.btnFollowingUpCase.UseVisualStyleBackColor = true;
            this.btnFollowingUpCase.Click += new System.EventHandler(this.BtnFollowingUpCase_Click);
            // 
            // btnWaitingCase
            // 
            this.btnWaitingCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnWaitingCase.Location = new System.Drawing.Point(387, 42);
            this.btnWaitingCase.Name = "btnWaitingCase";
            this.btnWaitingCase.Size = new System.Drawing.Size(142, 39);
            this.btnWaitingCase.TabIndex = 9;
            this.btnWaitingCase.Text = "&Waiting Case";
            this.btnWaitingCase.UseVisualStyleBackColor = true;
            this.btnWaitingCase.Click += new System.EventHandler(this.BtnWaitingCase_Click);
            // 
            // dgvApplicants
            // 
            this.dgvApplicants.AllowUserToAddRows = false;
            this.dgvApplicants.AllowUserToDeleteRows = false;
            this.dgvApplicants.AllowUserToResizeRows = false;
            this.dgvApplicants.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvApplicants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplicants.Location = new System.Drawing.Point(2, 158);
            this.dgvApplicants.Name = "dgvApplicants";
            this.dgvApplicants.ReadOnly = true;
            this.dgvApplicants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplicants.Size = new System.Drawing.Size(951, 303);
            this.dgvApplicants.TabIndex = 10;
            this.dgvApplicants.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvApplicants_CellClick);
            this.dgvApplicants.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvApplicants_CellDoubleClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(75, 506);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(185, 29);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "&Edit Application";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(397, 506);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 29);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "&Delete Application";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnShowAll.Location = new System.Drawing.Point(558, 94);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(142, 39);
            this.btnShowAll.TabIndex = 15;
            this.btnShowAll.Text = "&Show All Cases";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.BtnShowAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(92, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Search Applicant:";
            // 
            // btnBackUp
            // 
            this.btnBackUp.Location = new System.Drawing.Point(709, 506);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(180, 29);
            this.btnBackUp.TabIndex = 17;
            this.btnBackUp.Text = "&Back up";
            this.btnBackUp.UseVisualStyleBackColor = true;
            this.btnBackUp.Click += new System.EventHandler(this.BtnBackUp_Click);
            // 
            // frmViewApplicant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CLICC.Properties.Resources.Bg;
            this.ClientSize = new System.Drawing.Size(965, 560);
            this.Controls.Add(this.btnBackUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvApplicants);
            this.Controls.Add(this.btnWaitingCase);
            this.Controls.Add(this.btnFollowingUpCase);
            this.Controls.Add(this.btnClosedCase);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmViewApplicant";
            this.Text = "modifyApplicant";
            this.Load += new System.EventHandler(this.frmModifyApplicant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClosedCase;
        private System.Windows.Forms.Button btnFollowingUpCase;
        private System.Windows.Forms.Button btnWaitingCase;
        private System.Windows.Forms.DataGridView dgvApplicants;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackUp;
    }
}