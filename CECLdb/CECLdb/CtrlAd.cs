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
        public List<Object> consultationAreaAd(string data)
        {
            MySqlDataReader reader;
            List<Object> list = new List<object>();
            string sql;

            if (data == null)
            {
                sql = "SELECT IDaviso,Area.IDarea,Area.Nombre,Curso.IDcurso,Curso.Nombre ,Fecha,Descripcion " +
                    "FROM aviso AS Ad JOIN Area ON Area.IDarea=Ad.IDarea JOIN Curso ON Curso.IDcurso=Ad.IDcurso ORDER BY Fecha DESC";
            }
            else
            {
                sql = "SELECT IDaviso,Area.IDarea,Area.Nombre,Curso.IDcurso,Curso.Nombre,Fecha,Descripcion " +
                    "FROM aviso AS Ad JOIN Area ON Area.IDarea=Ad.IDarea JOIN Curso ON Curso.IDcurso=Ad.IDcurso WHERE Area.Nombre LIKE '%" + data + "%' ORDER BY Fecha DESC";
            }
            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Ad ad = new Ad();
                    ad.IDaviso = int.Parse(reader[0].ToString());
                    ad.idArea = int.Parse(reader[1].ToString());
                    ad.Area = reader[2].ToString();
                    ad.IDcurso = int.Parse(reader[3].ToString());
                    ad.Curso = reader[4].ToString();
                    ad.Fecha = Convert.ToDateTime(reader[5].ToString());
                    ad.Descripcion = reader.GetString(6);
                    list.Add(ad);
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
                sql = "SELECT IDaviso,Area.IDarea,Area.Nombre,Curso.IDcurso,Curso.Nombre ,Fecha,Descripcion " +
                    "FROM aviso AS Ad JOIN Area ON Area.IDarea=Ad.IDarea JOIN Curso ON Curso.IDcurso=Ad.IDcurso ORDER BY Fecha DESC";
            }
            else
            {
                sql = "SELECT IDaviso,Area.IDarea,Area.Nombre,Curso.IDcurso,Curso.Nombre,Fecha,Descripcion " +
                    "FROM aviso AS Ad JOIN Area ON Area.IDarea=Ad.IDarea JOIN Curso ON Curso.IDcurso=Ad.IDcurso WHERE Curso.Nombre LIKE '%" + data + "%' ORDER BY Fecha DESC";
            }
            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Ad ad = new Ad();
                    ad.IDaviso = int.Parse(reader[0].ToString());
                    ad.idArea = int.Parse(reader[1].ToString());
                    ad.Area = reader[2].ToString();
                    ad.IDcurso = int.Parse(reader[3].ToString());
                    ad.Curso = reader[4].ToString();
                    ad.Fecha = Convert.ToDateTime(reader[5].ToString());
                    ad.Descripcion = reader.GetString(6);
                    list.Add(ad);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
            }
            return list;
        }

        public List<Object> consultationDescription(string data)
        {
            MySqlDataReader reader;
            List<Object> list = new List<object>();
            string sql;

            if (data == null)
            {
                sql = "SELECT IDaviso,Area.IDarea,Area.Nombre,Curso.IDcurso,Curso.Nombre ,Fecha,Descripcion " +
                    "FROM aviso AS Ad JOIN Area ON Area.IDarea=Ad.IDarea JOIN Curso ON Curso.IDcurso=Ad.IDcurso ORDER BY Fecha DESC";
            }
            else
            {
                sql = "SELECT IDaviso,Area.IDarea,Area.Nombre,Curso.IDcurso,Curso.Nombre,Fecha,Descripcion" +
                    " FROM aviso AS Ad JOIN Area ON Area.IDarea=Ad.IDarea JOIN Curso ON Curso.IDcurso=Ad.IDcurso WHERE Descripcion LIKE '%" + data + "%' ORDER BY Fecha DESC";
            }
            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Ad ad = new Ad();
                    ad.IDaviso = int.Parse(reader[0].ToString());
                    ad.idArea = int.Parse(reader[1].ToString());
                    ad.Area = reader[2].ToString();
                    ad.IDcurso = int.Parse(reader[3].ToString());
                    ad.Curso = reader[4].ToString();
                    ad.Fecha = Convert.ToDateTime(reader[5].ToString());
                    ad.Descripcion = reader.GetString(6);
                    list.Add(ad);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
            }
            return list;
        }

        public void SelectedEmailSent(int IDselected)
        {
            MySqlDataReader reader;
            string sql;

            sql = "SELECT IDaviso,Area.IDarea,Area.Nombre,Curso.IDcurso,Curso.Nombre,Fecha,Descripcion " +
                    "FROM aviso AS Ad JOIN Area ON Area.IDarea=Ad.IDarea JOIN Curso ON Curso.IDcurso=Ad.IDcurso WHERE IDaviso LIKE '%" + IDselected + "%' ORDER BY Fecha DESC";

            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Ad ad = new Ad();
                    ad.IDaviso = int.Parse(reader[0].ToString());
                    ad.idArea = int.Parse(reader[1].ToString());
                    ad.Area = reader[2].ToString();
                    ad.IDcurso = int.Parse(reader[3].ToString());
                    ad.Curso = reader[4].ToString();
                    ad.Fecha = Convert.ToDateTime(reader[5].ToString());
                    ad.Descripcion = reader.GetString(6);
                    listSelected.Add(ad);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
            }
        }
        public Ad ModifyQuery(string IDaviso)
        {
            MySqlDataReader reader;

            string sql;
            Ad ad = new Ad();
            sql = "SELECT area.Nombre, curso.Nombre, aviso.Descripcion, aviso.Fecha " +
                "FROM aviso" +
                " INNER JOIN area ON aviso.IDarea = area.IDarea" +
                " INNER JOIN curso ON aviso.IDcurso = curso.IDcurso" +
                " WHERE IDaviso = " + IDaviso;

            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ad.IDaviso = int.Parse(IDaviso);
                    ad.Area = reader[0].ToString();
                    ad.Curso = reader[1].ToString();
                    ad.Descripcion = reader[2].ToString();
                    ad.Fecha = Convert.ToDateTime(reader[5].ToString());
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
            }
            return ad;
        }
        
    }
}
