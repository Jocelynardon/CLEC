using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CLEC
{
    class CtrlArea:ConnectionSearchResult
    {
        public List<Area> GetAreasQuery(string Filter, char Attribute)
        {
            MySqlDataReader reader;
            List<Area> list = new List<Area>();
            string sql = "SELECT IDarea, Año, Convocatoria, Nombre FROM area ";

            switch (Attribute)
            {
                case '0':
                    sql += "ORDER BY Nombre";
                    break;
                case 'i':
                    break;
                case 'a':
                    break;
                case 'c':
                    break;
                case 'n':
                    break;
                default:
                    break;
            }
            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Area area = new Area();
                    area.ID = int.Parse(reader[0].ToString());
                    area.Año = int.Parse(reader[1].ToString());
                    area.Convocatoria = int.Parse(reader[2].ToString());
                    area.Nombre = reader[2].ToString();
                    list.Add(area);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
            }
            return list;
        }
    }
}
