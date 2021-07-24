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
    public partial class RegisterReg : Form
    {
        public RegisterReg()
        {
            InitializeComponent();
            LoadAreaRegister();
            if (Menu.action==2)
            {
                txtbPersonIDRegister.Enabled = true;
                txtbPersonIDRegister.ReadOnly = false;
                bttnAddRegister.Visible = false;
                bttnSaveRegister.Visible = true;
                bttnSearchRegister.Visible = true;
                bttnImportRegister.Visible = false;
            }
        }

        private void bttnReturnRegister_Click(object sender, EventArgs e)
        {
            Menu Frm = new Menu();
            Frm.Show();
            this.Close();
        }

        private void Access(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Menu Frm = new Menu();
                Frm.Show();
                this.Close();
            }
        }

        private void bttnSearchRegister_Click(object sender, EventArgs e)
        {
            PersonReg Frm = new PersonReg();
            Frm.Show();
        }

        private void LoadAreaRegister()
        {
            cmbSelectAreaRegister.DataSource = null;
            cmbSelectAreaRegister.Items.Clear();
            string sql = "SELECT IDarea,Nombre FROM area ORDER BY Nombre";
            MySqlConnection connectionBD = Connection.connection();
            connectionBD.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                MySqlDataAdapter data = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                data.Fill(dataTable);

                cmbSelectAreaRegister.ValueMember = "IDarea";
                cmbSelectAreaRegister.DisplayMember = "Nombre";
                cmbSelectAreaRegister.DataSource = dataTable;
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

        private void LoadCourseRegister()
        {
            cmbSelectCourseRegister.DataSource = null;
            cmbSelectCourseRegister.Items.Clear();
            int idArea = int.Parse(cmbSelectAreaRegister.SelectedValue.ToString());

            string sql = "SELECT IDcurso,Nombre FROM curso WHERE IDarea='" + idArea + "' ORDER BY Nombre";
            MySqlConnection connectionBD = Connection.connection();
            connectionBD.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                MySqlDataAdapter data = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                data.Fill(dataTable);

                cmbSelectCourseRegister.ValueMember = "IDcurso";
                cmbSelectCourseRegister.DisplayMember = "Nombre";
                cmbSelectCourseRegister.DataSource = dataTable;
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
        private void cmbSelectAreaInscription_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadCourseRegister();
        }
    }
}
