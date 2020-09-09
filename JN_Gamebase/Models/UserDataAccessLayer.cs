using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using JN_Gamebase.Models;
using Microsoft.Extensions.Configuration;
using JN_Gamebase.App_Code;

namespace JN_Gamebase.Models
{
    public class UserDataAccessLayer
    {
        string connectionString;

        private readonly IConfiguration _configuration;

        public UserDataAccessLayer(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public void Create(User users)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "INSERT Into Users (Email, Username, Password) VALUES (@Email, @Username, @Password);";
                users.Feedback = "";

                try
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@GameId", users.Email);
                        command.Parameters.AddWithValue("@Developer", users.Username);
                        command.Parameters.AddWithValue("@Genre", users.Password);

                        connection.Open();

                        users.Feedback = command.ExecuteNonQuery().ToString() + " Record Added";

                        connection.Close();
                    }
                }
                catch (Exception err)
                {
                    users.Feedback = "Error: " + err.Message;
                }

            }
        }
    }
}
