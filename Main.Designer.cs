namespace LoginApp
{
    partial class MainPage
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
            this.ChangePassword = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.loginHistory = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loginHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // ChangePassword
            // 
            this.ChangePassword.Location = new System.Drawing.Point(228, 12);
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(114, 23);
            this.ChangePassword.TabIndex = 0;
            this.ChangePassword.Text = "Change Password";
            this.ChangePassword.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ChangePassword.UseVisualStyleBackColor = true;
            this.ChangePassword.Click += new System.EventHandler(this.ChangePassword_Click);
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(348, 12);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(75, 23);
            this.LogOut.TabIndex = 1;
            this.LogOut.Text = "Log out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // loginHistory
            // 
            this.loginHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loginHistory.Location = new System.Drawing.Point(12, 53);
            this.loginHistory.Name = "loginHistory";
            this.loginHistory.Size = new System.Drawing.Size(331, 267);
            this.loginHistory.TabIndex = 2;
            this.loginHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loginHistory_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login History";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 330);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginHistory);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.ChangePassword);
            this.Name = "MainPage";
            this.Text = "Main Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPage_FormClosing);
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangePassword;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.DataGridView loginHistory;
        private System.Windows.Forms.Label label1;
    }
}