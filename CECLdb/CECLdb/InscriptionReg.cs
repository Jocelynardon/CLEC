using CLEC;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CECLdb
{
    public partial class InscriptionReg : Form, AddID
    {
        int winOrLose;
        public InscriptionReg()
        {
            InitializeComponent();

            LoadAreaInscription();
            if (Menu.action==2)
            {
                txtbPersonIDInscription.ReadOnly = false;
                txtbPersonIDInscription.Enabled = true;
                bttnAddInscription.Visible = false;
                bttnSaveInscription.Visible = true;
                bttnImportInscription.Visible = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbApproved.Checked)
            {
                winOrLose =1;
            }
            else
            {
                winOrLose =0;
            }
        }
        private void bttnAddInscription_Click(object sender, EventArgs e)
        {
            int idArea = int.Parse(cmbSelectAreaInscription.SelectedValue.ToString());
            int idCourse = int.Parse(cmbSelectCourseInscription.SelectedValue.ToString());
            int idPerson = int.Parse(txtbPersonIDInscription.Text);

            string sql = "INSERT INTO inscripcion (IDarea,IDcurso,IDpersona,FechaInicio,FechaFin,Aprobo) VALUES ('" + idArea + "'," +
                "'" + idCourse + "','" + idPerson + "','" + mtbStartDate.Text + "','" + mtbFinalDate.Text + "','" + winOrLose + "')";
            MySqlConnection connectionBD = Connection.connection();
            connectionBD.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                command.ExecuteNonQuery();
                MessageBox.Show("Registro correctamente agregado");
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
        private void bttnReturnInscription_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }
        private void bttnSearchInscription_Click(object sender, EventArgs e)
        {
            Menu.action = 5;
            PersonReg frmAdd = new PersonReg();
            frmAdd.Show(this);
        }

        private void Access(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                CloseWindow();
            }
        }
        private void LoadAreaInscription()
        {
            cmbSelectAreaInscription.DataSource = null;
            cmbSelectAreaInscription.Items.Clear();
            string sql = "SELECT IDarea,Nombre FROM area ORDER BY Nombre";
            MySqlConnection connectionBD = Connection.connection();
            connectionBD.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                MySqlDataAdapter data = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                data.Fill(dataTable);

                cmbSelectAreaInscription.ValueMember = "IDarea";
                cmbSelectAreaInscription.DisplayMember = "Nombre";
                cmbSelectAreaInscription.DataSource = dataTable;
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
        private void LoadCourseInscription()
        {
            cmbSelectCourseInscription.DataSource = null;
            cmbSelectCourseInscription.Items.Clear();
            int idArea = int.Parse(cmbSelectAreaInscription.SelectedValue.ToString());

            string sql = "SELECT IDcurso,Nombre FROM curso WHERE IDarea='" + idArea + "' ORDER BY Nombre";
            MySqlConnection connectionBD = Connection.connection();
            connectionBD.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                MySqlDataAdapter data = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                data.Fill(dataTable);

                cmbSelectCourseInscription.ValueMember = "IDcurso";
                cmbSelectCourseInscription.DisplayMember = "Nombre";
                cmbSelectCourseInscription.DataSource = dataTable;
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

        private void CloseWindow()
        {
            Menu Frm = new Menu();
            Frm.Show();
            this.Close();
        }

        private void cmbSelectAreaInscription_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadCourseInscription();
        }

        #region AddID data
        public void AddNewItem(DataGridViewCell row)
        {
            string idPersonChoosen = row.Value.ToString();
            this.txtbPersonIDInscription.Text = idPersonChoosen;
        }
        #endregion
        private void Clean()
        {
            cmbSelectAreaInscription.Text = "";
            cmbSelectCourseInscription.Text = "";
            txtbPersonIDInscription.Text = "";
            ckbApproved.Checked = false;
            mtbStartDate.Text = "";
            mtbFinalDate.Text = "";
        }

        private void bttnImportInscription_Click(object sender, EventArgs e)
        {
            int linesCount = 0;
            MessageBox.Show("El formato para el archivo .csv es:\n ID AREA, ID CURSO , ID PERSONA,\n FECHA DE INICIO (AÑO/MES/DÍA)," +
                "FECHA DE FIN (AÑO/MES/DÍA), APROBO EL CURSO (1=SI ; 0=NO)");

            OpenFileDialog window = new OpenFileDialog();
            window.Title = "Importar archivo (.txt, .csv)";
            window.Filter = "Text files (*.Csv)|*.csv|(*.txt)|*.txt";

            if (window.ShowDialog() == DialogResult.OK)
            {
                MySqlConnection connectionBD = Connection.connection();
                connectionBD.Open();
                try
                {
                    String[] lines = File.ReadAllLines(window.FileName);

                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (lines[i] != "")
                        {
                            String[] lineConverted = lines[i].Split(",");

                            string sql = "INSERT INTO inscripcion (IDarea,IDcurso,IDpersona,FechaInicio,FechaFin,Aprobo) VALUES" +
                        "('" + lineConverted[0] + "','" + lineConverted[1] + "','" + lineConverted[2] + "'," +
                        "'" + lineConverted[3] + "','" + lineConverted[4] + "','" + lineConverted[5] + "')";

                            if (lineConverted.Length == 6)
                            {
                                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                                command.ExecuteNonQuery();
                                if (i == lines.Length - 1)
                                {
                                    MessageBox.Show("Se ha insertado exitosamente");
                                    Clean();
                                }
                            }
                            else
                            {
                                MessageBox.Show("No tiene la cantidad de datos indicado");
                            }
                        }
                        else
                        {
                            linesCount++;
                            if (linesCount == lines.Length)
                            {
                                MessageBox.Show("El archivo se encuentra vacío");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar: Revise los datos ingresados \n" + ex.Message);
                }
                finally
                {
                    connectionBD.Close();
                }
            }
        }
    }
}
