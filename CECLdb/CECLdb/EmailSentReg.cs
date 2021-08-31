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
    public partial class EmailSentReg : Form, AddID
    {
        public static int id = 0;
        public static int type = 0;
        public int amountSelected = 0;
        public int CurrentAdID;
        public String textSearch;
        public int LastSearchTypeSelected;
        public int amount = 0;
        public List<int> selectedIDList = new List<int>();
        public List<int> RemovedIDList = new List<int>();
        public List<int> OriginalIDList = new List<int>();
        public List<int> AddedIDList = new List<int>();
        string ChosenAdID;
        char LastButtonClicked;
        bool updating;
        //Falta agregar una lista con los seleccionados, mostrar las demás personas que no se encuentren en ese aviso
        public EmailSentReg()
        {
            InitializeComponent();
            if (Menu.action==2 || Menu.action==3)
            {
                this.Height = 111;
            }
        }

        private void bttnReturnEmailSent_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }
        private void bttnSearch_Click(object sender, EventArgs e)
        {
            Menu.action = 5;
            AdReg frmAdd = new AdReg();
            frmAdd.Show(this);
            
        }
        private void PersonSent()
        {
            if (!updating)
            {
                SelectAllcbx.Checked = false;
                DeselectAllcbx.Checked = false;
                LastButtonClicked = 'p';
            }
            cmbTypeSearch.Items.Clear();
            amountSelected = 0;
            LoadTypeSearch();
            string IDSearch = txtNoAviso.Text.ToString();
            consultationAmount(IDSearch);
            if (amount>0)
            {
                dgvEmailSent.Visible = true;
                LoadTableID(IDSearch);
                this.Height = 750;
                bttnReturnEmailSent.Location = new Point(448, 484);
                SelectAllcbx.Visible = true;
                DeselectAllcbx.Visible = true;
                bttnViewSelected.Visible = true;
                bttnViewAll.Visible = true;
                if (Menu.action == 2)
                {
                    Modifybtn.Visible = true;
                }
                if (Menu.action == 3)
                {
                    DeletedPreviewbtn.Location = new Point(332, 484);
                    DeletedPreviewbtn.Visible = true;
                }
            }
            if (amount == 0)
            {
                if (!updating) 
                {
                    MessageBox.Show("No hay correos enviados con ese aviso");
                    AdReg.empty = -1;
                    dgvEmailSent.DataSource = null;
                }
                else
                {
                    updating = false;
                    dgvEmailSent.DataSource = null;
                }
                
            }
        }
        private void bttnViewAll_Click(object sender, EventArgs e)
        {
            SelectAllcbx.Checked = false;
            DeselectAllcbx.Checked = false;
            CtrlPerson person = new CtrlPerson();
            dgvEmailSent.DataSource = person.consultationName(null);
            validateSelection();
            LastButtonClicked = 'T';
            if (dgvEmailSent.Rows.Count > 0)
            {
                try
                {
                    this.dgvEmailSent.Columns["ID"].Visible = false;
                }
                catch (MySqlException)
                {
                    if (!updating) MessageBox.Show("No se han ingresado personas");
                    else
                    {
                        dgvEmailSent.DataSource = null;
                        updating = false;
                    }
                }
            }
            else
            {
                if (!updating) MessageBox.Show("No se han ingresado personas");
                else
                {
                    dgvEmailSent.DataSource = null;
                    updating = false;
                }
            }
        }
        private void bttnViewSelected_Click(object sender, EventArgs e)
        {
            if (!updating)
            {
                SelectAllcbx.Checked = false;
                DeselectAllcbx.Checked = false;
                LastButtonClicked = 'v';
            }
            if (amountSelected == 0)
            {
                if (!updating) MessageBox.Show("No se ha seleccionado ningún destinatario");
                else
                {
                    updating = false;
                    dgvEmailSent.DataSource = null;
                }
            }
            else if (amountSelected >= 1)
            {
                LoadTableFromPersonList(selectedIDList);
            }
        }

        public void ExportData(DataGridView dataList)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application exportExcel = new Microsoft.Office.Interop.Excel.Application();
                exportExcel.Application.Workbooks.Add(true);

                int indexColumn = 0;
                foreach (DataGridViewColumn column in dataList.Columns)
                {
                    indexColumn++;

                    exportExcel.Cells[1, indexColumn] = column.Name;
                }
                int indexRow = 0;
                foreach (DataGridViewRow row in dataList.Rows)
                {
                    indexRow++;
                    indexColumn = 0;
                    foreach (DataGridViewColumn column in dataList.Columns)
                    {
                        indexColumn++;
                        exportExcel.Cells[indexRow + 1, indexColumn] = row.Cells[column.Name].Value;
                    }
                }
                exportExcel.Visible = true;
            }
            catch (Exception)
            {

                MessageBox.Show("No hay Correos a Exportar."); ;
            }
        }
        private void Access(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                CloseWindow();
            }

        }
        private void LoadTableID(string data)
        {
            CtrlPerson person = new CtrlPerson();
            dgvEmailSent.DataSource = person.consultationIDEmailSent(data);
            validateSelection();

            if (dgvEmailSent.Rows.Count > 0)
            {
                try
                {
                    this.dgvEmailSent.Columns["ID"].Visible = false;
                    this.dgvEmailSent.Columns["Apellido"].Visible = false;
                    CheckShow();

                }
                catch (MySqlException)
                {
                    if (!updating) MessageBox.Show("No se ha encontrado coincidencias");
                    else updating = false;
                }
            }
            else
            {
                if (!updating) MessageBox.Show("No se han encontrado datos");
                else updating = false;
            }
        }
        private void LoadTableFromPersonList(List<int> personList)
        {
            amountSelected = 0;
            CtrlPerson person = new CtrlPerson();
            int sentID = 0;
            for (int i = 0; i < personList.Count; i++)
            {
                sentID = int.Parse(personList[i].ToString());
                person.SelectedEmailSent(sentID);
            }
            dgvEmailSent.DataSource = person.listSelected;
            validateSelection();

            if (dgvEmailSent.Rows.Count > 0)
            {
                try
                {
                    this.dgvEmailSent.Columns["ID"].Visible = false;
                    this.dgvEmailSent.Columns["Apellido"].Visible = false;
                }
                catch (MySqlException)
                {
                    if (!updating)
                    {
                        MessageBox.Show("No se ha seleccionado a alguna persona");
                        person.consultationName(null);
                    }
                    else updating = false;
                }
            }
            else
            {
                if (!updating)
                {
                    MessageBox.Show("No se han seleccionado datos");
                    person.consultationName(null);
                }
                else updating = false;
            }
        }
        private void CheckShow()
        {
            foreach (DataGridViewRow row in dgvEmailSent.Rows)
            {
                row.Cells["ChangeStatusbtn"].Value = "Eliminar";
                row.Cells["ChangeStatusbtn"].Style.SelectionBackColor = Color.Red;
                row.Cells["ChangeStatusbtn"].Style.BackColor = Color.Red;
                selectedIDList.Add(int.Parse(row.Cells["ID"].Value.ToString()));
                OriginalIDList.Add(int.Parse(row.Cells["ID"].Value.ToString()));
            }
            amountSelected = selectedIDList.Count;
        }
        private void consultationAmount(string IDselected)
        {
            amount = 0;
            string sql = "SELECT COUNT(1) FROM correoenviado WHERE IDaviso= "+IDselected;
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
                MessageBox.Show("No hay email enviados a los correos");
                amount = -1;
            }
            finally
            {
                connectionBD.Close();
            }
        }
        public void validateSelection()
        {
            foreach (DataGridViewRow row in dgvEmailSent.Rows)
            {
                if (selectedIDList.Contains(int.Parse(row.Cells["ID"].Value.ToString())))
                {
                    row.Cells["ChangeStatusbtn"].Value = "Eliminar";
                    row.Cells["ChangeStatusbtn"].Style.BackColor = Color.Red;
                    row.Cells["ChangeStatusbtn"].Style.SelectionBackColor = Color.Red;
                }
                else
                {
                    row.Cells["ChangeStatusbtn"].Value = "Agregar";
                    row.Cells["ChangeStatusbtn"].Style.BackColor = Color.LimeGreen;
                    row.Cells["ChangeStatusbtn"].Style.SelectionBackColor = Color.LimeGreen;
                }
            }
            amountSelected = selectedIDList.Count;
        }
        private void CloseWindow()
        {
            Menu Frm = new Menu();
            Frm.Show();
            this.Close();
        }
        
        //colocar ID seleccionado
        #region AddID data
        public void AddNewItem(DataGridViewCell row)
        {
            ChosenAdID = row.Value.ToString();
            this.txtNoAviso.Text = ChosenAdID;
            bttnSearch.Text = "Buscar Otro Aviso";
            AdReg.empty = 1;
            AddedIDList.Clear();
            RemovedIDList.Clear();
            selectedIDList.Clear();
            amountSelected = 0;
            PersonSent();
            Modifybtn.Visible = true;
        }
        #endregion
        private void txtbTextSearch_TextChanged(object sender, EventArgs e)
        {
            selectedIDList.Clear();
        }

        private void dgvEmailSent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
        e.RowIndex >= 0)
            {
                id = int.Parse(dgvEmailSent.CurrentRow.Cells["ID"].Value.ToString());
                if (dgvEmailSent.CurrentRow.Cells["ChangeStatusbtn"].Value.ToString() == "Agregar")
                {
                    dgvEmailSent.CurrentRow.Cells["ChangeStatusbtn"].Value = "Eliminar";
                    dgvEmailSent.CurrentRow.Cells["ChangeStatusbtn"].Style.BackColor = Color.Red;
                    dgvEmailSent.CurrentRow.Cells["ChangeStatusbtn"].Style.SelectionBackColor = Color.Red;
                    amountSelected += 1;
                    selectedIDList.Add(id);
                    if (RemovedIDList.Contains(id)) RemovedIDList.Remove(id);
                    if (!OriginalIDList.Contains(id)) AddedIDList.Add(id);
                    DeselectAllcbx.Checked = false;
                }
                else if (dgvEmailSent.CurrentRow.Cells["ChangeStatusbtn"].Value.ToString() == "Eliminar")
                {
                    dgvEmailSent.CurrentRow.Cells["ChangeStatusbtn"].Value = "Agregar";
                    dgvEmailSent.CurrentRow.Cells["ChangeStatusbtn"].Style.BackColor = Color.LimeGreen;
                    dgvEmailSent.CurrentRow.Cells["ChangeStatusbtn"].Style.SelectionBackColor = Color.LimeGreen;
                    amountSelected -= 1;
                    selectedIDList.Remove(id);
                    if (OriginalIDList.Contains(id)) RemovedIDList.Add(id);
                    if (AddedIDList.Contains(id)) AddedIDList.Remove(id);
                    SelectAllcbx.Checked = false;
                }
            }
        }

        private void Modifybtn_Click(object sender, EventArgs e)
        {
            SelectAllcbx.Checked = false;
            DeselectAllcbx.Checked = false;
            bool Changes = false;
            string message = "¿Deseas realizar los siguientes cambios ?\r\n";
            bool Fail = false;
            if (AddedIDList.Count>0)
            {
                message += "    - AGREGAR destinatarios (Puedes revisar los destinatarios agregados en el botón 'Ver Agregados')\r\n";
                Changes = true;
            }
            if (RemovedIDList.Count>0)
            {
                message += "    - ELIMINAR destinatarios (Puedes revisar los destinatarios eliminados en el botón 'Ver Eliminados')\r\n";
                Changes = true;
            }
            if (Changes)
            {
                DialogResult dialogResult = MessageBox.Show(message, "Confirmar Cambios", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string sql;
                    foreach (int item in AddedIDList)
                    {
                        sql = "INSERT INTO correoenviado(IDaviso, IDpersona) VALUES ('" + ChosenAdID + "', '" + item + "')";
                        MySqlConnection connectionBD = Connection.connection();
                        connectionBD.Open();
                        try
                        {
                            MySqlCommand command = new MySqlCommand(sql, connectionBD);
                            command.ExecuteNonQuery();
                            OriginalIDList.Add(item);
                        }
                        catch (MySqlException ex)
                        {
                            //Hacer búsqueda con ID y mostrar cada error con los datos de la persona que no pudo ser agregada, lo mismo con las eliminadas
                            MessageBox.Show("Error al guardar: " + ex.Message);
                            Fail = true;
                        }
                        finally
                        {
                            connectionBD.Close();
                        }
                    }
                    foreach (int item in RemovedIDList)
                    {
                        sql = "DELETE FROM correoenviado WHERE IDaviso = " + ChosenAdID + " AND IDpersona = " + item;
                        MySqlConnection connectionBD = Connection.connection();
                        connectionBD.Open();
                        try
                        {
                            MySqlCommand command = new MySqlCommand(sql, connectionBD);
                            command.ExecuteNonQuery();
                            OriginalIDList.Remove(item);
                        }
                        catch (MySqlException ex)
                        {
                            //Hacer búsqueda con ID y mostrar cada error con los datos de la persona que no pudo ser agregada, lo mismo con las eliminadas
                            MessageBox.Show("Error al guardar: " + ex.Message);
                            Fail = true;
                        }
                        finally
                        {
                            connectionBD.Close();
                        }
                    }
                    if (!Fail)
                    {
                        MessageBox.Show("Cambios realizados exitosamente");

                    }
                    else
                    {

                    }
                    AddedIDList.Clear();
                    RemovedIDList.Clear();
                    UpdateDataGrid();
                }
            }
            else
            {
                MessageBox.Show("No se han realizado cambios");
            }
            
        }
        private void UpdateDataGrid()
        {
            CtrlPerson person = new CtrlPerson();
            PersonReg personReg = new PersonReg();
            personReg.consultationAmount();
            updating = true;
            if (personReg.amountPerson > 0)
            {
                switch (LastButtonClicked)
                {
                    case 'S':
                        if (textSearch == "")
                        {
                            dgvEmailSent.DataSource = person.consultationEmail(null);
                        }
                        switch (LastSearchTypeSelected)
                        {
                            // 0 Correo, 1 Nombre
                            case 0:
                                dgvEmailSent.DataSource = person.consultationEmail(textSearch);
                                break;
                            case 1:
                                dgvEmailSent.DataSource = person.consultationName(textSearch);
                                break;
                            default:
                                MessageBox.Show("ERROOOOOOOOOOOOOOOOOOOOR");
                                cmbTypeSearch.Text = "";
                                break;
                        }
                        validateSelection();
                        if (dgvEmailSent.Rows.Count > 0)
                        {
                            try
                            {
                                this.dgvEmailSent.Columns["ID"].Visible = false;
                                this.dgvEmailSent.Columns["Apellido"].Visible = false;
                            }
                            catch (MySqlException)
                            {
                                dgvEmailSent.DataSource = null;
                            }
                        }
                        else
                        {
                            dgvEmailSent.DataSource = null;
                        }

                        break;
                    case 'A':
                        if (AddedIDList.Count > 0) LoadTableFromPersonList(AddedIDList);
                        else dgvEmailSent.DataSource = null;
                        break;
                    case 'E':
                        if (RemovedIDList.Count > 0) LoadTableFromPersonList(RemovedIDList);
                        else dgvEmailSent.DataSource = null;
                        break;
                    case 'T':
                        bttnViewAll.PerformClick();
                        break;
                    case 'p':
                        PersonSent();
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
                dgvEmailSent.DataSource = null;
            }
            updating = false;
        }
        private void AddedPreviewbtn_Click(object sender, EventArgs e)
        {
            SelectAllcbx.Checked = false;
            DeselectAllcbx.Checked = false;
            LastButtonClicked = 'A';
            if (AddedIDList.Count > 0) LoadTableFromPersonList(AddedIDList);
            else MessageBox.Show("No se ha agregado a ninguna persona");
        }

        private void DeletedPreviewbtn_Click(object sender, EventArgs e)
        {
            SelectAllcbx.Checked = false;
            DeselectAllcbx.Checked = false;
            LastButtonClicked = 'E';
            if (RemovedIDList.Count > 0) LoadTableFromPersonList(RemovedIDList);
            else MessageBox.Show("No se ha eliminado a ninguna persona");
        }

        private void SelectAllcbx_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectAllcbx.Checked)
            {
                DeselectAllcbx.Checked = false;
                foreach (DataGridViewRow Fila in dgvEmailSent.Rows)
                {
                    int currentID = Convert.ToInt32(Fila.Cells[1].Value);
                    if (!selectedIDList.Contains(currentID))
                    {
                        selectedIDList.Add(currentID);
                        amountSelected++;
                    }

                    Fila.Cells[0].Value = "Eliminar";
                    Fila.Cells[0].Style.BackColor = Color.Red;
                    Fila.Cells[0].Style.SelectionBackColor = Color.Red;
                    if (RemovedIDList.Contains(currentID)) RemovedIDList.Remove(currentID);
                    if (!OriginalIDList.Contains(currentID) && !AddedIDList.Contains(currentID)) AddedIDList.Add(currentID);
                    
                }
            }
        }

        private void bttnSearchPerson_Click(object sender, EventArgs e)
        {
            SelectAllcbx.Checked = false;
            DeselectAllcbx.Checked = false;
            PersonReg personReg = new PersonReg();
            CtrlPerson person = new CtrlPerson();
            amountSelected = 0;
            personReg.consultationAmount();
            LastButtonClicked = 'S';
            if (personReg.amountPerson > 0)
            {
                textSearch = txtTextSearch.Text;
                LastSearchTypeSelected = cmbTypeSearch.SelectedIndex;

                if (textSearch == "")
                {
                    dgvEmailSent.DataSource = person.consultationEmail(null);
                }
                switch (cmbTypeSearch.SelectedIndex)
                {
                    //0 Correo, 1 Nombre, 2 Aviso
                    case 0:
                        dgvEmailSent.DataSource = person.consultationEmail(textSearch);
                        break;
                    case 1:
                        dgvEmailSent.DataSource = person.consultationName(textSearch);
                        break;
                    case 2:
                        dgvEmailSent.DataSource = person.consultationIDEmailSent(textSearch);
                        break;
                    default:
                        MessageBox.Show("Seleccione una de las opciones por las que desea buscar");
                        cmbTypeSearch.Text = "";
                        break;
                }
                validateSelection();
                if (dgvEmailSent.Rows.Count > 0)
                {
                    try
                    {
                        this.dgvEmailSent.Columns["ID"].Visible = false;
                        this.dgvEmailSent.Columns["Apellido"].Visible = false;
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("No se ha encontrado coincidencias");
                        dgvEmailSent.DataSource = person.consultationEmail(null);
                    }
                }
                else
                {
                    MessageBox.Show("No se han encontrado datos");
                    dgvEmailSent.DataSource = person.consultationEmail(null);
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
            cmbTypeSearch.Items.Add(new { Text = "Aviso", Value = 4 });

            cmbTypeSearch.SelectedIndex = 0;
        }

        private void DeselectAllcbx_CheckedChanged(object sender, EventArgs e)
        {
            if (DeselectAllcbx.Checked)
            {
                
                SelectAllcbx.Checked = false;
                foreach (DataGridViewRow Fila in dgvEmailSent.Rows)
                {
                    int currentID = Convert.ToInt32(Fila.Cells[1].Value);
                    if (selectedIDList.Contains(currentID))
                    {
                        selectedIDList.Remove(currentID);
                        amountSelected--;
                    }
                   
                    Fila.Cells[0].Value = "Agregar";
                    Fila.Cells[0].Style.BackColor = Color.LimeGreen;
                    Fila.Cells[0].Style.SelectionBackColor = Color.LimeGreen;
                    if (OriginalIDList.Contains(currentID) && !RemovedIDList.Contains(currentID)) RemovedIDList.Add(currentID);
                    if (AddedIDList.Contains(currentID)) AddedIDList.Remove(currentID);
                }
            }
        }

        private void bttnExport_Click(object sender, EventArgs e)
        {
            ExportData(dgvEmailSent);
        }
    }
}
