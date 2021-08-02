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
using System.IO;
using System.Diagnostics;
using System.Security;

namespace CECLdb
{
    public partial class PersonReg : Form
    {
        public static int type = 0;
        public int amountSelected = 0;

        public int PerID;

        public int amountPerson = 0;
        public int idPerson = 0;
        public List<int> selectedIDList= new List<int>();

        //opción 1 agregar, 2 modificar, 3 eliminar, 4 viene de registro, 5 viene de inscripción,6 viene de de aviso
        public PersonReg()
        {
            InitializeComponent();
            if (Menu.action >=2 && Menu.action<=6)
            {
                LoadTypeSearch();
                bttnAddPerson.Visible = false;
                bttnSearchPerson.Visible = true;
                bttnImportPerson.Visible = false;
                dgvPersonReg.Visible = true;
                txtTextSearch.Visible = true;
                cmbTypeSearch.Visible = true;
                lblModify.Visible = false;
                bttnViewSelectedPerson.Visible = true;
                bttnViewSelectedPerson.Location = new Point(762, 513);
                if (Menu.action>=3 && Menu.action<=6)
                {
                    this.Height = 169;
                    HideAndMove();
                }
            }
            if (Menu.action == 1)
            {
                lblDataPerson.Visible = true;
                this.Height = 367;
                btnSaveData.Visible = false;
                btnClean.Location = new Point(739,273);
                btnClean.Visible = true;
            }
            if (Menu.action == 2)
            {
                lblModify.Visible = true;
                this.Height = 440;
                Modifybtn.Visible = true;
                lblModify.Visible = true;
                Deletebtn.Visible = false;
                bttnSelectPerson.Visible = false;
                btnSaveData.Visible = true;
                btnClean.Visible = true;
                btnSaveData.Visible = true;
            }
            if (Menu.action == 3)
            {
                SelectAllcbx.Visible = true;
                Modifybtn.Visible = false;
                Deletebtn.Visible = true;
                Deletebtn.Location = new Point(459, 513);
                bttnSelectPerson.Visible = false;
                btnSaveData.Visible = false;
                btnClean.Visible = false;
            }
            if (Menu.action == 4||Menu.action==5)
            {
                Modifybtn.Visible = false;
                Deletebtn.Visible = false;
                bttnSelectPerson.Visible = true;
                bttnSelectPerson.Location = new Point(459, 513);
                btnSaveData.Visible = false;
            }
            if (Menu.action==6)
            {
                SelectAllcbx.Visible = true;
                Modifybtn.Visible = false;
                Deletebtn.Visible = false;
                bttnSelectPerson.Visible = false;
                btnSaveData.Visible = false;
                bttnSentEmail.Visible = true;
                bttnSentEmail.Location = new Point(403,513) ;
                bttnViewSelectedPerson.Location = new Point(762, 513);
            }
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
            if (txtbNamePerson.Text != "" && txtbLastNamePerson.Text != "" && txtEmailPerson.Text != "")
            {
                if (txtbCodePerson.TextLength == 7)
                {
                    if (txtbTelephone.TextLength>=8 || txtbTelephone.TextLength<=9)
                    {
                        String personName = txtbNamePerson.Text;
                        String personLastName = txtbLastNamePerson.Text;
                        String personEmail = txtEmailPerson.Text;
                        int codePerson = int.Parse(txtbCodePerson.Text);
                        int personNumber = int.Parse(txtbTelephone.Text);

                        string sql = "INSERT INTO Persona (Nombre,Apellido,Correo,codigo,Teléfono) VALUES" +
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
        private void bttnImportPerson_Click(object sender, EventArgs e)
        {
            int linesCount = 0;
            MessageBox.Show("El formato para el archivo .csv es:\n CÓDIGO (long. 7), NOMBRE, APELLIDO, CORREO, TELÉFONO");

            OpenFileDialog window = new OpenFileDialog();
            window.Title = "Importar archivo (.txt, .csv)";
            window.Filter = "Text files (*.Csv)|*.csv|(*.txt)|*.txt";
            if (window.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(window.FileName);
                MySqlConnection connectionBD = Connection.connection();
                connectionBD.Open();
                try
                {
                    String[] lines = File.ReadAllLines(window.FileName);
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (lines[i] != "")
                        {
                            String[] lineConverted = lines[i].Split(";");

                            string sql = "INSERT INTO Persona (codigo,Nombre,Apellido,Correo,Teléfono) VALUES" +
                        "('" + lineConverted[0] + "','" + lineConverted[1] + "','" + lineConverted[2] + "'," +
                        "'" + lineConverted[3] + "','" + lineConverted[4] + "')";

                            if (lineConverted.Length == 5)
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
        private void bttnSentEmail_Click(object sender, EventArgs e)
        {
            int saveId = 0;
            //int saveId = 0;
            if (amountSelected == 0)
            {
                MessageBox.Show("No se ha seleccionado a alguna persona");
            }
            if (amountSelected >= 1)
            {
                for (int i = 0; i < selectedIDList.Count; i++)
                {
                    saveId=int.Parse(selectedIDList[i].ToString());
                    string sql = "INSERT INTO correoenviado (IDaviso,IDpersona) VALUES" +
                            "('" + AdReg.idAd + "','"  + saveId + "')";

                    MySqlConnection connectionBD = Connection.connection();
                    connectionBD.Open();
                    try
                    {
                        MySqlCommand command = new MySqlCommand(sql, connectionBD);
                        command.ExecuteNonQuery();
                        if (i==selectedIDList.Count-1)
                        {
                            MessageBox.Show("Se ha registrado exitosamente");
                            Clean();
                        }
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
            }
            this.Close();
        }
        private void bttnViewSelectedPerson_Click(object sender, EventArgs e)
        {
            if (amountSelected == 0)
            {
                MessageBox.Show("No se ha seleccionado a alguna persona");
            }
            else if (amountSelected>=1)
            {
                LoadTableSelectedPerson(selectedIDList);
            }
        }
        private void bttnSearchPerson_Click(object sender, EventArgs e)
        {
            amountSelected = 0;
            consultationAmount();
            if (amountPerson > 0)
            {
                LoadTableCode(null);
                if (Menu.action>=3 && Menu.action<=6)
                {

                    this.Height = 615;
                }
                if (Menu.action == 2)
                {
                    this.Height = 875;
                    bttnReturnPerson.Location = new Point(496, 787);
                    bttnViewSelectedPerson.Location = new Point(618, 787);
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
            else
            {
                MessageBox.Show("No se encuentran personas registradas");
            }

        }
        private void LoadTypeSearch()
        {
            cmbTypeSearch.DisplayMember = "Text";
            cmbTypeSearch.ValueMember = "Value";
            cmbTypeSearch.SelectedIndex = cmbTypeSearch.Items.IndexOf("Correo");

            cmbTypeSearch.Items.Add(new { Text = "Código", Value = 1 });
            cmbTypeSearch.Items.Add(new { Text = "Correo", Value = 2 });
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
            bttnReturnPerson.Location = new Point(618, 513);
            Modifybtn.Location = new Point(285, 513);
            Deletebtn.Location = new Point(408, 513);
            bttnSelectPerson.Location = new Point(533, 513);
        }
        //CAMBIAR ENSEÑAR EL APELLIDO
        private void LoadTableCode(string date)
        {
            List<Person> list = new List<Person>();
            CtrlPerson person = new CtrlPerson();
            dgvPersonReg.DataSource = person.consultationCode(date);
            validateSelection();

            if (dgvPersonReg.Rows.Count > 0)
            {
                try
                {
                    this.dgvPersonReg.Columns["IdPerson"].Visible = false;
                    this.dgvPersonReg.Columns["LastName"].Visible = false;
                }
                catch (MySqlException)
                {
                    MessageBox.Show("No se ha encontrado coincidencias");
                    LoadTableCode(null);
                }
            }
            else
            {
                MessageBox.Show("No se han encontrado datos");
                LoadTableCode(null);
            }
        }
        private void LoadTableEmail(string date)
        {
            List<Person> list = new List<Person>();
            CtrlPerson person = new CtrlPerson();
            dgvPersonReg.DataSource = person.consultationEmail(date);
            validateSelection();

            if (dgvPersonReg.Rows.Count > 0)
            {
                try
                {
                    this.dgvPersonReg.Columns["IdPerson"].Visible = false;
                    this.dgvPersonReg.Columns["LastName"].Visible = false;
                }
                catch (MySqlException)
                {
                    MessageBox.Show("No se ha encontrado coincidencias");
                    LoadTableEmail(null);
                }
            }
            else
            {
                MessageBox.Show("No se han encontrado datos");
                LoadTableEmail(null);
            }
        }
        private void LoadTableName(string date)
        {
            List<Person> list = new List<Person>();
            CtrlPerson person = new CtrlPerson();
            dgvPersonReg.DataSource = person.consultationName(date);
            validateSelection();

            DataGridViewCheckBoxColumn CheckboxColumn = new DataGridViewCheckBoxColumn();
            if (dgvPersonReg.Rows.Count > 0)
            {
                try
                {
                    this.dgvPersonReg.Columns["IdPerson"].Visible = false;
                    this.dgvPersonReg.Columns["LastName"].Visible = false;
                }
                catch (MySqlException)
                {
                    MessageBox.Show("No se ha encontrado coincidencias");
                    LoadTableName(null);
                }
            }
            else
            {
                MessageBox.Show("No se han encontrado datos");
                LoadTableName(null);
            }
        }
        private void LoadTableSelectedPerson(List<int> personSelected)
        {
            amountSelected = 0;
            List<object> listToShow = new List<object>();
            CtrlPerson person = new CtrlPerson();
            int sentID = 0;
            for (int i = 0; i < personSelected.Count; i++)
            {
                sentID=int.Parse(personSelected[i].ToString());
                person.SelectedEmailSent(sentID);
                //listToShow.Add();
            }
            dgvPersonReg.DataSource =person.listSelected;
            validateSelection();

            if (dgvPersonReg.Rows.Count > 0)
            {
                try
                {
                    this.dgvPersonReg.Columns["IdPerson"].Visible = false;
                    this.dgvPersonReg.Columns["LastName"].Visible = false;
                }
                catch (MySqlException)
                {
                    MessageBox.Show("No se ha seleccionado a alguna persona");
                    LoadTableCode(null);
                }
            }
            else
            {
                MessageBox.Show("No se han seleccionado datos");
                LoadTableSelectedPerson(null);
            }
        }
        private void dgvPersonReg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idPerson = int.Parse(dgvPersonReg.CurrentRow.Cells["IdPerson"].Value.ToString());
            if (dgvPersonReg.CurrentRow.Cells["CheckSelection"].Value != null && (bool)dgvPersonReg.CurrentRow.Cells["CheckSelection"].Value)
            {
                dgvPersonReg.CurrentRow.Cells["CheckSelection"].Value = false;
                dgvPersonReg.CurrentRow.Cells["CheckSelection"].Value = null;
                amountSelected += -1;
                selectedIDList.Remove(idPerson);
            }
            else if (dgvPersonReg.CurrentRow.Cells["CheckSelection"].Value == null)
            {
                dgvPersonReg.CurrentRow.Cells["CheckSelection"].Value = true;
                amountSelected += 1;
                selectedIDList.Add(idPerson);
            }
        }

        private void bttnSelectPerson_Click(object sender, EventArgs e)
        {
            if (amountSelected == 0)
            {
                MessageBox.Show("No se ha seleccionado a alguna persona");
            }
            if (amountSelected == 1)
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
                    }
                }
            }

            if (amountSelected > 1)
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
                        string codePerson = txtbCodePerson.Text;
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

        public void consultationAmount()
        {
            string sql = "SELECT COUNT(IDpersona) FROM persona ";
            MySqlConnection connectionBD = Connection.connection();
            connectionBD.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                command.Parameters.AddWithValue(sql, amountPerson);
                command.ExecuteNonQuery();
                amountPerson = int.Parse(command.ExecuteScalar().ToString());
            }
            catch (MySqlException)
            {
                MessageBox.Show("No hay personas ingresadas ");
            }
            finally
            {
                connectionBD.Close();
            }
        }
        public void validateSelection()
        {
            foreach (DataGridViewRow row in dgvPersonReg.Rows)
            {
                for (int i = 0; i < selectedIDList.Count; i++)
                {
                    if (selectedIDList[i].Equals(row.Cells["idPerson"].Value))
                    {
                        row.Cells["CheckSelection"].Value = true;
                    }
                }
            }
            amountSelected = selectedIDList.Count;
        }
        private void CloseWindow()
        {
            if (Menu.action>=1 && Menu.action<=3)
            {
                Menu Frm = new Menu();
                Frm.Show();
                this.Close();
            }
            if (Menu.action >= 4 && Menu.action <= 6)
            {
                this.Close();
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

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            int saveId = 0;
            if (amountSelected == 0)
            {
                MessageBox.Show("No se ha seleccionado a ninguna persona");
            }
            if (amountSelected >= 1)
            {
                DialogResult dialogResult = MessageBox.Show("¿Deseas eliminar las personas seleccionadas de la base de datos? (Puedes revisar tu selección al presionar el botón 'Ver Seleccionados')", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    for (int i = 0; i < selectedIDList.Count; i++)
                    {
                        saveId = int.Parse(selectedIDList[i].ToString());
                        string sql = "DELETE FROM persona WHERE IDpersona =" + saveId;

                        MySqlConnection connectionBD = Connection.connection();
                        connectionBD.Open();
                        try
                        {
                            MySqlCommand command = new MySqlCommand(sql, connectionBD);
                            command.ExecuteNonQuery();
                            if (i == selectedIDList.Count - 1)
                            {
                                MessageBox.Show("Se ha eliminado exitosamente");
                                Clean();
                            }
                        }
                        catch (MySqlException ex)
                        {

                            MessageBox.Show("Error al eliminar: " + ex.Message);
                        }
                        finally
                        {
                            connectionBD.Close();
                        }
                    }
                }
            }
        }

        private void SelectAllcbx_CheckedChanged(object sender, EventArgs e)
        {
            amountSelected = 0;
            selectedIDList.Clear();
            if (SelectAllcbx.Checked)
            {
                foreach (DataGridViewRow Fila in dgvPersonReg.Rows)
                {
                    Fila.Cells[0].Value = true;
                    amountSelected++;
                    selectedIDList.Add(Convert.ToInt32(Fila.Cells[1].Value));
                }
            }
            else
            {
                foreach (DataGridViewRow Fila in dgvPersonReg.Rows)
                {
                    Fila.Cells[0].Value = false;
                }
            }
        }
    }
}
