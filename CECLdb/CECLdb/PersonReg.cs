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
    public partial class PersonReg : Form
    {
        public PersonReg()
        {
            InitializeComponent();
            if (Menu.action==2)
            {
                bttnAddPerson.Visible = false;
                bttnSavePerson.Visible = true;
                bttnSearchPerson.Visible = true;
                bttnImportPerson.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttnReturnPerson_Click(object sender, EventArgs e)
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

        private void bttnAddPerson_Click(object sender, EventArgs e)
        {
            String personName = txtbNamePerson.Text;
            String personLastName = txtbLastNamePerson.Text;
            String personEmail = txtEmailPerson.Text;
            int codePerson = int.Parse(txtbCodePerson.Text);
            int personNumber = int.Parse(mtbTelephonPerson.Text);

            string sql = "INSERT INTO Persona (Nombre,Apellido,Correo,Codigo,Teléfono) VALUES" +
                "('"+personName+ "','" + personLastName + "','" + personEmail + "'," +
                "'" + codePerson + "','" + personNumber + "')";

            MySqlConnection connectionBD = Connection.connection();
            connectionBD.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                command.ExecuteNonQuery();
                MessageBox.Show("Se ha insertado exitosamente");
                Clean();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al guardar: " + ex.Message);
            }
            finally 
            {
                connectionBD.Close();
            }
        }

        private void Clean()
        {
            txtbCodePerson.Text = "";
            txtbLastNamePerson.Text = "";
            txtbNamePerson.Text = "";
            txtEmailPerson.Text = "";
            mtbTelephonPerson.Text = "";
        }
        private void PersonReg_Load(object sender, EventArgs e)
        {
            
        }
    }
}
