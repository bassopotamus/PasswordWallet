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
    public partial class PassGen : Form
    {
        private string newPassword;

        public PassGen()
        {
            InitializeComponent();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Form showMenu = Application.OpenForms["Menu"];
            showMenu.Show();
            this.Close();

        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            String passwordLength = txtLength.Text;
            int goodLength;

            txtPassword.Text = String.Empty;

            if(Int32.TryParse(passwordLength, out goodLength))
            {                
                lblNumberError.Visible = false;

                Boolean correctLength = checkLengthCorrect(goodLength);

                if (goodLength >= 5 && goodLength <= 20)
                {
                    createPassword(goodLength);
                }
                else
                {
                    lblNumberError.Visible = true;
                    txtLength.Text = String.Empty;
                }
            }
            else
            {
                lblNumberError.Visible = true;
                txtLength.Text = String.Empty;
            }
        }

        private bool checkLengthCorrect(int numberToCheck)
        {
            Boolean correctDecision;

            if (numberToCheck > 5 && numberToCheck < 20)
            {
                correctDecision = true;
            }
            else
            {
                correctDecision = false;
            }

            return correctDecision;
        }

        private void createPassword(int passwordLength)
        {
            int lngthPass = passwordLength;
            StringBuilder builtString = new StringBuilder();
            String[] arrayCharacters = new String[78];
            CreatePassword arrayCreation = new CreatePassword();

            arrayCharacters = arrayCreation.creatingArray();

            Random random = new Random();

            for (int i = 0; i < lngthPass; i++)
            {                
                int newRandom = random.Next(0, 77);

                builtString.Append(arrayCharacters[newRandom]);
                
            }

            newPassword = builtString.ToString();
            txtPassword.Text = newPassword;

        }

        private void btnSavePass_Click(object sender, EventArgs e)
        {
            PassSavePage savePage = new PassSavePage(newPassword);
            savePage.Show();
            this.Hide();

        }
    }
}
