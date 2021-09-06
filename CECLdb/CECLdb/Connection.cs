using MySql.Data.MySqlClient;
using System;

namespace CECLdb
{
    class Connection
    {
        public static MySqlConnection connection()
        {
            //Falta el connector
            string server = "localhost";//192.168.1.183
            //string port = "3306";
            string bd = "cecldb";
            string user = "URLuser";
            string password = "Algebra123";

            /*Port="+port+";*/
            string stringconnection = "Database= " + bd + ";Data Source= " + server +
                ";User Id= " + user + "; Password= " + password + "";

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
