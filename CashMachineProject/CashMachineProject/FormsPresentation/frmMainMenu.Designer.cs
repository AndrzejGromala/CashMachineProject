namespace CashMachineProject.FormsPresentation
{
    partial class frmMainMenu
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
            this.btnBalanceEnquiry = new System.Windows.Forms.Button();
            this.btnWithdrowal = new System.Windows.Forms.Button();
            this.btnLodgement = new System.Windows.Forms.Button();
            this.btnChangePIN = new System.Windows.Forms.Button();
            this.btnExitMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBalanceEnquiry
            // 
            this.btnBalanceEnquiry.Location = new System.Drawing.Point(145, 54);
            this.btnBalanceEnquiry.Name = "btnBalanceEnquiry";
            this.btnBalanceEnquiry.Size = new System.Drawing.Size(160, 38);
            this.btnBalanceEnquiry.TabIndex = 0;
            this.btnBalanceEnquiry.Text = "Balance Enquiry";
            this.btnBalanceEnquiry.UseVisualStyleBackColor = true;
            this.btnBalanceEnquiry.Click += new System.EventHandler(this.btnBalanceEnquiry_Click);
            // 
            // btnWithdrowal
            // 
            this.btnWithdrowal.Location = new System.Drawing.Point(145, 118);
            this.btnWithdrowal.Name = "btnWithdrowal";
            this.btnWithdrowal.Size = new System.Drawing.Size(160, 38);
            this.btnWithdrowal.TabIndex = 1;
            this.btnWithdrowal.Text = "Withdrowal";
            this.btnWithdrowal.UseVisualStyleBackColor = true;
            this.btnWithdrowal.Click += new System.EventHandler(this.btnWithdrowal_Click);
            // 
            // btnLodgement
            // 
            this.btnLodgement.Location = new System.Drawing.Point(145, 183);
            this.btnLodgement.Name = "btnLodgement";
            this.btnLodgement.Size = new System.Drawing.Size(160, 38);
            this.btnLodgement.TabIndex = 2;
            this.btnLodgement.Text = "Lodgement";
            this.btnLodgement.UseVisualStyleBackColor = true;
            this.btnLodgement.Click += new System.EventHandler(this.btnLodgement_Click);
            // 
            // btnChangePIN
            // 
            this.btnChangePIN.Location = new System.Drawing.Point(145, 249);
            this.btnChangePIN.Name = "btnChangePIN";
            this.btnChangePIN.Size = new System.Drawing.Size(160, 38);
            this.btnChangePIN.TabIndex = 3;
            this.btnChangePIN.Text = "Change PIN";
            this.btnChangePIN.UseVisualStyleBackColor = true;
            this.btnChangePIN.Click += new System.EventHandler(this.btnChangePIN_Click);
            // 
            // btnExitMainMenu
            // 
            this.btnExitMainMenu.BackColor = System.Drawing.Color.Red;
            this.btnExitMainMenu.Location = new System.Drawing.Point(145, 316);
            this.btnExitMainMenu.Name = "btnExitMainMenu";
            this.btnExitMainMenu.Size = new System.Drawing.Size(160, 38);
            this.btnExitMainMenu.TabIndex = 4;
            this.btnExitMainMenu.Text = "Exit";
            this.btnExitMainMenu.UseVisualStyleBackColor = false;
            this.btnExitMainMenu.Click += new System.EventHandler(this.btnExitMainMenu_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 397);
            this.Controls.Add(this.btnExitMainMenu);
            this.Controls.Add(this.btnChangePIN);
            this.Controls.Add(this.btnLodgement);
            this.Controls.Add(this.btnWithdrowal);
            this.Controls.Add(this.btnBalanceEnquiry);
            this.Name = "frmMainMenu";
            this.Text = "frmMainMenu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBalanceEnquiry;
        private System.Windows.Forms.Button btnWithdrowal;
        private System.Windows.Forms.Button btnLodgement;
        private System.Windows.Forms.Button btnChangePIN;
        private System.Windows.Forms.Button btnExitMainMenu;
    }
}