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
    public class GamesDataAcessLayer
    {
        string connectionString;

        private readonly IConfiguration _configuration;

        public GamesDataAcessLayer(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public void Create(Games game)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "INSERT Into Games (GameTitle, Developer, Genre, ESRB, ReleaseDate, DateAdded) VALUES (@GameTitle, @Developer, @Genre, @ESRB, @ReleaseDate, @DateAdded);";
                game.Feedback = "";

                try
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@GameId", game.GameTitle);
                        command.Parameters.AddWithValue("@Developer", game.Developer);
                        command.Parameters.AddWithValue("@Genre", game.Genre);
                        command.Parameters.AddWithValue("@ESRB", game.ESRB);
                        command.Parameters.AddWithValue("@ReleaseDate", game.ReleaseDate);
                        command.Parameters.AddWithValue("@DateAdded", DateTime.Now);

                        connection.Open();

                        game.Feedback = command.ExecuteNonQuery().ToString() + " Record Added";

                        connection.Close();
                    }
                }
                catch (Exception err)
                {
                    game.Feedback = "Error: " + err.Message;
                }

            }
        }
    }
}
