using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PasswordGenerator
{
    public partial class Login : Form
    {
        private String user;
        private String pass;

        public Login()
        {
            InitializeComponent();
        }

        //Clear the text boxes.
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUserName.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Check the user name for entered text and either assign it if it is filled in
            //or generate a messagebox error.
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Please enter a login.", "Login Error");
            }
            else
            {                
                user = txtUserName.Text;
            }

            //Check the password for text.  If present, take the entered login and password
            //and instantiate the login executor class and run the ExecuteLogin method to
            //finish the login process or generate an error message.
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter a password.", "Password Error");
            }
            else
            {                
                pass = txtPassword.Text;

                LoginExecution executor = new LoginExecution(user, pass);

                Boolean loginOK = executor.ExecuteLogin();

                if (loginOK)
                {
                    Menu newMenu = new Menu();
                    newMenu.Show();
                    txtPassword.Text = "";
                    txtUserName.Text = "";
                    this.Hide();
                }
                else
                {
                    lblIncorrectLogin.Visible = true;
                    txtPassword.Text = "";
                    txtUserName.Text = "";
                }

            }

                       
        }

        //Instantiate the Change Password form, open it, and hide this form.
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword changeCurrentPassword = new ChangePassword();
            changeCurrentPassword.Show();
            this.Hide();

        }

        //Close the application.
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
