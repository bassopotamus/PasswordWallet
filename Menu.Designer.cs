namespace PasswordGenerator
{
    partial class Menu
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
            this.btnCreatePass = new System.Windows.Forms.Button();
            this.btnViewPasswords = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreatePass
            // 
            this.btnCreatePass.Location = new System.Drawing.Point(12, 12);
            this.btnCreatePass.Name = "btnCreatePass";
            this.btnCreatePass.Size = new System.Drawing.Size(106, 39);
            this.btnCreatePass.TabIndex = 0;
            this.btnCreatePass.Text = "Create New Password";
            this.btnCreatePass.UseVisualStyleBackColor = true;
            this.btnCreatePass.Click += new System.EventHandler(this.btnCreatePass_Click);
            // 
            // btnViewPasswords
            // 
            this.btnViewPasswords.Location = new System.Drawing.Point(137, 12);
            this.btnViewPasswords.Name = "btnViewPasswords";
            this.btnViewPasswords.Size = new System.Drawing.Size(106, 39);
            this.btnViewPasswords.TabIndex = 1;
            this.btnViewPasswords.Text = "View Current Passwords";
            this.btnViewPasswords.UseVisualStyleBackColor = true;
            this.btnViewPasswords.Click += new System.EventHandler(this.btnViewPasswords_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(85, 69);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(80, 30);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 111);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnViewPasswords);
            this.Controls.Add(this.btnCreatePass);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreatePass;
        private System.Windows.Forms.Button btnViewPasswords;
        private System.Windows.Forms.Button btnLogout;
    }
}