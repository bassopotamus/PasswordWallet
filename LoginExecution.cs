using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PasswordGenerator
{
    class LoginExecution
    {
        private string currentUser;
        private string currentPass;
        private string hashedPass;


        public LoginExecution(String user, String pass)
        {
            currentUser = user;
            currentPass = pass;

        }

        //Take the passed-in password and call the EncryptionFunctions class to hash it so it can be
        //compared to the saved, hashed password.  Open the database connection, check the username
        //and password against the database information.  If it does, pass back true.  If not, pass back false.
        public Boolean ExecuteLogin()
        {
            Boolean loginSuccessful = false;

            Hashing forPassHash = new Hashing();

            hashedPass = forPassHash.EncryptString(currentPass);

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Passwords.mdf;Integrated Security=True";
                connection.Open();

                SqlCommand sqlCheck = new SqlCommand($"SELECT * FROM dbo.Login WHERE username = @0", connection);
                sqlCheck.Parameters.AddWithValue("0", currentUser);

                using (SqlDataReader dataReader = sqlCheck.ExecuteReader())
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            IDataRecord currentRead = (IDataRecord)dataReader;

                            var checkUserName = currentRead[0];
                            var checkPassword = currentRead[1];

                            if (currentUser == (string)checkUserName && hashedPass == (string)checkPassword)
                            {
                                loginSuccessful = true;
                                User.returnUser = Convert.ToInt32(currentRead[2]);
                                
                            }
                            else
                            {
                                loginSuccessful = false;
                            }

                        }
                    }
                    else
                    {
                        loginSuccessful = false;
                    }

                    return loginSuccessful;
                }
            }
                    
        }

    }
}
