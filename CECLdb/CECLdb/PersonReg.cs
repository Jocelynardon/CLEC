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
        public static int _action = 0;
        public PersonReg()
        {
            InitializeComponent();
            _action = Menu.action;
            if (Menu.action==1)
            {
               this.Height = 367;
                dgvPersonReg.Visible = false;
            }
            if (Menu.action==2||Menu.action==3)
            {
                this.Height = 367;
                bttnAddPerson.Visible = false;
                bttnSearchPerson.Visible = true;
                bttnImportPerson.Visible = false;
                dgvPersonReg.Visible = true;
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
            if (txtbNamePerson.Text!="" && txtbLastNamePerson.Text != "" && txtEmailPerson.Text != ""
                && txtbCodePerson.Text != "" && mtbTelephonPerson.Text != "")
            {
                String personName = txtbNamePerson.Text;
                String personLastName = txtbLastNamePerson.Text;
                String personEmail = txtEmailPerson.Text;
                int codePerson = int.Parse(txtbCodePerson.Text);
                int personNumber = int.Parse(mtbTelephonPerson.Text);

                string sql = "INSERT INTO Persona (Nombre,Apellido,Correo,Codigo,Teléfono) VALUES" +
                    "('" + personName + "','" + personLastName + "','" + personEmail + "'," +
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
                MessageBox.Show("Por favor, complete la información");
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

        private void bttnSearchPerson_Click(object sender, EventArgs e)
        {
            this.Height = 779;

        }
    }
}
