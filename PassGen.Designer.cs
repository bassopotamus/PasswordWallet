namespace PasswordGenerator
{
    partial class PassGen
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
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.lblNumberError = new System.Windows.Forms.Label();
            this.btnSavePass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLength
            // 
            this.txtLength.BackColor = System.Drawing.Color.White;
            this.txtLength.Location = new System.Drawing.Point(168, 6);
            this.txtLength.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(52, 20);
            this.txtLength.TabIndex = 0;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(12, 9);
            this.lblLength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(150, 13);
            this.lblLength.TabIndex = 1;
            this.lblLength.Text = "Character Length of Password";
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Location = new System.Drawing.Point(98, 44);
            this.btnGeneratePassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(74, 36);
            this.btnGeneratePassword.TabIndex = 1;
            this.btnGeneratePassword.Text = "Generate Password";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(11, 125);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(257, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(11, 92);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(194, 166);
            this.btnDone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(74, 23);
            this.btnDone.TabIndex = 3;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblNumberError
            // 
            this.lblNumberError.AutoSize = true;
            this.lblNumberError.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberError.ForeColor = System.Drawing.Color.Red;
            this.lblNumberError.Location = new System.Drawing.Point(69, 29);
            this.lblNumberError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberError.Name = "lblNumberError";
            this.lblNumberError.Size = new System.Drawing.Size(200, 12);
            this.lblNumberError.TabIndex = 5;
            this.lblNumberError.Text = "Please enter a numeric value between 5 and 20.";
            this.lblNumberError.Visible = false;
            // 
            // btnSavePass
            // 
            this.btnSavePass.Location = new System.Drawing.Point(14, 165);
            this.btnSavePass.Name = "btnSavePass";
            this.btnSavePass.Size = new System.Drawing.Size(119, 23);
            this.btnSavePass.TabIndex = 6;
            this.btnSavePass.Text = "Save Password?";
            this.btnSavePass.UseVisualStyleBackColor = true;
            this.btnSavePass.Click += new System.EventHandler(this.btnSavePass_Click);
            // 
            // PassGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.btnSavePass);
            this.Controls.Add(this.lblNumberError);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnGeneratePassword);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtLength);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "PassGen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lblNumberError;
        private System.Windows.Forms.Button btnSavePass;
    }
}

