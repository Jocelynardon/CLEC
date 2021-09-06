using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CLEC
{
    class CtrlSearchPeople:ConnectionSearchResult
    {
        public List<Object> consultationCode(string data)
        {
            MySqlDataReader reader;
            List<Object> list = new List<object>();
            string sql;

            if (data == null)
            {
                sql = "SELECT Ins.IDpersona,Persona.Nombre,Persona.Apellido, " +
                    "persona.Correo,persona.Teléfono," +
                    "CONCAT(Area.Nombre,', ',Area.Año,', ',Convocatoria) AS Nombre,Curso.Nombre," +
                    "FechaInicio,IFNULL(FechaFin, '---') AS FechaFin," +
                    "CASE WHEN Aprobo=1 THEN 'SI' Else 'NO' END AS Aprobado, Ins.Codigo "+
                    "FROM persona INNER JOIN Inscripcion as Ins " +
                    "ON Ins.IDpersona=persona.IDpersona INNER JOIN Area ON Area.IDarea=Ins.IDarea " +
                    "INNER JOIN Curso ON Ins.IDcurso=Curso.IDcurso ORDER BY Persona.Nombre";
            }
            else
            {
                sql = "SELECT Ins.IDpersona,Persona.Nombre,Persona.Apellido, " +
                    "persona.Correo,persona.Teléfono," +
                    "CONCAT(Area.Nombre,', ',Area.Año,', ',Convocatoria) AS Nombre,Curso.Nombre," +
                    "FechaInicio,IFNULL(FechaFin, '---') AS FechaFin," +
                    "CASE WHEN Aprobo=1 THEN 'SI' Else 'NO' END AS Aprobado, Ins.Codigo " +
                    "FROM persona INNER JOIN Inscripcion as Ins " +
                    "ON Ins.IDpersona=persona.IDpersona INNER JOIN Area ON Area.IDarea=Ins.IDarea " +
                    "INNER JOIN Curso ON Ins.IDcurso=Curso.IDcurso WHERE Ins.Codigo LIKE '%"+data+"%' ORDER BY Persona.Nombre";
            }
            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    People person = new People();
                    person.ID = int.Parse(reader[0].ToString());
                    person.Nombre = reader[1].ToString() + " " + reader[2].ToString();
                    person.Email = reader[3].ToString();
                    person.Teléfono = reader[4].ToString();
                    person.Área = reader[5].ToString();
                    person.Curso = reader[6].ToString();
                    person.FechaInicio = reader[7].ToString();
                    person.FechaFin = reader[8].ToString();
                    person.Aprobado = reader[9].ToString();
                    person.Código = reader[10].ToString();
                    list.Add(person);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
            }
            return list;
        }
        public List<Object> consultationEmail(string data)
        {
            MySqlDataReader reader;
            List<Object> list = new List<object>();
            string sql;

            if (data == null)
            {
                sql = "SELECT Ins.IDpersona,Persona.Nombre,Persona.Apellido, " +
                    "persona.Correo,persona.Teléfono," +
                    "CONCAT(Area.Nombre,', ',Area.Año,', ',Convocatoria) AS Nombre,Curso.Nombre," +
                    "FechaInicio,IFNULL(FechaFin, '---') AS FechaFin," +
                    "CASE WHEN Aprobo=1 THEN 'SI' Else 'NO' END AS Aprobado, Ins.Codigo " +
                    "FROM persona INNER JOIN Inscripcion as Ins " +
                    "ON Ins.IDpersona=persona.IDpersona INNER JOIN Area ON Area.IDarea=Ins.IDarea " +
                    "INNER JOIN Curso ON Ins.IDcurso=Curso.IDcurso ORDER BY Persona.Nombre";
            }
            else
            {
                sql = "SELECT Ins.IDpersona,Persona.Nombre,Persona.Apellido, " +
                    "persona.Correo,persona.Teléfono," +
                    "CONCAT(Area.Nombre,', ',Area.Año,', ',Convocatoria) AS Nombre,Curso.Nombre," +
                    "FechaInicio,IFNULL(FechaFin, '---') AS FechaFin," +
                    "CASE WHEN Aprobo=1 THEN 'SI' Else 'NO' END AS Aprobado, Ins.Codigo " +
                    "FROM persona INNER JOIN Inscripcion as Ins " +
                    "ON Ins.IDpersona=persona.IDpersona INNER JOIN Area ON Area.IDarea=Ins.IDarea " +
                    "INNER JOIN Curso ON Ins.IDcurso=Curso.IDcurso WHERE Persona.Correo LIKE '%" + data + "%' ORDER BY Persona.Nombre";
            }
            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    People person = new People();
                    person.ID = int.Parse(reader[0].ToString());
                    person.Nombre = reader[1].ToString() + " " + reader[2].ToString();
                    person.Email = reader[3].ToString();
                    person.Teléfono = reader[4].ToString();
                    person.Área = reader[5].ToString();
                    person.Curso = reader[6].ToString();
                    person.FechaInicio = reader[7].ToString();
                    person.FechaFin = reader[8].ToString();
                    person.Aprobado = reader[9].ToString();
                    person.Código = reader[10].ToString();
                    list.Add(person);
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
                sql = "SELECT Ins.IDpersona,Persona.Nombre,Persona.Apellido, " +
                    "persona.Correo,persona.Teléfono," +
                    "CONCAT(Area.Nombre,', ',Area.Año,', ',Convocatoria) AS Nombre,Curso.Nombre," +
                    "FechaInicio,IFNULL(FechaFin, '---') AS FechaFin," +
                    "CASE WHEN Aprobo=1 THEN 'SI' Else 'NO' END AS Aprobado, Ins.Codigo " +
                    "FROM persona INNER JOIN Inscripcion as Ins " +
                    "ON Ins.IDpersona=persona.IDpersona INNER JOIN Area ON Area.IDarea=Ins.IDarea " +
                    "INNER JOIN Curso ON Ins.IDcurso=Curso.IDcurso ORDER BY Persona.Nombre";
            }
            else
            {
                sql = "SELECT Ins.IDpersona,Persona.Nombre,Persona.Apellido, " +
                    "persona.Correo,persona.Teléfono," +
                    "CONCAT(Area.Nombre,', ',Area.Año,', ',Convocatoria) AS Nombre,Curso.Nombre," +
                    "FechaInicio,IFNULL(FechaFin, '---') AS FechaFin," +
                    "CASE WHEN Aprobo=1 THEN 'SI' Else 'NO' END AS Aprobado, Ins.Codigo " +
                    "FROM persona INNER JOIN Inscripcion as Ins " +
                    "ON Ins.IDpersona=persona.IDpersona INNER JOIN Area ON Area.IDarea=Ins.IDarea " +
                    "INNER JOIN Curso ON Ins.IDcurso=Curso.IDcurso WHERE Persona.Nombre LIKE '%" + data + "%' ORDER BY Persona.Nombre";
            }
            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    People person = new People();
                    person.ID = int.Parse(reader[0].ToString());
                    person.Nombre = reader[1].ToString() + " " + reader[2].ToString();
                    person.Email = reader[3].ToString();
                    person.Teléfono = reader[4].ToString();
                    person.Área = reader[5].ToString();
                    person.Curso = reader[6].ToString();
                    person.FechaInicio = reader[7].ToString();
                    person.FechaFin = reader[8].ToString();
                    person.Aprobado = reader[9].ToString();
                    person.Código = reader[10].ToString();
                    list.Add(person);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
            }
            return list;
        }
        public List<Object> consultationCourse(int idArea,int idCourse)
        {
            MySqlDataReader reader;
            List<Object> list = new List<object>();
            string sql;

            if (idArea == 0 && idCourse==0)
            {
                sql = "SELECT Ins.IDpersona,Persona.Nombre,Persona.Apellido, " +
                    "persona.Correo,persona.Teléfono," +
                    "CONCAT(Area.Nombre,', ',Area.Año,', ',Convocatoria) AS Nombre,Curso.Nombre," +
                    "FechaInicio,IFNULL(FechaFin, '---') AS FechaFin," +
                    "CASE WHEN Aprobo=1 THEN 'SI' Else 'NO' END AS Aprobado, Ins.Codigo " +
                    "FROM persona INNER JOIN Inscripcion as Ins " +
                    "ON Ins.IDpersona=persona.IDpersona INNER JOIN Area ON Area.IDarea=Ins.IDarea " +
                    "INNER JOIN Curso ON Ins.IDcurso=Curso.IDcurso ORDER BY Persona.Nombre";
            }
            else
            {
                sql = "SELECT Ins.IDpersona,Persona.Nombre,Persona.Apellido, " +
                    "persona.Correo,persona.Teléfono," +
                    "CONCAT(Area.Nombre,', ',Area.Año,', ',Convocatoria) AS Nombre,Curso.Nombre," +
                    "FechaInicio,IFNULL(FechaFin, '---') AS FechaFin," +
                    "CASE WHEN Aprobo=1 THEN 'SI' Else 'NO' END AS Aprobado, Ins.Codigo " +
                    "FROM persona INNER JOIN Inscripcion as Ins " +
                    "ON Ins.IDpersona=persona.IDpersona INNER JOIN Area ON Area.IDarea=Ins.IDarea " +
                    "INNER JOIN Curso ON Ins.IDcurso=Curso.IDcurso WHERE Area.idArea LIKE '%" + idArea + "%' " +
                    "AND Curso.IDcurso LIKE '%"+idCourse+"%' ORDER BY Persona.Nombre";
            }
            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    People person = new People();
                    person.ID = int.Parse(reader[0].ToString());
                    person.Nombre = reader[1].ToString() + " " + reader[2].ToString();
                    person.Email = reader[3].ToString();
                    person.Teléfono = reader[4].ToString();
                    person.Área = reader[5].ToString();
                    person.Curso = reader[6].ToString();
                    person.FechaInicio = reader[7].ToString();
                    person.FechaFin = reader[8].ToString();
                    person.Aprobado = reader[9].ToString();
                    person.Código = reader[10].ToString();
                    list.Add(person);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
            }
            return list;
        }
        public List<Object> consultationCodeByEmailSent(string data)
        {
            MySqlDataReader reader;
            List<Object> list = new List<object>();
            string sql;

            if (data==null)
            {
                sql = "SELECT per.IDpersona,per.Nombre,per.Apellido,per.Correo,per.Teléfono," +
                    "CONCAT(Area.Nombre, ', ', Area.Año, ', ', Convocatoria) AS Nombre, Curso.Nombre," +
                    "av.Descripcion, av.Fecha,ins.codigo " +
                    "FROM persona AS per INNER JOIN correoenviado AS coren ON coren.IDpersona = per.IDpersona " +
                    "INNER JOIN aviso AS av ON av.IDaviso = coren.IDaviso INNER JOIN area ON area.IDarea = av.IDarea " +
                    "INNER JOIN curso ON curso.IDcurso = av.IDcurso INNER JOIN inscripcion AS ins " +
                    "ON ins.IDpersona = per.IDpersona ORDER BY per.Nombre";
            }
            else
            {
                sql = "SELECT per.IDpersona,per.Nombre,per.Apellido,per.Correo,per.Teléfono," +
                    "CONCAT(Area.Nombre, ', ', Area.Año, ', ', Convocatoria) AS Nombre, Curso.Nombre," +
                    "av.Descripcion, av.Fecha,ins.codigo " +
                    "FROM persona AS per INNER JOIN correoenviado AS coren ON coren.IDpersona = per.IDpersona " +
                    "INNER JOIN aviso AS av ON av.IDaviso = coren.IDaviso INNER JOIN area ON area.IDarea = av.IDarea " +
                    "INNER JOIN curso ON curso.IDcurso = av.IDcurso INNER JOIN inscripcion AS ins " +
                    "ON ins.IDpersona = per.IDpersona WHERE ins.codigo LIKE '%"+data+"%' ORDER BY per.Nombre";
            }
            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    People person = new People();
                    person.ID = int.Parse(reader[0].ToString());
                    person.Nombre = reader[1].ToString() + " " + reader[2].ToString();
                    person.Email = reader[3].ToString();
                    person.Teléfono = reader[4].ToString();
                    person.Área = reader[5].ToString();
                    person.Curso = reader[6].ToString();
                    person.Descripción = reader[7].ToString();
                    person.FechaAviso = reader[8].ToString();
                    person.Código = reader[9].ToString();
                    list.Add(person);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
            }
            return list;
        }
        public List<Object> consultationEmailByEmailSent(string data)
        {
            MySqlDataReader reader;
            List<Object> list = new List<object>();
            string sql;

            if (data == null)
            {
                sql = "SELECT per.IDpersona,per.Nombre,per.Apellido,per.Correo,per.Teléfono," +
                    "CONCAT(Area.Nombre, ', ', Area.Año, ', ', Convocatoria) AS Nombre, Curso.Nombre," +
                    "av.Descripcion, av.Fecha,ins.codigo " +
                    "FROM persona AS per INNER JOIN correoenviado AS coren ON coren.IDpersona = per.IDpersona " +
                    "INNER JOIN aviso AS av ON av.IDaviso = coren.IDaviso INNER JOIN area ON area.IDarea = av.IDarea " +
                    "INNER JOIN curso ON curso.IDcurso = av.IDcurso INNER JOIN inscripcion AS ins " +
                    "ON ins.IDpersona = per.IDpersona ORDER BY per.Nombre";
            }
            else
            {
                sql = "SELECT per.IDpersona,per.Nombre,per.Apellido,per.Correo,per.Teléfono," +
                    "CONCAT(Area.Nombre, ', ', Area.Año, ', ', Convocatoria) AS Nombre, Curso.Nombre," +
                    "av.Descripcion, av.Fecha,ins.codigo " +
                    "FROM persona AS per INNER JOIN correoenviado AS coren ON coren.IDpersona = per.IDpersona " +
                    "INNER JOIN aviso AS av ON av.IDaviso = coren.IDaviso INNER JOIN area ON area.IDarea = av.IDarea " +
                    "INNER JOIN curso ON curso.IDcurso = av.IDcurso INNER JOIN inscripcion AS ins " +
                    "ON ins.IDpersona = per.IDpersona WHERE per.correo LIKE '%" + data + "%' ORDER BY per.Nombre";
            }
            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    People person = new People();
                    person.ID = int.Parse(reader[0].ToString());
                    person.Nombre = reader[1].ToString() + " " + reader[2].ToString();
                    person.Email = reader[3].ToString();
                    person.Teléfono = reader[4].ToString();
                    person.Área = reader[5].ToString();
                    person.Curso = reader[6].ToString();
                    person.Descripción = reader[7].ToString();
                    person.FechaAviso = reader[8].ToString();
                    person.Código = reader[9].ToString();
                    list.Add(person);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
            }
            return list;
        }
        public List<Object> consultationNameByEmailSent(string data)
        {
            MySqlDataReader reader;
            List<Object> list = new List<object>();
            string sql;

            if (data == null)
            {
                sql = "SELECT per.IDpersona,per.Nombre,per.Apellido,per.Correo,per.Teléfono," +
                    "CONCAT(Area.Nombre, ', ', Area.Año, ', ', Convocatoria) AS Nombre, Curso.Nombre," +
                    "av.Descripcion, av.Fecha,ins.codigo " +
                    "FROM persona AS per INNER JOIN correoenviado AS coren ON coren.IDpersona = per.IDpersona " +
                    "INNER JOIN aviso AS av ON av.IDaviso = coren.IDaviso INNER JOIN area ON area.IDarea = av.IDarea " +
                    "INNER JOIN curso ON curso.IDcurso = av.IDcurso INNER JOIN inscripcion AS ins " +
                    "ON ins.IDpersona = per.IDpersona ORDER BY per.Nombre";
            }
            else
            {
                sql = "SELECT per.IDpersona,per.Nombre,per.Apellido,per.Correo,per.Teléfono," +
                    "CONCAT(Area.Nombre, ', ', Area.Año, ', ', Convocatoria) AS Nombre, Curso.Nombre," +
                    "av.Descripcion, av.Fecha,ins.codigo " +
                    "FROM persona AS per INNER JOIN correoenviado AS coren ON coren.IDpersona = per.IDpersona " +
                    "INNER JOIN aviso AS av ON av.IDaviso = coren.IDaviso INNER JOIN area ON area.IDarea = av.IDarea " +
                    "INNER JOIN curso ON curso.IDcurso = av.IDcurso INNER JOIN inscripcion AS ins " +
                    "ON ins.IDpersona = per.IDpersona WHERE per.Nombre LIKE '%" + data + "%' ORDER BY per.Nombre";
            }
            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    People person = new People();
                    person.ID = int.Parse(reader[0].ToString());
                    person.Nombre = reader[1].ToString() + " " + reader[2].ToString();
                    person.Email = reader[3].ToString();
                    person.Teléfono = reader[4].ToString();
                    person.Área = reader[5].ToString();
                    person.Curso = reader[6].ToString();
                    person.Descripción = reader[7].ToString();
                    person.FechaAviso = reader[8].ToString();
                    person.Código = reader[9].ToString();
                    list.Add(person);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
            }
            return list;
        }
        public List<Object> consultationCourseByEmailSent(int idArea, int idCourse)
        {
            MySqlDataReader reader;
            List<Object> list = new List<object>();
            string sql;

            if (idArea==0 && idCourse==0)
            {
                sql = "SELECT per.IDpersona,per.Nombre,per.Apellido,per.Correo,per.Teléfono," +
                    "CONCAT(Area.Nombre, ', ', Area.Año, ', ', Convocatoria) AS Nombre, Curso.Nombre," +
                    "av.Descripcion, av.Fecha,ins.codigo " +
                    "FROM persona AS per INNER JOIN correoenviado AS coren ON coren.IDpersona = per.IDpersona " +
                    "INNER JOIN aviso AS av ON av.IDaviso = coren.IDaviso INNER JOIN area ON area.IDarea = av.IDarea " +
                    "INNER JOIN curso ON curso.IDcurso = av.IDcurso INNER JOIN inscripcion AS ins " +
                    "ON ins.IDpersona = per.IDpersona ORDER BY per.Nombre";
            }
            else
            {
                sql = "SELECT per.IDpersona,per.Nombre,per.Apellido,per.Correo,per.Teléfono," +
                    "CONCAT(Area.Nombre, ', ', Area.Año, ', ', Convocatoria) AS Nombre, Curso.Nombre," +
                    "av.Descripcion, av.Fecha,ins.codigo " +
                    "FROM persona AS per INNER JOIN correoenviado AS coren ON coren.IDpersona = per.IDpersona " +
                    "INNER JOIN aviso AS av ON av.IDaviso = coren.IDaviso INNER JOIN area ON area.IDarea = av.IDarea " +
                    "INNER JOIN curso ON curso.IDcurso = av.IDcurso INNER JOIN inscripcion AS ins " +
                    "ON ins.IDpersona = per.IDpersona WHERE area.IDarea LIKE '%" + idArea + "%' AND curso.IDcurso LIKE '%" + idCourse + "%' " +
                    "ORDER BY per.Nombre";
            }
            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    People person = new People();
                    person.ID = int.Parse(reader[0].ToString());
                    person.Nombre = reader[1].ToString() + " " + reader[2].ToString();
                    person.Email = reader[3].ToString();
                    person.Teléfono = reader[4].ToString();
                    person.Área = reader[5].ToString();
                    person.Curso = reader[6].ToString();
                    person.Descripción = reader[7].ToString();
                    person.FechaAviso = reader[8].ToString();
                    person.Código = reader[9].ToString();
                    list.Add(person);
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
