using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CLEC
{
    class CtrlCourse:ConnectionSearchResult
    {
        public List<Object> listSelected = new List<Object>();
        public List<Object> consultationArea(string data)
        {
            MySqlDataReader reader;
            List<Object> list = new List<object>();
            string sql;

            if (data == null)
            {
                sql = "SELECT area.IDarea,IDcurso,curso.Nombre,CONCAT(Area.Nombre,', ',Area.Año,', ',Convocatoria) " +
                    "FROM curso INNER JOIN area ON area.IDarea=curso.IDarea ORDER BY curso.Nombre ASC,Area.Año DESC";
            }
            else
            {
                sql = "SELECT area.IDarea,IDcurso,curso.Nombre,CONCAT(Area.Nombre,', ',Area.Año,', ',Convocatoria) " +
                    "FROM curso INNER JOIN area ON area.IDarea=curso.IDarea WHERE Area.Nombre LIKE '%" + data + "%'  ORDER BY curso.Nombre ASC,Area.Año DESC";
            }
            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Course course = new Course();
                    course.IDarea = int.Parse(reader[0].ToString());
                    course.IDcurso = int.Parse(reader[1].ToString());
                    course.Nombre = reader[2].ToString();
                    course.Area = reader[3].ToString();
                    list.Add(course);
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
                sql = "SELECT area.IDarea,IDcurso,curso.Nombre,CONCAT(Area.Nombre,', ',Area.Año,', ',Convocatoria) " +
                    "FROM curso INNER JOIN area ON area.IDarea=curso.IDarea " +
                    "ORDER BY curso.Nombre ASC,Area.Año DESC";
            }
            else
            {
                sql = "SELECT area.IDarea,IDcurso,curso.Nombre,CONCAT(Area.Nombre,', ',Area.Año,', ',Convocatoria) " +
                    "FROM curso INNER JOIN area ON area.IDarea=curso.IDarea WHERE curso.Nombre LIKE '%" + data + "%'  " +
                    "ORDER BY curso.Nombre ASC,Area.Año DESC";
            }
            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Course course = new Course();
                    course.IDarea = int.Parse(reader[0].ToString());
                    course.IDcurso = int.Parse(reader[1].ToString());
                    course.Nombre = reader[2].ToString();
                    course.Area = reader[3].ToString();
                    list.Add(course);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
            }
            return list;
        }
        public void Selected(int data)
        {
            MySqlDataReader reader;
            string sql;

            sql = "SELECT area.IDarea,IDcurso,curso.Nombre,CONCAT(Area.Nombre,', ',Area.Año,', ',Convocatoria) " +
                    "FROM curso INNER JOIN area ON area.IDarea=curso.IDarea WHERE IDcurso= '" + data + "'  " +
                    "ORDER BY curso.Nombre ASC,Area.Año DESC";
            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Course course = new Course();
                    course.IDarea = int.Parse(reader[0].ToString());
                    course.IDcurso= int.Parse(reader[1].ToString());
                    course.Nombre = reader[2].ToString();
                    course.Area = reader[3].ToString();
                    listSelected.Add(course);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
            }
        }
        public Course ModifyQuery(string IDcourse)
        {
            MySqlDataReader reader;

            string sql;
            Course course = new Course();
            sql = "SELECT IDarea, Nombre FROM curso WHERE IDcurso =" + IDcourse;

            try
            {
                MySqlConnection connectionBD = base.connectionTable();
                connectionBD.Open();
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    course.IDarea = int.Parse(reader[0].ToString());
                    course.Nombre = reader[1].ToString();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se ha podido cargar los resultados " + ex.Message);
            }
            return course;
        }

    }
}
