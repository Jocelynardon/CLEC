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
    public partial class AreaReg : Form
    {
        public AreaReg()
        {
            InitializeComponent();
            if (Menu.action == 2)
            {
                bttnSaveArea.Visible = true;
                bttnAddArea.Visible = false;
                bttnSearchArea.Visible = true;
            }
            FullCombobox();
        }


        private void lblAreaName_Click(object sender, EventArgs e)
        {

        }

        private void bttnReturnArea_Click(object sender, EventArgs e)
        {
            Menu Frm = new Menu();
            Frm.Show();
            this.Close();
        }

        private void AreaReg_Load(object sender, EventArgs e)
        {
        }

        private void Exit(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Menu Frm = new Menu();
                Frm.Show();
                this.Close();
            }
        }

        private void bttnAddArea_Click(object sender, EventArgs e)
        {
            if (cmbAnnouncement.Text!=null && cmbYear.Text!=null && txtbAreaName.Text!="")
            {
                int yearArea = int.Parse(cmbYear.Text);
                int convocatoryArea = int.Parse(cmbAnnouncement.Text);
                String nameArea = txtbAreaName.Text;
                if (yearArea > 2010 && yearArea < 2999)
                {
                    if (convocatoryArea > 0 && convocatoryArea < 10)
                    {
                        string sql = "INSERT INTO Area (Año,Convocatoria,Nombre) VALUES" +
                    "('" + yearArea + "','" + convocatoryArea + "','" + nameArea + "')";

                        MySqlConnection connectionBD = Connection.connection();
                        connectionBD.Open();
                        try
                        {
                            MySqlCommand command = new MySqlCommand(sql, connectionBD);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Se ha insertado exitosamente");
                            Clean();
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Error al guardar: " + ex.Message);
                        }
                        finally
                        {
                            connectionBD.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione la convocatoria");
                    }
                }
                else
                {
                    MessageBox.Show("El año debe ser 2010 en adelante");
                }
            }
            else
            {
                MessageBox.Show("Por favor, Ingrese la información solicitada");
            }
        }
        private void FullCombobox()
        {
            //Años
            cmbYear.Items.Add("2017");
            cmbYear.Items.Add("2018");
            cmbYear.Items.Add("2019");
            cmbYear.Items.Add("2020");
            cmbYear.Items.Add("2021");
            cmbYear.Items.Add("2022");
            cmbYear.Items.Add("2023");
            cmbYear.Items.Add("2024");
            cmbYear.Items.Add("2025");
            cmbYear.Items.Add("2026");
            cmbYear.Items.Add("2027");
            cmbYear.Items.Add("2028");
            cmbYear.Items.Add("2029");
            cmbYear.Items.Add("2030");
            //Convocatoria
            cmbAnnouncement.Items.Add("1");
            cmbAnnouncement.Items.Add("2");
            cmbAnnouncement.Items.Add("3");
        }
        private void Clean()
        {
            cmbYear.Text="";
            cmbAnnouncement.Text="";
            txtbAreaName.Text = "";
        }
    }
}
