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
    public partial class CurrentPasswords : Form
    {
        Dictionary<String, List<String>> passwordsDictionary;

        public CurrentPasswords()
        {
            InitializeComponent();

            GetPasswords passGetter = new GetPasswords();

            passwordsDictionary = passGetter.returnPasswords();

            foreach (KeyValuePair<string, List<string>> pair in passwordsDictionary)
            {
                cboChosenPass.Items.Add(pair.Key);
            }

        }

        private void cboChosenPass_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPassword.Text = passwordsDictionary[cboChosenPass.Text][0];
            txtLogin.Text = passwordsDictionary[cboChosenPass.Text][1];

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Form showMenu = Application.OpenForms["Menu"];
            showMenu.Show();
            this.Close();
        }
    }
}
