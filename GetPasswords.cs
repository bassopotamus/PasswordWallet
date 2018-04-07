using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PasswordGenerator
{
    class GetPasswords
    {
        int ?userID;

        public GetPasswords()
        {
            userID = User.returnUser;

        }

        public Dictionary<String, List<String>> returnPasswords()
        {
            SqlConnection connection;
            SqlDataReader dataReader;
            Dictionary<String, List<String>> passwordsList;

            using (connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dusti\source\repos\PasswordGenerator\PasswordGenerator\bin\Debug\Passwords.mdf;Integrated Security=True";
                try
                {
                    connection.Open();
                }
                catch
                {
                    String[] noDBConnection = new string[0];

                }

                SqlCommand sqlCheck = new SqlCommand($"SELECT * FROM dbo.Passwords WHERE userid = @0", connection);
                sqlCheck.Parameters.AddWithValue("0", userID);

                dataReader = sqlCheck.ExecuteReader();

                passwordsList = new Dictionary<String, List<String>>();

                while (dataReader.Read())
                {
                    string decryptedPassword;

                    EncryptionDecryptionServices decryptPassword = new EncryptionDecryptionServices();
                    decryptedPassword = decryptPassword.Decrypt(dataReader.GetString(0));

                    List<String> interiorList = new List<String>();

                    interiorList.Add(decryptedPassword);
                    interiorList.Add(dataReader.GetString(2));
                    

                    passwordsList.Add(dataReader.GetString(1), interiorList);  

                }

            }
            return passwordsList;
        }
    }
}
