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
        //Menu.action= 1 es agregar, 2 modificar, 3 eliminar
        int winOrLose;
        DateTime actualDate = DateTime.Today;
        bool FirstBttnSearchClick = true;
        string ID_area;
        string ID_persona;
        string ID_curso;
        public static int type = 0;
        public int amountSelected = 0;
        public int LastSearchTypeSelected;
        public String textSearch;
        public int amount = 0;
        private bool update = false;
        char LastBtnClicked;
        List<string> selectedIDList = new List<string>();
        public InscriptionReg()
        {
            InitializeComponent();
            LoadAreaInscription();
            if (Menu.action>=2 && Menu.action<=4)
            {
                LoadTypeSearch();
                txtText.Visible = true;
                cmbType.Visible = true;
                bttnSearch.Visible = true;
                bttnEraserText.Visible = true;
            }
            if (Menu.action==1)
            {
                cmbSelectAreaInscription.SelectedIndex = -1;
                dateToday();
                this.Height = 342;
                btnClean.Visible = true;
                bttnAddInscription.Visible = true;
            }
            if (Menu.action==2)
            {
                SearchGBox.Top = 47;/*******************************/
                DataGBox.Top += 510;/*******************************/
                this.Height = 604;
                btnClean.Visible = true;
                SaveChanges.Visible = true;
                Modifybtn.Visible = true;
            }
            if (Menu.action == 3)
            {
                SearchGBox.Top = 47;
                DataGBox.Top += 510;
                this.Height = 604;
                btnClean.Visible = true;
                SaveChanges.Visible = true;
                bttnViewSelected.Visible = true;
                Deletebtn.Visible = true;
                SelectAllcbx.Visible = true;
                DeselectAllcbx.Visible = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbApproved.Checked)
            {
                winOrLose =1;
                lblFinalDateInscription.Visible = true;
                mtbFinalDate.Visible = true;
            }
            else
            {
                winOrLose =0;
                lblFinalDateInscription.Visible = false;
                mtbFinalDate.Visible = false;
            }
        }
        private void bttnAddInscription_Click(object sender, EventArgs e)
        {
            if (cmbSelectAreaInscription.Text!="")
            {
                if (cmbSelectCourseInscription.Text!="")
                {
                    if (txtbPersonIDInscription.Text!="")
                    {
                        if (mtbStartDate.Text!="")
                        {
                            if (mTxBxCode.Text != "" && mTxBxCode.TextLength==7)
                            {
                                int idArea = int.Parse(cmbSelectAreaInscription.SelectedValue.ToString());
                                int idCourse = int.Parse(cmbSelectCourseInscription.SelectedValue.ToString());
                                int idPerson = int.Parse(txtbPersonIDInscription.Text);
                                string sql;

                                if (mtbFinalDate.Text == "    /  /" || mtbFinalDate.Visible == false)
                                {
                                    sql = "INSERT INTO inscripcion (IDarea,IDcurso,IDpersona,FechaInicio,Aprobo, Codigo) VALUES ('" + idArea + "'," +
                                    "'" + idCourse + "','" + idPerson + "','" + mtbStartDate.Text + "','" + winOrLose + "', '" + mTxBxCode.Text + "')";
                                }
                                else
                                {
                                    sql = "INSERT INTO inscripcion (IDarea,IDcurso,IDpersona,FechaInicio,FechaFin,Aprobo, Codigo) VALUES ('" + idArea + "'," +
                                    "'" + idCourse + "','" + idPerson + "','" + mtbStartDate.Text + "','" + mtbFinalDate.Text + "','" + winOrLose + "', '" + mTxBxCode.Text + "')";
                                }


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
                                MessageBox.Show("Ingrese el código asignado, debe ser de 7 dígitos");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese la fecha de inicio");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese el ID de la persona");
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
        private void bttnReturnInscription_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }
        private void bttnSearchPerson_Click(object sender, EventArgs e)
        {
            Menu.action = 5;
            PersonReg frmAdd = new PersonReg();
            frmAdd.Show(this);
        }
        private void btnClean_Click(object sender, EventArgs e)
        {
            Clean();
        }
        private void bttnEraserText_Click(object sender, EventArgs e)
        {
            txtText.Text = "";
        }
        private void bttnSearch_Click_1(object sender, EventArgs e)
        {
            SelectAllcbx.Checked = false;
            DeselectAllcbx.Checked = false;
            amountSelected = 0;//Por qué?
            ConsultationAmount();
            LastBtnClicked = 'b';
            if (FirstBttnSearchClick)
            {
                if (Menu.action != 2) bttnViewSelected.Visible = true;
                dgvInscription.Visible = true;
                if (Menu.action == 2)
                {
                    Modifybtn.Enabled = true;
                }
                if (Menu.action == 4)
                {
                    this.Height = 594;
                    DeselectAllcbx.Visible = true;
                    DeselectAllcbx.Enabled = true;
                    SelectAllcbx.Visible = true;
                    SelectAllcbx.Enabled = true;
                    //Mostrar botones según la opción

                    //else
                    //{
                    //    bttnSelect.Visible = true;
                    //}
                }
                if (Menu.action == 3)
                {
                    DeselectAllcbx.Enabled = true;
                    SelectAllcbx.Enabled = true;
                    Deletebtn.Enabled = true;
                    bttnViewSelected.Enabled = true;
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
            if (amount==0)
            {
                MessageBox.Show("No se encuentran inscripciones registradas");
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
                if (!update) MessageBox.Show("No se ha seleccionado ninguna inscripción");
                else
                {
                    dgvInscription.DataSource = null;
                }
            }
            else if (amountSelected >= 1)
            {
                LoadTableSelected(selectedIDList);
            }
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
            string sql = "SELECT IDarea, CONCAT(Nombre,'-',Convocatoria,'-', Año) AS infoArea FROM area ORDER BY Nombre";
            MySqlConnection connectionBD = Connection.connection();
            connectionBD.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                MySqlDataAdapter data = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                data.Fill(dataTable);
                

                cmbSelectAreaInscription.ValueMember = "IDarea";
                cmbSelectAreaInscription.DisplayMember = "infoArea";
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
        private void LoadTypeSearch()
        {
            cmbType.DisplayMember = "Text";
            cmbType.ValueMember = "Value";
            cmbType.SelectedIndex = cmbType.Items.IndexOf("Área (Nombre)");

            cmbType.Items.Add(new { Text = "Área (Nombre)", Value = 1 });
            cmbType.Items.Add(new { Text = "Curso (Nombre)", Value = 2 });
            cmbType.Items.Add(new { Text = "Persona (Nombre)", Value = 3 });
            cmbType.Items.Add(new { Text = "Mes*(Año actual)", Value = 3 });
            cmbType.SelectedIndex = 0;
        }
        private void LoadTableArea(string data)
        {
            CtrlInscription  inscription= new CtrlInscription();
            dgvInscription.DataSource = inscription.consultationArea(data);
            validateSelection();

            if (dgvInscription.Rows.Count > 0)
            {
                try
                {
                    this.dgvInscription.Columns["IDarea"].Visible = false;
                    this.dgvInscription.Columns["IDcurso"].Visible = false;
                    this.dgvInscription.Columns["IDpersona"].Visible = false;
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
            CtrlInscription inscription = new CtrlInscription();
            dgvInscription.DataSource = inscription.consultationCourse(data);
            validateSelection();

            if (dgvInscription.Rows.Count > 0)
            {
                try
                {
                    this.dgvInscription.Columns["IDarea"].Visible = false;
                    this.dgvInscription.Columns["IDcurso"].Visible = false;
                    this.dgvInscription.Columns["IDpersona"].Visible = false;
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
            CtrlInscription inscription = new CtrlInscription();
            dgvInscription.DataSource = inscription.consultationPerson(data);
            validateSelection();

            if (dgvInscription.Rows.Count > 0)
            {
                try
                {
                    this.dgvInscription.Columns["IDarea"].Visible = false;
                    this.dgvInscription.Columns["IDcurso"].Visible = false;
                    this.dgvInscription.Columns["IDpersona"].Visible = false;
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
            CtrlInscription inscription = new CtrlInscription();
            dgvInscription.DataSource = inscription.consultationMonthYear(data);
            validateSelection();

            if (dgvInscription.Rows.Count > 0)
            {
                try
                {
                    this.dgvInscription.Columns["IDarea"].Visible = false;
                    this.dgvInscription.Columns["IDcurso"].Visible = false;
                    this.dgvInscription.Columns["IDpersona"].Visible = false;
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
            CtrlInscription inscription = new CtrlInscription();
            string sentID;
            for (int i = 0; i < Selected.Count; i++)
            {
                sentID = Selected[i].ToString();
                inscription.SelectedEmailSent(sentID);
            }
            dgvInscription.DataSource = inscription.listSelected;
            validateSelection();

            if (dgvInscription.Rows.Count > 0)
            {
                try
                {
                    this.dgvInscription.Columns["IDpersona"].Visible = false;
                    this.dgvInscription.Columns["IDarea"].Visible = false;
                    this.dgvInscription.Columns["IDcurso"].Visible = false;
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
            string sql = "SELECT COUNT(1) FROM inscripcion ";
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
            foreach (DataGridViewRow row in dgvInscription.Rows)
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
        private void dateToday()
        {

            if (actualDate.Month>0 && actualDate.Month<10)
            {
                if (actualDate.Day>0 && actualDate.Day<10)
                {
                    mtbStartDate.Text = actualDate.Year + "0" + actualDate.Month + "0" + actualDate.Day;
                }
                else
                {
                    mtbStartDate.Text = actualDate.Year + "0" + actualDate.Month + "" + actualDate.Day;
                }
            }
            else
            {
                mtbStartDate.Text = actualDate.Year + "" + actualDate.Month + "" + actualDate.Day;
            }
        }
        private void CloseWindow()
        {
            Menu Frm = new Menu();
            Frm.Show();
            this.Close();
        }
        private void cmbSelectAreaInscription_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            LoadCourseInscription();
        }
        private void InscriptionReg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                CloseWindow();
            }
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
            cmbSelectAreaInscription.SelectedIndex = -1;
            cmbSelectCourseInscription.SelectedIndex = -1;
            txtbPersonIDInscription.Text = "";
            mTxBxCode.Text = "";
            ckbApproved.Checked = false;
            dateToday();
            mtbFinalDate.Text = "";
        }

        private void Modifybtn_Click(object sender, EventArgs e)
        {
            
            if (amountSelected == 0)
            {
                MessageBox.Show("No se ha seleccionado ninguna inscripción");
            }
            if (amountSelected == 1)
            {
                SaveChanges.Enabled = true;/******************************/
                this.Height = 876;
                CtrlInscription ctrlIns = new CtrlInscription();
                foreach (DataGridViewRow row in dgvInscription.Rows)
                {
                    bool isChecked = Convert.ToBoolean(row.Cells[0].Value);
                    if (isChecked)
                    {
                        ID_area = row.Cells["IDarea"].Value.ToString();
                        ID_curso = row.Cells["IDcurso"].Value.ToString();
                        ID_persona = row.Cells["IDpersona"].Value.ToString();
                        Inscription ins = ctrlIns.ModifyQuery(ID_curso, ID_area, ID_persona);
                        cmbSelectAreaInscription.SelectedValue= ins.IDarea;
                        LoadCourseInscription();
                        cmbSelectCourseInscription.SelectedValue = ins.IDcurso;
                        txtbPersonIDInscription.Text = ins.IDpersona.ToString();
                        if (ins.Aprobado == "SI") ckbApproved.Checked = true;
                        else ckbApproved.Checked = false;
                        mtbStartDate.Text = ins.FechaInicio.Substring(6,4)+ ins.FechaInicio.Substring(3, 2) + ins.FechaInicio.Substring(0, 2);
                        if(ins.FechaFin == "") mtbFinalDate.Text = ins.FechaFin;
                        else mtbFinalDate.Text = ins.FechaFin.Substring(0, 4) + ins.FechaFin.Substring(5, 2) + ins.FechaFin.Substring(8, 2);
                        mTxBxCode.Text = ins.Código;
                    }
                }
            }

            if (amountSelected > 1)
            {
                MessageBox.Show("Selecciona únicamente a 1 inscripción");
            }
        }

        private void dgvInscription_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idArea = int.Parse(dgvInscription.CurrentRow.Cells["IDarea"].Value.ToString());
            int idCurso = int.Parse(dgvInscription.CurrentRow.Cells["IDcurso"].Value.ToString());
            int idPersona = int.Parse(dgvInscription.CurrentRow.Cells["IDpersona"].Value.ToString());
            string keyInscription = idArea + "," + idCurso + "," + idPersona;
            if (dgvInscription.CurrentRow.Cells["CheckSelection"].Value != null && (bool)dgvInscription.CurrentRow.Cells["CheckSelection"].Value)
            {
                dgvInscription.CurrentRow.Cells["CheckSelection"].Value = false;
                dgvInscription.CurrentRow.Cells["CheckSelection"].Value = null;
                amountSelected += -1;
                if (Menu.action != 2)
                {

                    selectedIDList.Remove(keyInscription);
                    SelectAllcbx.Checked = false;
                }
            }
            else if (dgvInscription.CurrentRow.Cells["CheckSelection"].Value == null)
            {
                if (Menu.action != 2)
                {
                    dgvInscription.CurrentRow.Cells["CheckSelection"].Value = true;

                    selectedIDList.Add(keyInscription);
                    DeselectAllcbx.Checked = false;/****************************/
                }
                else
                {
                    foreach (DataGridViewRow Fila in dgvInscription.Rows)
                    {
                        Fila.Cells[0].Value = null;
                    }
                    amountSelected = 0;
                    dgvInscription.CurrentRow.Cells["CheckSelection"].Value = true;
                }
                amountSelected += 1;
            }
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            SelectAllcbx.Checked = false;
            DeselectAllcbx.Checked = false;
            if (cmbSelectAreaInscription.Text != "")
            {
                if (cmbSelectCourseInscription.Text != "")
                {
                    if (txtbPersonIDInscription.Text != "")
                    {
                        if (mtbStartDate.Text != "")
                        {
                            if (mTxBxCode.Text != "")
                            {
                                int idArea = int.Parse(cmbSelectAreaInscription.SelectedValue.ToString());
                                int idCourse = int.Parse(cmbSelectCourseInscription.SelectedValue.ToString());
                                int idPerson = int.Parse(txtbPersonIDInscription.Text);
                                if (ckbApproved.Checked) winOrLose = 1;
                                else winOrLose = 0;
                                string sql;

                                if (mtbFinalDate.Text == "    /  /" || mtbFinalDate.Visible == false)
                                {
                                    sql = "UPDATE inscripcion SET IDcurso = '" + idCourse + "', IDarea = '" + idArea + "', IDpersona = '" + idPerson + "', Aprobo = '" + winOrLose + "', FechaInicio = '" + mtbStartDate.Text + "', Codigo = '"+mTxBxCode.Text+"', FechaFin = null " +
                                        " WHERE IDcurso = " + ID_curso + " AND IDarea = " + ID_area + " AND IDpersona = " + ID_persona;
                                }
                                else
                                {
                                    sql = "UPDATE inscripcion SET IDcurso = '" + idCourse + "', IDarea = '" + idArea + "', IDpersona = '" + idPerson + "', Aprobo = '" + winOrLose + "', FechaInicio = '" + mtbStartDate.Text + "', Codigo = '" + mTxBxCode.Text + "', FechaFin = '" + mtbFinalDate.Text +
                                         "' WHERE IDcurso = " + ID_curso + " AND IDarea = " + ID_area + " AND IDpersona = " + ID_persona;
                                }


                                MySqlConnection connectionBD = Connection.connection();
                                connectionBD.Open();
                                try
                                {
                                    MySqlCommand command = new MySqlCommand(sql, connectionBD);
                                    command.ExecuteNonQuery();
                                    MessageBox.Show("Inscripción correctamente modificada");
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
                                MessageBox.Show("Ingrese código asignado a la persona");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese la fecha de inicio");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese el ID de la persona");
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
        private void UpdateDataGrid()/******************************************/
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
                dgvInscription.DataSource = null;
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
                MessageBox.Show("No se ha seleccionado ninguna inscripción");
            }
            if (amountSelected >= 1)
            {
                DialogResult dialogResult = MessageBox.Show("¿Deseas eliminar las inscripciones seleccionadas de la base de datos? (Puedes revisar tu selección al presionar el botón 'Ver Seleccionados')", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    for (int i = 0; i < selectedIDList.Count; i++)
                    {
                        saveId = selectedIDList[i].Split(',');
                        string sql = "DELETE FROM inscripcion WHERE IDcurso =" + saveId[1] +" AND IDarea = "+saveId[0]+" AND IDpersona = "+saveId[2];

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
                foreach (DataGridViewRow Fila in dgvInscription.Rows)
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
                foreach (DataGridViewRow Fila in dgvInscription.Rows)
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
