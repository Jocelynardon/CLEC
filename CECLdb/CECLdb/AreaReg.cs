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
    public partial class AreaReg : Form
    {
        public int amountSelected = 0;
        public int LastSearchTypeSelected;
        public String textSearch;
        public int amount = 0;

        List<int> selectedIDList = new List<int>();
        public AreaReg()
        {
            InitializeComponent();
            
            switch (Menu.action)
            {
                case 1:
                    this.Height = 306;
                    FullCombobox();
                    bttnAddArea.Visible = true;
                    break;
                case 2:
                    this.Height = 355;
                    LoadTypeSearch();
                    bttnSaveArea.Visible = true;
                    txtText.Visible = true;
                    cmbType.Visible = true;
                    bttnSearch.Visible = true;
                    bttnEraserText.Visible = true;
                    break;
                case 3:
                    this.Height = 167;
                    LoadTypeSearch();
                    HideAndMove();
                    bttnSaveArea.Visible = true;
                    txtText.Visible = true;
                    cmbType.Visible = true;
                    bttnSearch.Visible = true;
                    bttnEraserText.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void bttnAddArea_Click(object sender, EventArgs e)
        {
            if (cmbAnnouncement.Text != null && cmbYear.Text != null && txtbAreaName.Text != "")
            {
                int yearArea = int.Parse(cmbYear.Text);
                int convocatoryArea = int.Parse(cmbAnnouncement.Text);
                String nameArea = txtbAreaName.Text;
                if (yearArea > 2010 && yearArea < 2999)
                {
                    if (convocatoryArea > 0 && convocatoryArea < 10)
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
                        MessageBox.Show("Seleccione la convocatoria");
                    }
                }
                else
                {
                    MessageBox.Show("El año debe ser 2010 en adelante");
                }
            }
            else
            {
                MessageBox.Show("Por favor, Ingrese la información solicitada");
            }
        }
        private void bttnReturnArea_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }
        private void bttnSearch_Click(object sender, EventArgs e)
        {
            amountSelected = 0;
            ConsultationAmount();

            dgvArea.Visible = true;
            bttnViewSelected.Visible = true;
            switch (Menu.action)
            {
                case 2:
                    this.Height = 772;
                    Modifybtn.Visible = true;
                    bttnReturnArea.Location = new Point(301, 687);
                    DeselectAllcbx.Visible = true;
                    break;
                case 3:
                    bttnReturnArea.Location = new Point(325, 511);
                    this.Height = 597;
                    DeselectAllcbx.Visible = true;
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
            if (amountSelected == 0)
            {
                MessageBox.Show("No se ha seleccionado a alguna persona");
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

            if (dgvArea.Rows.Count > 0)
            {
                try
                {
                    this.dgvArea.Columns["IDarea"].Visible = false;
                }
                catch (MySqlException)
                {
                    MessageBox.Show("No se ha encontrado coincidencias");
                    LoadTableYear(null);
                }
            }
            else
            {
                MessageBox.Show("No se han encontrado datos");
                LoadTableYear(null);
            }
        }
        private void LoadTableConvocatory(string data)
        {
            CtrlArea area = new CtrlArea();
            dgvArea.DataSource = area.consultationConvocatory(data);
            validateSelection();

            if (dgvArea.Rows.Count > 0)
            {
                try
                {
                    this.dgvArea.Columns["IDarea"].Visible = false;
                }
                catch (MySqlException)
                {
                    MessageBox.Show("No se ha encontrado coincidencias");
                    LoadTableConvocatory(null);
                }
            }
            else
            {
                MessageBox.Show("No se han encontrado datos");
                LoadTableConvocatory(null);
            }
        }
        private void LoadTableName(string data)
        {
            CtrlArea area = new CtrlArea();
            dgvArea.DataSource = area.consultationName(data);
            validateSelection();

            if (dgvArea.Rows.Count > 0)
            {
                try
                {
                    this.dgvArea.Columns["IDarea"].Visible = false;
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
            CtrlArea area = new CtrlArea();
            int sentID;
            for (int i = 0; i < Selected.Count; i++)
            {
                sentID = int.Parse(Selected[i].ToString());
                area.Selected(sentID);
            }
            dgvArea.DataSource = area.listSelected;
            validateSelection();

            if (dgvArea.Rows.Count > 0)
            {
                try
                {
                    this.dgvArea.Columns["IDarea"].Visible = false;
                }
                catch (MySqlException)
                {
                    MessageBox.Show("No se ha seleccionado a alguna persona");
                    LoadTableYear(null);
                }
            }
            else
            {
                MessageBox.Show("No se han seleccionado datos");
                LoadTableYear(null);
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


        private void HideAndMove()
        {
            lblYear.Visible = false;
            cmbYear.Visible = false;
            lblAnnouncement.Visible = false;
            cmbAnnouncement.Visible = false;
            lblAreaName.Visible = false;
            txtbAreaName.Visible = false;
            txtText.Location = new Point(12, 76);
            cmbType.Location = new Point(481, 75);
            bttnSearch.Location = new Point(687, 77);
            bttnEraserText.Location = new Point(809, 78);
            SelectAllcbx.Location = new Point(24, 127);
            DeselectAllcbx.Location = new Point(181, 127);
            dgvArea.Location = new Point(24, 165);
            Deletebtn.Location = new Point(225, 511);
            bttnViewSelected.Location = new Point(425, 511);
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

        private void dgvArea_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idArea = int.Parse(dgvArea.CurrentRow.Cells["IDarea"].Value.ToString());
            if (dgvArea.CurrentRow.Cells["CheckSelection"].Value != null && (bool)dgvArea.CurrentRow.Cells["CheckSelection"].Value)
            {
                dgvArea.CurrentRow.Cells["CheckSelection"].Value = false;
                dgvArea.CurrentRow.Cells["CheckSelection"].Value = null;
                amountSelected += -1;
                selectedIDList.Remove(idArea);
                SelectAllcbx.Checked = false;
            }
            else if (dgvArea.CurrentRow.Cells["CheckSelection"].Value == null)
            {
                dgvArea.CurrentRow.Cells["CheckSelection"].Value = true;
                amountSelected += 1;
                selectedIDList.Add(idArea);
                DeselectAllcbx.Checked = false;
            }
        }
    }
}
