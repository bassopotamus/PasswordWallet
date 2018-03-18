using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class ChangePassword : Form
    {
        private String login;
        private String password;
        private String encryptedPass;
        private Boolean updateComplete;

        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text != "" && txtPassword.Text != "" && txtPassword.Text.Length > 5)
            {
                login = txtLogin.Text;
                password = txtPassword.Text;
                encryption(login, password);
            }
            else
            {
                MessageBox.Show("Please enter a current login and password greater than 5 characters.", "Login/Password Error");
            }

        }

        private void encryption(string log, string pass)
        {
            EncryptionFunctions encryptPassword = new EncryptionFunctions();

            encryptedPass = encryptPassword.EncryptString(password);

            UpdatePassword saveNewPassword = new UpdatePassword();

            updateComplete = saveNewPassword.Update(login, encryptedPass);

            if (updateComplete)
            {
                MessageBox.Show("Password Updated!", "Success!");
                Form showLogin = Application.OpenForms["Login"];
                showLogin.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Password Not Updated.", "Failure.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form showLogin = Application.OpenForms["Login"];
            showLogin.Show();
            this.Close();
        }
    }
}
