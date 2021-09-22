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
    public partial class AreaReg : Form
    {
        public int amountSelected = 0;
        public int LastSearchTypeSelected;
        public String textSearch;
        public int amount = 0;
        int AreaID;
        private bool update = false;
        char LastBtnClicked;
        List<int> selectedIDList = new List<int>();
        public AreaReg()
        {
            InitializeComponent();
            
            switch (Menu.action)
            {
                case 1:
                    this.Height = 294;
                    bttnImport.Visible = true;
                    FullCombobox();
                    bttnAddArea.Visible = true;
                    break;
                case 2:
                    HideAndMove(true);
                    LoadTypeSearch();
                    Modifybtn.Visible = true;
                    btnSaveData.Visible = true;
                    txtText.Visible = true;
                    cmbType.Visible = true;
                    bttnSearch.Visible = true;
                    bttnEraserText.Visible = true;
                    break;
                case 3:
                    LoadTypeSearch();
                    HideAndMove(false);
                    bttnSaveArea.Visible = true;
                    txtText.Visible = true;
                    cmbType.Visible = true;
                    bttnSearch.Visible = true;
                    bttnEraserText.Visible = true;

                    DeselectAllcbx.Visible = true;
                    SelectAllcbx.Visible = true;
                    Deletebtn.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void bttnAddArea_Click(object sender, EventArgs e)
        {
            if (cmbAnnouncement.Text != "" && cmbYear.Text != "" && txtbAreaName.Text != "")
            {
                int yearArea = int.Parse(cmbYear.Text);
                int convocatoryArea = int.Parse(cmbAnnouncement.Text);
                String nameArea = txtbAreaName.Text;
                if (yearArea > 2010 && yearArea < 9999)
                {
                    if (convocatoryArea > 0 && convocatoryArea < 10)
                    {
                        CtrlArea ctrlArea = new CtrlArea();
                        bool duplicated = ctrlArea.IsDuplicated(nameArea, yearArea, convocatoryArea);
                        if (!duplicated)
                        {
                            string sql = "INSERT INTO Area (Año,Convocatoria,Nombre) VALUES" +
                    "('" + yearArea + "','" + convocatoryArea + "','" + nameArea + "')";

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
                            MessageBox.Show("Ya existe un área con esos datos");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione la convocatoria");
                    }
                }
                else
                {
                    MessageBox.Show("El año debe tener 4 dígitos");
                }
            }
            else
            {
                MessageBox.Show("Por favor, Ingrese la información solicitada");
            }
        }
        private void bttnImportPerson_Click(object sender, EventArgs e)
        {
            int linesCount = 0;
            MessageBox.Show("El formato para el archivo .csv es:\n NOMBRE, AÑO (2010 en adelante), CONVOCATORIA (Solo número, ej: 2)");

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

                            string sql = "INSERT INTO Area (Nombre,Año,Convocatoria) VALUES" +
                        "('" + lineConverted[0] + "','" + lineConverted[1] + "','" + lineConverted[2] + "')";

                            if (lineConverted.Length == 3)
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

        private void bttnReturnArea_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }
        private void bttnSearch_Click(object sender, EventArgs e)
        {
            SelectAllcbx.Checked = false;
            DeselectAllcbx.Checked = false;
            LastBtnClicked = 'b';
            amountSelected = 0;
            ConsultationAmount();

            dgvArea.Visible = true;
            if(Menu.action !=2)bttnViewSelected.Visible = true;
            switch (Menu.action)
            {
                case 2:
                    Modifybtn.Enabled = true;/*******************/
                    break;
                case 3:
                    Deletebtn.Enabled = true;/*******************/
                    SelectAllcbx.Enabled = true;/****************/
                    DeselectAllcbx.Enabled = true;/**************/
                    bttnViewSelected.Enabled = true;/************/
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
                    LoadTableYear(null);
                }
                else
                {
                    switch (cmbType.SelectedIndex)
                    {
                        //0 Área, 1 Curso, 2 Persona, Mes
                        case 0:
                            LoadTableYear(textSearch);
                            break;
                        case 1:
                            LoadTableConvocatory(textSearch);
                            break;
                        case 2:
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
        private void bttnEraserText_Click(object sender, EventArgs e)
        {
            txtText.Text = "";
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
                if (!update) MessageBox.Show("No se ha seleccionado ningún área");
                else
                {
                    dgvArea.DataSource = null;
                }
            }
            else if (amountSelected >= 1)
            {
                LoadTableSelected(selectedIDList);
            }
        }


        private void LoadTypeSearch()
        {
            cmbType.DisplayMember = "Text";
            cmbType.ValueMember = "Value";
            cmbType.SelectedIndex = cmbType.Items.IndexOf("Área");

            cmbType.Items.Add(new { Text = "Año", Value = 1 });
            cmbType.Items.Add(new { Text = "Convocatoria", Value = 2 });
            cmbType.Items.Add(new { Text = "Nombre", Value = 3 });
            cmbType.SelectedIndex = 0;
        }
        private void LoadTableYear(string data)
        {
            CtrlArea area = new CtrlArea();
            dgvArea.DataSource = area.consultationYear(data);
            validateSelection();
            lblResult.Text = "Total Resultados: " + dgvArea.Rows.Count;
            lblResult.Visible = true;

            if (dgvArea.Rows.Count > 0)
            {
                try
                {
                    this.dgvArea.Columns["IDarea"].Visible = false;
                }
                catch (MySqlException)
                {
                    if (!update)
                    {
                        MessageBox.Show("No se ha encontrado coincidencias");
                        LoadTableYear(null);
                    }
                }
            }
            else
            {
                if (!update)
                {
                    MessageBox.Show("No se han encontrado datos");
                    LoadTableYear(null);
                }
            }
        }
        private void LoadTableConvocatory(string data)
        {
            CtrlArea area = new CtrlArea();
            dgvArea.DataSource = area.consultationConvocatory(data);
            validateSelection();
            lblResult.Text = "Total Resultados: " + dgvArea.Rows.Count;
            lblResult.Visible = true;

            if (dgvArea.Rows.Count > 0)
            {
                try
                {
                    this.dgvArea.Columns["IDarea"].Visible = false;
                }
                catch (MySqlException)
                {
                    if (!update)
                    {
                        MessageBox.Show("No se ha encontrado coincidencias");
                        LoadTableConvocatory(null);
                    }
                }
            }
            else
            {
                if (!update)
                {
                    MessageBox.Show("No se han encontrado datos");
                    LoadTableConvocatory(null);
                }
            }
        }
        private void LoadTableName(string data)
        {
            CtrlArea area = new CtrlArea();
            dgvArea.DataSource = area.consultationName(data);
            validateSelection();
            lblResult.Text = "Total Resultados: " + dgvArea.Rows.Count;
            lblResult.Visible = true;

            if (dgvArea.Rows.Count > 0)
            {
                try
                {
                    this.dgvArea.Columns["IDarea"].Visible = false;
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
        private void LoadTableSelected(List<int> Selected)
        {
            amountSelected = 0;
            CtrlArea area = new CtrlArea();
            int sentID;
            for (int i = 0; i < Selected.Count; i++)
            {
                sentID = int.Parse(Selected[i].ToString());
                area.Selected(sentID);
            }
            dgvArea.DataSource = area.listSelected;
            validateSelection();

            lblResult.Text = "Total Resultados: " + dgvArea.Rows.Count;
            lblResult.Visible = true;

            if (dgvArea.Rows.Count > 0)
            {
                try
                {
                    this.dgvArea.Columns["IDarea"].Visible = false;
                }
                catch (MySqlException)
                {
                    if (!update)
                    {
                        MessageBox.Show("No se ha seleccionado a alguna persona");
                        LoadTableYear(null);
                    }
                }
            }
            else
            {
                if (!update)
                {
                    MessageBox.Show("No se han seleccionado datos");
                    LoadTableYear(null);
                }
            }
        }


        private void FullCombobox()
        {
            //Años
            cmbYear.Items.Add("2017");
            cmbYear.Items.Add("2018");
            cmbYear.Items.Add("2019");
            cmbYear.Items.Add("2020");
            cmbYear.Items.Add("2021");
            cmbYear.Items.Add("2022");
            cmbYear.Items.Add("2023");
            cmbYear.Items.Add("2024");
            cmbYear.Items.Add("2025");
            cmbYear.Items.Add("2026");
            cmbYear.Items.Add("2027");
            cmbYear.Items.Add("2028");
            cmbYear.Items.Add("2029");
            cmbYear.Items.Add("2030");
            //Convocatoria
            cmbAnnouncement.Items.Add("1");
            cmbAnnouncement.Items.Add("2");
            cmbAnnouncement.Items.Add("3");
        }
        private void ConsultationAmount()
        {
            string sql = "SELECT COUNT(1) FROM area ";
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
            foreach (DataGridViewRow row in dgvArea.Rows)
            {
                for (int i = 0; i < selectedIDList.Count; i++)
                {
                    if (selectedIDList[i].Equals(row.Cells["IDarea"].Value))
                    {
                        row.Cells["CheckSelection"].Value = true;
                    }
                }
            }
            amountSelected = selectedIDList.Count;
        }


        private void HideAndMove(bool justOneSelection)
        {
            this.Height = 640;
            SearchGBox.Top = 62;
            DataGBox.Top += 541;
            if (!justOneSelection)
            {
                SelectAllcbx.Visible = true;
                DeselectAllcbx.Visible = true;
                bttnViewSelected.Visible = true;
            }
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
            cmbYear.Text="";
            cmbAnnouncement.Text="";
            txtbAreaName.Text = "";
        }
        private void CloseWindow()
        {
            Menu Frm = new Menu();
            Frm.Show();
            this.Close();
        }

        private void Modifybtn_Click(object sender, EventArgs e)
        {
            
            CtrlArea ctrl = new CtrlArea();
            if (amountSelected == 0)
            {
                MessageBox.Show("No se ha seleccionado ningún Área");
            }
            if (amountSelected == 1)
            {
                this.Height = 839;/***************************************/
                btnSaveData.Enabled = true;/******************************/
                foreach (DataGridViewRow row in dgvArea.Rows)
                {
                    bool isChecked = Convert.ToBoolean(row.Cells[0].Value);
                    if (isChecked)
                    {
                        AreaID = Convert.ToInt32(row.Cells["IDarea"].Value);
                        Area area = ctrl.ModifyQuery(row.Cells["IDarea"].Value.ToString());
                        FullCombobox();
                        cmbYear.SelectedItem = area.Año.ToString();
                        cmbAnnouncement.SelectedItem = area.Convocatoria.ToString();
                        txtbAreaName.Text = area.Nombre;
                    }
                }
            }

            if (amountSelected > 1)
            {
                MessageBox.Show("Selecciona únicamente a 1 Área");
            }
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            SelectAllcbx.Checked = false;
            DeselectAllcbx.Checked = false;
            if (cmbAnnouncement.Text != null && cmbYear.Text != null && txtbAreaName.Text != "")
            {
                int yearArea = int.Parse(cmbYear.Text);
                int convocatoryArea = int.Parse(cmbAnnouncement.Text);
                String nameArea = txtbAreaName.Text;
                if (yearArea > 2010 && yearArea < 2999)
                {
                    if (convocatoryArea > 0 && convocatoryArea < 10)
                    {
                        CtrlArea ctrlArea = new CtrlArea();
                        bool Duplicated = ctrlArea.IsDuplicated(nameArea, yearArea, convocatoryArea);
                        if (!Duplicated)
                        {
                            string sql = "UPDATE area SET Nombre = '" + nameArea + "', Año = '" + yearArea + "', Convocatoria = '" + convocatoryArea +
                        "' WHERE IDarea =" + AreaID;

                            MySqlConnection connectionBD = Connection.connection();
                            connectionBD.Open();
                            try
                            {
                                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                                command.ExecuteNonQuery();
                                MessageBox.Show("Se ha modificado exitosamente");
                                EmptyChecked();

                                UpdateDataGrid();
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
                            MessageBox.Show("Ya existe un área con los mismos datos");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione la convocatoria");
                    }
                }
                else
                {
                    MessageBox.Show("El año debe ser desde 2010 en adelante");
                }
            }
            else
            {
                MessageBox.Show("Por favor, Ingrese la información solicitada");
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            SelectAllcbx.Checked = false;
            DeselectAllcbx.Checked = false;
            int saveId = 0;
            if (amountSelected == 0)
            {
                MessageBox.Show("No se ha seleccionado a ningún Área");
            }
            if (amountSelected >= 1)
            {
                DialogResult dialogResult = MessageBox.Show("¿Deseas eliminar las áreas seleccionadas de la base de datos? (Puedes revisar tu selección al presionar el botón 'Ver Seleccionados')", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    for (int i = 0; i < selectedIDList.Count; i++)
                    {
                        saveId = int.Parse(selectedIDList[i].ToString());
                        string sql = "DELETE FROM area WHERE IDarea =" + saveId;

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
                foreach (DataGridViewRow Fila in dgvArea.Rows)
                {
                    int currentID = Convert.ToInt32(Fila.Cells["IDarea"].Value);
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
            ConsultationAmount();
            update = true;
            if (amount > 0)
            {
                switch (LastBtnClicked)
                {
                    case 'b':
                        if (textSearch == "")
                        {
                            LoadTableYear(null);
                        }
                        else
                        {
                            switch (cmbType.SelectedIndex)
                            {
                                //0 Área, 1 Curso, 2 Persona, Mes
                                case 0:
                                    LoadTableYear(textSearch);
                                    break;
                                case 1:
                                    LoadTableConvocatory(textSearch);
                                    break;
                                case 2:
                                    LoadTableName(textSearch);
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
                dgvArea.DataSource = null;
            }
            update = false;
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
                foreach (DataGridViewRow Fila in dgvArea.Rows)
                {
                    int currentID = Convert.ToInt32(Fila.Cells["IDarea"].Value);
                    if (selectedIDList.Contains(currentID))
                    {
                        selectedIDList.Remove(currentID);
                        amountSelected--;
                    }

                    Fila.Cells[0].Value = null;
                }
            }
        }

        private void dgvArea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idArea = int.Parse(dgvArea.CurrentRow.Cells["IDarea"].Value.ToString());
            if (dgvArea.CurrentRow.Cells["CheckSelection"].Value != null && (bool)dgvArea.CurrentRow.Cells["CheckSelection"].Value)
            {
                dgvArea.CurrentRow.Cells["CheckSelection"].Value = false;
                dgvArea.CurrentRow.Cells["CheckSelection"].Value = null;
                amountSelected += -1;
                if (Menu.action != 2)
                {
                    selectedIDList.Remove(idArea);
                    SelectAllcbx.Checked = false;
                }
            }
            else if (dgvArea.CurrentRow.Cells["CheckSelection"].Value == null)
            {
                if (Menu.action != 2)
                {
                    dgvArea.CurrentRow.Cells["CheckSelection"].Value = true;

                    selectedIDList.Add(idArea);
                    DeselectAllcbx.Checked = false;
                }
                else
                {
                    foreach (DataGridViewRow Fila in dgvArea.Rows)
                    {
                        Fila.Cells[0].Value = null;
                    }
                    amountSelected = 0;
                    dgvArea.CurrentRow.Cells["CheckSelection"].Value = true;
                }
                amountSelected += 1;
            }
        }
       
    }
}
