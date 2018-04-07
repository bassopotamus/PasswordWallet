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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCreatePass_Click(object sender, EventArgs e)
        {
            PassGen newPassGen = new PassGen();
            newPassGen.Show();
            this.Hide();
        }

        private void btnViewPasswords_Click(object sender, EventArgs e)
        {
            CurrentPasswords newCurrentPass = new CurrentPasswords();
            newCurrentPass.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            User.returnUser = null;
            Form showMenu = Application.OpenForms["Login"];
            this.Close();
            showMenu.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
