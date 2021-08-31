using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CLEC
{
    class ConnectionSearchResult
    {
        public MySqlConnection connectionTable()
        {
            //Falta el connector
            string server = "Localhost";//10.200.111.20  172.19.50.81  192.168.100.135
            //string port = "3306";
            string bd = "cecldb";
            string user = "URLuser";
            string password = "Algebra123";

            //Port=" + port + ";
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
