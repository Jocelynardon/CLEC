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

            if (data == null || data == "")
            {
                sql = "SELECT Area.IDarea,CONCAT(Area.Nombre,', ',Area.Año,', ',Area.Convocatoria),Curso.IDcurso,Curso.Nombre ,persona.IDpersona," +
                    "CONCAT(Persona.Nombre,', ',Persona.Apellido)," +
                    "FechaInicio,IFNULL(FechaFin,'---') AS FechaFin," +
                    "CASE WHEN Aprobo=1 THEN 'SI' Else 'NO' END AS Aprobado, Ins.Codigo " +
                    "FROM inscripcion AS Ins INNER JOIN Area ON Area.IDarea=Ins.IDarea INNER JOIN Curso ON Curso.IDcurso=Ins.IDcurso " +
                    "INNER JOIN persona ON persona.IDpersona=Ins.IDpersona ORDER BY FechaInicio DESC,Area.Año DESC";
            }
            else
            {
                sql = "SELECT Area.IDarea,CONCAT(Area.Nombre,', ',Area.Año,', ',Area.Convocatoria),Curso.IDcurso,Curso.Nombre ,persona.IDpersona," +
                   "CONCAT(Persona.Nombre,', ',Persona.Apellido) AS NombreCom," +
                   "FechaInicio,IFNULL(FechaFin,'---') AS FechaFin," +
                   "CASE WHEN Aprobo=1 THEN 'SI' Else 'NO' END AS Aprobado, Ins.Codigo " +
                   "FROM inscripcion AS Ins INNER JOIN Area ON Area.IDarea=Ins.IDarea INNER JOIN Curso ON Curso.IDcurso=Ins.IDcurso " +
                   "INNER JOIN persona ON persona.IDpersona=Ins.IDpersona WHERE Area.Nombre LIKE '%" + data + "%' OR Area.Año LIKE '%" + data + "%' OR " +
                   "Area.Convocatoria LIKE '%" + data + "%' ORDER BY FechaInicio DESC,Area.Año DESC";
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
                    inscription.Código = reader[9].ToString();
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

            if (data == null || data == "")
            {
                sql = "SELECT Area.IDarea,CONCAT(Area.Nombre,', ',Area.Año,', ',Area.Convocatoria),Curso.IDcurso,Curso.Nombre ,persona.IDpersona," +
                    "CONCAT(Persona.Nombre,', ',Persona.Apellido)," +
                    "FechaInicio,IFNULL(FechaFin,'---') AS FechaFin," +
                    "CASE WHEN Aprobo=1 THEN 'SI' Else 'NO' END AS Aprobado, Ins.Codigo " +
                    "FROM inscripcion AS Ins INNER JOIN Area ON Area.IDarea=Ins.IDarea INNER JOIN Curso ON Curso.IDcurso=Ins.IDcurso " +
                    "INNER JOIN persona ON persona.IDpersona=Ins.IDpersona ORDER BY FechaInicio DESC,Area.Año DESC";
            }
            else
            {
                sql = "SELECT Area.IDarea,CONCAT(Area.Nombre,', ',Area.Año,', ',Area.Convocatoria),Curso.IDcurso,Curso.Nombre ,persona.IDpersona," +
                   "CONCAT(Persona.Nombre,', ',Persona.Apellido) AS NombreCom," +
                   "FechaInicio,IFNULL(FechaFin,'---') AS FechaFin," +
                   "CASE WHEN Aprobo=1 THEN 'SI' Else 'NO' END AS Aprobado, Ins.Codigo " +
                   "FROM inscripcion AS Ins INNER JOIN Area ON Area.IDarea=Ins.IDarea INNER JOIN Curso ON Curso.IDcurso=Ins.IDcurso " +
                   "INNER JOIN persona ON persona.IDpersona=Ins.IDpersona WHERE Curso.Nombre LIKE '%" + data + "%' ORDER BY FechaInicio DESC,Area.Año DESC";
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
                    inscription.Código = reader[9].ToString();
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

            if (data == null || data == "")
            {
                sql = "SELECT Area.IDarea,CONCAT(Area.Nombre,', ',Area.Año,', ',Area.Convocatoria),Curso.IDcurso,Curso.Nombre ,persona.IDpersona," +
                    "CONCAT(Persona.Nombre,', ',Persona.Apellido)," +
                    "FechaInicio,IFNULL(FechaFin,'---') AS FechaFin," +
                    "CASE WHEN Aprobo=1 THEN 'SI' Else 'NO' END AS Aprobado, Ins.Codigo " +
                    "FROM inscripcion AS Ins INNER JOIN Area ON Area.IDarea=Ins.IDarea INNER JOIN Curso ON Curso.IDcurso=Ins.IDcurso " +
                    "INNER JOIN persona ON persona.IDpersona=Ins.IDpersona ORDER BY FechaInicio DESC,Area.Año DESC";
            }
            else
            {
                sql = "SELECT Area.IDarea,CONCAT(Area.Nombre,', ',Area.Año,', ',Area.Convocatoria),Curso.IDcurso,Curso.Nombre ,persona.IDpersona," +
                   "CONCAT(Persona.Nombre,', ',Persona.Apellido) AS NombreCom," +
                   "FechaInicio,IFNULL(FechaFin,'---') AS FechaFin," +
                   "CASE WHEN Aprobo=1 THEN 'SI' Else 'NO' END AS Aprobado, Ins.Codigo " +
                   "FROM inscripcion AS Ins INNER JOIN Area ON Area.IDarea=Ins.IDarea INNER JOIN Curso ON Curso.IDcurso=Ins.IDcurso " +
                   "INNER JOIN persona ON persona.IDpersona=Ins.IDpersona WHERE Persona.Nombre LIKE '%" + data + "%' OR " +
                   "Persona.Apellido LIKE '%" + data + "%' ORDER BY FechaInicio DESC,Area.Año DESC";
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
                    inscription.Código = reader[9].ToString();
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

            if (data == null || data == "")
            {
                sql = "SELECT Area.IDarea,CONCAT(Area.Nombre,', ',Area.Año,', ',Area.Convocatoria),Curso.IDcurso,Curso.Nombre ,persona.IDpersona," +
                    "CONCAT(Persona.Nombre,', ',Persona.Apellido)," +
                    "FechaInicio,IFNULL(FechaFin,'---') AS FechaFin," +
                    "CASE WHEN Aprobo=1 THEN 'SI' Else 'NO' END AS Aprobado, Ins.Codigo " +
                    "FROM inscripcion AS Ins INNER JOIN Area ON Area.IDarea=Ins.IDarea INNER JOIN Curso ON Curso.IDcurso=Ins.IDcurso " +
                    "INNER JOIN persona ON persona.IDpersona=Ins.IDpersona ORDER BY FechaInicio DESC,Area.Año DESC";
            }
            else
            {
                sql = "SELECT Area.IDarea,CONCAT(Area.Nombre,', ',Area.Año,', ',Area.Convocatoria),Curso.IDcurso,Curso.Nombre ,persona.IDpersona," +
                   "CONCAT(Persona.Nombre,', ',Persona.Apellido) AS NombreCom," +
                   "FechaInicio,IFNULL(FechaFin,'---') AS FechaFin," +
                   "CASE WHEN Aprobo=1 THEN 'SI' Else 'NO' END AS Aprobado, Ins.Codigo " +
                   "FROM inscripcion AS Ins INNER JOIN Area ON Area.IDarea=Ins.IDarea INNER JOIN Curso ON Curso.IDcurso=Ins.IDcurso " +
                   "INNER JOIN persona ON persona.IDpersona=Ins.IDpersona WHERE YEAR(FechaInicio) = YEAR(CURRENT_DATE()) AND MONTH(FechaInicio) ='"+data+ "' ORDER BY FechaInicio DESC,Area.Año DESC";
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
                    inscription.Código = reader[9].ToString();
                    list.Add(inscription);
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
            string [] array=InsSelected.ToString().Split(',');
            int idArea = int.Parse(array[0]);
            int idCurso = int.Parse(array[1]);
            int idPersona = int.Parse(array[2]);
            MySqlDataReader reader;
            string sql;

            sql = "SELECT Area.IDarea,CONCAT(Area.Nombre,', ',Area.Año,', ',Area.Convocatoria),Curso.IDcurso,Curso.Nombre ,persona.IDpersona," +
                   "CONCAT(Persona.Nombre,', ',Persona.Apellido) AS NombreCom," +
                   "FechaInicio,IFNULL(FechaFin,'---') AS FechaFin," +
                   "CASE WHEN Aprobo=1 THEN 'SI' Else 'NO' END AS Aprobado, Ins.Codigo " +
                   "FROM inscripcion AS Ins INNER JOIN Area ON Area.IDarea=Ins.IDarea INNER JOIN Curso ON Curso.IDcurso=Ins.IDcurso " +
                   "INNER JOIN persona ON persona.IDpersona=Ins.IDpersona WHERE Area.IDarea LIKE '%" + idArea + "%' AND " +
                   "Curso.IDcurso LIKE '%" + idCurso + "%' AND persona.IDpersona LIKE '%" + idPersona + "%' ORDER BY FechaInicio DESC,Area.Año DESC";

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
                    inscription.Código = reader[9].ToString();
                    listSelected.Add(inscription);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
            }
        }
        public Inscription ModifyQuery(string IDcurso, string IDarea, string IDperson)/********************************************************/
        {
            MySqlDataReader reader;

            string sql;
            Inscription inscription = new Inscription();
            sql = "SELECT IDcurso, IDarea, IDpersona, Codigo, CASE WHEN Aprobo=1 THEN 'SI' Else 'NO' END AS Aprobado , FechaInicio, IFNULL(FechaFin,'') " +
                "FROM inscripcion  " +
                "WHERE IDcurso =" + IDcurso+" AND IDarea = "+IDarea+" AND IDpersona = "+IDperson;

            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    inscription.IDcurso = int.Parse(reader[0].ToString());
                    inscription.IDarea = int.Parse(reader[1].ToString());
                    inscription.IDpersona = int.Parse(reader[2].ToString());
                    inscription.Código = reader[3].ToString();
                    inscription.Aprobado = reader[4].ToString();
                    inscription.FechaInicio = reader[5].ToString();
                    inscription.FechaFin = reader[6].ToString();

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
            }
            return inscription;
        }

    }
}
