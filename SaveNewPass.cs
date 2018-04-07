using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PasswordGenerator
{
    class SaveNewPass
    {
        private string newLogin;
        private string newName;
        private string newPassword;
        private int ?currentUserID;

        public SaveNewPass(string loginToSave, string nameToSave, string passwordToSave, int ?userIDToSave)
        {
            newLogin = loginToSave;
            newName = nameToSave;
            newPassword = passwordToSave;
            currentUserID = userIDToSave;
                        
        }

        public int PasswordSaver()
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Passwords.mdf;Integrated Security=True";

                try
                {
                    connection.Open();
                }
                catch
                {
                    return 1;

                }
                                           

                SqlCommand sqlCheck = new SqlCommand($"INSERT INTO dbo.Passwords(passwordentry, passwordname, login, userid) VALUES (@0, @1, @2, @3)", connection);
                //SqlCommand sqlCheck = new SqlCommand(sqlStatement, connection);

                sqlCheck.Parameters.AddWithValue("0", newPassword);
                sqlCheck.Parameters.AddWithValue("1", newName);
                sqlCheck.Parameters.AddWithValue("2", newLogin);
                sqlCheck.Parameters.AddWithValue("3", currentUserID);

                //sqlCheck.Connection.Open();
                int executeReturnValue = sqlCheck.ExecuteNonQuery();
                
                if (executeReturnValue == 1)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }

            }

        }
    }
}
