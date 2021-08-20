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
    public partial class RegisterReg : Form,AddID
    {
        //Opción 1 agregar, opción 2 modificar, opción 3 eliminar

        public static int type = 0;
        public int amountSelected = 0;
        public int LastSearchTypeSelected;
        public String textSearch;
        public int amount = 0;
        string ID_area;
        string ID_persona;
        string ID_curso;
        bool FirstBttnSearchClick = true;
        private bool update = false;
        char LastBtnClicked;
        List<string> selectedIDList = new List<string>();
        public RegisterReg()
        {
            InitializeComponent();
            LoadAreaRegister();
            switch (Menu.action)
            {
                case 1:
                    cmbSelectAreaRegister.SelectedIndex = -1;
                    bttnAddRegister.Visible = true;
                    this.Height = 362;
                    break;
                case 2:
                    
                    LoadTypeSearch();//
                    SaveChanges.Visible = true;
                    Modifybtn.Visible = true;
                    txtText.Visible = true;//
                    cmbType.Visible = true;//
                    bttnSearch.Visible = true;//
                    bttnEraserText.Visible = true;//
                    SearchGBox.Top = 47;
                    DataGBox.Top += 510;
                    this.Height = 604;
                    break;
                case 3:
                    LoadTypeSearch();//
                    txtText.Visible = true;//
                    cmbType.Visible = true;//
                    bttnSearch.Visible = true;//
                    bttnEraserText.Visible = true;//
                    SearchGBox.Top = 47;
                    DataGBox.Top += 510;
                    this.Height = 604;
                    SaveChanges.Visible = true;
                    bttnViewSelected.Visible = true;
                    Deletebtn.Visible = true;
                    SelectAllcbx.Visible = true;
                    DeselectAllcbx.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void bttnReturnRegister_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }
        private void bttnSearchPersonReg_Click(object sender, EventArgs e)
        {
            Menu.action = 4;
            PersonReg frmAdd = new PersonReg();
            frmAdd.Show(this);
        }
        //private void bttnImportRegister_Click(object sender, EventArgs e)
        //{
        //    int linesCount = 0;
        //    MessageBox.Show("El formato para el archivo .csv es:\n ID AREA, ID CURSO , ID PERSONA, FECHA DE LA CONSULTA (AÑO/MES/DÍA)");

        //    OpenFileDialog window = new OpenFileDialog();
        //    window.Title = "Importar archivo (.txt, .csv)";
        //    window.Filter = "Text files (*.Csv)|*.csv|(*.txt)|*.txt";
        //    if (window.ShowDialog() == DialogResult.OK)
        //    {
        //        MySqlConnection connectionBD = Connection.connection();
        //        connectionBD.Open();
        //        try
        //        {
        //            String[] lines = File.ReadAllLines(window.FileName);

        //            for (int i = 0; i < lines.Length; i++)
        //            {
        //                if (lines[i] != "")
        //                {
        //                    String[] lineConverted = lines[i].Split(",");

        //                    string sql = "INSERT INTO registro (IDarea,IDcurso,IDpersona,FechaConsulta) VALUES" +
        //                "('" + lineConverted[0] + "','" + lineConverted[1] + "','" + lineConverted[2] + "'," +
        //                "'" + lineConverted[3] + "')";

        //                    if (lineConverted.Length == 4)
        //                    {
        //                        MySqlCommand command = new MySqlCommand(sql, connectionBD);
        //                        command.ExecuteNonQuery();
        //                        if (i == lines.Length - 1)
        //                        {
        //                            MessageBox.Show("Se ha insertado exitosamente");
        //                            Clean();
        //                        }
        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("No tiene la cantidad de datos indicado");
        //                    }
        //                }
        //                else
        //                {
        //                    linesCount++;
        //                    if (linesCount == lines.Length)
        //                    {
        //                        MessageBox.Show("El archivo se encuentra vacío");
        //                    }
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error al insertar: Revise los datos ingresados \n" + ex.Message);
        //        }
        //        finally
        //        {
        //            connectionBD.Close();
        //        }
        //    }
        //}
        private void bttnAddRegister_Click(object sender, EventArgs e)
        {
            if (cmbSelectAreaRegister.Text != "")
            {
                if (cmbSelectCourseRegister.Text != "")
                {
                    if (dtpConsultationDateRegister.Text != "")
                    {
                        if (txtbPersonIDRegister.Text != "" || txtbPersonIDRegister.Text != "0")
                        {
                            int idArea = int.Parse(cmbSelectAreaRegister.SelectedValue.ToString());
                            int idCourse = int.Parse(cmbSelectCourseRegister.SelectedValue.ToString());
                            int idPerson = int.Parse(txtbPersonIDRegister.Text);

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
        private void bttnEraserText_Click(object sender, EventArgs e)
        {
            txtText.Text = "";
        }
        private void bttnSearch_Click(object sender, EventArgs e)
        {
            SelectAllcbx.Checked = false;
            DeselectAllcbx.Checked = false;
            amountSelected = 0;
            ConsultationAmount();
            LastBtnClicked = 'b';
            if (FirstBttnSearchClick)
            {
                dgvRegister.Visible = true;
                if (Menu.action != 2) bttnViewSelected.Visible = true;
                switch (Menu.action)
                {
                    case 2:
                        Modifybtn.Enabled = true;
                        break;
                    case 3:
                        SelectAllcbx.Enabled = true;
                        DeselectAllcbx.Enabled = true;
                        Deletebtn.Enabled = true;
                        bttnViewSelected.Enabled = true;
                        break;
                    default:
                        break;
                }
                FirstBttnSearchClick = false;
            }
            if (amount > 0)
            {
                textSearch = txtText.Text.ToLower();
                LastSearchTypeSelected = cmbType.SelectedIndex;
                if (textSearch == "")
                {
                    LoadTableArea(null);
                }
                else
                {
                    switch (cmbType.SelectedIndex)
                    {
                        //0 Área, 1 Curso, 2 Persona, Mes
                        case 0:
                            LoadTableArea(textSearch);
                            break;
                        case 1:
                            LoadTableCourse(textSearch);
                            break;
                        case 2:
                            LoadTablePerson(textSearch);
                            break;
                        case 3:
                            ChangingInfo();
                            LoadTableMonthYear(textSearch);
                            break;
                        default:
                            MessageBox.Show("Seleccione una de las opciones por las que desea buscar");
                            cmbType.Text = "";
                            break;
                    }
                }
            }
            if (amount == 0)
            {
                MessageBox.Show("No se encuentran consultas registradas");
            }
        }
        private void bttnViewSelected_Click(object sender, EventArgs e)
        {
            if (!update)
            {
                SelectAllcbx.Checked = false;
                DeselectAllcbx.Checked = false;
                LastBtnClicked = 'v';
            }
            if (amountSelected == 0)
            {
                if (!update) MessageBox.Show("No se ha seleccionado ninguna consulta");/***************/
                else
                {
                    dgvRegister.DataSource = null;
                }
            }
            else if (amountSelected >= 1)
            {
                LoadTableSelected(selectedIDList);
            }
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
        private void LoadTypeSearch()
        {
            cmbType.DisplayMember = "Text";
            cmbType.ValueMember = "Value";
            cmbType.SelectedIndex = cmbType.Items.IndexOf("Área");

            cmbType.Items.Add(new { Text = "Área", Value = 1 });
            cmbType.Items.Add(new { Text = "Curso", Value = 2 });
            cmbType.Items.Add(new { Text = "Persona", Value = 3 });
            cmbType.Items.Add(new { Text = "Mes*(Año actual)", Value = 3 });
            cmbType.SelectedIndex = 0;
        }
        private void LoadTableArea(string data)
        {
            CtrlRegister register = new CtrlRegister();
            dgvRegister.DataSource = register.consultationArea(data);
            validateSelection();

            if (dgvRegister.Rows.Count > 0)
            {
                try
                {
                    this.dgvRegister.Columns["IDarea"].Visible = false;
                    this.dgvRegister.Columns["IDcurso"].Visible = false;
                    this.dgvRegister.Columns["IDpersona"].Visible = false;
                }
                catch (MySqlException)
                {
                    if (!update)
                    {
                        MessageBox.Show("No se ha encontrado coincidencias");
                        LoadTableArea(null);
                    }
                }
            }
            else
            {
                if (!update)
                {
                    MessageBox.Show("No se han encontrado datos");
                    LoadTableArea(null);
                }
            }
        }
        private void LoadTableCourse(string data)
        {
            CtrlRegister register = new CtrlRegister();
            dgvRegister.DataSource = register.consultationCourse(data);
            validateSelection();

            if (dgvRegister.Rows.Count > 0)
            {
                try
                {
                    this.dgvRegister.Columns["IDarea"].Visible = false;
                    this.dgvRegister.Columns["IDcurso"].Visible = false;
                    this.dgvRegister.Columns["IDpersona"].Visible = false;
                }
                catch (MySqlException)
                {
                    if (!update)
                    {
                        MessageBox.Show("No se ha encontrado coincidencias");
                        LoadTableCourse(null);
                    }
                }
            }
            else
            {
                if (!update)
                {
                    MessageBox.Show("No se han encontrado datos");
                    LoadTableCourse(null);
                }
            }
        }
        private void LoadTablePerson(string data)
        {
            CtrlRegister register = new CtrlRegister();
            dgvRegister.DataSource = register.consultationPerson(data);
            validateSelection();

            if (dgvRegister.Rows.Count > 0)
            {
                try
                {
                    this.dgvRegister.Columns["IDarea"].Visible = false;
                    this.dgvRegister.Columns["IDcurso"].Visible = false;
                    this.dgvRegister.Columns["IDpersona"].Visible = false;
                }
                catch (MySqlException)
                {
                    if (!update)
                    {
                        MessageBox.Show("No se ha encontrado coincidencias");
                        LoadTablePerson(null);
                    }
                }
            }
            else
            {
                if (!update)
                {
                    MessageBox.Show("No se han encontrado datos");
                    LoadTablePerson(null);
                }
            }
        }
        private void LoadTableMonthYear(string data)
        {
            CtrlRegister register = new CtrlRegister();
            dgvRegister.DataSource = register.consultationMonthYear(data);
            validateSelection();

            if (dgvRegister.Rows.Count > 0)
            {
                try
                {
                    this.dgvRegister.Columns["IDarea"].Visible = false;
                    this.dgvRegister.Columns["IDcurso"].Visible = false;
                    this.dgvRegister.Columns["IDpersona"].Visible = false;
                }
                catch (MySqlException)
                {
                    if (!update)
                    {
                        MessageBox.Show("No se ha encontrado coincidencias");
                        LoadTableMonthYear(null);
                    }
                }
            }
            else
            {
                if (!update)
                {
                    MessageBox.Show("No se han encontrado datos");
                    LoadTableMonthYear(null);
                }
            }
        }
        private void LoadTableSelected(List<string> Selected)
        {
            amountSelected = 0;
            CtrlRegister register = new CtrlRegister();
            string sentID;
            for (int i = 0; i < Selected.Count; i++)
            {
                sentID = Selected[i].ToString();
                register.SelectedEmailSent(sentID);
            }
            dgvRegister.DataSource = register.listSelected;
            validateSelection();

            if (dgvRegister.Rows.Count > 0)
            {
                try
                {
                    this.dgvRegister.Columns["IDpersona"].Visible = false;
                    this.dgvRegister.Columns["IDarea"].Visible = false;
                    this.dgvRegister.Columns["IDcurso"].Visible = false;
                }
                catch (MySqlException)
                {
                    if (!update)
                    {
                        MessageBox.Show("No se ha seleccionado a alguna persona");
                        LoadTableArea(null);
                    }
                }
            }
            else
            {
                if (!update)
                {
                    MessageBox.Show("No se han seleccionado datos");
                    LoadTableArea(null);
                }
            }
        }


        private void ConsultationAmount()
        {
            string sql = "SELECT COUNT(1) FROM registro ";
            MySqlConnection connectionBD = Connection.connection();
            connectionBD.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                command.Parameters.AddWithValue(sql, amount);
                command.ExecuteNonQuery();
                amount = int.Parse(command.ExecuteScalar().ToString());
            }
            catch (MySqlException)
            {
                MessageBox.Show("No hay personas ingresadas ");
                amount = -1;
            }
            finally
            {
                connectionBD.Close();
            }
        }
        public void validateSelection()
        {
            foreach (DataGridViewRow row in dgvRegister.Rows)
            {
                for (int i = 0; i < selectedIDList.Count; i++)
                {
                    string[] array = selectedIDList[i].ToString().Split(',');
                    int idArea = int.Parse(array[0]);
                    int idCurso = int.Parse(array[1]);
                    int idPersona = int.Parse(array[2]);
                    if (idArea.Equals(row.Cells["IDarea"].Value) && idCurso.Equals(row.Cells["IDcurso"].Value) &&
                        idPersona.Equals(row.Cells["IDpersona"].Value))
                    {
                        row.Cells["CheckSelection"].Value = true;
                    }
                }
            }
            amountSelected = selectedIDList.Count;
        }
        public void ChangingInfo()
        {
            switch (textSearch)
            {
                case "enero":
                case "1":
                case "01":
                    textSearch = "01";
                    break;
                case "febrero":
                case "2":
                case "02":
                    textSearch = "02";
                    break;
                case "marzo":
                case "3":
                case "03":
                    textSearch = "03";
                    break;
                case "abril":
                case "4":
                case "04":
                    textSearch = "04";
                    break;
                case "mayo":
                case "5":
                case "05":
                    textSearch = "05";
                    break;
                case "junio":
                case "6":
                case "06":
                    textSearch = "06";
                    break;
                case "julio":
                case "7":
                case "07":
                    textSearch = "07";
                    break;
                case "agosto":
                case "8":
                case "08":
                    textSearch = "08";
                    break;
                case "septiembre":
                case "9":
                case "09":
                    textSearch = "09";
                    break;
                case "octubre":
                case "10":
                    textSearch = "10";
                    break;
                case "noviembre":
                case "11":
                    textSearch = "11";
                    break;
                case "diciembre":
                case "12":
                    textSearch = "12";
                    break;
                default:
                    LoadTableMonthYear(null);
                    break;
            }
        }
        private void Access(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                CloseWindow();
            }
        }
        private void Clean()
        {
            cmbSelectAreaRegister.Text = "";
            cmbSelectCourseRegister.Text = "";
            dtpConsultationDateRegister.Value = DateTime.Now;
            dtpConsultationDateRegister.Format = DateTimePickerFormat.Custom;
            dtpConsultationDateRegister.CustomFormat = "yyyy/MM/dd hh:mm";
            txtbPersonIDRegister.Text = "";
        }
        private void CloseWindow()
        {
            Menu Frm = new Menu();
            Frm.Show();
            this.Close();
        }


        private void cmbSelectAreaInscription_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadCourseRegister();
        }
        private void dgvRegister_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idArea = int.Parse(dgvRegister.CurrentRow.Cells["IDarea"].Value.ToString());
            int idCurso = int.Parse(dgvRegister.CurrentRow.Cells["IDcurso"].Value.ToString());
            int idPersona = int.Parse(dgvRegister.CurrentRow.Cells["IDpersona"].Value.ToString());
            string key = idArea + "," + idCurso + "," + idPersona;
            if (dgvRegister.CurrentRow.Cells["CheckSelection"].Value != null && (bool)dgvRegister.CurrentRow.Cells["CheckSelection"].Value)
            {
                dgvRegister.CurrentRow.Cells["CheckSelection"].Value = false;
                dgvRegister.CurrentRow.Cells["CheckSelection"].Value = null;
                amountSelected += -1;
                if (Menu.action != 2)
                {
                    selectedIDList.Remove(key);
                    SelectAllcbx.Checked = false;
                }
            }
            else if (dgvRegister.CurrentRow.Cells["CheckSelection"].Value == null)
            {
                if (Menu.action != 2)
                {
                    dgvRegister.CurrentRow.Cells["CheckSelection"].Value = true;

                    selectedIDList.Add(key);
                    DeselectAllcbx.Checked = false;
                }
                else
                {
                    foreach (DataGridViewRow Fila in dgvRegister.Rows)
                    {
                        Fila.Cells[0].Value = null;
                    }
                    amountSelected = 0;
                    dgvRegister.CurrentRow.Cells["CheckSelection"].Value = true;
                }
                amountSelected += 1;
            }
        }
        


        #region AddID data
        public void AddNewItem(DataGridViewCell row)
        {
            string idPersonChoosen = row.Value.ToString();
            this.txtbPersonIDRegister.Text = idPersonChoosen;
        }
        #endregion

        private void Modifybtn_Click(object sender, EventArgs e)
        {
            
            if (amountSelected == 0)
            {
                MessageBox.Show("No se ha seleccionado ninguna consulta");
            }
            if (amountSelected == 1)
            {
                this.Height = 876;
                CtrlRegister ctrlReg = new CtrlRegister();
                foreach (DataGridViewRow row in dgvRegister.Rows)
                {
                    bool isChecked = Convert.ToBoolean(row.Cells[0].Value);
                    if (isChecked)
                    {
                        ID_area = row.Cells["IDarea"].Value.ToString();
                        ID_curso = row.Cells["IDcurso"].Value.ToString();
                        ID_persona = row.Cells["IDpersona"].Value.ToString();
                        Register reg = ctrlReg.ModifyQuery(ID_curso, ID_area, ID_persona);
                        cmbSelectAreaRegister.SelectedValue = reg.IDarea;
                        LoadCourseRegister();
                        cmbSelectCourseRegister.SelectedValue = reg.IDcurso;
                        txtbPersonIDRegister.Text = reg.IDpersona.ToString();
                        dtpConsultationDateRegister.Value = reg.FechaConsulta;
                    }
                }
            }

            if (amountSelected > 1)
            {
                MessageBox.Show("Selecciona únicamente a 1 consulta");
            }
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            SelectAllcbx.Checked = false;
            DeselectAllcbx.Checked = false;
            if (cmbSelectAreaRegister.Text != "")
            {
                if (cmbSelectCourseRegister.Text != "")
                {
                    if (dtpConsultationDateRegister.Text != "")
                    {
                        if (txtbPersonIDRegister.Text != "" || txtbPersonIDRegister.Text != "0")
                        {
                            int idArea = int.Parse(cmbSelectAreaRegister.SelectedValue.ToString());
                            int idCourse = int.Parse(cmbSelectCourseRegister.SelectedValue.ToString());
                            int idPerson = int.Parse(txtbPersonIDRegister.Text);

                            string sql = "UPDATE registro SET IDcurso = '" + idCourse + "', IDarea = '" + idArea + "', IDpersona = '" + idPerson + "', FechaConsulta = '" +dtpConsultationDateRegister.Text+
                                    "' WHERE IDcurso = " + ID_curso + " AND IDarea = " + ID_area + " AND IDpersona = " + ID_persona;
                            MySqlConnection connectionBD = Connection.connection();
                            connectionBD.Open();
                            try
                            {
                                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                                command.ExecuteNonQuery();
                                MessageBox.Show("Consulta correctamente modificado");
                                EmptyChecked();

                                UpdateDataGrid();
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
        private void UpdateDataGrid()
        {
            
            ConsultationAmount();
            update = true;
            if (amount > 0)
            {
                switch (LastBtnClicked)
                {
                    case 'b':
                        if (textSearch == "")
                        {
                            LoadTableArea(null);
                        }
                        else
                        {
                            switch (cmbType.SelectedIndex)
                            {
                                //0 Área, 1 Curso, 2 Persona, Mes
                                case 0:
                                    LoadTableArea(textSearch);
                                    break;
                                case 1:
                                    LoadTableCourse(textSearch);
                                    break;
                                case 2:
                                    LoadTablePerson(textSearch);
                                    break;
                                case 3:
                                    ChangingInfo();
                                    LoadTableMonthYear(textSearch);
                                    break;
                                default:
                                    MessageBox.Show("ERROOOOOOOOOOOOOOOOOOOOR");
                                    cmbType.Text = "";
                                    break;
                            }
                        }
                        break;
                    case 'v':
                        bttnViewSelected.PerformClick();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                dgvRegister.DataSource = null;
            }
            update = false;
        }
        private void EmptyChecked()
        {
            amountSelected = 0;
            selectedIDList.Clear();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            SelectAllcbx.Checked = false;
            DeselectAllcbx.Checked = false;
            string[] saveId;
            if (amountSelected == 0)
            {
                MessageBox.Show("No se ha seleccionado ninguna consulta");
            }
            if (amountSelected >= 1)
            {
                DialogResult dialogResult = MessageBox.Show("¿Deseas eliminar las consultas seleccionadas de la base de datos? (Puedes revisar tu selección al presionar el botón 'Ver Seleccionados')", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    for (int i = 0; i < selectedIDList.Count; i++)
                    {
                        saveId = selectedIDList[i].Split(',');
                        string sql = "DELETE FROM registro WHERE IDcurso =" + saveId[1] + " AND IDarea = " + saveId[0] + " AND IDpersona = " + saveId[2];

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

        private void SelectAllcbx_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectAllcbx.Checked)
            {
                DeselectAllcbx.Checked = false;
                foreach (DataGridViewRow Fila in dgvRegister.Rows)
                {
                    int idArea = int.Parse(Fila.Cells["IDarea"].Value.ToString());
                    int idCurso = int.Parse(Fila.Cells["IDcurso"].Value.ToString());
                    int idPersona = int.Parse(Fila.Cells["IDpersona"].Value.ToString());
                    string keyInscription = idArea + "," + idCurso + "," + idPersona;

                    if (!selectedIDList.Contains(keyInscription))
                    {
                        selectedIDList.Add(keyInscription);
                        amountSelected++;
                    }
                    Fila.Cells[0].Value = true;
                }
            }
        }

        private void DeselectAllcbx_CheckedChanged(object sender, EventArgs e)
        {
            if (DeselectAllcbx.Checked)
            {

                SelectAllcbx.Checked = false;
                foreach (DataGridViewRow Fila in dgvRegister.Rows)
                {
                    int idArea = int.Parse(Fila.Cells["IDarea"].Value.ToString());
                    int idCurso = int.Parse(Fila.Cells["IDcurso"].Value.ToString());
                    int idPersona = int.Parse(Fila.Cells["IDpersona"].Value.ToString());
                    string keyInscription = idArea + "," + idCurso + "," + idPersona;
                    if (selectedIDList.Contains(keyInscription))
                    {
                        selectedIDList.Remove(keyInscription);
                        amountSelected--;
                    }

                    Fila.Cells[0].Value = null;
                }
            }
        }
    }
}
