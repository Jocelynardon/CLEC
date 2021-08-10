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
        //public int idAd = 0;
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
            if (Menu.action == 1)
            {
                //ShowNumberAd();
                LoadAreaAd();
                this.Height = 555;
                btnCleanAd.Visible = true;
            }
            if (Menu.action == 2)
            {
                //ShowNumberAd();
                LoadAreaAd();
                this.Height = 636;
                bttnSaveAd.Visible = true;
                btnCleanAd.Visible = true;
                ModifybtnAd.Visible = true;
                bttnViewSelectedAd.Visible = true;
            }
            if (Menu.action == 3)
            {
                this.Height = 180;
                HideAndMove();
                DeletebtnAd.Visible = true;
            }
            if (Menu.action == 4||Menu.action==5)
            {
                cmbSelectAreaAd.Enabled = false;
                cmbSelectCourseAd.Enabled = false;
                dtpDateAd.Enabled = false;
                rtbDescriptionAd.Enabled = false;

                this.Height = 636;
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
            amountSelectedAd = 0;
            ConsultationAmountAd();

            if (Menu.action == 2)
            {
                ModifybtnAd.Location = new Point(340, 938);
                bttnReturnAd.Location = new Point(440, 938);
                DeselectAllcbx.Visible = true;
                bttnViewSelectedAd.Visible = true;
                this.Height = 1022;
            }
            if (Menu.action == 3)
            {
                SelectAllcbx.Visible = true;
                DeselectAllcbx.Visible = true;
                bttnViewSelectedAd.Visible = true;
                this.Height = 607;
            }
            if (Menu.action == 4 || Menu.action==5)
            {
                this.Height = 1022;
                DeselectAllcbx.Visible = true;
                bttnSelectPerson.Visible = true;
                bttnReturnAd.Location = new Point(437, 938);
                bttnSelectPerson.Location = new Point(323, 938);
                bttnViewSelectedAd.Visible = true;
            }
            if (amountAd > 0)
            {
                textSearch = txtTextAd.Text;
                LastSearchTyprSelected = cmbTypeAd.SelectedIndex;
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
                        MessageBox.Show("Seleccione una de las opciones por las que desea buscar");
                        cmbTypeAd.Text = "";
                        break;
                }
            }
            else
            {
                MessageBox.Show("No se encuentran avisos/anuncios registrados");
            }
        }
        private void bttnSaveAd_Click(object sender, EventArgs e)
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
            if (Menu.action==5)
            {
                bttnSelectPerson.Text = "Verificar";
            }
            if (amountSelectedAd == 0)
            {
                MessageBox.Show("No se ha seleccionado un aviso");
            }
            if (amountSelectedAd == 1)
            {
                foreach (DataGridViewRow row in dgvAdReg.Rows)
                {
                    bool isChecked = Convert.ToBoolean(row.Cells[0].Value);
                    if (isChecked)
                    {
                        idAd = int.Parse(row.Cells[1].Value.ToString());
                        cmbSelectAreaAd.Text = row.Cells[3].Value.ToString();
                        cmbSelectCourseAd.Text = row.Cells[4].Value.ToString();
                        dtpDateAd.Text = row.Cells[6].Value.ToString();
                        rtbDescriptionAd.Text = row.Cells[7].Value.ToString();
                    }
                }
                if (Menu.action==4)
                {
                    bttnEmailSent.Visible = true;
                }
                if (Menu.action==5)
                {
                    bttnConfirm.Visible = true;
                }
            }
            if (amountSelectedAd > 1)
            {
                MessageBox.Show("Selecciona únicamente 1 aviso");
            }
        }
        private void bttnViewSelectedAd_Click(object sender, EventArgs e)
        {
            if (amountSelectedAd == 0)
            {
                MessageBox.Show("No se ha seleccionado a alguna persona");
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
            cmbTypeAd.SelectedIndex = cmbTypeAd.Items.IndexOf("Curso");

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
                    MessageBox.Show("No se ha encontrado coincidencias");
                    LoadTableDescription(null);
                }
            }
            else
            {
                MessageBox.Show("No se han encontrado datos");
                LoadTableDescription(null);
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
        //private void ShowNumberAd()
        //{
        //    MySqlDataReader reader = null;
        //    string sql = "SELECT MAX(IDaviso)+1 FROM aviso";
        //    MySqlConnection connectionBD = Connection.connection();
        //        connectionBD.Open();
        //        try
        //        {
        //            MySqlCommand command = new MySqlCommand(sql, connectionBD);
        //        reader = command.ExecuteReader();
        //        if (reader.HasRows)
        //        {
        //            while (reader.Read())
        //            {
        //                try
        //                {
        //                    txtbAdNumber.Text = reader.GetString(0);
        //                    idAd = int.Parse(txtbAdNumber.Text);
        //                }
        //                catch (Exception)
        //                {

        //                    txtbAdNumber.Text = "1";
        //                    idAd = int.Parse(txtbAdNumber.Text);
        //                }

        //            }
        //        }
        //        }
        //        catch (MySqlException ex)
        //        {
        //            MessageBox.Show("Error al cargar los avisos " + ex.Message);
        //        }
        //    finally
        //    {
        //        connectionBD.Close();
        //    }
        //}
        private void ConsultationAmountAd()
        {
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
                MessageBox.Show("No hay personas ingresadas ");
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
        private void HideAndMove()
        {
            bttnSearchAd.Visible = true;
            lblSelectAreaAd.Visible = false;
            cmbSelectAreaAd.Visible = false;
            lblSelectCourseAd.Visible = false;
            cmbSelectCourseAd.Visible = false;
            lblDateAd.Visible = false;
            dtpDateAd.Visible = false;
            lblDescriptionAd.Visible = false;
            rtbDescriptionAd.Visible = false;
            bttnSaveAd.Visible = false;
            bttnEmailSent.Visible = false;
            txtTextAd.Location = new Point(12, 89);
            cmbTypeAd.Location = new Point(591, 89);
            bttnSearchAd.Location = new Point(857, 89);
            bttnEraserText.Location = new Point(989, 91);
            dgvAdReg.Location = new Point(30, 163);
            bttnReturnAd.Location = new Point(495, 517);
            bttnViewSelectedAd.Location = new Point(628, 517);
            DeletebtnAd.Location = new Point(386, 517);
            bttnSelectPerson.Location = new Point(386, 517);
            SelectAllcbx.Location = new Point(42, 133);
            DeselectAllcbx.Location = new Point(213, 133);
        }
        
        

        private void dgvAdReg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idAd = int.Parse(dgvAdReg.CurrentRow.Cells["IDaviso"].Value.ToString());
            if (dgvAdReg.CurrentRow.Cells["CheckSelection"].Value != null && (bool)dgvAdReg.CurrentRow.Cells["CheckSelection"].Value)
            {
                dgvAdReg.CurrentRow.Cells["CheckSelection"].Value = false;
                dgvAdReg.CurrentRow.Cells["CheckSelection"].Value = null;
                amountSelectedAd += -1;
                selectedIDList.Remove(idAd);
                SelectAllcbx.Checked = false;
            }
            else if (dgvAdReg.CurrentRow.Cells["CheckSelection"].Value == null)
            {
                dgvAdReg.CurrentRow.Cells["CheckSelection"].Value = true;
                amountSelectedAd += 1;
                selectedIDList.Add(idAd);
                DeselectAllcbx.Checked = false;
            }
        }
        private void CloseWindow()
        {
            if (Menu.action >= 5)
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
                foreach (DataGridViewRow row in dgvAdReg.Rows)
                {
                    bool isChecked = Convert.ToBoolean(row.Cells[0].Value);
                    if (isChecked)
                    {
                        DataGridViewCell choosenID = row.Cells[1];
                        AddID parent = this.Owner as AddID;
                        parent.AddNewItem(choosenID);
                        this.Close();
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
            dtpDateAd.CustomFormat = "yyyy/MM/dd";
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
                amountSelectedAd = 0;
                selectedIDList.Clear();
                DeselectAllcbx.Checked = false;
                foreach (DataGridViewRow Fila in dgvAdReg.Rows)
                {
                    Fila.Cells[0].Value = true;
                    amountSelectedAd++;
                    selectedIDList.Add(Convert.ToInt32(Fila.Cells[1].Value));
                }
            }
        }
        private void UpdateDataGrid()
        {
            amountSelectedAd = 0;
            ConsultationAmountAd();
            if (amountAd > 0)
            {
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
                        MessageBox.Show("Seleccione una de las opciones por las que desea buscar");
                        cmbTypeAd.Text = "";
                        break;
                }
            }
            else
            {
                dgvAdReg.Rows.Clear();
            }
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
                amountSelectedAd = 0;
                selectedIDList.Clear();
                SelectAllcbx.Checked = false;
                foreach (DataGridViewRow Fila in dgvAdReg.Rows)
                {
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
                foreach (DataGridViewRow row in dgvAdReg.Rows)
                {
                    bool isChecked = Convert.ToBoolean(row.Cells[0].Value);
                    if (isChecked)
                    {
                        AdID = Convert.ToInt32(row.Cells[1].Value);
                        Ad ad = ctrlAd.ModifyQuery(AdID.ToString());
                        cmbSelectAreaAd.Text = ad.Area;
                        cmbSelectCourseAd.Text = ad.Curso;
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
    }
}
