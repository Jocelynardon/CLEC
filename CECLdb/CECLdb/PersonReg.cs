using CLEC;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CECLdb;
namespace CECLdb
{
    public partial class PersonReg : Form
    {
        public static int type = 0;
        public int amountSelected = 0;
        public int PerID;
        public PersonReg()
        {
            //opción 1 agregar, 2 modificar, 3 eliminar, 4 viene de registro
            InitializeComponent();
            if (Menu.action==2||Menu.action==3 || Menu.action==4)
            {
                LoadTypeSearch();
                bttnAddPerson.Visible = false;
                bttnSearchPerson.Visible = true;
                bttnImportPerson.Visible = false;
                dgvPersonReg.Visible = true;
                txtTextSearch.Visible = true;
                cmbTypeSearch.Visible = true;
                lblModify.Visible = false;
                if (Menu.action==3 || Menu.action==4)
                {
                    this.Height = 169;
                    HideAndMove();
                }
            }
            if (Menu.action == 1)
            {
                this.Height = 367;
                btnSaveData.Visible = false;
            }
            if (Menu.action == 2)
            {
                this.Height = 440;
                Modifybtn.Visible = true;
                lblModify.Visible = true;
                Deletebtn.Visible = false;
                bttnSelectPerson.Visible = false;
                btnSaveData.Visible = true;
            }
            if (Menu.action==3)
            {
                SelectAllcbx.Visible = true;
                Modifybtn.Visible = false;
                Deletebtn.Visible = true;
                bttnSelectPerson.Visible = false;
                btnSaveData.Visible = false;
            }
            if (Menu.action==4)
            {
                Modifybtn.Visible = false;
                Deletebtn.Visible = false;
                bttnSelectPerson.Visible = true;
                btnSaveData.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttnReturnPerson_Click(object sender, EventArgs e)
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

        private void bttnAddPerson_Click(object sender, EventArgs e)
        {
            if (txtbNamePerson.Text!="" && txtbLastNamePerson.Text != "" && txtEmailPerson.Text != "")
            {
                if (txtbCodePerson.TextLength==7)
                {
                    if (txtbTelephone.TextLength>=8 || txtbTelephone.TextLength<=9)
                    {
                        String personName = txtbNamePerson.Text;
                        String personLastName = txtbLastNamePerson.Text;
                        String personEmail = txtEmailPerson.Text;
                        int codePerson = int.Parse(txtbCodePerson.Text);
                        int personNumber = int.Parse(txtbTelephone.Text);

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
                        MessageBox.Show("El teléfono debe tener 8 o 9 dígitos");
                    }
                }
                else
                {
                    MessageBox.Show("El código debe tener 7 dígitos");
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
            txtbTelephone.Text = "";
            amountSelected = 0;
        }
        private void CloseWindow()
        {
            if (Menu.action == 1 || Menu.action == 2 || Menu.action == 3)
            {
                Menu Frm = new Menu();
                Frm.Show();
                this.Close();
            }
            if (Menu.action == 4)
            {
                this.Close();
            }
        }


        private void bttnSearchPerson_Click(object sender, EventArgs e)
        {
            LoadTableCode(null);
            if (Menu.action==3 || Menu.action==4)
            {

                this.Height = 615;
            }
            if (Menu.action==2)
            {
                this.Height = 875;
                bttnReturnPerson.Location = new Point(496, 787);
            }
            String textSearch = txtTextSearch.Text;

            switch (cmbTypeSearch.SelectedIndex)
            {
                //0 Código, 1 Correo, 2 Nombre
                case 0:
                    LoadTableCode(textSearch);
                    break;
                case 1:
                    LoadTableEmail(textSearch);
                    break;
                case 2:
                    LoadTableName(textSearch);
                    break;
                default:
                    MessageBox.Show("Seleccione una de las opciones por las que desea buscar");
                    cmbTypeSearch.Text = "";
                    break;
            }
        }
        private void LoadTypeSearch()
        {
            cmbTypeSearch.DisplayMember = "Text";
            cmbTypeSearch.ValueMember = "Value";
            cmbTypeSearch.SelectedIndex = cmbTypeSearch.Items.IndexOf("Correo");

            cmbTypeSearch.Items.Add(new { Text = "Código", Value = 1 });
            cmbTypeSearch.Items.Add(new { Text="Correo",Value=2});
            cmbTypeSearch.Items.Add(new { Text = "Nombre", Value = 3 });
            cmbTypeSearch.SelectedIndex = 0;
        }
        private void HideAndMove()
        {
            txtbNamePerson.Visible = false;
            txtbLastNamePerson.Visible = false;
            txtbCodePerson.Visible = false;
            txtbTelephone.Visible = false;
            txtEmailPerson.Visible = false;
            lblName.Visible = false;
            lblLastNamePerson.Visible = false;
            lblTelNumber.Visible = false;
            lblEmail.Visible = false;
            lblCodePerson.Visible = false;
            txtTextSearch.Location = new Point(46, 76);
            cmbTypeSearch.Location = new Point(517, 76);
            bttnSearchPerson.Location = new Point(811, 76);
            SelectAllcbx.Location = new Point(46, 133);
            dgvPersonReg.Location = new Point(46, 174);
            bttnReturnPerson.Location = new Point(660,513);
            Modifybtn.Location = new Point(285, 513);
            Deletebtn.Location = new Point(408, 513);
            bttnSelectPerson.Location = new Point(533, 513);
        }
        private void LoadTableCode(string date)
        {
            List<Person> list = new List<Person>();
            CtrlPerson person = new CtrlPerson();
            dgvPersonReg.DataSource = person.consultationCode(date);

            if (dgvPersonReg.Rows.Count > 0)
            {
                try
                {
                    this.dgvPersonReg.Columns["IdPerson"].Visible = false;
                }
                catch (MySqlException)
                {
                    MessageBox.Show("No se ha encontrado coincidencias");
                    LoadTableCode(null);
                }
            }
            else
            {
                MessageBox.Show("No hay datos para mostrar");
            }
        }
        private void LoadTableEmail(string date)
        {
            List<Person> list = new List<Person>();
            CtrlPerson person = new CtrlPerson();
            dgvPersonReg.DataSource = person.consultationEmail(date);
            if (dgvPersonReg.Rows.Count > 0)
            {
                try
                {
                    this.dgvPersonReg.Columns["IdPerson"].Visible = false;
                }
                catch (MySqlException)
                {
                    MessageBox.Show("No se ha encontrado coincidencias");
                    LoadTableEmail(null);
                }
            }
            else
            {
                MessageBox.Show("No hay datos para mostrar");
            }
        }
        private void LoadTableName(string date)
        {
            List<Person> list = new List<Person>();
            CtrlPerson person = new CtrlPerson();
            dgvPersonReg.DataSource = person.consultationName(date);
            DataGridViewCheckBoxColumn CheckboxColumn = new DataGridViewCheckBoxColumn();
            if (dgvPersonReg.Rows.Count>0)
            {
                try
                {
                    this.dgvPersonReg.Columns["IdPerson"].Visible = false;
                }
                catch (MySqlException)
                {
                    MessageBox.Show("No se ha encontrado coincidencias");
                    LoadTableName(null);
                }
            }
            else
            {
                MessageBox.Show("No hay datos para mostrar");
            }
        }
        private void dgvPersonReg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPersonReg.CurrentRow.Cells["CheckSelection"].Value != null && (bool)dgvPersonReg.CurrentRow.Cells["CheckSelection"].Value)
            {
                dgvPersonReg.CurrentRow.Cells["CheckSelection"].Value = false;
                dgvPersonReg.CurrentRow.Cells["CheckSelection"].Value = null;
                amountSelected += -1;
            }
            else if (dgvPersonReg.CurrentRow.Cells["CheckSelection"].Value == null)
            {
                dgvPersonReg.CurrentRow.Cells["CheckSelection"].Value = true;
                amountSelected += 1;
            }
        }

        private void bttnSelectPerson_Click(object sender, EventArgs e)
        {
            if (amountSelected==0)
            {
                MessageBox.Show("No se ha seleccionado a alguna persona");
            }
            if (amountSelected==1)
            {
                foreach (DataGridViewRow row in dgvPersonReg.Rows)
                {
                    bool isChecked = Convert.ToBoolean(row.Cells[0].Value);
                    if (isChecked)
                    {
                        DataGridViewCell choosenID = row.Cells[1];
                        AddID parent = this.Owner as AddID;
                        parent.AddNewItem(choosenID);
                        this.Close();
                    }
                }
            }
            if (amountSelected>1)
            {
                MessageBox.Show("Selecciona únicamente a 1 persona");
            }
        }

        private void Modifybtn_Click(object sender, EventArgs e)
        {
            CtrlPerson ctrl = new CtrlPerson();
            if (amountSelected==0)
            {
                MessageBox.Show("No se ha seleccionado a alguna persona");
            }
            if (amountSelected==1)
            {
                foreach (DataGridViewRow row in dgvPersonReg.Rows)
                {
                    bool isChecked = Convert.ToBoolean(row.Cells[0].Value);
                    if (isChecked)
                    {
                        PerID = Convert.ToInt32(row.Cells[1].Value);
                        Person person = ctrl.ModifyQuery(row.Cells[1].Value.ToString());
                        txtbCodePerson.Text = person.CodePerson;
                        txtbLastNamePerson.Text = person.LastName;
                        txtbNamePerson.Text = person.Name;
                        txtEmailPerson.Text = person.Email;
                        txtbTelephone.Text = person.Telephone.ToString();
                        //AddID parent = this.Owner as AddID;
                        //parent.AddNewItem(choosenID);
                        //this.Close();
                    }
                }
            }
            if (amountSelected>1)
            {
                MessageBox.Show("Selecciona únicamente a 1 persona");
            }
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            CtrlPerson ctrlP = new CtrlPerson();
            Person person_ = new Person();
            person_.IdPerson = PerID;
            if (txtbNamePerson.Text != "" && txtbLastNamePerson.Text != "" && txtEmailPerson.Text != "")
            {
                if (txtbCodePerson.TextLength == 7)
                {
                    if (txtbTelephone.TextLength >= 8 || txtbTelephone.TextLength <= 9)
                    {
                        String personName = txtbNamePerson.Text;
                        String personLastName = txtbLastNamePerson.Text;
                        String personEmail = txtEmailPerson.Text;
                        int codePerson = int.Parse(txtbCodePerson.Text);
                        int personNumber = int.Parse(txtbTelephone.Text);

                        string sql = "UPDATE persona SET Codigo = '" + codePerson + "', Nombre = '" + personName + "', Apellido = '" + personLastName + "', Correo = '" + personEmail + "', Teléfono = '" + personNumber + "' " +
                "WHERE IDpersona =" + PerID;

                        MySqlConnection connectionBD = Connection.connection();
                        connectionBD.Open();
                        try
                        {
                            MySqlCommand command = new MySqlCommand(sql, connectionBD);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Se ha modificado exitosamente");

                            
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
                        MessageBox.Show("El teléfono debe tener 8 o 9 dígitos");
                    }
                }
                else
                {
                    MessageBox.Show("El código debe tener 7 dígitos");
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete la información");
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Clean();
            
        }
    }
}
