using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CLEC
{
    class CtrlArea:ConnectionSearchResult
    {
        public List<Object> listSelected = new List<Object>();
        public List<Object> consultationYear(string data)
        {
            MySqlDataReader reader;
            List<Object> list = new List<object>();
            string sql;

            if (data == null)
            {
                sql = "SELECT IDarea,Nombre,Año,Convocatoria " +
                    "FROM area ORDER BY Año DESC, Nombre ASC";
            }
            else
            {
                sql = "SELECT IDarea,Nombre,Año,Convocatoria " +
                    "FROM area WHERE Año LIKE '%" + data + "%' ORDER BY Año DESC, Nombre ASC";
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
                    area.IDarea = int.Parse(reader[0].ToString());
                    area.Nombre = reader[1].ToString();
                    area.Año =int.Parse(reader[2].ToString());
                    area.Convocatoria = int.Parse(reader[3].ToString());
                    list.Add(area);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
            }
            return list;
        }
        public List<Object> consultationConvocatory(string data)
        {
            MySqlDataReader reader;
            List<Object> list = new List<object>();
            string sql;

            if (data == null)
            {
                sql = "SELECT IDarea,Nombre,Año,Convocatoria " +
                    "FROM area ORDER BY Año DESC,Nombre ASC";
            }
            else
            {
                sql = "SELECT IDarea,Nombre,Año,Convocatoria " +
                    "FROM area WHERE Convocatoria LIKE '%" + data + "%' ORDER BY Año DESC,Nombre ASC";
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
                    area.IDarea = int.Parse(reader[0].ToString());
                    area.Nombre = reader[1].ToString();
                    area.Año = int.Parse(reader[2].ToString());
                    area.Convocatoria = int.Parse(reader[3].ToString());
                    list.Add(area);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
            }
            return list;
        }
        public List<Object> consultationName(string data)
        {
            MySqlDataReader reader;
            List<Object> list = new List<object>();
            string sql;

            if (data == null)
            {
                sql = "SELECT IDarea,Nombre,Año,Convocatoria " +
                    "FROM area ORDER BY Año DESC,Nombre ASC";
            }
            else
            {
                sql = "SELECT IDarea,Nombre,Año,Convocatoria " +
                    "FROM area WHERE Nombre LIKE '%" + data + "%' ORDER BY Año DESC,Nombre ASC";
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
                    area.IDarea = int.Parse(reader[0].ToString());
                    area.Nombre = reader[1].ToString();
                    area.Año = int.Parse(reader[2].ToString());
                    area.Convocatoria = int.Parse(reader[3].ToString());
                    list.Add(area);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
            }
            return list;
        }
        public void Selected(int data)
        {
            MySqlDataReader reader;
            List<Object> list = new List<object>();
            string sql;

                sql = "SELECT IDarea,Nombre,Año,Convocatoria " +
                    "FROM area WHERE IDarea LIKE '%" + data + "%' ORDER BY Año DESC,Nombre ASC";
            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Area area = new Area();
                    area.IDarea = int.Parse(reader[0].ToString());
                    area.Nombre = reader[1].ToString();
                    area.Año = int.Parse(reader[2].ToString());
                    area.Convocatoria = int.Parse(reader[3].ToString());
                    listSelected.Add(area);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
            }
        }

        public List<Area> GetAreasQuery(string Filter, char Attribute)
        {
            MySqlDataReader reader;
            List<Area> list = new List<Area>();
            string sql = "SELECT IDarea, Año, Convocatoria, Nombre FROM area ";

            switch (Attribute)
            {
                case '0':
                    sql += "ORDER BY Nombre,Año DESC";
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
                    area.IDarea = int.Parse(reader[0].ToString());
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
        public Area ModifyQuery(string IDarea)/********************************************************/
        {
            MySqlDataReader reader;

            string sql;
            Area area = new Area();
            sql = "SELECT Nombre, Año, Convocatoria FROM area WHERE IDarea =" + IDarea;

            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    area.Nombre = reader[0].ToString();
                    area.Año = int.Parse(reader[1].ToString());
                    area.Convocatoria = int.Parse(reader[2].ToString());
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
            }
            return area;
        }

        public bool IsDuplicated(string Name, int Year, int Convocatory)
        {
            int result = 0;
            string sql = "SELECT COUNT(1) FROM Area WHERE Nombre = '" + Name + "' AND Año = '" + Year + "' AND Convocatoria = '" + Convocatory + "'";
            MySqlDataReader reader;
            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result = int.Parse(reader[0].ToString());
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
            }
            if (result > 0) return true;
            else return false;
        }
    }
}
