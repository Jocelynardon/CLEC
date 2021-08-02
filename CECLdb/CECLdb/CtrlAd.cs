using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CLEC
{
    class CtrlAd:ConnectionSearchResult
    {
        public List<Object> listSelected = new List<Object>();
        //public List<Object> consultationAreaAd(string data)
        //{
        //    MySqlDataReader reader;
        //    List<Object> list = new List<object>();
        //    string sql;

        //    if (data == null)
        //    {
        //        sql = "SELECT IDaviso,IDarea,IDcurso,Fecha,Descripcion  FROM aviso ORDER BY Fecha DESC";
        //    }
        //    else
        //    {
        //        sql = "SELECT IDaviso,IDarea,IDcurso,Fecha,Descripcion  FROM aviso WHERE IDarea= " + data + "ORDER BY Fecha DESC";
        //    }
        //    try
        //    {
        //        MySqlConnection connectionBD = base.connectionTable();
        //        connectionBD.Open();
        //        MySqlCommand command = new MySqlCommand(sql, connectionBD);
        //        reader = command.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            Person person = new Person();
        //            person.IdPerson = int.Parse(reader[0].ToString());
        //            person.Name = reader[1].ToString() + " " + reader[2].ToString();
        //            person.Email = reader[3].ToString();
        //            person.Telephone = int.Parse(reader[4].ToString());
        //            person.CodePerson = reader.GetString(5);
        //            list.Add(person);
        //        }
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
        //    }
        //    return list;
        //}

        //public List<Object> consultationEmail(string data)
        //{
        //    MySqlDataReader reader;
        //    List<Object> list = new List<object>();
        //    string sql;

        //    if (data == null)
        //    {
        //        sql = "SELECT IDpersona, Nombre, Apellido, Correo,Teléfono,codigo FROM persona ORDER BY Nombre";
        //    }
        //    else
        //    {
        //        sql = "SELECT IDpersona, Nombre, Apellido, Correo,Teléfono,codigo FROM persona WHERE Correo LIKE '%" + date + "%'ORDER BY Nombre";
        //    }
        //    try
        //    {
        //        MySqlConnection connectionBD = base.connectionTable();
        //        connectionBD.Open();
        //        MySqlCommand command = new MySqlCommand(sql, connectionBD);
        //        reader = command.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            Person person = new Person();
        //            person.IdPerson = int.Parse(reader[0].ToString());
        //            person.Name = reader[1].ToString() + " " + reader[2].ToString();
        //            person.Email = reader[3].ToString();
        //            person.Telephone = int.Parse(reader[4].ToString());
        //            person.CodePerson = reader.GetString(5);
        //            list.Add(person);
        //        }
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
        //    }
        //    return list;
        //}
        //public List<Object> consultationName(string data)
        //{
        //    MySqlDataReader reader;
        //    List<Object> list = new List<object>();
        //    string sql;

        //    if (data == null)
        //    {
        //        sql = "SELECT IDpersona, Nombre, Apellido, Correo,Teléfono,codigo FROM persona ORDER BY Nombre";
        //    }
        //    else
        //    {
        //        sql = "SELECT IDpersona, Nombre, Apellido, Correo,Teléfono,codigo FROM persona WHERE Nombre LIKE '%" + date + "%' OR Apellido LIKE '%" + date + "%' ORDER BY Nombre";
        //    }
        //    try
        //    {
        //        MySqlConnection connectionBD = base.connectionTable();
        //        connectionBD.Open();
        //        MySqlCommand command = new MySqlCommand(sql, connectionBD);
        //        reader = command.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            Person person = new Person();
        //            person.IdPerson = int.Parse(reader[0].ToString());
        //            person.Name = reader[1].ToString() + " " + reader[2].ToString();
        //            person.Email = reader[3].ToString();
        //            person.Telephone = int.Parse(reader[4].ToString());
        //            person.CodePerson = reader.GetString(5);
        //            list.Add(person);
        //        }
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
        //    }
        //    return list;
        //}
        //public void SelectedEmailSent(int IDselected)
        //{
        //    MySqlDataReader reader;
        //    string sql;

        //    sql = "SELECT IDpersona, Nombre, Apellido, Correo,Teléfono,codigo FROM persona WHERE IDpersona= " + IDselected + " ORDER BY Nombre";

        //    try
        //    {
        //        MySqlConnection connectionBD = base.connectionTable();
        //        connectionBD.Open();
        //        MySqlCommand command = new MySqlCommand(sql, connectionBD);
        //        reader = command.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            Person person = new Person();
        //            person.IdPerson = int.Parse(reader[0].ToString());
        //            person.Name = reader[1].ToString() + " " + reader[2].ToString();
        //            person.Email = reader[3].ToString();
        //            person.Telephone = int.Parse(reader[4].ToString());
        //            person.CodePerson = reader.GetString(5);
        //            listSelected.Add(person);
        //        }
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
        //    }
        //}
    }
}
