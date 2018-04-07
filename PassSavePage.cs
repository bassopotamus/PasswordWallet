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
    public partial class PassSavePage : Form
    {
        private string login;
        private string name;
        private string newPassword;
        private int ?currentUserID;

        public PassSavePage(String password)
        {
            InitializeComponent();
            txtNewPassword.Text = password;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form showPassGen = Application.OpenForms["PassGen"];
            showPassGen.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblNoLogin.Hide();
            lblNoName.Hide();

            if (txtLogin.Text != "" && txtPassName.Text != "")
            {
                login = txtLogin.Text;
                name = txtPassName.Text;
                savePass(login, name);
            }
            else
            {
                if (txtLogin.Text == "" && txtPassName.Text == "")
                {
                    lblNoLogin.Show();
                    lblNoName.Show();
                }
                else if (txtLogin.Text == "")
                {
                    lblNoLogin.Show();
                }
                else
                {
                    lblNoName.Show();
                }
            }
        }

        private void savePass(string newLogin, string newName)
        {
            newPassword = txtNewPassword.Text;
            string encryptedNewPassword;
            currentUserID = User.returnUser;


            EncryptionDecryptionServices encryptPassword = new EncryptionDecryptionServices();
            encryptedNewPassword = encryptPassword.Encrypt(newPassword);
            
            SaveNewPass savePassword = new SaveNewPass(newLogin, newName, encryptedNewPassword, currentUserID);
            int saveResult = savePassword.PasswordSaver();

            switch (saveResult)
            {
                case 0:
                    MessageBox.Show("Saved Successfully!");
                    break;
                case 1:
                    MessageBox.Show("Unable to connect to database.");
                    break;
                case 2:
                    MessageBox.Show("Save Unsuccessful.");
                    break;
            }
        }
    }
}
