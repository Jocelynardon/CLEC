using CLEC;
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
    public partial class AdReg : Form
    {
        public static int idAd = 0;
        //Menu.action 1 es agregar, 2 modificar, 3 eliminar, 4 viene de email enviado
        public AdReg()
        {
            InitializeComponent();
            LoadAreaAd();
            ShowNumberAd();
            if (Menu.action==1)
            {

            }
            if (Menu.action==2)
            {
                bttnAddAd.Visible = false;
                bttnSaveAd.Visible = true;
                bttnSearchAd.Visible = true;
                bttnEmailSent.Visible = false;
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bttnReturnAd_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }
        private void bttnAddAd_Click(object sender, EventArgs e)
        {
            if (cmbSelectAreaAd.Text!="")
            {
                if (cmbSelectCourseAd.Text!="")
                {
                    if (rtbDescriptionAd.Text!="")
                    {
                        int idArea = int.Parse(cmbSelectAreaAd.SelectedValue.ToString());
                        int idCourse = int.Parse(cmbSelectCourseAd.SelectedValue.ToString());
                        String description = rtbDescriptionAd.Text;

                        string sql = "INSERT INTO aviso (IDarea,IDcurso,Fecha,Descripcion) VALUES ('" + idArea + "'," +
                            "'" + idCourse + "','" + dtpDateAd.Text + "','" + description + "')";
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
                            MessageBox.Show("Error al guardar " + ex1.Message);
                        }
                        finally
                        {
                            connectionBD.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Coloque una descripción sobre el anuncio");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione el curso al que pertence");
                }
            }
            else
            {
                MessageBox.Show("Seleccione el área a la que pertenece");
            }
        }

        private void bttnSearchAd_Click(object sender, EventArgs e)
        {

        }

        private void bttnSaveAd_Click(object sender, EventArgs e)
        {
     
        }

        private void lblEscAd_Click(object sender, EventArgs e)
        {

        }

        private void Exit(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                CloseWindow();
            }
        }

        private void LoadAreaAd()
        {
            cmbSelectAreaAd.DataSource = null;
            cmbSelectAreaAd.Items.Clear();
            string sql = "SELECT IDarea,Nombre FROM area ORDER BY Nombre";
            MySqlConnection connectionBD = Connection.connection();
            connectionBD.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                MySqlDataAdapter data = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                data.Fill(dataTable);

                cmbSelectAreaAd.ValueMember = "IDarea";
                cmbSelectAreaAd.DisplayMember = "Nombre";
                cmbSelectAreaAd.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar áreas" + ex.Message);
            }
            finally
            {
                connectionBD.Close();
            }
        }

        private void LoadCourseAd()
        {
            cmbSelectCourseAd.DataSource = null;
            cmbSelectCourseAd.Items.Clear();
            int idArea = int.Parse(cmbSelectAreaAd.SelectedValue.ToString());

            string sql = "SELECT IDcurso,Nombre FROM curso WHERE IDarea='"+idArea+"' ORDER BY Nombre";
            MySqlConnection connectionBD = Connection.connection();
            connectionBD.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                MySqlDataAdapter data = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                data.Fill(dataTable);

                cmbSelectCourseAd.ValueMember = "IDcurso";
                cmbSelectCourseAd.DisplayMember = "Nombre";
                cmbSelectCourseAd.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los cursos" + ex.Message);
            }
            finally
            {
                connectionBD.Close();
            }
        }

        private void ShowNumberAd()
        {
            MySqlDataReader reader = null;
            string sql = "SELECT MAX(IDaviso)+1 FROM aviso";
            MySqlConnection connectionBD = Connection.connection();
                connectionBD.Open();
                try
                {
                    MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        try
                        {
                            txtbAdNumber.Text = reader.GetString(0);
                            idAd = int.Parse(txtbAdNumber.Text);
                        }
                        catch (Exception)
                        {

                            txtbAdNumber.Text = "1";
                            idAd = int.Parse(txtbAdNumber.Text);
                        }
                            
                    }
                }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al cargar los avisos " + ex.Message);
                }
            finally
            {
                connectionBD.Close();
            }
        }

        private void Clean()
        {
            cmbSelectAreaAd.Text = "";
            cmbSelectCourseAd.Text = "";
            rtbDescriptionAd.Text = "";
            dtpDateAd.Value = DateTime.Now;
            dtpDateAd.Format = DateTimePickerFormat.Custom;
            dtpDateAd.CustomFormat = "yyyy/MM/dd";
            ShowNumberAd();
        }
        private void CloseWindow()
        {
            Menu Frm = new Menu();
            Frm.Show();
            this.Close();
        }

        private void cmbSelectAreaAd_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadCourseAd();
        }

        private void bttnEmailSent_Click(object sender, EventArgs e)
        {
            Menu.action = 6;
            PersonReg Frm = new PersonReg();
            Frm.Show();
        }
    }
}
