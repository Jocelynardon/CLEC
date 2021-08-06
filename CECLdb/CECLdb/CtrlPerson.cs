﻿using MySql.Data.MySqlClient;
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
        public List<Object> consultationCode(string date)
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
                    person.ID = int.Parse(reader[0].ToString());
                    person.Nombre = reader[1].ToString() + " " + reader[2].ToString();
                    person.Email = reader[3].ToString();
                    person.Teléfono = int.Parse(reader[4].ToString());
                    person.Código = reader.GetString(5);
                    list.Add(person);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
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
                    person.ID = int.Parse(reader[0].ToString());
                    person.Nombre = reader[1].ToString() + " " + reader[2].ToString();
                    person.Email = reader[3].ToString();
                    person.Teléfono = int.Parse(reader[4].ToString());
                    person.Código = reader.GetString(5);
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
                    person.ID = int.Parse(reader[0].ToString());
                    person.Nombre = reader[1].ToString() + " " + reader[2].ToString();
                    person.Email = reader[3].ToString();
                    person.Teléfono = int.Parse(reader[4].ToString());
                    person.Código = reader.GetString(5);
                    list.Add(person);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
            }
            return list;
        }
        
        public Person ModifyQuery(string IDpersona)
        {
            MySqlDataReader reader;

            string sql;
            Person person = new Person();
            sql = "SELECT IDpersona, Nombre, Apellido, Correo,Teléfono,codigo FROM persona WHERE IDpersona =" + IDpersona;

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
                    person.Teléfono = int.Parse(reader[4].ToString());
                    person.Código = reader.GetString(5);

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
            }
            return person;
        }
        public void SaveDataQuery(Person person)
        {
            string sql;

            sql = "UPDATE persona SET Codigo = '" + person.Código + "', Nombre = '" + person.Nombre + "', Apellido = '" + person.Apellido + "', Correo = '" + person.Email + "', Teléfono = '" + person.Teléfono + "' " +
                "WHERE IDpersona =" + person.ID;

            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido guardar los datos " + ex.Message);
            }

        }
        public void SelectedEmailSent(int IDselected)
        {
            MySqlDataReader reader;
            string sql;

            sql = "SELECT IDpersona, Nombre, Apellido, Correo,Teléfono,codigo FROM persona WHERE IDpersona LIKE " + IDselected + " ORDER BY Nombre";

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
                    person.Teléfono = int.Parse(reader[4].ToString());
                    person.Código = reader.GetString(5);
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
            if (data == null)
            {
                sql = "SELECT persona.IDpersona, persona.Nombre, Apellido, Correo,Teléfono,codigo FROM correoenviado " +
                "JOIN persona ON persona.IDpersona=correoenviado.IDpersona ORDER BY persona.Nombre ASC";
            }
            else
            {
                sql = "SELECT persona.IDpersona, persona.Nombre, Apellido, Correo,Teléfono,codigo FROM correoenviado " +
                "JOIN persona ON persona.IDpersona=correoenviado.IDpersona WHERE IDaviso LIKE " + data + " ORDER BY persona.Nombre ASC";
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
                    person.Teléfono = int.Parse(reader[4].ToString());
                    person.Código = reader.GetString(5);
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
