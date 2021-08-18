using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CLEC
{
    class CtrlRegister:ConnectionSearchResult
    {
        public List<Object> listSelected = new List<Object>();
        public List<Object> consultationArea(string data)
        {
            MySqlDataReader reader;
            List<Object> list = new List<object>();
            string sql;

            if (data == null)
            {
                sql = "SELECT Area.IDarea,CONCAT(Area.Nombre,', ',Area.Año,', ',Area.Convocatoria),Curso.IDcurso,Curso.Nombre ,persona.IDpersona," +
                    "CONCAT(Persona.Nombre,', ',Persona.Apellido)," +
                    "FechaConsulta " +
                    "FROM registro AS Reg INNER JOIN Area ON Area.IDarea=Reg.IDarea INNER JOIN Curso ON Curso.IDcurso=Reg.IDcurso " +
                    "INNER JOIN persona ON persona.IDpersona=Reg.IDpersona ORDER BY FechaConsulta DESC";
            }
            else
            {
                sql = "SELECT Area.IDarea,CONCAT(Area.Nombre,', ',Area.Año,', ',Area.Convocatoria),Curso.IDcurso,Curso.Nombre ,persona.IDpersona," +
                   "CONCAT(Persona.Nombre,', ',Persona.Apellido) AS NombreCom," +
                   "FechaConsulta " +
                   "FROM registro AS Reg INNER JOIN Area ON Area.IDarea=Reg.IDarea INNER JOIN Curso ON Curso.IDcurso=Reg.IDcurso " +
                   "INNER JOIN persona ON persona.IDpersona=Reg.IDpersona WHERE Area.Nombre LIKE '%" + data + "%' OR Area.Año LIKE '%" + data + "%' OR " +
                   "Area.Convocatoria LIKE '%" + data + "%' ORDER BY FechaConsulta DESC";
            }
            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Register register = new Register();

                    register.idArea = int.Parse(reader[0].ToString());
                    register.Area = reader[1].ToString();
                    register.IDcurso = int.Parse(reader[2].ToString());
                    register.Curso = reader[3].ToString();
                    register.IDpersona = int.Parse(reader[4].ToString());
                    register.Nombre = reader[5].ToString();
                    register.FechaConsulta = Convert.ToDateTime(reader[6].ToString());
                    list.Add(register);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
            }
            return list;
        }
        public List<Object> consultationCourse(string data)
        {
            MySqlDataReader reader;
            List<Object> list = new List<object>();
            string sql;

            if (data == null)
            {
                sql = "SELECT Area.IDarea,CONCAT(Area.Nombre,', ',Area.Año,', ',Area.Convocatoria),Curso.IDcurso,Curso.Nombre ,persona.IDpersona," +
                    "CONCAT(Persona.Nombre,', ',Persona.Apellido)," +
                    "FechaConsulta " +
                    "FROM registro AS Reg INNER JOIN Area ON Area.IDarea=Reg.IDarea INNER JOIN Curso ON Curso.IDcurso=Reg.IDcurso " +
                    "INNER JOIN persona ON persona.IDpersona=Reg.IDpersona ORDER BY FechaConsulta DESC";
            }
            else
            {
                sql = "SELECT Area.IDarea,CONCAT(Area.Nombre,', ',Area.Año,', ',Area.Convocatoria),Curso.IDcurso,Curso.Nombre ,persona.IDpersona," +
                   "CONCAT(Persona.Nombre,', ',Persona.Apellido) AS NombreCom," +
                   "FechaConsulta " +
                   "FROM registro AS Reg INNER JOIN Area ON Area.IDarea=Reg.IDarea INNER JOIN Curso ON Curso.IDcurso=Reg.IDcurso " +
                   "INNER JOIN persona ON persona.IDpersona=Reg.IDpersona WHERE Curso.Nombre LIKE '%" + data + "%' ORDER BY FechaConsulta DESC";
            }
            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Register register = new Register();

                    register.idArea = int.Parse(reader[0].ToString());
                    register.Area = reader[1].ToString();
                    register.IDcurso = int.Parse(reader[2].ToString());
                    register.Curso = reader[3].ToString();
                    register.IDpersona = int.Parse(reader[4].ToString());
                    register.Nombre = reader[5].ToString();
                    register.FechaConsulta = Convert.ToDateTime(reader[6].ToString());
                    list.Add(register);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
            }
            return list;
        }
        public List<Object> consultationPerson(string data)
        {
            MySqlDataReader reader;
            List<Object> list = new List<object>();
            string sql;

            if (data == null)
            {
                sql = "SELECT Area.IDarea,CONCAT(Area.Nombre,', ',Area.Año,', ',Area.Convocatoria),Curso.IDcurso,Curso.Nombre ,persona.IDpersona," +
                    "CONCAT(Persona.Nombre,', ',Persona.Apellido)," +
                    "FechaConsulta " +
                    "FROM registro AS Reg INNER JOIN Area ON Area.IDarea=Reg.IDarea INNER JOIN Curso ON Curso.IDcurso=Reg.IDcurso " +
                    "INNER JOIN persona ON persona.IDpersona=Reg.IDpersona ORDER BY FechaConsulta DESC";
            }
            else
            {
                sql = "SELECT Area.IDarea,CONCAT(Area.Nombre,', ',Area.Año,', ',Area.Convocatoria),Curso.IDcurso,Curso.Nombre ,persona.IDpersona," +
                   "CONCAT(Persona.Nombre,', ',Persona.Apellido) AS NombreCom," +
                   "FechaConsulta " +
                   "FROM registro AS Reg INNER JOIN Area ON Area.IDarea=Reg.IDarea INNER JOIN Curso ON Curso.IDcurso=Reg.IDcurso " +
                   "INNER JOIN persona ON persona.IDpersona=Reg.IDpersona WHERE Persona.Nombre LIKE '%" + data + "%' OR " +
                   "Persona.Apellido LIKE '%" + data + "%' ORDER BY FechaConsulta DESC";
            }
            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Register register = new Register();

                    register.idArea = int.Parse(reader[0].ToString());
                    register.Area = reader[1].ToString();
                    register.IDcurso = int.Parse(reader[2].ToString());
                    register.Curso = reader[3].ToString();
                    register.IDpersona = int.Parse(reader[4].ToString());
                    register.Nombre = reader[5].ToString();
                    register.FechaConsulta = Convert.ToDateTime(reader[6].ToString());
                    list.Add(register);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
            }
            return list;
        }
        public List<Object> consultationMonthYear(string data)
        {
            MySqlDataReader reader;
            List<Object> list = new List<object>();
            string sql;

            if (data == null)
            {
                sql = "SELECT Area.IDarea,CONCAT(Area.Nombre,', ',Area.Año,', ',Area.Convocatoria),Curso.IDcurso,Curso.Nombre ,persona.IDpersona," +
                    "CONCAT(Persona.Nombre,', ',Persona.Apellido)," +
                    "FechaConsulta " +
                    "FROM registro AS Reg INNER JOIN Area ON Area.IDarea=Reg.IDarea INNER JOIN Curso ON Curso.IDcurso=Reg.IDcurso " +
                    "INNER JOIN persona ON persona.IDpersona=Reg.IDpersona ORDER BY FechaConsulta DESC";
            }
            else
            {
                sql = "SELECT Area.IDarea,CONCAT(Area.Nombre,', ',Area.Año,', ',Area.Convocatoria),Curso.IDcurso,Curso.Nombre ,persona.IDpersona," +
                   "CONCAT(Persona.Nombre,', ',Persona.Apellido) AS NombreCom," +
                   "FechaConsulta " +
                   "FROM registro AS Reg INNER JOIN Area ON Area.IDarea=Reg.IDarea INNER JOIN Curso ON Curso.IDcurso=Reg.IDcurso " +
                   "INNER JOIN persona ON persona.IDpersona=Reg.IDpersona WHERE YEAR(FechaConsulta) = YEAR(CURRENT_DATE()) AND MONTH(FechaConsulta) ='" + data + "' ORDER BY FechaConsulta DESC";
            }
            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Register register = new Register();

                    register.idArea = int.Parse(reader[0].ToString());
                    register.Area = reader[1].ToString();
                    register.IDcurso = int.Parse(reader[2].ToString());
                    register.Curso = reader[3].ToString();
                    register.IDpersona = int.Parse(reader[4].ToString());
                    register.Nombre = reader[5].ToString();
                    register.FechaConsulta = Convert.ToDateTime(reader[6].ToString());
                    list.Add(register);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
            }
            return list;
        }
        public void SelectedEmailSent(string InsSelected)
        {
            string[] array = InsSelected.ToString().Split(',');
            int idArea = int.Parse(array[0]);
            int idCurso = int.Parse(array[1]);
            int idPersona = int.Parse(array[2]);
            MySqlDataReader reader;
            string sql;

            sql = "SELECT Area.IDarea,CONCAT(Area.Nombre,', ',Area.Año,', ',Area.Convocatoria),Curso.IDcurso,Curso.Nombre ,persona.IDpersona," +
                   "CONCAT(Persona.Nombre,', ',Persona.Apellido) AS NombreCom," +
                   "FechaConsulta " +
                   "FROM registro AS Reg INNER JOIN Area ON Area.IDarea=Reg.IDarea INNER JOIN Curso ON Curso.IDcurso=Reg.IDcurso " +
                   "INNER JOIN persona ON persona.IDpersona=Reg.IDpersona WHERE Area.IDarea LIKE '%" + idArea + "%' AND " +
                   "Curso.IDcurso LIKE '%" + idCurso + "%' AND persona.IDpersona LIKE '%" + idPersona + "%' ORDER BY FechaConsulta DESC";

            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Register register = new Register();

                    register.idArea = int.Parse(reader[0].ToString());
                    register.Area = reader[1].ToString();
                    register.IDcurso = int.Parse(reader[2].ToString());
                    register.Curso = reader[3].ToString();
                    register.IDpersona = int.Parse(reader[4].ToString());
                    register.Nombre = reader[5].ToString();
                    register.FechaConsulta = Convert.ToDateTime(reader[6].ToString());
                    listSelected.Add(register);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
            }
        }
    }
}
