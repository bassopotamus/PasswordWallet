namespace PasswordGenerator
{
    partial class CurrentPasswords
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cboChosenPass = new System.Windows.Forms.ComboBox();
            this.lblChoosePass = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblLoginEntry = new System.Windows.Forms.Label();
            this.lblPasswordEntry = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(15, 124);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(234, 20);
            this.txtPassword.TabIndex = 0;
            // 
            // cboChosenPass
            // 
            this.cboChosenPass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChosenPass.FormattingEnabled = true;
            this.cboChosenPass.Location = new System.Drawing.Point(128, 25);
            this.cboChosenPass.Name = "cboChosenPass";
            this.cboChosenPass.Size = new System.Drawing.Size(121, 21);
            this.cboChosenPass.TabIndex = 1;
            this.cboChosenPass.SelectedIndexChanged += new System.EventHandler(this.cboChosenPass_SelectedIndexChanged);
            // 
            // lblChoosePass
            // 
            this.lblChoosePass.AutoSize = true;
            this.lblChoosePass.Location = new System.Drawing.Point(12, 25);
            this.lblChoosePass.Name = "lblChoosePass";
            this.lblChoosePass.Size = new System.Drawing.Size(92, 13);
            this.lblChoosePass.TabIndex = 2;
            this.lblChoosePass.Text = "Choose Password";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(174, 166);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 3;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(15, 75);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(234, 20);
            this.txtLogin.TabIndex = 4;
            // 
            // lblLoginEntry
            // 
            this.lblLoginEntry.AutoSize = true;
            this.lblLoginEntry.Location = new System.Drawing.Point(15, 56);
            this.lblLoginEntry.Name = "lblLoginEntry";
            this.lblLoginEntry.Size = new System.Drawing.Size(36, 13);
            this.lblLoginEntry.TabIndex = 5;
            this.lblLoginEntry.Text = "Login:";
            // 
            // lblPasswordEntry
            // 
            this.lblPasswordEntry.AutoSize = true;
            this.lblPasswordEntry.Location = new System.Drawing.Point(15, 108);
            this.lblPasswordEntry.Name = "lblPasswordEntry";
            this.lblPasswordEntry.Size = new System.Drawing.Size(56, 13);
            this.lblPasswordEntry.TabIndex = 6;
            this.lblPasswordEntry.Text = "Password:";
            // 
            // CurrentPasswords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.lblPasswordEntry);
            this.Controls.Add(this.lblLoginEntry);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblChoosePass);
            this.Controls.Add(this.cboChosenPass);
            this.Controls.Add(this.txtPassword);
            this.Name = "CurrentPasswords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CurrentPasswords";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cboChosenPass;
        private System.Windows.Forms.Label lblChoosePass;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblLoginEntry;
        private System.Windows.Forms.Label lblPasswordEntry;
    }
}