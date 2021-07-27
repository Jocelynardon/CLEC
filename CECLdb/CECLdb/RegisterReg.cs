﻿using CLEC;
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
        //Opción 1 agregar, opción 2 modificar, opción 3 eliminar
        public static int _action = 0;
        public RegisterReg()
        {
            InitializeComponent();
            _action = Menu.action;
            LoadAreaRegister();
            txtbPersonIDRegister.Text = Convert.ToString(PersonReg.getIdPerson);
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
            CloseWindow();
        }

        private void Access(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                CloseWindow();
            }
        }

        private void bttnSearchRegister_Click(object sender, EventArgs e)
        {
            Menu.action = 4;
            PersonReg Frm = new PersonReg();
            Frm.Show();
        }
        private void CloseWindow()
        {
            Menu Frm = new Menu();
            Frm.Show();
            this.Close();
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

        private void bttnAddRegister_Click(object sender, EventArgs e)
        {
            if (cmbSelectAreaRegister.Text!="")
            {
                if (cmbSelectCourseRegister.Text!="")
                {
                    if (dtpConsultationDateRegister.Text!="")
                    {
                        if (txtbPersonIDRegister.Text!="" || txtbPersonIDRegister.Text!="0")
                        {
                            int idArea = int.Parse(cmbSelectAreaRegister.SelectedValue.ToString());
                            int idCourse = int.Parse(cmbSelectCourseRegister.SelectedValue.ToString());
                            int idPerson = PersonReg.getIdPerson;

                            string sql = "INSERT INTO registro (IDarea,IDcurso,FechaConsulta,IDpersona) VALUES ('" + idArea + "'," +
                                "'" + idCourse + "','" + dtpConsultationDateRegister.Text + "','" + idPerson + "')";
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
                        else
                        {
                            MessageBox.Show("Ingrese el ID de la persona");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una fecha");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione el curso al que pertenece");
                }
            }
            else
            {
                MessageBox.Show("Seleccione el área al que pertenece");
            }
        }
        private void Clean()
        {
            cmbSelectAreaRegister.Text = "";
            cmbSelectCourseRegister.Text = "";
            dtpConsultationDateRegister.Value = DateTime.Now;
            dtpConsultationDateRegister.Format = DateTimePickerFormat.Custom;
            dtpConsultationDateRegister.CustomFormat = "yyyy/MM/dd";
            txtbPersonIDRegister.Text = "";
        }
    }
}
