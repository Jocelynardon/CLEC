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

        public static int id = 0;
        public static int type = 0;
        public int amountSelected = 0;
        public int LastSearchTypeSelected;
        public String textSearch;
        public int amount = 0;

        public List<int> selectedIDList = new List<int>();
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
                if (Menu.action==3||Menu.action==4)
                {
                    //Ocultar y reducir
                    this.Height = 168;
                    HideAndMove();
                }
            }
            if (Menu.action==1)
            {
                cmbSelectAreaInscription.SelectedIndex = -1;
                dateToday();
                this.Height = 300;
                btnClean.Visible = true;
                bttnAddInscription.Visible = true;
            }
            if (Menu.action==2)
            {
                this.Height = 375;
                btnClean.Visible = true;
                bttnSaveInscription.Visible = true;
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
                            int idArea = int.Parse(cmbSelectAreaInscription.SelectedValue.ToString());
                            int idCourse = int.Parse(cmbSelectCourseInscription.SelectedValue.ToString());
                            int idPerson = int.Parse(txtbPersonIDInscription.Text);
                            string sql;

                            if (mtbFinalDate.Text=="    /  /" || mtbFinalDate.Visible==false)
                            {
                                sql = "INSERT INTO inscripcion (IDarea,IDcurso,IDpersona,FechaInicio,Aprobo) VALUES ('" + idArea + "'," +
                                "'" + idCourse + "','" + idPerson + "','" + mtbStartDate.Text + "','" + winOrLose + "')";
                            }
                            else
                            {
                                sql = "INSERT INTO inscripcion (IDarea,IDcurso,IDpersona,FechaInicio,FechaFin,Aprobo) VALUES ('" + idArea + "'," +
                                "'" + idCourse + "','" + idPerson + "','" + mtbStartDate.Text + "','" + mtbFinalDate.Text + "','" + winOrLose + "')";
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
            amountSelected = 0;
            ConsultationAmount();

            bttnViewSelected.Visible = true;
            dgvInscription.Visible = true;
            if (Menu.action == 2)
            {
                this.Height = 761;
                DeselectAllcbx.Visible = true;
                Modifybtn.Location = new Point(404, 677);
                Modifybtn.Visible = true;
                bttnReturnInscription.Location = new Point(504, 677);
            }
            if (Menu.action == 3 || Menu.action == 4)
            {
                this.Height = 594;
                DeselectAllcbx.Visible = true;
                //Mostrar botones según la opción
                if (Menu.action == 3)
                {
                    Deletebtn.Visible = true;
                    SelectAllcbx.Visible = true;
                }
                else
                {
                    bttnSelect.Visible = true;
                }
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
                MessageBox.Show("No se encuentran avisos/anuncios registrados");
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
            cmbType.SelectedIndex = cmbType.Items.IndexOf("Área");

            cmbType.Items.Add(new { Text = "Área", Value = 1 });
            cmbType.Items.Add(new { Text = "Curso", Value = 2 });
            cmbType.Items.Add(new { Text = "Persona", Value = 3 });
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
                    MessageBox.Show("No se ha encontrado coincidencias");
                    LoadTableArea(null);
                }
            }
            else
            {
                MessageBox.Show("No se han encontrado datos");
                LoadTableArea(null);
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
                    MessageBox.Show("No se ha encontrado coincidencias");
                    LoadTableCourse(null);
                }
            }
            else
            {
                MessageBox.Show("No se han encontrado datos");
                LoadTableCourse(null);
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
                    MessageBox.Show("No se ha encontrado coincidencias");
                    LoadTablePerson(null);
                }
            }
            else
            {
                MessageBox.Show("No se han encontrado datos");
                LoadTablePerson(null);
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
                    MessageBox.Show("No se ha encontrado coincidencias");
                    LoadTableMonthYear(null);
                }
            }
            else
            {
                MessageBox.Show("No se han encontrado datos");
                LoadTableMonthYear(null);
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
                    if (selectedIDList[i].Equals(row.Cells["IDaviso"].Value))
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
                    textSearch= "01";
                    break;
                case "febrero":
                    textSearch = "02";
                    break;
                case "marzo":
                    textSearch = "03";
                    break;
                case "abril":
                    textSearch = "04";
                    break;
                case "mayo":
                    textSearch = "05";
                    break;
                case "junio":
                    textSearch = "06";
                    break;
                case "julio":
                    textSearch = "07";
                    break;
                case "agosto":
                    textSearch = "08";
                    break;
                case "septiembre":
                    textSearch = "09";
                    break;
                case "octubre":
                    textSearch = "10";
                    break;
                case "noviembre":
                    textSearch = "11";
                    break;
                case "diciembre":
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
        private void HideAndMove()
        {
            lblSelectAreaInscription.Visible = false;
            cmbSelectAreaInscription.Visible = false;
            lblSelectCourseInscription.Visible = false;
            cmbSelectCourseInscription.Visible = false;
            lblPersonIDInscription.Visible = false;
            txtbPersonIDInscription.Visible = false;
            bttnSearchPerson.Visible = false;
            ckbApproved.Visible = false;
            lblStartDate.Visible = false;
            mtbStartDate.Visible = false;
            lblFinalDateInscription.Visible = false;
            mtbFinalDate.Visible = false;
            txtText.Location = new Point(12, 79);
            cmbType.Location = new Point(592, 79);
            bttnSearch.Location = new Point(857, 79);
            bttnEraserText.Location = new Point(989, 79);
            SelectAllcbx.Location = new Point(26, 121);
            DeselectAllcbx.Location = new Point(183, 121);
            dgvInscription.Location = new Point(46, 156);
            Deletebtn.Location = new Point(387, 502);
            bttnSelect.Location = new Point(387, 502);
            bttnReturnInscription.Location = new Point(487, 502);
            bttnViewSelected.Location = new Point(592, 502);
        }

        private void CloseWindow()
        {
            Menu Frm = new Menu();
            Frm.Show();
            this.Close();
        }

        private void dgvInscription_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //idAd = int.Parse(dgvAdReg.CurrentRow.Cells["IDaviso"].Value.ToString());
            //if (dgvAdReg.CurrentRow.Cells["CheckSelection"].Value != null && (bool)dgvAdReg.CurrentRow.Cells["CheckSelection"].Value)
            //{
            //    dgvAdReg.CurrentRow.Cells["CheckSelection"].Value = false;
            //    dgvAdReg.CurrentRow.Cells["CheckSelection"].Value = null;
            //    amountSelectedAd += -1;
            //    selectedIDList.Remove(idAd);
            //    SelectAllcbx.Checked = false;
            //}
            //else if (dgvAdReg.CurrentRow.Cells["CheckSelection"].Value == null)
            //{
            //    dgvAdReg.CurrentRow.Cells["CheckSelection"].Value = true;
            //    amountSelectedAd += 1;
            //    selectedIDList.Add(idAd);
            //    DeselectAllcbx.Checked = false;
            //}
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
            ckbApproved.Checked = false;
            dateToday();
            mtbFinalDate.Text = "";
        }
    }
}
