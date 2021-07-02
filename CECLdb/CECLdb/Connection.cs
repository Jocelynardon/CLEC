using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CECLdb
{
    class Connection
    {
        public static MySqlConnection connection()
        {
            //Falta el connector
            string server = "localhost";
            string bd = "cecldb";
            string user = "URLuser";
            string password = "Algebra123";

            string stringconnection = "Database= " + bd + ";Data Source= " + server + 
                ";User Id= " + user + "; Password= " + password +"";

            try
            {
                MySqlConnection connectionBD = new MySqlConnection(stringconnection);

                return connectionBD;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}
