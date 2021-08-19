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
        int CourseID;
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
                    btnSaveData.Visible = true;
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
            SelectAllcbx.Checked = false;
            DeselectAllcbx.Checked = false;
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
                MessageBox.Show("No se encuentran cursos registrados");
            }
        }
        private void bttnViewSelected_Click(object sender, EventArgs e)
        {
            SelectAllcbx.Checked = false;
            DeselectAllcbx.Checked = false;
            if (amountSelected == 0)
            {
                MessageBox.Show("No se ha seleccionado ningún curso");
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


        private void Modifybtn_Click(object sender, EventArgs e)
        {
            CtrlCourse ctrl = new CtrlCourse();
            if (amountSelected == 0)
            {
                MessageBox.Show("No se ha seleccionado ningún curso");
            }
            if (amountSelected == 1)
            {
                foreach (DataGridViewRow row in dgvCourse.Rows)
                {
                    bool isChecked = Convert.ToBoolean(row.Cells[0].Value);
                    if (isChecked)
                    {
                        CourseID = Convert.ToInt32(row.Cells["IDcurso"].Value);
                        Course course = ctrl.ModifyQuery(row.Cells["IDcurso"].Value.ToString());
                        cmbSelectArea.SelectedValue = course.IDarea;
                        txtbCourseName.Text = course.Nombre;
                    }
                }
            }

            if (amountSelected > 1)
            {
                MessageBox.Show("Selecciona únicamente a 1 curso");
            }
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            SelectAllcbx.Checked = false;
            DeselectAllcbx.Checked = false;
            if (cmbSelectArea.SelectedValue != null && txtbCourseName.Text != "")
            {
                int idArea = int.Parse(cmbSelectArea.SelectedValue.ToString());
                try
                {
                    String NameCourse = txtbCourseName.Text;
                    string sql = "UPDATE curso SET IDarea = '" + idArea + "', Nombre = '" + NameCourse + "' " +
                    "WHERE IDcurso =" + CourseID;
                    MySqlConnection connectionBD = Connection.connection();
                    connectionBD.Open();
                    try
                    {
                        MySqlCommand command = new MySqlCommand(sql, connectionBD);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Curso correctamente modificado");
                        EmptyChecked();

                        UpdateDataGrid();
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

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            SelectAllcbx.Checked = false;
            DeselectAllcbx.Checked = false;
            int saveId = 0;
            if (amountSelected == 0)
            {
                MessageBox.Show("No se ha seleccionado ningún curso");
            }
            if (amountSelected >= 1)
            {
                DialogResult dialogResult = MessageBox.Show("¿Deseas eliminar los cursos seleccionadas de la base de datos? (Puedes revisar tu selección al presionar el botón 'Ver Seleccionados')", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    for (int i = 0; i < selectedIDList.Count; i++)
                    {
                        saveId = int.Parse(selectedIDList[i].ToString());
                        string sql = "DELETE FROM curso WHERE IDcurso =" + saveId;

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
                foreach (DataGridViewRow Fila in dgvCourse.Rows)
                {
                    int currentID = Convert.ToInt32(Fila.Cells["IDcurso"].Value);
                    if (!selectedIDList.Contains(currentID))
                    {
                        selectedIDList.Add(currentID);
                        amountSelected++;
                    }
                    Fila.Cells[0].Value = true;
                }
            }
        }
        private void UpdateDataGrid()
        {
            amountSelected = 0;
            ConsultationAmount();
            if (amount > 0)
            {
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
                            MessageBox.Show("ERROOOOOOOOOOOOOOOOOOOOR");
                            cmbType.Text = "";
                            break;
                    }
                }
            }
            if (amount == 0)
            {
                dgvCourse.DataSource = null;
            }
        }
        private void EmptyChecked()
        {
            amountSelected = 0;
            selectedIDList.Clear();
        }

        private void DeselectAllcbx_CheckedChanged(object sender, EventArgs e)
        {
            if (DeselectAllcbx.Checked)
            {
                SelectAllcbx.Checked = false;
                foreach (DataGridViewRow Fila in dgvCourse.Rows)
                {
                    int currentID = Convert.ToInt32(Fila.Cells["IDcurso"].Value);
                    if (selectedIDList.Contains(currentID))
                    {
                        selectedIDList.Remove(currentID);
                        amountSelected--;
                    }

                    Fila.Cells[0].Value = null;
                }
            }
        }

        private void dgvCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idCourse = int.Parse(dgvCourse.CurrentRow.Cells["IDcurso"].Value.ToString());
            if (dgvCourse.CurrentRow.Cells["CheckSelection"].Value != null && (bool)dgvCourse.CurrentRow.Cells["CheckSelection"].Value)
            {
                dgvCourse.CurrentRow.Cells["CheckSelection"].Value = false;
                dgvCourse.CurrentRow.Cells["CheckSelection"].Value = null;
                amountSelected += -1;
                if (Menu.action != 2)
                {
                    selectedIDList.Remove(idCourse);
                    SelectAllcbx.Checked = false;
                }
            }
            else if (dgvCourse.CurrentRow.Cells["CheckSelection"].Value == null)
            {
                if (Menu.action != 2)
                {
                    dgvCourse.CurrentRow.Cells["CheckSelection"].Value = true;

                    selectedIDList.Add(idCourse);
                    DeselectAllcbx.Checked = false;
                }
                else
                {
                    foreach (DataGridViewRow Fila in dgvCourse.Rows)
                    {
                        Fila.Cells[0].Value = null;
                    }
                    amountSelected = 0;
                    dgvCourse.CurrentRow.Cells["CheckSelection"].Value = true;
                }
                amountSelected += 1;
            }
        }
    }
}
