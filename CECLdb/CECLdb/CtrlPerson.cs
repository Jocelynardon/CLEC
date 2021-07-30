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
        public List<Object> consultationCode(string date)
        {
            MySqlDataReader reader;
            List<Object> list = new List<object>();
            string sql;
            int count = 0;

            if (date==null)
            {
                sql = "SELECT IDpersona, Nombre, Apellido, Correo,Teléfono,codigo FROM persona ORDER BY Nombre";
            }
            else
            {
                sql = "SELECT IDpersona, Nombre, Apellido, Correo,Teléfono,codigo FROM persona WHERE codigo LIKE '%" + date + "%'ORDER BY Nombre";
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
                    person.IdPerson = int.Parse(reader[0].ToString());
                    person.Name = reader[1].ToString() + " " + reader[2].ToString();
                    person.Email = reader[3].ToString();
                    person.Telephone = int.Parse(reader[4].ToString());
                    person.CodePerson = reader.GetString(5);
                    list.Add(person);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido cargar los resultados "+ ex.Message);
            }
            return list;
        }

        public List<Object> consultationEmail(string date)
        {
            MySqlDataReader reader;
            List<Object> list = new List<object>();
            string sql;

            if (date == null)
            {
                sql = "SELECT IDpersona, Nombre, Apellido, Correo,Teléfono,codigo FROM persona ORDER BY Nombre";
            }
            else
            {
                sql = "SELECT IDpersona, Nombre, Apellido, Correo,Teléfono,codigo FROM persona WHERE Correo LIKE '%" + date + "%'ORDER BY Nombre";
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
                    person.IdPerson = int.Parse(reader[0].ToString());
                    person.Name = reader[1].ToString() + " " + reader[2].ToString();
                    person.Email = reader[3].ToString();
                    person.Telephone = int.Parse(reader[4].ToString());
                    person.CodePerson = reader.GetString(5);
                    list.Add(person);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
            }
            return list;
        }
        public List<Object> consultationName(string date)
        {
            MySqlDataReader reader;
            List<Object> list = new List<object>();
            string sql;

            if (date == null)
            {
                sql = "SELECT IDpersona, Nombre, Apellido, Correo,Teléfono,codigo FROM persona ORDER BY Nombre";
            }
            else
            {
                sql = "SELECT IDpersona, Nombre, Apellido, Correo,Teléfono,codigo FROM persona WHERE Nombre LIKE '%" + date + "%' OR Apellido LIKE '%" + date + "%' ORDER BY Nombre";
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
                    person.IdPerson = int.Parse(reader[0].ToString());
                    person.Name = reader[1].ToString() + " " + reader[2].ToString();
                    person.Email = reader[3].ToString();
                    person.Telephone = int.Parse(reader[4].ToString());
                    person.CodePerson = reader.GetString(5);
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
