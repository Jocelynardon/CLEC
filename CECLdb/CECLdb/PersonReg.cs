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
        public String textSearch;/*************************************************/
        public int PerID;
        public int LastSearchTypeSelected;/****************************************/
        public int amountPerson = 0;
        public int idPerson = 0;
        public List<int> selectedIDList= new List<int>();
        private bool update = false;
        char LastBtnClicked;
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
                bttnEraserText.Visible = true;
                dgvPersonReg.Visible = true;
                txtTextSearch.Visible = true;
                cmbTypeSearch.Visible = true;
                DataGBox.Text = "DATOS A MODIFICAR";
            }
            if (Menu.action == 1)
            {
                this.Height = 396;
                btnSaveData.Visible = false;
                btnClean.Visible = true;
            }
            if (Menu.action == 2)
            {
                DataGBox.Text = "DATOS A MODIFICAR";
                HideAndMove(true);
                Modifybtn.Visible = true;
                Deletebtn.Visible = false;
                bttnSelectPerson.Visible = false;
                btnSaveData.Visible = true;
                btnClean.Visible = true;
                btnSaveData.Visible = true;
            }
            if (Menu.action == 3)
            {
                HideAndMove(false);
                Modifybtn.Visible = false;
                Deletebtn.Visible = true;
                bttnSelectPerson.Visible = false;
                btnSaveData.Visible = false;
                btnClean.Visible = false;
                Deletebtn.Visible = true;/*******************/
                SelectAllcbx.Visible = true;/****************/
                DeselectAllcbx.Visible = true;/**************/
                bttnViewSelectedPerson.Visible = true;/************/
                bttnViewSelectedPerson.Visible = true;
            }
            if (Menu.action == 4||Menu.action==5)
            {
                HideAndMove(true);
                Modifybtn.Visible = false;
                Deletebtn.Visible = false;
                bttnSelectPerson.Visible = true;
                btnSaveData.Visible = false;
            }
            if (Menu.action==6)
            {
                HideAndMove(false);
                Modifybtn.Visible = false;
                Deletebtn.Visible = false;
                bttnSelectPerson.Visible = false;
                btnSaveData.Visible = false;
                bttnSentEmail.Visible = true;
                SelectAllcbx.Visible = true;/****************/
                DeselectAllcbx.Visible = true;/**************/
                bttnViewSelectedPerson.Visible = true;/************/
                bttnViewSelectedPerson.Visible = true;
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
                if (txtbTelephone.Text != "")
                {
                    String personName = txtbNamePerson.Text;
                    String personLastName = txtbLastNamePerson.Text;
                    String personEmail = txtEmailPerson.Text;
                    string personNumber = txtbTelephone.Text;

                    string sql = "INSERT INTO Persona (Nombre,Apellido,Correo,Teléfono) VALUES" +
                        "('" + personName + "','" + personLastName + "','" + personEmail + "'," +
                        "'"  + personNumber + "')";

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

                        MessageBox.Show("ERROR AL GUARDAR: " + ex.Message);
                    }
                    finally
                    {
                        connectionBD.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un número telefónico");
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
            if (!update)
            {
                SelectAllcbx.Checked = false;
                DeselectAllcbx.Checked = false;
                LastBtnClicked = 'v';
            }
            if (amountSelected == 0)
            {
                if (!update) MessageBox.Show("No se ha seleccionado ninguna persona");
                else
                {
                    dgvPersonReg.DataSource = null;
                }
            }
            else if (amountSelected>=1)
            {
                LoadTableSelectedPerson(selectedIDList);
            }
        }
        private void bttnSearchPerson_Click(object sender, EventArgs e)
        {
            SelectAllcbx.Checked = false;
            DeselectAllcbx.Checked = false;
            amountSelected = 0;
            consultationAmount();
            LastBtnClicked = 'b';
            if (amountPerson > 0)
            {
                switch (Menu.action)
                {
                    case 2:
                        Modifybtn.Enabled = true;
                        break;
                    case 3:
                        Deletebtn.Enabled = true;/*******************/
                        SelectAllcbx.Enabled = true;/****************/
                        DeselectAllcbx.Enabled = true;/**************/
                        bttnViewSelectedPerson.Enabled = true;/************/
                        break;
                    case 4:
                    case 5:
                        bttnSelectPerson.Enabled = true;
                        break;
                    case 6:
                        bttnSentEmail.Enabled = true;
                        SelectAllcbx.Enabled = true;/****************/
                        DeselectAllcbx.Enabled = true;/**************/
                        bttnViewSelectedPerson.Enabled = true;/************/
                        break;
                    default:
                        break;
                }
                textSearch = txtTextSearch.Text;/***************************************/
                LastSearchTypeSelected = cmbTypeSearch.SelectedIndex;/******************/

                if (textSearch == "")
                {
                    LoadTableEmail(null);
                }
                else
                {
                    switch (cmbTypeSearch.SelectedIndex)
                    {
                        //1 Correo, 2 Nombre
                        case 0:
                            LoadTableEmail(textSearch);
                            break;
                        case 1:
                            LoadTableName(textSearch);
                            break;
                        default:
                            MessageBox.Show("Seleccione una de las opciones por las que desea buscar");
                            cmbTypeSearch.Text = "";
                            break;
                    }
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

            cmbTypeSearch.Items.Add(new { Text = "Correo", Value = 2 });
            cmbTypeSearch.Items.Add(new { Text = "Nombre", Value = 3 });
            cmbTypeSearch.Items.Add(new { Text = "Área", Value = 4 });
            cmbTypeSearch.Items.Add(new { Text = "Curso", Value = 5 });
            cmbTypeSearch.SelectedIndex = 0;
        }
        private void HideAndMove(bool justOneSelection)
        {
            this.Height = 616;
            SearchGBox.Top = 46;
            DataGBox.Top += 523;
            if (!justOneSelection)
            {
                SelectAllcbx.Visible = true;
                DeselectAllcbx.Visible = true;
                bttnViewSelectedPerson.Visible = true;
            }
        }
        //CAMBIAR ENSEÑAR EL APELLIDO
        
        public void LoadTableEmail(string date)
        {
            List<Person> list = new List<Person>();
            CtrlPerson person = new CtrlPerson();
            dgvPersonReg.DataSource = person.consultationEmail(date);
            validateSelection();

            if (dgvPersonReg.Rows.Count > 0)
            {
                try
                {
                    this.dgvPersonReg.Columns["ID"].Visible = false;
                    this.dgvPersonReg.Columns["Apellido"].Visible = false;
                }
                catch (MySqlException)
                {
                    if (!update)
                    {
                        MessageBox.Show("No se ha encontrado coincidencias");
                        LoadTableEmail(null);
                    }
                }
            }
            else
            {
                if (!update)
                {
                    MessageBox.Show("No se han encontrado datos");
                    LoadTableEmail(null);
                }
            }
        }
        public void LoadTableName(string date)
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
                    this.dgvPersonReg.Columns["ID"].Visible = false;
                    this.dgvPersonReg.Columns["Apellido"].Visible = false;
                }
                catch (MySqlException)
                {
                    if (!update)
                    {
                        MessageBox.Show("No se ha encontrado coincidencias");
                        LoadTableName(null);
                    }
                }
            }
            else
            {
                if (!update)
                {
                    MessageBox.Show("No se han encontrado datos");
                    LoadTableName(null);
                }
            }
        }
        public void LoadTableSelectedPerson(List<int> personSelected)
        {
            amountSelected = 0;
            CtrlPerson person = new CtrlPerson();
            int sentID = 0;
            for (int i = 0; i < personSelected.Count; i++)
            {
                sentID=int.Parse(personSelected[i].ToString());
                person.SelectedEmailSent(sentID);
            }
            dgvPersonReg.DataSource =person.listSelected;
            validateSelection();

            if (dgvPersonReg.Rows.Count > 0)
            {
                try
                {
                    this.dgvPersonReg.Columns["ID"].Visible = false;
                    this.dgvPersonReg.Columns["Apellido"].Visible = false;
                }
                catch (MySqlException)
                {
                    if (!update)
                    {
                        MessageBox.Show("No se ha seleccionado a alguna persona");
                        LoadTableEmail(null);
                    }
                }
            }
            else
            {
                if (!update)
                {
                    MessageBox.Show("No se han seleccionado datos");
                    LoadTableEmail(null);
                }
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
                this.Height = 925;
                foreach (DataGridViewRow row in dgvPersonReg.Rows)
                {
                    bool isChecked = Convert.ToBoolean(row.Cells[0].Value);
                    if (isChecked)
                    {
                        DataGridViewCell choosenID = row.Cells[1];
                        AddID parent = this.Owner as AddID;
                        parent.AddNewItem(choosenID);
                        Menu.action = 4;
                        this.Close();
                    }
                }
            }
            if (amountSelected>1)
            {
                MessageBox.Show("Selecciona únicamente a 1 persona");
            }
        }
        private void Modifybtn_Click(object sender, EventArgs e)/*************************/
        {
            CtrlPerson ctrl = new CtrlPerson();
            if (amountSelected==0)
            {
                MessageBox.Show("No se ha seleccionado a ninguna persona");
            }
            if (amountSelected==1)
            {
                this.Height = 925;/***************************************/
                btnSaveData.Enabled = true;/******************************/
                foreach (DataGridViewRow row in dgvPersonReg.Rows)
                {
                    bool isChecked = Convert.ToBoolean(row.Cells[0].Value);
                    if (isChecked)
                    {
                        PerID = Convert.ToInt32(row.Cells[1].Value);
                        Person person = ctrl.ModifyQuery(row.Cells[1].Value.ToString());
                        txtbLastNamePerson.Text = person.Apellido;
                        txtbNamePerson.Text = person.Nombre;
                        txtEmailPerson.Text = person.Email;
                        txtbTelephone.Text = person.Teléfono.ToString();
                    }
                }
            }

            if (amountSelected > 1)
            {
                MessageBox.Show("Selecciona únicamente a 1 persona");
            }
        }
        private void btnSaveData_Click(object sender, EventArgs e)/********************/
        {
            SelectAllcbx.Checked = false;
            DeselectAllcbx.Checked = false;
            if (txtbNamePerson.Text != "" && txtbLastNamePerson.Text != "" && txtEmailPerson.Text != "")
            {
                if (txtbTelephone.Text != "")
                {
                    String personName = txtbNamePerson.Text;
                    String personLastName = txtbLastNamePerson.Text;
                    String personEmail = txtEmailPerson.Text;
                    string personNumber = txtbTelephone.Text;

                    string sql = "UPDATE persona SET Nombre = '" + personName + "', Apellido = '" + personLastName + "', Correo = '" + personEmail + "', Teléfono = '" + personNumber + "' " +
            "WHERE IDpersona =" + PerID;

                    MySqlConnection connectionBD = Connection.connection();
                    connectionBD.Open();
                    try
                    {
                        MySqlCommand command = new MySqlCommand(sql, connectionBD);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Se ha modificado exitosamente");
                        EmptyChecked();/****************************************************/

                        UpdateDataGrid();/**************************************************/
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
                MessageBox.Show("Por favor, complete la información");
            }
        }
        private void bttnEraserText_Click(object sender, EventArgs e)
        {
            txtTextSearch.Text = "";
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
                    if (selectedIDList[i].Equals(row.Cells["ID"].Value))
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
            txtbLastNamePerson.Text = "";
            txtbNamePerson.Text = "";
            txtEmailPerson.Text = "";
            txtbTelephone.Text = "";
            amountSelected = 0;
        }


        private void Deletebtn_Click(object sender, EventArgs e)/***************/
        {
            SelectAllcbx.Checked = false;
            DeselectAllcbx.Checked = false;
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
                                EmptyChecked();
                                UpdateDataGrid();
                            }
                        }
                        catch (MySqlException ex)
                        {
                            //Decir cuál NO se logró eliminar
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

        private void SelectAllcbx_CheckedChanged(object sender, EventArgs e)/***********/
        {
            if (SelectAllcbx.Checked)
            {
                DeselectAllcbx.Checked = false;
                foreach (DataGridViewRow Fila in dgvPersonReg.Rows)
                {
                    int currentID = Convert.ToInt32(Fila.Cells[1].Value);
                    if (!selectedIDList.Contains(currentID))
                    {
                        selectedIDList.Add(currentID);
                        amountSelected++;
                    }
                    Fila.Cells[0].Value = true;
                }
            }
        }
        private void UpdateDataGrid()/******************************************/
        {
            
            consultationAmount();
            update = true;
            if (amountPerson > 0)
            {
                switch (LastBtnClicked)
                {
                    case 'b':
                        if (textSearch == "")
                        {
                            LoadTableEmail(null);
                        }
                        switch (LastSearchTypeSelected)
                        {
                            //1 Correo, 2 Nombre
                            case 1:
                                LoadTableEmail(textSearch);
                                break;
                            case 2:
                                LoadTableName(textSearch);
                                break;
                            default:
                                MessageBox.Show("ERROOOOOOOOOOOOOOOOOOOOR");
                                cmbTypeSearch.Text = "";
                                break;
                        }
                        break;
                    case 'v':
                        bttnViewSelectedPerson.PerformClick();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                dgvPersonReg.DataSource = null;
            }
            update = false;
        }
        private void EmptyChecked()/********************************************/
        {
            amountSelected = 0;
            selectedIDList.Clear();
        }

        private void DeselectAllcbx_CheckedChanged(object sender, EventArgs e)/***********/
        {
            if (DeselectAllcbx.Checked)
            {
                SelectAllcbx.Checked = false;
                foreach (DataGridViewRow Fila in dgvPersonReg.Rows)
                {
                    int currentID = Convert.ToInt32(Fila.Cells[1].Value);
                    if (selectedIDList.Contains(currentID))
                    {
                        selectedIDList.Remove(currentID);
                        amountSelected--;
                    }

                    Fila.Cells[0].Value = null;
                }
            }
        }

        private void dgvPersonReg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idPerson = int.Parse(dgvPersonReg.CurrentRow.Cells["ID"].Value.ToString());
            if (dgvPersonReg.CurrentRow.Cells["CheckSelection"].Value != null && (bool)dgvPersonReg.CurrentRow.Cells["CheckSelection"].Value)
            {
                dgvPersonReg.CurrentRow.Cells["CheckSelection"].Value = false;
                dgvPersonReg.CurrentRow.Cells["CheckSelection"].Value = null;
                amountSelected += -1;
                if (Menu.action != 5 && Menu.action !=2 && Menu.action != 4)
                {

                    selectedIDList.Remove(idPerson);
                    SelectAllcbx.Checked = false;/******************************************/
                }
            }
            else if (dgvPersonReg.CurrentRow.Cells["CheckSelection"].Value == null)
            {
                if (Menu.action != 5 && Menu.action != 2 && Menu.action != 4)
                {
                    dgvPersonReg.CurrentRow.Cells["CheckSelection"].Value = true;

                    selectedIDList.Add(idPerson);
                    DeselectAllcbx.Checked = false;/****************************/
                }
                else
                {
                    foreach (DataGridViewRow Fila in dgvPersonReg.Rows)
                    {
                        Fila.Cells[0].Value = null;
                    }
                    amountSelected = 0;
                    dgvPersonReg.CurrentRow.Cells["CheckSelection"].Value = true;
                }
                amountSelected += 1;
            }
        }
    }
}
