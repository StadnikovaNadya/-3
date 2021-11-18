using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Моя_полка_книг_3
{
    class global

    {

        string StringConnection = "server=localhost; user id=root; password=12345;database=database_dk";


        public string CheckConnection()
        {
            string answer = string.Empty;
            using (MySqlConnection connection = new MySqlConnection(StringConnection))
            {

                connection.Open();

                string SQL = "SELECT * FROM database_bk.bооks;";

                MySqlCommand cmd = new MySqlCommand(SQL, connection);
                answer = cmd.ExecuteScalar().ToString();
            }

            return answer;
        }
    }
