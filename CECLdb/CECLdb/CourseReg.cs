using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CECLdb
{
    public partial class CourseReg : Form
    {
        public CourseReg()
        {
            InitializeComponent();
            LoadAreaCourse();
            if (Menu.action==2)
            {
                cmbSelectArea.SelectedIndex = -1;
                bttnAddCourse.Visible = false;
                bttnSaveCourse.Visible = true;
                bttnSearchCourse.Visible = true;
            }
        }

        private void lblSelectArea_Click(object sender, EventArgs e)
        {

        }

        private void bttnReturnCourse_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }

        private void Exit(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                CloseWindow();
            }
        }

        private void LoadAreaCourse()
        {
            cmbSelectArea.DataSource = null;
            cmbSelectArea.Items.Clear();
            string sql = "SELECT IDarea,Nombre FROM area ORDER BY Nombre";
            MySqlConnection connectionBD = Connection.connection();
            connectionBD.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                MySqlDataAdapter data = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                data.Fill(dataTable);

                cmbSelectArea.ValueMember = "IDarea";
                cmbSelectArea.DisplayMember = "Nombre";
                cmbSelectArea.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar áreas" + ex.Message);
            }
        }

        private void bttnAddCourse_Click(object sender, EventArgs e)
        {
            if (cmbSelectArea.SelectedValue != null && txtbCourseName.Text!="")
            {
                int idArea = int.Parse(cmbSelectArea.SelectedValue.ToString());
                try
                {
                    String NameCourse = txtbCourseName.Text;
                    string sql = "INSERT INTO curso (IDarea,Nombre) VALUES ('"+idArea+ "'," +
                        "'"+NameCourse+"')";
                    MySqlConnection connectionBD = Connection.connection();
                    connectionBD.Open();
                    try
                    {
                        MySqlCommand command = new MySqlCommand(sql, connectionBD);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Curso correctamente agregado");
                        Clean();
                    }
                    catch (MySqlException ex1)
                    {
                        MessageBox.Show("Error al guardar"+ex1.Message);
                    }
                    finally
                    {
                        connectionBD.Close();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Seleccione el área" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese los datos");
            }
        }
        
        private void Clean()
        {
            cmbSelectArea.Text = "";
            txtbCourseName.Text = "";
        }
        private void CloseWindow()
        {
            Menu Frm = new Menu();
            Frm.Show();
            this.Close();
        }
    }
}
