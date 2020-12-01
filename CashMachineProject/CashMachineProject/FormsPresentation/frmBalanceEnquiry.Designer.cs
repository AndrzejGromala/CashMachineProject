namespace CashMachineProject.FormsPresentation
{
    partial class frmBalanceEnquiry
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBalanceINBalanceEnquiry = new System.Windows.Forms.TextBox();
            this.btnBackINBalanceEnquiry = new System.Windows.Forms.Button();
            this.btnExinINBalanceEnquiry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Balance";
            // 
            // txtBalanceINBalanceEnquiry
            // 
            this.txtBalanceINBalanceEnquiry.Enabled = false;
            this.txtBalanceINBalanceEnquiry.Location = new System.Drawing.Point(143, 46);
            this.txtBalanceINBalanceEnquiry.Name = "txtBalanceINBalanceEnquiry";
            this.txtBalanceINBalanceEnquiry.Size = new System.Drawing.Size(137, 20);
            this.txtBalanceINBalanceEnquiry.TabIndex = 1;
            this.txtBalanceINBalanceEnquiry.TextChanged += new System.EventHandler(this.txtBalanceINBalanceEnquiry_TextChanged);
            // 
            // btnBackINBalanceEnquiry
            // 
            this.btnBackINBalanceEnquiry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBackINBalanceEnquiry.Location = new System.Drawing.Point(35, 124);
            this.btnBackINBalanceEnquiry.Name = "btnBackINBalanceEnquiry";
            this.btnBackINBalanceEnquiry.Size = new System.Drawing.Size(75, 23);
            this.btnBackINBalanceEnquiry.TabIndex = 2;
            this.btnBackINBalanceEnquiry.Text = "<< Back";
            this.btnBackINBalanceEnquiry.UseVisualStyleBackColor = false;
            this.btnBackINBalanceEnquiry.Click += new System.EventHandler(this.btnBackINBalanceEnquiry_Click);
            // 
            // btnExinINBalanceEnquiry
            // 
            this.btnExinINBalanceEnquiry.BackColor = System.Drawing.Color.Red;
            this.btnExinINBalanceEnquiry.Location = new System.Drawing.Point(205, 124);
            this.btnExinINBalanceEnquiry.Name = "btnExinINBalanceEnquiry";
            this.btnExinINBalanceEnquiry.Size = new System.Drawing.Size(75, 23);
            this.btnExinINBalanceEnquiry.TabIndex = 3;
            this.btnExinINBalanceEnquiry.Text = "Exit";
            this.btnExinINBalanceEnquiry.UseVisualStyleBackColor = false;
            this.btnExinINBalanceEnquiry.Click += new System.EventHandler(this.btnExinINBalanceEnquiry_Click);
            // 
            // frmBalanceEnquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 227);
            this.Controls.Add(this.btnExinINBalanceEnquiry);
            this.Controls.Add(this.btnBackINBalanceEnquiry);
            this.Controls.Add(this.txtBalanceINBalanceEnquiry);
            this.Controls.Add(this.label1);
            this.Name = "frmBalanceEnquiry";
            this.Text = "frmBalanceEnquiry";
            this.Load += new System.EventHandler(this.frmBalanceEnquiry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBalanceINBalanceEnquiry;
        private System.Windows.Forms.Button btnBackINBalanceEnquiry;
        private System.Windows.Forms.Button btnExinINBalanceEnquiry;
    }
}