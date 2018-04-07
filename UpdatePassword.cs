using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PasswordGenerator
{
    class UpdatePassword
    {
        private Boolean updateFlag = false;
        private int updatingUserID;
        
        public Boolean Update(String login, String newPassword)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Passwords.mdf;Integrated Security=True";

                connection.Open();

                SqlCommand sqlLookUp = new SqlCommand($"SELECT userid FROM dbo.Login WHERE username = @0", connection);
                sqlLookUp.Parameters.AddWithValue("0", login);
                SqlDataReader lookupReader = sqlLookUp.ExecuteReader();

                if (lookupReader.HasRows)
                {
                    while (lookupReader.Read())
                    {
                        IDataRecord currentRead = (IDataRecord)lookupReader;

                        updatingUserID = Convert.ToInt32(currentRead[0]);
                                                
                    }
                    lookupReader.Close();
                }
                else
                {
                    updateFlag = false;
                    return updateFlag;
                }

                SqlCommand sqlUpdate = new SqlCommand($"UPDATE dbo.Login SET password = (@0) WHERE userid = @1", connection);
                
                sqlUpdate.Parameters.AddWithValue("0", newPassword);
                sqlUpdate.Parameters.AddWithValue("1", updatingUserID);
                
                int executeReturnValue = sqlUpdate.ExecuteNonQuery();

                if (executeReturnValue == 1)
                {
                    updateFlag = true;
                    return updateFlag;
                }
                else
                {
                    updateFlag = false;
                    return updateFlag;
                }

            }
            
        }
    }
}
