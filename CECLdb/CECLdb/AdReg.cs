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
    public partial class AdReg : Form
    {
        public static int idAd = 0;
        public static int type = 0;
        public int amountSelected = 0;

        public int PerID;

        public int amountPerson = 0;
        public int idPerson = 0;
        public List<int> selectedIDList = new List<int>();
        //Menu.action 1 es agregar, 2 modificar, 3 eliminar, 4 viene de email enviado
        public AdReg()
        {
            InitializeComponent();
            if (Menu.action>=2 && Menu.action<=4)
            {
                LoadTypeSearchAd();
                txtTextAd.Visible = true;
                cmbTypeAd.Visible = true;
                dgvAdReg.Visible = true;
            }
            if (Menu.action==1)
            {
                ShowNumberAd();
                LoadAreaAd();
                this.Height = 630;
                btnCleanAd.Visible = true;
                bttnImportAd.Visible = true;
            }
            if (Menu.action==2)
            {
                ShowNumberAd();
                LoadAreaAd();
                this.Height =705;
                bttnAddAd.Visible = false;
                bttnSaveAd.Visible = true;
                btnCleanAd.Visible = true;
            }
            if (Menu.action>=3 && Menu.action<4)
            {
                this.Height = 180;
                bttnSaveAd.Visible = false;
                bttnAddAd.Visible = false;
                HideAndMove();
                SelectAllcbx.Visible = true;
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
        private void cmbSelectAreaAd_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadCourseAd();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void bttnReturnAd_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }
        private void bttnAddAd_Click(object sender, EventArgs e)
        {
            if (cmbSelectAreaAd.Text!="")
            {
                if (cmbSelectCourseAd.Text!="")
                {
                    if (rtbDescriptionAd.Text!="")
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
                            MessageBox.Show("Curso correctamente agregado");
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
            //amountSelected = 0;
            //consultationAmountAd();
            //bttnEmailSent.Visible = true;
            //if (Menu.action==2)
            //{
            //    ModifybtnAd.Location = new Point(340, 1015);
            //    bttnReturnAd.Location = new Point(440, 1014);
            //    this.Width = 1102;
            //}
            //if (Menu.action >= 3 && Menu.action <= 4)
            //{

            //    this.Height = 573;
            //}

            //if (amountPerson > 0)
            //{
            //    if (Menu.action >= 3 && Menu.action <= 6)
            //    {

            //        this.Height = 615;
            //    }
            //    if (Menu.action == 2)
            //    {
            //        this.Height = 875;
            //        bttnReturnPerson.Location = new Point(496, 787);
            //        bttnViewSelectedPerson.Location = new Point(618, 787);
            //    }
            //    String textSearch = txtTextSearch.Text;
                  //if (textSearch == "")
                  //{
                  //LoadTableCode(null);
                  //}
            //    switch (cmbTypeSearch.SelectedIndex)
            //    {
            //        //0 Código, 1 Correo, 2 Nombre
            //        case 0:
            //            LoadTableCode(textSearch);
            //            break;
            //        case 1:
            //            LoadTableEmail(textSearch);
            //            break;
            //        case 2:
            //            LoadTableName(textSearch);
            //            break;
            //        default:
            //            MessageBox.Show("Seleccione una de las opciones por las que desea buscar");
            //            cmbTypeSearch.Text = "";
            //            break;
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("No se encuentran personas registradas");
            //}
        }
        private void bttnSaveAd_Click(object sender, EventArgs e)
        {
     
        }
        private void lblEscAd_Click(object sender, EventArgs e)
        {

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
            string sql = "SELECT IDarea,Nombre FROM area ORDER BY Nombre";
            MySqlConnection connectionBD = Connection.connection();
            connectionBD.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                MySqlDataAdapter data = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                data.Fill(dataTable);

                cmbSelectAreaAd.ValueMember = "IDarea";
                cmbSelectAreaAd.DisplayMember = "Nombre";
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

            string sql = "SELECT IDcurso,Nombre FROM curso WHERE IDarea='"+idArea+"' ORDER BY Nombre";
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
        private void ShowNumberAd()
        {
            MySqlDataReader reader = null;
            string sql = "SELECT MAX(IDaviso)+1 FROM aviso";
            MySqlConnection connectionBD = Connection.connection();
                connectionBD.Open();
                try
                {
                    MySqlCommand command = new MySqlCommand(sql, connectionBD);
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        try
                        {
                            txtbAdNumber.Text = reader.GetString(0);
                            idAd = int.Parse(txtbAdNumber.Text);
                        }
                        catch (Exception)
                        {

                            txtbAdNumber.Text = "1";
                            idAd = int.Parse(txtbAdNumber.Text);
                        }
                            
                    }
                }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al cargar los avisos " + ex.Message);
                }
            finally
            {
                connectionBD.Close();
            }
        }
        private void HideAndMove()
        {
            bttnSearchAd.Visible = true;
            lblSelectAreaAd.Visible = false;
            cmbSelectAreaAd.Visible = false;
            lblSelectCourseAd.Visible = false;
            cmbSelectCourseAd.Visible = false;
            lblAdNumber.Visible = false;
            txtbAdNumber.Visible = false;
            lblDateAd.Visible = false;
            dtpDateAd.Visible = false;
            lblDescriptionAd.Visible = false;
            rtbDescriptionAd.Visible = false;
            bttnSaveAd.Visible = false;
            txtTextAd.Location = new Point(42,90);
            cmbTypeAd.Location = new Point(618,90);
            bttnSearchAd.Location = new Point(887, 90);
            dgvAdReg.Location = new Point(33, 133);
            bttnReturnAd.Location = new Point(510,483);
            bttnViewSelectedPerson.Location = new Point(647,483);
            DeletebtnAd.Location = new Point(400, 483);
            bttnSelectPerson.Location = new Point(400,483);
            bttnEmailSent.Location=new Point(346, 555);
        }
        private void Clean()
        {
            cmbSelectAreaAd.Text = "";
            cmbSelectCourseAd.Text = "";
            rtbDescriptionAd.Text = "";
            dtpDateAd.Value = DateTime.Now;
            dtpDateAd.Format = DateTimePickerFormat.Custom;
            dtpDateAd.CustomFormat = "yyyy/MM/dd";
            ShowNumberAd();
        }
        private void CloseWindow()
        {
            Menu Frm = new Menu();
            Frm.Show();
            this.Close();
        }
    }
}
