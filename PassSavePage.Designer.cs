namespace PasswordGenerator
{
    partial class PassSavePage
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPassName = new System.Windows.Forms.TextBox();
            this.lblPassName = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblNoLogin = new System.Windows.Forms.Label();
            this.lblNoName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(31, 136);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(169, 136);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPassName
            // 
            this.txtPassName.BackColor = System.Drawing.Color.White;
            this.txtPassName.Location = new System.Drawing.Point(114, 62);
            this.txtPassName.Name = "txtPassName";
            this.txtPassName.Size = new System.Drawing.Size(140, 20);
            this.txtPassName.TabIndex = 1;
            // 
            // lblPassName
            // 
            this.lblPassName.AutoSize = true;
            this.lblPassName.Location = new System.Drawing.Point(10, 62);
            this.lblPassName.Name = "lblPassName";
            this.lblPassName.Size = new System.Drawing.Size(96, 13);
            this.lblPassName.TabIndex = 3;
            this.lblPassName.Text = "Name of Password";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(10, 23);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "Login";
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.White;
            this.txtLogin.Location = new System.Drawing.Point(114, 23);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(140, 20);
            this.txtLogin.TabIndex = 0;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(10, 100);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(53, 13);
            this.lblNewPassword.TabIndex = 6;
            this.lblNewPassword.Text = "Password";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(114, 100);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.ReadOnly = true;
            this.txtNewPassword.Size = new System.Drawing.Size(140, 20);
            this.txtNewPassword.TabIndex = 7;
            this.txtNewPassword.TabStop = false;
            // 
            // lblNoLogin
            // 
            this.lblNoLogin.AutoSize = true;
            this.lblNoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoLogin.ForeColor = System.Drawing.Color.Red;
            this.lblNoLogin.Location = new System.Drawing.Point(104, 46);
            this.lblNoLogin.Name = "lblNoLogin";
            this.lblNoLogin.Size = new System.Drawing.Size(87, 12);
            this.lblNoLogin.TabIndex = 8;
            this.lblNoLogin.Text = "Please enter a login.";
            this.lblNoLogin.Visible = false;
            // 
            // lblNoName
            // 
            this.lblNoName.AutoSize = true;
            this.lblNoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoName.ForeColor = System.Drawing.Color.Red;
            this.lblNoName.Location = new System.Drawing.Point(104, 85);
            this.lblNoName.Name = "lblNoName";
            this.lblNoName.Size = new System.Drawing.Size(162, 12);
            this.lblNoName.TabIndex = 9;
            this.lblNoName.Text = "Please enter a name for the password.";
            this.lblNoName.Visible = false;
            // 
            // PassSavePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 171);
            this.Controls.Add(this.lblNoName);
            this.Controls.Add(this.lblNoLogin);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblPassName);
            this.Controls.Add(this.txtPassName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "PassSavePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Save Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPassName;
        private System.Windows.Forms.Label lblPassName;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblNoLogin;
        private System.Windows.Forms.Label lblNoName;
    }
}