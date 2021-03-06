using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using CECLdb;
using System.Windows.Forms;

namespace CLEC
{
    class CtrlPerson: ConnectionSearchResult
    {
        public List<Object> listSelected = new List<Object>();
        

        public List<Object> consultationEmail(string data)
        {
            MySqlDataReader reader;
            List<Object> list = new List<object>();
            string sql;

            if (data == null)
            {
                sql = "SELECT IDpersona, Nombre, Apellido, Correo,Teléfono FROM persona ORDER BY Nombre";
            }
            else
            {
                sql = "SELECT IDpersona, Nombre, Apellido, Correo,Teléfono FROM persona WHERE Correo LIKE '%" + data + "%'ORDER BY Nombre";
            }
            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Person person = new Person();
                    person.ID = int.Parse(reader[0].ToString());
                    person.Nombre = reader[1].ToString() + " " + reader[2].ToString();
                    person.Email = reader[3].ToString();
                    person.Teléfono = reader[4].ToString();
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

            if (data == null || data == "")
            {
                sql = "SELECT IDpersona, Nombre, Apellido, Correo,Teléfono FROM persona ORDER BY Nombre";
            }
            else
            {
                sql = "SELECT IDpersona, Nombre, Apellido, Correo,Teléfono FROM persona WHERE Nombre LIKE '%" + data + "%' OR Apellido LIKE '%" + data + "%' ORDER BY Nombre";
            }
            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Person person = new Person();
                    person.ID = int.Parse(reader[0].ToString());
                    person.Nombre = reader[1].ToString() + " " + reader[2].ToString();
                    person.Email = reader[3].ToString();
                    person.Teléfono = reader[4].ToString();
                    list.Add(person);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
            }
            return list;
        }
        public List<Object> consultationArea(string data)
        {
            MySqlDataReader reader;
            List<Object> list = new List<object>();
            string sql;

            if (data == null || data == "")
            {
                sql = "SELECT Ins.IDpersona, persona.Nombre, persona.Apellido, " +
                    "persona.Correo,persona.Teléfono," +
                    "CONCAT(Area.Nombre,', ',Area.Año,', ',Convocatoria) AS Nombre,Curso.Nombre " +
                    "FROM persona INNER JOIN Inscripcion as Ins " +
                    "ON Ins.IDpersona=persona.IDpersona INNER JOIN Area ON Area.IDarea=Ins.IDarea " +
                    "INNER JOIN Curso ON Ins.IDcurso=Curso.IDcurso ORDER BY Area.Nombre";
            }
            else
            {
                sql = "SELECT Ins.IDpersona, persona.Nombre, " +
                    "persona.Apellido, persona.Correo,persona.Teléfono," +
                    "CONCAT(Area.Nombre,', ',Area.Año,', ',Convocatoria) AS Nombre,Curso.Nombre " +
                    "FROM persona INNER JOIN Inscripcion as Ins " +
                    "ON Ins.IDpersona=persona.IDpersona INNER JOIN Area ON Area.IDarea=Ins.IDarea " +
                    "INNER JOIN Curso ON Ins.IDcurso=Curso.IDcurso WHERE Area.Nombre LIKE '%" + data + "%' ORDER BY Area.Nombre";
            }
            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Person person = new Person();
                    person.ID = int.Parse(reader[0].ToString());
                    person.Nombre = reader[1].ToString() + " " + reader[2].ToString();
                    person.Email = reader[3].ToString();
                    person.Teléfono = reader[4].ToString();
                    person.Área = reader[5].ToString();
                    person.Curso = reader[6].ToString();
                    list.Add(person);
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
                sql = "SELECT Ins.IDpersona, persona.Nombre, persona.Apellido, " +
                    "persona.Correo,persona.Teléfono," +
                    "CONCAT(Area.Nombre,', ',Area.Año,', ',Convocatoria) AS Nombre,Curso.Nombre " +
                    "FROM persona INNER JOIN Inscripcion as Ins " +
                    "ON Ins.IDpersona=persona.IDpersona INNER JOIN Area ON Area.IDarea=Ins.IDarea " +
                    "INNER JOIN Curso ON Ins.IDcurso=Curso.IDcurso ORDER BY Curso.Nombre";
            }
            else
            {
                sql = "SELECT Ins.IDpersona, persona.Nombre, " +
                    "persona.Apellido, persona.Correo,persona.Teléfono," +
                    "CONCAT(Area.Nombre,', ',Area.Año,', ',Convocatoria) AS Nombre,Curso.Nombre " +
                    "FROM persona INNER JOIN Inscripcion as Ins " +
                    "ON Ins.IDpersona=persona.IDpersona INNER JOIN Area ON Area.IDarea=Ins.IDarea " +
                    "INNER JOIN Curso ON Ins.IDcurso=Curso.IDcurso WHERE Curso.Nombre LIKE '%" + data + "%' ORDER BY Curso.Nombre";
            }
            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Person person = new Person();
                    person.ID = int.Parse(reader[0].ToString());
                    person.Nombre = reader[1].ToString() + " " + reader[2].ToString();
                    person.Email = reader[3].ToString();
                    person.Teléfono = reader[4].ToString();
                    person.Área = reader[5].ToString();
                    person.Curso = reader[6].ToString();
                    list.Add(person);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
            }
            return list;
        }


        public Person ModifyQuery(string IDpersona)/********************************************************/
        {
            MySqlDataReader reader;

            string sql;
            Person person = new Person();
            sql = "SELECT IDpersona, Nombre, Apellido, Correo,Teléfono FROM persona WHERE IDpersona =" + IDpersona;

            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    person.ID = int.Parse(reader[0].ToString());
                    person.Nombre = reader[1].ToString();
                    person.Apellido = reader[2].ToString();
                    person.Email = reader[3].ToString();
                    person.Teléfono =reader[4].ToString();

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
            }
            return person;
        }
        
        public void SelectedEmailSent(int IDselected)
        {
            MySqlDataReader reader;
            string sql;

            sql = "SELECT IDpersona, Nombre, Apellido, Correo,Teléfono FROM persona WHERE IDpersona = " + IDselected + " ORDER BY Nombre";

            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Person person = new Person();
                    person.ID = int.Parse(reader[0].ToString());
                    person.Nombre = reader[1].ToString() + " " + reader[2].ToString();
                    person.Email = reader[3].ToString();
                    person.Teléfono = reader[4].ToString();
                    listSelected.Add(person);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
            }
        }
        public List<Object> consultationIDEmailSent(string data)
        {
            MySqlDataReader reader;
            List<Object> list = new List<object>();
            string sql;

            if (data == null || data == "")
            {
                sql = "SELECT persona.IDpersona, persona.Nombre, Apellido, Correo,Teléfono FROM correoenviado " +
            "JOIN persona ON persona.IDpersona=correoenviado.IDpersona ORDER BY persona.Nombre ASC";
            }
            else
            {
                sql = "SELECT persona.IDpersona, persona.Nombre, Apellido, Correo,Teléfono FROM correoenviado " +
            "JOIN persona ON persona.IDpersona=correoenviado.IDpersona WHERE IDaviso = " + data + " ORDER BY persona.Nombre ASC";
            }

            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Person person = new Person();
                    person.ID = int.Parse(reader[0].ToString());
                    person.Nombre = reader[1].ToString() + " " + reader[2].ToString();
                    person.Email = reader[3].ToString();
                    person.Teléfono = reader[4].ToString();
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
