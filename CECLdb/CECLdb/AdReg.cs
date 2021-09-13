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
    public partial class AdReg : Form
    {
        public static int idAd = 0;
        public static int type = 0;
        public int amountSelectedAd = 0;
        public String textSearch;
        public int AdID;
        public int LastSearchTyprSelected;
        public int amountAd = 0;
        public static int empty = 0;
        private bool update = false;/*********************************************************/
        char LastBtnClicked;/*********************************************************/
        public List<int> selectedIDList = new List<int>();
        //Menu.action 1 es agregar, 2 modificar, 3 eliminar, 4 viene de email enviado en agregar, 5 viene
        // de email enviado pero modificar
        public AdReg()
        {
            InitializeComponent();
            
            if (Menu.action >= 2 && Menu.action <= 5)
            {
                LoadTypeSearchAd();
                txtTextAd.Visible = true;
                cmbTypeAd.Visible = true;
                dgvAdReg.Visible = true;
                bttnSearchAd.Visible = true;
                bttnEraserText.Visible = true;
                bttnAddAd.Visible = false;
            }
            switch (Menu.action)
            {
                case 1:
                    //ShowNumberAd();
                    LoadAreaAd();
                    this.Height = 556;
                    btnCleanAd.Visible = true;
                    cmbSelectAreaAd.SelectedIndex = -1;
                    break;
                case 2:
                    //ShowNumberAd();
                    LoadAreaAd();
                    HideAndMove(true);
                    bttnSaveAd.Visible = true;/*********************************/
                    
                    btnCleanAd.Visible = true;
                    ModifybtnAd.Visible = true;
                    cmbSelectAreaAd.SelectedIndex = -1;
                    break;
                case 3:
                    HideAndMove(false);
                    DeletebtnAd.Visible = true;
                    break;
                case 5:
                    LoadAreaAd();
                    HideAndMove(true);
                    bttnSelectPerson.Visible = true;
                    bttnConfirm.Visible = true;
                    break;
                default:
                    break;
            }
           
        }
        private void bttnReturnAd_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }
        private void cmbSelectAreaAd_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadCourseAd();
        }
        
        private void bttnAddAd_Click(object sender, EventArgs e)
        {
            if (cmbSelectAreaAd.Text != "")
            {
                if (cmbSelectCourseAd.Text != "")
                {
                    if (rtbDescriptionAd.Text != "")
                    {
                        int idArea = int.Parse(cmbSelectAreaAd.SelectedValue.ToString());
                        int idCourse = int.Parse(cmbSelectCourseAd.SelectedValue.ToString());
                        String description = rtbDescriptionAd.Text;

                        string sql = "INSERT INTO aviso (IDarea,IDcurso,Fecha,Descripcion) VALUES ('" + idArea + "'," +
                            "'" + idCourse + "','" + dtpDateAd.Text + "','" + description + "')";
                        MySqlConnection connectionBD = Connection.connection();
                        connectionBD.Open();
                        try
                        {
                            MySqlCommand command = new MySqlCommand(sql, connectionBD);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Aviso correctamente agregado");
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
                        MessageBox.Show("Coloque una descripción sobre el anuncio");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione el curso al que pertence");
                }
            }
            else
            {
                MessageBox.Show("Seleccione el área a la que pertenece");
            }
        }
        private void bttnEmailSent_Click(object sender, EventArgs e)
        {
            Menu.action = 6;
            PersonReg Frm = new PersonReg();
            Frm.Show();
        }
        private void bttnSearchAd_Click_1(object sender, EventArgs e)
        {
            SelectAllcbx.Checked = false;
            DeselectAllcbx.Checked = false;
            LastBtnClicked = 'b';/********************************************************************/
            amountSelectedAd = 0;
            SelectAllcbx.Enabled = true;
            DeselectAllcbx.Enabled = true;
            ModifybtnAd.Enabled = true;
            DeletebtnAd.Enabled = true;
            bttnSelectPerson.Enabled = true;
            bttnConfirm.Enabled = true;
            bttnViewSelectedAd.Enabled = true;
            ConsultationAmountAd();
            
            if (amountAd > 0)
            {
                textSearch = txtTextAd.Text;
                LastSearchTyprSelected = cmbTypeAd.SelectedIndex;
                if (textSearch == "")
                {
                    LoadTableArea(null);
                }
                else
                {
                    switch (cmbTypeAd.SelectedIndex)
                    {
                        //0 Código, 1 Correo, 2 Nombre
                        case 0:
                            LoadTableArea(textSearch);
                            break;
                        case 1:
                            LoadTableCourse(textSearch);
                            break;
                        case 2:
                            LoadTableDescription(textSearch);
                            break;
                        default:
                            MessageBox.Show("Seleccione una de las opciones por las que desea buscar");
                            cmbTypeAd.Text = "";
                            break;
                    }
                }
            }
            if (amountAd == 0)
            {
                MessageBox.Show("No se encuentran avisos/anuncios registrados");
            }
        }
        private void bttnSaveAd_Click(object sender, EventArgs e)
        {
            SelectAllcbx.Checked = false;
            DeselectAllcbx.Checked = false;
            if (cmbSelectAreaAd.Text != "")
            {
                if (cmbSelectCourseAd.Text != "")
                {
                    if (rtbDescriptionAd.Text != "")
                    {
                        int idArea = int.Parse(cmbSelectAreaAd.SelectedValue.ToString());
                        int idCourse = int.Parse(cmbSelectCourseAd.SelectedValue.ToString());
                        String description = rtbDescriptionAd.Text;

                        string sql = "UPDATE aviso SET IDcurso = '" + idCourse + "', IDarea = '" + idArea + "', Descripcion = '" + description + "', Fecha = '" + dtpDateAd.Text + "' " +
                "WHERE IDaviso =" + AdID;
                        MySqlConnection connectionBD = Connection.connection();
                        connectionBD.Open();
                        try
                        {
                            MySqlCommand command = new MySqlCommand(sql, connectionBD);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Aviso correctamente modificado");
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
                        MessageBox.Show("Coloque una descripción sobre el anuncio");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione el curso al que pertence");
                }
            }
            else
            {
                MessageBox.Show("Seleccione el área a la que pertenece");
            }
        }
        private void bttnSelectPerson_Click(object sender, EventArgs e)
        {
            if (amountSelectedAd == 0)
            {
                MessageBox.Show("No se ha seleccionado un aviso");
            }
            else if (amountSelectedAd == 1)
            {
                this.Height = 1000;

                cmbSelectAreaAd.Enabled = false;
                cmbSelectCourseAd.Enabled = false;
                dtpDateAd.Enabled = false;
                rtbDescriptionAd.Enabled = false;

                foreach (DataGridViewRow Fila in dgvAdReg.Rows)
                {
                    bool isChecked = Convert.ToBoolean(Fila.Cells[0].Value);
                    if (isChecked)
                    {
                        cmbSelectAreaAd.SelectedValue = int.Parse(Fila.Cells[2].Value.ToString());
                        LoadCourseAd();
                        cmbSelectCourseAd.SelectedValue = int.Parse(Fila.Cells[5].Value.ToString());
                        dtpDateAd.Value = Convert.ToDateTime(Fila.Cells[6].Value.ToString());
                        rtbDescriptionAd.Text = Fila.Cells[7].Value.ToString();
                    }
                }
                //bttnConfirm.Top = 951;
            }
            else
            {
                MessageBox.Show("Selecciona únicamente 1 aviso");//¿Es necesario?
            }
        }
        private void bttnViewSelectedAd_Click(object sender, EventArgs e)
        {
            if (!update)/********************************************************************/
            {
                SelectAllcbx.Checked = false;
                DeselectAllcbx.Checked = false;
                LastBtnClicked = 'v';
            }
            if (amountSelectedAd == 0)
            {
                if(!update) MessageBox.Show("No se ha seleccionado ningún aviso");/***************/
                else
                {
                    dgvAdReg.DataSource = null;
                }
            }
            else if (amountSelectedAd >= 1)
            {
                LoadTableSelectedAd(selectedIDList);
            }
        }
        private void bttnEraserText_Click(object sender, EventArgs e)
        {
            txtTextAd.Text = "";
        }

        private void Exit(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                CloseWindow();
            }
        }
        private void LoadAreaAd()
        {
            cmbSelectAreaAd.DataSource = null;
            cmbSelectAreaAd.Items.Clear();
            string sql = "SELECT IDarea, CONCAT(Nombre,'-',Convocatoria,'-', Año) AS infoArea FROM area ORDER BY Nombre";
            MySqlConnection connectionBD = Connection.connection();
            connectionBD.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                MySqlDataAdapter data = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                data.Fill(dataTable);

                cmbSelectAreaAd.ValueMember = "IDarea";
                cmbSelectAreaAd.DisplayMember = "infoArea";
                cmbSelectAreaAd.DataSource = dataTable;
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
        private void LoadCourseAd()
        {
            cmbSelectCourseAd.DataSource = null;
            cmbSelectCourseAd.Items.Clear();
            int idArea = int.Parse(cmbSelectAreaAd.SelectedValue.ToString());

            string sql = "SELECT IDcurso,Nombre FROM curso WHERE IDarea='" + idArea + "' ORDER BY Nombre";
            MySqlConnection connectionBD = Connection.connection();
            connectionBD.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                MySqlDataAdapter data = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                data.Fill(dataTable);

                cmbSelectCourseAd.ValueMember = "IDcurso";
                cmbSelectCourseAd.DisplayMember = "Nombre";
                cmbSelectCourseAd.DataSource = dataTable;
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
        private void LoadTypeSearchAd()
        {
            cmbTypeAd.DisplayMember = "Text";
            cmbTypeAd.ValueMember = "Value";
            cmbTypeAd.SelectedIndex = cmbTypeAd.Items.IndexOf("Área");

            cmbTypeAd.Items.Add(new { Text = "Área", Value = 1 });
            cmbTypeAd.Items.Add(new { Text = "Curso", Value = 2 });
            cmbTypeAd.Items.Add(new { Text = "Descripción", Value = 3 });
            cmbTypeAd.SelectedIndex = 0;
        }
        private void LoadTableArea(string data)
        {
            CtrlAd ad = new CtrlAd();
            dgvAdReg.DataSource = ad.consultationAreaAd(data);
            validateSelectionAd();

            if (dgvAdReg.Rows.Count > 0)
            {
                try
                {
                    this.dgvAdReg.Columns["IDaviso"].Visible = false;
                    this.dgvAdReg.Columns["IDarea"].Visible = false;
                    this.dgvAdReg.Columns["IDcurso"].Visible = false;
                }
                catch (MySqlException)
                {
                    if (!update)/******************************************/
                    {
                        MessageBox.Show("No se ha encontrado coincidencias");
                        LoadTableArea(null);
                    }
                }
            }
            else
            {
                if (!update)/**********************************************/
                {
                    MessageBox.Show("No se han encontrado datos");
                    LoadTableArea(null);
                }
            }
        }
        private void LoadTableCourse(string data)
        {
            CtrlAd ad = new CtrlAd();
            dgvAdReg.DataSource = ad.consultationCourse(data);
            validateSelectionAd();

            if (dgvAdReg.Rows.Count > 0)
            {
                try
                {
                    this.dgvAdReg.Columns["IDaviso"].Visible = false;
                    this.dgvAdReg.Columns["IDarea"].Visible = false;
                    this.dgvAdReg.Columns["IDcurso"].Visible = false;
                }
                catch (MySqlException)
                {
                    if (!update)/*************************************************/
                    {
                        MessageBox.Show("No se ha encontrado coincidencias");
                        LoadTableCourse(null);
                    }
                    else update = false;
                }
            }
            else
            {
                if (!update)/**************************************/
                {
                    MessageBox.Show("No se han encontrado datos");
                    LoadTableCourse(null);
                }
            }
        }
        private void LoadTableDescription(string data)
        {
            CtrlAd ad = new CtrlAd();
            dgvAdReg.DataSource = ad.consultationDescription(data);
            validateSelectionAd();

            if (dgvAdReg.Rows.Count > 0)
            {
                try
                {
                    this.dgvAdReg.Columns["IDaviso"].Visible = false;
                    this.dgvAdReg.Columns["IDarea"].Visible = false;
                    this.dgvAdReg.Columns["IDcurso"].Visible = false;
                }
                catch (MySqlException)
                {
                    if (!update)/************************************************/
                    {
                        MessageBox.Show("No se ha encontrado coincidencias");
                        LoadTableDescription(null);
                    }
                }
            }
            else
            {
                if (!update)/***********************************/
                {
                    MessageBox.Show("No se han encontrado datos");
                    LoadTableDescription(null);
                }
            }
        }
        private void LoadTableSelectedAd(List<int> adSelected)
        {
            amountSelectedAd = 0;
            CtrlAd ad = new CtrlAd();
            int sentID = 0;
            for (int i = 0; i < adSelected.Count; i++)
            {
                sentID = int.Parse(adSelected[i].ToString());
                ad.SelectedEmailSent(sentID);
            }
            dgvAdReg.DataSource = ad.listSelected;
            validateSelectionAd();

            if (dgvAdReg.Rows.Count > 0)
            {
                try
                {
                    this.dgvAdReg.Columns["IDaviso"].Visible = false;
                    this.dgvAdReg.Columns["IDarea"].Visible = false;
                    this.dgvAdReg.Columns["IDcurso"].Visible = false;
                }
                catch (MySqlException)
                {
                    if (!update)/***************************************************/
                    {
                        MessageBox.Show("No se ha seleccionado a alguna persona");
                        LoadTableArea(null);
                    }
                }
            }
            else
            {
                if (!update)/***************************************/
                {
                    MessageBox.Show("No se han seleccionado datos");
                    LoadTableArea(null);
                }
            }
        }
        private void ConsultationAmountAd()
        {
            amountAd = 0;
            string sql = "SELECT COUNT(1) FROM aviso ";
            MySqlConnection connectionBD = Connection.connection();
            connectionBD.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                command.Parameters.AddWithValue(sql, amountAd);
                command.ExecuteNonQuery();
                amountAd = int.Parse(command.ExecuteScalar().ToString());
            }
            catch (MySqlException)
            {
                MessageBox.Show("No hay avisos ingresados ");
                amountAd = -1;
            }
            finally
            {
                connectionBD.Close();
            }
        }
        public void validateSelectionAd()
        {
            foreach (DataGridViewRow row in dgvAdReg.Rows)
            {
                for (int i = 0; i < selectedIDList.Count; i++)
                {
                    if (selectedIDList[i].Equals(row.Cells["IDaviso"].Value))
                    {
                        row.Cells["CheckSelection"].Value = true;
                    }
                }
            }
            amountSelectedAd = selectedIDList.Count;
        }
        private void HideAndMove(bool justOneSelection)
        {
            this.Height = 605;
            SearchGBox.Top = 46;
            DataGBox.Top += 512;
            if (!justOneSelection)
            {
                SelectAllcbx.Visible = true;
                DeselectAllcbx.Visible = true;
                bttnViewSelectedAd.Visible = true;
            }
        }
        private void CloseWindow()
        {
            if (Menu.action == 5)
            {
                Menu.action = 2;
                this.Close();
            }
            else
            {
                Menu Frm = new Menu();
                Frm.Show();
                this.Close();
            }
        }
        private void bttnConfirm_Click(object sender, EventArgs e)
        {
            if (amountSelectedAd == 0)
            {
                MessageBox.Show("No se ha seleccionado un aviso");
            }
            else
            {
                foreach (DataGridViewRow row in dgvAdReg.Rows)
                {
                    bool isChecked = Convert.ToBoolean(row.Cells[0].Value);
                    if (isChecked)
                    {
                        DataGridViewCell choosenID = row.Cells[1];
                        AddID parent = this.Owner as AddID;
                        parent.AddNewItem(choosenID);
                        if (empty == 1 /*||empty==-1*/)
                        {
                            this.Close();
                        }
                    }
                }
            }
            
        }
        private void Clean()
        {
            cmbSelectAreaAd.Text = "";
            cmbSelectCourseAd.Text = "";
            rtbDescriptionAd.Text = "";
            dtpDateAd.Value = DateTime.Now;
            dtpDateAd.Format = DateTimePickerFormat.Custom;
            dtpDateAd.CustomFormat = "yyyy/MM/dd hh:mm";
            //ShowNumberAd();
        }

        private void DeletebtnAd_Click(object sender, EventArgs e)
        {
            int saveId = 0;
            if (amountSelectedAd == 0)
            {
                MessageBox.Show("No se ha seleccionado a ningun aviso/anuncio");
            }
            if (amountSelectedAd >= 1)
            {
                DialogResult dialogResult = MessageBox.Show("¿Deseas eliminar los avisos/anuncios seleccionadas de la base de datos? (Puedes revisar tu selección al presionar el botón 'Ver Seleccionados')", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SelectAllcbx.Checked = false;
                    DeselectAllcbx.Checked = false;
                    for (int i = 0; i < selectedIDList.Count; i++)
                    {
                        saveId = int.Parse(selectedIDList[i].ToString());
                        string sql = "DELETE FROM aviso WHERE IDaviso =" + saveId;

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
                foreach (DataGridViewRow Fila in dgvAdReg.Rows)
                {
                    int currentID = Convert.ToInt32(Fila.Cells["IDaviso"].Value);
                    if (!selectedIDList.Contains(currentID))
                    {
                        selectedIDList.Add(currentID);
                        amountSelectedAd++;
                    }
                    Fila.Cells[0].Value = true;
                }
            }
        }
        private void UpdateDataGrid()/***************************************************************/
        {
            ConsultationAmountAd();
            update = true;
            if (amountAd > 0)
            {
                switch (LastBtnClicked)
                {
                    case 'b':
                        if (textSearch == "")
                        {
                            LoadTableArea(null);
                        }
                        switch (cmbTypeAd.SelectedIndex)
                        {
                            //0 Código, 1 Correo, 2 Nombre
                            case 0:
                                LoadTableArea(textSearch);
                                break;
                            case 1:
                                LoadTableCourse(textSearch);
                                break;
                            case 2:
                                LoadTableDescription(textSearch);
                                break;
                            default:
                                MessageBox.Show("ERROOOOOOOOOOOOOOOOOR");
                                cmbTypeAd.Text = "";
                                break;
                        }
                        break;
                    case 'v':
                        bttnViewSelectedAd.PerformClick();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                dgvAdReg.DataSource = null;
            }
            update = false;
        }
        private void EmptyChecked()
        {
            amountSelectedAd = 0;
            selectedIDList.Clear();
        }
        private void DeselectAllcbx_CheckedChanged(object sender, EventArgs e)
        {
            if (DeselectAllcbx.Checked)
            {
                SelectAllcbx.Checked = false;
                foreach (DataGridViewRow Fila in dgvAdReg.Rows)
                {
                    int currentID = Convert.ToInt32(Fila.Cells["IDaviso"].Value);
                    if (selectedIDList.Contains(currentID))
                    {
                        selectedIDList.Remove(currentID);
                        amountSelectedAd--;
                    }

                    Fila.Cells[0].Value = null;
                }
            }
        }
        private void ModifybtnAd_Click(object sender, EventArgs e)
        {
            
            CtrlAd ctrlAd = new CtrlAd();
            if (amountSelectedAd == 0)
            {
                MessageBox.Show("No se ha seleccionado a ningún aviso/anuncio");
            }
            if (amountSelectedAd == 1)
            {
                this.Height = 1063;
                bttnSaveAd.Enabled = true;/*********************************/
                foreach (DataGridViewRow row in dgvAdReg.Rows)
                {
                    bool isChecked = Convert.ToBoolean(row.Cells[0].Value);
                    if (isChecked)
                    {
                        AdID = Convert.ToInt32(row.Cells["IDaviso"].Value);
                        Ad ad = ctrlAd.ModifyQuery(AdID.ToString());
                        cmbSelectAreaAd.SelectedValue = ad.IDarea;
                        LoadCourseAd();
                        cmbSelectCourseAd.SelectedValue = ad.IDcurso;
                        rtbDescriptionAd.Text = ad.Descripcion;
                        dtpDateAd.Value = Convert.ToDateTime(ad.Fecha);
                    }
                }
            }

            if (amountSelectedAd > 1)
            {
                MessageBox.Show("Selecciona únicamente a 1 aviso/anuncio");
            }
        }

        private void btnCleanAd_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void dgvAdReg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idAd = int.Parse(dgvAdReg.CurrentRow.Cells["IDaviso"].Value.ToString());
            if (dgvAdReg.CurrentRow.Cells["CheckSelection"].Value != null && (bool)dgvAdReg.CurrentRow.Cells["CheckSelection"].Value)
            {
                dgvAdReg.CurrentRow.Cells["CheckSelection"].Value = false;
                dgvAdReg.CurrentRow.Cells["CheckSelection"].Value = null;
                amountSelectedAd += -1;
                if (Menu.action != 5 && Menu.action != 2 && Menu.action != 4)
                {

                    selectedIDList.Remove(idAd);
                    SelectAllcbx.Checked = false;
                }
            }
            else if (dgvAdReg.CurrentRow.Cells["CheckSelection"].Value == null)
            {
                if (Menu.action != 5 && Menu.action != 2 && Menu.action != 4)
                {
                    dgvAdReg.CurrentRow.Cells["CheckSelection"].Value = true;

                    selectedIDList.Add(idAd);
                    DeselectAllcbx.Checked = false;
                }
                else
                {
                    foreach (DataGridViewRow Fila in dgvAdReg.Rows)
                    {
                        Fila.Cells[0].Value = null;
                    }
                    amountSelectedAd = 0;
                    dgvAdReg.CurrentRow.Cells["CheckSelection"].Value = true;
                }
                amountSelectedAd += 1;
            }
        }
    }
    }
