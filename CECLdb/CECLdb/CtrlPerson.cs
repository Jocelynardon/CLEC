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
        

        public List<Object> consultationEmail(string date)
        {
            MySqlDataReader reader;
            List<Object> list = new List<object>();
            string sql;

            if (date == null)
            {
                sql = "SELECT IDpersona, Nombre, Apellido, Correo,Teléfono FROM persona ORDER BY Nombre";
            }
            else
            {
                sql = "SELECT IDpersona, Nombre, Apellido, Correo,Teléfono FROM persona WHERE Correo LIKE '%" + date + "%'ORDER BY Nombre";
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
        public List<Object> consultationName(string date)
        {
            MySqlDataReader reader;
            List<Object> list = new List<object>();
            string sql;

            if (date == null)
            {
                sql = "SELECT IDpersona, Nombre, Apellido, Correo,Teléfono FROM persona ORDER BY Nombre";
            }
            else
            {
                sql = "SELECT IDpersona, Nombre, Apellido, Correo,Teléfono FROM persona WHERE Nombre LIKE '%" + date + "%' OR Apellido LIKE '%" + date + "%' ORDER BY Nombre";
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

            sql = "SELECT persona.IDpersona, persona.Nombre, Apellido, Correo,Teléfono FROM correoenviado " +
            "JOIN persona ON persona.IDpersona=correoenviado.IDpersona WHERE IDaviso = " + data + " ORDER BY persona.Nombre ASC";

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
