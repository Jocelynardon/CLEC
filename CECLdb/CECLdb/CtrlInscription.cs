using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CLEC
{
    class CtrlInscription:ConnectionSearchResult
    {
        public List<Object> listSelected = new List<Object>();
        public List<Object> consultationArea(string data)
        {
            MySqlDataReader reader;
            List<Object> list = new List<object>();
            string sql;

            if (data == null)
            {
                sql = "SELECT Area.IDarea,Area.Nombre,Curso.IDcurso,Curso.Nombre ,persona.IDpersona," +
                    "CONCAT(Persona.Nombre,', ',Persona.Apellido)," +
                    "FechaInicio,IFNULL(FechaFin,'---') AS FechaFin," +
                    "CASE WHEN Aprobo=1 THEN 'SI' Else 'NO' END AS Aprobado " +
                    "FROM inscripcion AS Ins INNER JOIN Area ON Area.IDarea=Ins.IDarea INNER JOIN Curso ON Curso.IDcurso=Ins.IDcurso " +
                    "INNER JOIN persona ON persona.IDpersona=Ins.IDpersona ORDER BY FechaInicio DESC";
            }
            else
            {
                sql = "SELECT Area.IDarea,Area.Nombre,Curso.IDcurso,Curso.Nombre ,persona.IDpersona," +
                   "CONCAT(Persona.Nombre,', ',Persona.Apellido) AS NombreCom," +
                   "FechaInicio,IFNULL(FechaFin,'---') AS FechaFin," +
                   "CASE WHEN Aprobo=1 THEN 'SI' Else 'NO' END AS Aprobado " +
                   "FROM inscripcion AS Ins INNER JOIN Area ON Area.IDarea=Ins.IDarea INNER JOIN Curso ON Curso.IDcurso=Ins.IDcurso " +
                   "INNER JOIN persona ON persona.IDpersona=Ins.IDpersona WHERE Area.Nombre LIKE '%" + data + "%' ORDER BY FechaInicio DESC";
            }
            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Inscription inscription = new Inscription();
                    
                    inscription.idArea = int.Parse(reader[0].ToString());
                    inscription.Area = reader[1].ToString();
                    inscription.IDcurso = int.Parse(reader[2].ToString());
                    inscription.Curso = reader[3].ToString();
                    inscription.IDpersona = int.Parse(reader[4].ToString());
                    inscription.Nombre = reader[5].ToString();
                    inscription.FechaInicio = reader[6].ToString();
                    inscription.FechaFin = reader.GetString(7);
                    inscription.Aprobado = reader[8].ToString();
                    list.Add(inscription);
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
                sql = "SELECT Area.IDarea,Area.Nombre,Curso.IDcurso,Curso.Nombre ,persona.IDpersona," +
                    "CONCAT(Persona.Nombre,', ',Persona.Apellido)," +
                    "FechaInicio,IFNULL(FechaFin,'---') AS FechaFin," +
                    "CASE WHEN Aprobo=1 THEN 'SI' Else 'NO' END AS Aprobado " +
                    "FROM inscripcion AS Ins INNER JOIN Area ON Area.IDarea=Ins.IDarea INNER JOIN Curso ON Curso.IDcurso=Ins.IDcurso " +
                    "INNER JOIN persona ON persona.IDpersona=Ins.IDpersona ORDER BY FechaInicio DESC";
            }
            else
            {
                sql = "SELECT Area.IDarea,Area.Nombre,Curso.IDcurso,Curso.Nombre ,persona.IDpersona," +
                   "CONCAT(Persona.Nombre,', ',Persona.Apellido) AS NombreCom," +
                   "FechaInicio,IFNULL(FechaFin,'---') AS FechaFin," +
                   "CASE WHEN Aprobo=1 THEN 'SI' Else 'NO' END AS Aprobado " +
                   "FROM inscripcion AS Ins INNER JOIN Area ON Area.IDarea=Ins.IDarea INNER JOIN Curso ON Curso.IDcurso=Ins.IDcurso " +
                   "INNER JOIN persona ON persona.IDpersona=Ins.IDpersona WHERE Curso.Nombre LIKE '%" + data + "%' ORDER BY FechaInicio DESC";
            }
            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Inscription inscription = new Inscription();

                    inscription.idArea = int.Parse(reader[0].ToString());
                    inscription.Area = reader[1].ToString();
                    inscription.IDcurso = int.Parse(reader[2].ToString());
                    inscription.Curso = reader[3].ToString();
                    inscription.IDpersona = int.Parse(reader[4].ToString());
                    inscription.Nombre = reader[5].ToString();
                    inscription.FechaInicio = reader[6].ToString();
                    inscription.FechaFin = reader.GetString(7);
                    inscription.Aprobado = reader[8].ToString();
                    list.Add(inscription);
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
                sql = "SELECT Area.IDarea,Area.Nombre,Curso.IDcurso,Curso.Nombre ,persona.IDpersona," +
                    "CONCAT(Persona.Nombre,', ',Persona.Apellido)," +
                    "FechaInicio,IFNULL(FechaFin,'---') AS FechaFin," +
                    "CASE WHEN Aprobo=1 THEN 'SI' Else 'NO' END AS Aprobado " +
                    "FROM inscripcion AS Ins INNER JOIN Area ON Area.IDarea=Ins.IDarea INNER JOIN Curso ON Curso.IDcurso=Ins.IDcurso " +
                    "INNER JOIN persona ON persona.IDpersona=Ins.IDpersona ORDER BY FechaInicio DESC";
            }
            else
            {
                sql = "SELECT Area.IDarea,Area.Nombre,Curso.IDcurso,Curso.Nombre ,persona.IDpersona," +
                   "CONCAT(Persona.Nombre,', ',Persona.Apellido) AS NombreCom," +
                   "FechaInicio,IFNULL(FechaFin,'---') AS FechaFin," +
                   "CASE WHEN Aprobo=1 THEN 'SI' Else 'NO' END AS Aprobado " +
                   "FROM inscripcion AS Ins INNER JOIN Area ON Area.IDarea=Ins.IDarea INNER JOIN Curso ON Curso.IDcurso=Ins.IDcurso " +
                   "INNER JOIN persona ON persona.IDpersona=Ins.IDpersona WHERE Persona.Nombre LIKE '%" + data + "%' OR " +
                   "Persona.Apellido LIKE '%" + data + "%' ORDER BY FechaInicio DESC";
            }
            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Inscription inscription = new Inscription();

                    inscription.idArea = int.Parse(reader[0].ToString());
                    inscription.Area = reader[1].ToString();
                    inscription.IDcurso = int.Parse(reader[2].ToString());
                    inscription.Curso = reader[3].ToString();
                    inscription.IDpersona = int.Parse(reader[4].ToString());
                    inscription.Nombre = reader[5].ToString();
                    inscription.FechaInicio = reader[6].ToString();
                    inscription.FechaFin = reader.GetString(7);
                    inscription.Aprobado = reader[8].ToString();
                    list.Add(inscription);
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
                sql = "SELECT Area.IDarea,Area.Nombre,Curso.IDcurso,Curso.Nombre ,persona.IDpersona," +
                    "CONCAT(Persona.Nombre,', ',Persona.Apellido)," +
                    "FechaInicio,IFNULL(FechaFin,'---') AS FechaFin," +
                    "CASE WHEN Aprobo=1 THEN 'SI' Else 'NO' END AS Aprobado " +
                    "FROM inscripcion AS Ins INNER JOIN Area ON Area.IDarea=Ins.IDarea INNER JOIN Curso ON Curso.IDcurso=Ins.IDcurso " +
                    "INNER JOIN persona ON persona.IDpersona=Ins.IDpersona ORDER BY FechaInicio DESC";
            }
            else
            {
                sql = "SELECT Area.IDarea,Area.Nombre,Curso.IDcurso,Curso.Nombre ,persona.IDpersona," +
                   "CONCAT(Persona.Nombre,', ',Persona.Apellido) AS NombreCom," +
                   "FechaInicio,IFNULL(FechaFin,'---') AS FechaFin," +
                   "CASE WHEN Aprobo=1 THEN 'SI' Else 'NO' END AS Aprobado " +
                   "FROM inscripcion AS Ins INNER JOIN Area ON Area.IDarea=Ins.IDarea INNER JOIN Curso ON Curso.IDcurso=Ins.IDcurso " +
                   "INNER JOIN persona ON persona.IDpersona=Ins.IDpersona WHERE YEAR(FechaInicio) = YEAR(CURRENT_DATE()) AND MONTH(FechaInicio) ='"+data+"' ORDER BY FechaInicio DESC";
            }
            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Inscription inscription = new Inscription();

                    inscription.idArea = int.Parse(reader[0].ToString());
                    inscription.Area = reader[1].ToString();
                    inscription.IDcurso = int.Parse(reader[2].ToString());
                    inscription.Curso = reader[3].ToString();
                    inscription.IDpersona = int.Parse(reader[4].ToString());
                    inscription.Nombre = reader[5].ToString();
                    inscription.FechaInicio = reader[6].ToString();
                    inscription.FechaFin = reader.GetString(7);
                    inscription.Aprobado = reader[8].ToString();
                    list.Add(inscription);
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
