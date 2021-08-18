using CLEC;
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
    public partial class CourseReg : Form
    {
        public int amountSelected = 0;
        public int LastSearchTypeSelected;
        public String textSearch;
        public int amount = 0;

        List<int> selectedIDList = new List<int>();
        public CourseReg()
        {
            InitializeComponent();
            LoadAreaCourse();
            switch (Menu.action)
            {
                case 1:
                    this.Height = 269;
                    bttnAddCourse.Visible = true;
                    cmbType.SelectedIndex = -1;
                    break;
                case 2:
                    this.Height = 312;
                    LoadTypeSearch();
                    cmbType.SelectedIndex = -1;
                    bttnSaveCourse.Visible = true;
                    cmbSelectArea.SelectedIndex = -1;
                    txtText.Visible = true;
                    cmbType.Visible = true;
                    bttnSearch.Visible = true;
                    bttnEraserText.Visible = true;
                    break;
                case 3:
                    this.Height = 174;
                    LoadTypeSearch();
                    HideAndMove();
                    txtText.Visible = true;
                    cmbType.Visible = true;
                    bttnSearch.Visible = true;
                    bttnEraserText.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void bttnReturnCourse_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }
        private void bttnAddCourse_Click(object sender, EventArgs e)
        {
            if (cmbSelectArea.SelectedValue != null && txtbCourseName.Text != "")
            {
                int idArea = int.Parse(cmbSelectArea.SelectedValue.ToString());
                try
                {
                    String NameCourse = txtbCourseName.Text;
                    string sql = "INSERT INTO curso (IDarea,Nombre) VALUES ('" + idArea + "'," +
                        "'" + NameCourse + "')";
                    MySqlConnection connectionBD = Connection.connection();
                    connectionBD.Open();
                    try
                    {
                        MySqlCommand command = new MySqlCommand(sql, connectionBD);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Curso correctamente agregado");
                        Clean();
                    }
                    catch (MySqlException ex1)
                    {
                        MessageBox.Show("Error al guardar" + ex1.Message);
                    }
                    finally
                    {
                        connectionBD.Close();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Seleccione el área" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese los datos");
            }
        }
        private void bttnEraserText_Click(object sender, EventArgs e)
        {
            txtText.Text = "";
        }
        private void bttnSearch_Click(object sender, EventArgs e)
        {
            amountSelected = 0;
            ConsultationAmount();

            dgvCourse.Visible = true;
            bttnViewSelected.Visible = true;
            switch (Menu.action)
            {
                case 2:
                    this.Height = 730;
                    Modifybtn.Visible = true;
                    bttnReturnCourse.Location = new Point(366, 648);
                    DeselectAllcbx.Visible = true;
                    break;
                case 3:
                    this.Height = 593;
                    bttnReturnCourse.Location = new Point(380, 500);
                    SelectAllcbx.Visible = true;
                    Deletebtn.Visible = true;
                    break;
                default:
                    break;
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
                        //0 Area, 1 Nombre
                        case 0:
                            LoadTableArea(textSearch);
                            break;
                        case 1:
                            LoadTableName(textSearch);
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
                MessageBox.Show("No se encuentran avisos/anuncios registrados");
            }
        }
        private void bttnViewSelected_Click(object sender, EventArgs e)
        {
            if (amountSelected == 0)
            {
                MessageBox.Show("No se ha seleccionado a alguna persona");
            }
            else if (amountSelected >= 1)
            {
                LoadTableSelected(selectedIDList);
            }
        }


        private void LoadAreaCourse()
        {
            cmbSelectArea.DataSource = null;
            cmbSelectArea.Items.Clear();
            string sql = "SELECT IDarea,CONCAT(Nombre,', ',Año,', ',Convocatoria) AS NombreCom FROM area ORDER BY Nombre";
            MySqlConnection connectionBD = Connection.connection();
            connectionBD.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                MySqlDataAdapter data = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                data.Fill(dataTable);

                cmbSelectArea.ValueMember = "IDarea";
                cmbSelectArea.DisplayMember = "NombreCom";
                cmbSelectArea.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar áreas" + ex.Message);
            }
        }
        private void LoadTypeSearch()
        {
            cmbType.DisplayMember = "Text";
            cmbType.ValueMember = "Value";
            cmbType.SelectedIndex = cmbType.Items.IndexOf("Área");

            cmbType.Items.Add(new { Text = "Área", Value = 1 });
            cmbType.Items.Add(new { Text = "Nombre", Value = 2 });
            cmbType.SelectedIndex = -1;
        }
        private void LoadTableArea(string data)
        {
            CtrlCourse course = new CtrlCourse();
            dgvCourse.DataSource = course.consultationArea(data);
            validateSelection();

            if (dgvCourse.Rows.Count > 0)
            {
                try
                {
                    this.dgvCourse.Columns["IDarea"].Visible = false;
                    this.dgvCourse.Columns["IDcurso"].Visible = false;
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
        private void LoadTableName(string data)
        {
            CtrlCourse course = new CtrlCourse();
            dgvCourse.DataSource = course.consultationName(data);
            validateSelection();

            if (dgvCourse.Rows.Count > 0)
            {
                try
                {
                    this.dgvCourse.Columns["IDarea"].Visible = false;
                    this.dgvCourse.Columns["IDcurso"].Visible = false;
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
        private void LoadTableSelected(List<int> Selected)
        {
            amountSelected = 0;
            CtrlCourse course = new CtrlCourse();
            int sentID;
            for (int i = 0; i < Selected.Count; i++)
            {
                sentID = int.Parse(Selected[i].ToString());
                course.Selected(sentID);
            }
            dgvCourse.DataSource = course.listSelected;
            validateSelection();

            if (dgvCourse.Rows.Count > 0)
            {
                try
                {
                    this.dgvCourse.Columns["IDarea"].Visible = false;
                    this.dgvCourse.Columns["IDcurso"].Visible = false;
                }
                catch (MySqlException)
                {
                    MessageBox.Show("No se ha seleccionado a alguna persona");
                    LoadTableArea(null);
                }
            }
            else
            {
                MessageBox.Show("No se han seleccionado datos");
                LoadTableArea(null);
            }
        }


        private void HideAndMove()
        {
            lblSelectAreaCourse.Visible = false;
            cmbSelectArea.Visible = false;
            lblCourseName.Visible = false;
            txtbCourseName.Visible = false;
            txtText.Location = new Point(12, 83);
            cmbType.Location = new Point(481, 83);
            bttnSearch.Location = new Point(687, 83);
            bttnEraserText.Location = new Point(809, 83);
            SelectAllcbx.Location = new Point(15, 124);
            DeselectAllcbx.Location = new Point(172, 124);
            dgvCourse.Location = new Point(34, 154);
            Deletebtn.Location = new Point(280, 500);
            bttnViewSelected.Location = new Point(494, 500);
        }
        private void ConsultationAmount()
        {
            string sql = "SELECT COUNT(1) FROM curso ";
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
            foreach (DataGridViewRow row in dgvCourse.Rows)
            {
                for (int i = 0; i < selectedIDList.Count; i++)
                {
                    if (selectedIDList[i].Equals(row.Cells["IDcurso"].Value))
                    {
                        row.Cells["CheckSelection"].Value = true;
                    }
                }
            }
            amountSelected = selectedIDList.Count;
        }


        private void Exit(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                CloseWindow();
            }
        }
        private void Clean()
        {
            cmbSelectArea.Text = "";
            txtbCourseName.Text = "";
        }
        private void CloseWindow()
        {
            Menu Frm = new Menu();
            Frm.Show();
            this.Close();
        }

        private void dgvCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idCourse = int.Parse(dgvCourse.CurrentRow.Cells["IDcurso"].Value.ToString());
            if (dgvCourse.CurrentRow.Cells["CheckSelection"].Value != null && (bool)dgvCourse.CurrentRow.Cells["CheckSelection"].Value)
            {
                dgvCourse.CurrentRow.Cells["CheckSelection"].Value = false;
                dgvCourse.CurrentRow.Cells["CheckSelection"].Value = null;
                amountSelected += -1;
                selectedIDList.Remove(idCourse);
                SelectAllcbx.Checked = false;
            }
            else if (dgvCourse.CurrentRow.Cells["CheckSelection"].Value == null)
            {
                dgvCourse.CurrentRow.Cells["CheckSelection"].Value = true;
                amountSelected += 1;
                selectedIDList.Add(idCourse);
                DeselectAllcbx.Checked = false;
            }
        }
    }
}
