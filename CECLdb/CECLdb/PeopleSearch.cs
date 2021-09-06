using CLEC;
using MySql.Data.MySqlClient;
using System;
using System.Data;
﻿using CLEC;
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
    public partial class PeopleSearch : Form
    {
        public int amountSelected = 0;
        public int LastSearchTypeSelected;
        public String textSearch;
        public int amount = 0;
        private bool update = false;
        private int selectionType;
        private int emailOrStatus;
        public PeopleSearch()
        {
            InitializeComponent();
            rbttnCode.Checked=true;
        }
        private void bttnEraserText_Click(object sender, EventArgs e)
        {
            Clean();
        }
        private void PeopleSrcBtn_Click(object sender, EventArgs e)
        {
            //selectionType=1 Código, 2 correo, 3 Nombre
            //emailOrStatus=1 correoEnviado, 2 status
            switch (selectionType)
            {
                case 1:
                    if (emailOrStatus == 1)
                    {
                        if (txtCode.Text == "") 
                        {
                            SearchCodeEmail(null);
                        }
                        if (txtCode.Text != "")
                        {
                            SearchCodeEmail(txtCode.Text);
                        }
                    }
                    if (emailOrStatus == 2)
                    {
                        if (rbttnInscribed.Checked==true)
                        {
                            if (ckbApproved.Checked==true)
                            {
                                if (txtCode.Text == "")
                                {
                                   SearchByCodeStatus(null,1);
                                }
                                if (txtCode.Text != "")
                                {
                                    SearchByCodeStatus(txtCode.Text,1);
                                }
                            }
                            if (ckbApproved.Checked==false)
                            {
                                if (txtCode.Text == "")
                                {
                                    SearchByCodeStatus(null, 0);
                                }
                                if (txtCode.Text != "")
                                {
                                    SearchByCodeStatus(txtCode.Text, 0);
                                }
                            }
                        }
                        if (rbttnConsulted.Checked == true)
                        {

                        }
                    }
                    if (emailOrStatus == 0)
                    {
                        if (txtCode.Text == "")
                        {
                            SearchByCode(null);
                        }
                        if (txtCode.Text != "")
                        {
                            SearchByCode(txtCode.Text);
                        }
                    }
                    break;
                case 2:
                    if (emailOrStatus==1)
                    {
                        if (txtSearch.Text == "")
                        {
                            SearchEmailEmailSent(null);
                        }
                        if (txtSearch.Text != "")
                        {
                            SearchEmailEmailSent(txtSearch.Text);
                        }
                    }
                    if (emailOrStatus==2)
                    {
                        if (rbttnInscribed.Checked == true)
                        {
                            if (ckbApproved.Checked == true)
                            {
                                if (txtSearch.Text == "")
                                {
                                    SearchByEmailStatus(null, 1);
                                }
                                if (txtSearch.Text != "")
                                {
                                    SearchByEmailStatus(txtSearch.Text, 1);
                                }
                            }
                            if (ckbApproved.Checked == false)
                            {
                                if (txtSearch.Text == "")
                                {
                                    SearchByEmailStatus(null, 0);
                                }
                                if (txtSearch.Text != "")
                                {
                                    SearchByEmailStatus(txtSearch.Text, 0);
                                }
                            }
                        }
                        if (rbttnConsulted.Checked == true)
                        {

                        }
                    }
                    if (emailOrStatus==0)
                    {
                        if (txtSearch.Text == "") 
                        {
                            SearchByEmail(null);
                        }
                        if (txtSearch.Text != "")
                        {
                            SearchByEmail(txtSearch.Text);
                        }
                    }
                    break;
                case 3:
                    if (emailOrStatus==1)
                    {
                        if (txtSearch.Text == "") 
                        {
                            SearchByNameEmailSent(null);
                        }
                        if (txtSearch.Text != "")
                        {
                            SearchByNameEmailSent(txtSearch.Text);
                        }
                    }
                    if (emailOrStatus==2)
                    {
                        if (rbttnInscribed.Checked == true)
                        {
                            if (ckbApproved.Checked == true)
                            {
                                if (txtSearch.Text == "") 
                                {
                                    SearchByNameStatus(null, 1);
                                }
                                if (txtSearch.Text != "")
                                {
                                    SearchByNameStatus(txtSearch.Text, 1);
                                }
                            }
                            if (ckbApproved.Checked == false)
                            {
                                if (txtSearch.Text == "")
                                {
                                    SearchByNameStatus(null, 0);
                                }
                                if (txtSearch.Text != "")
                                {
                                    SearchByNameStatus(txtSearch.Text, 0);
                                }
                            }
                        }
                        if (rbttnConsulted.Checked == true)
                        {

                        }
                    }
                    if (emailOrStatus==0)
                    {
                        if (txtSearch.Text == "") 
                        {
                            SearchByName(null);
                        }
                        if (txtSearch.Text != "")
                        {
                            SearchByName(txtSearch.Text);
                        }
                    }
                    break;
                case 4:
                    if (emailOrStatus == 1)
                    {
                        if (cmbSelectArea.Text == "") ;
                        {
                            SearchByCourseEmailSent(0, 0);
                        }
                        if (cmbSelectArea.Text != "")
                        {
                            int idArea = int.Parse(cmbSelectArea.SelectedValue.ToString());
                            int idCourse = int.Parse(cmbSelectCourse.SelectedValue.ToString());
                            SearchByCourseEmailSent(idArea, idCourse);
                        }
                    }
                    if (emailOrStatus == 2)
                    {
                        if (rbttnInscribed.Checked == true)
                        {
                            if (ckbApproved.Checked == true)
                            {
                                if (cmbSelectArea.Text=="") ;
                                {
                                    SearchByCourseStatus(0,0, 1);
                                }
                                if (cmbSelectArea.Text != "")
                                {
                                    int idArea = int.Parse(cmbSelectArea.SelectedValue.ToString());
                                    int idCourse = int.Parse(cmbSelectCourse.SelectedValue.ToString());
                                    SearchByCourseStatus(idArea,idCourse,1);
                                }
                            }
                            if (ckbApproved.Checked == false)
                            {
                                if (cmbSelectArea.Text == "") ;
                                {
                                    SearchByCourseStatus(0,0,0);
                                }
                                if (cmbSelectArea.Text != "")
                                {
                                    int idArea = int.Parse(cmbSelectArea.SelectedValue.ToString());
                                    int idCourse = int.Parse(cmbSelectCourse.SelectedValue.ToString());
                                    SearchByCourseStatus(idArea,idCourse,0);
                                }
                            }
                        }
                        if (rbttnConsulted.Checked == true)
                        {

                        }
                    }
                    if (emailOrStatus == 0)
                    {
                        if (cmbSelectArea.Text == "") ;
                        {
                            SearchByCourse(0, 0);
                        }
                        if (cmbSelectArea.Text != "")
                        {
                            int idArea = int.Parse(cmbSelectArea.SelectedValue.ToString());
                            int idCourse = int.Parse(cmbSelectCourse.SelectedValue.ToString());
                            SearchByCourse(idArea, idCourse);
                        }
                    }
                    break;
                default:
                    MessageBox.Show("Seleccione la manera en que desea buscar");
                    break;
            }
        }

        private void bttnReturn_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }

        private void SearchByCode(string data)
        {
            CtrlSearchPeople person = new CtrlSearchPeople();
            dgvPeopleSearch.DataSource = person.consultationCode(data);
            lblTotalResult.Visible = true;
            lblTotalResult.Text = "Total Resultados: " + dgvPeopleSearch.Rows.Count;

            if (dgvPeopleSearch.Rows.Count > 0)
            {
                try
                {
                    this.dgvPeopleSearch.Columns["ID"].Visible = false;
                    this.dgvPeopleSearch.Columns["Apellido"].Visible = false;
                    this.dgvPeopleSearch.Columns["FechaInicio"].Visible = true;
                    this.dgvPeopleSearch.Columns["FechaFin"].Visible = true;
                    this.dgvPeopleSearch.Columns["Aprobado"].Visible = true;
                    this.dgvPeopleSearch.Columns["Descripción"].Visible = false;
                    this.dgvPeopleSearch.Columns["FechaAviso"].Visible = false;
                }
                catch (MySqlException)
                {
                    if (!update)
                    {
                        MessageBox.Show("No se ha encontrado coincidencias");
                        SearchByCode(null);
                    }
                }
            }
            else
            {
                if (!update)
                {
                    MessageBox.Show("No se han encontrado datos");
                    SearchByCode(null);
                }
            }
        }
        private void SearchByEmail(string data)
        {
            CtrlSearchPeople person = new CtrlSearchPeople();
            dgvPeopleSearch.DataSource = person.consultationEmail(data);
            lblTotalResult.Visible = true;
            lblTotalResult.Text = "Total Resultados: " + dgvPeopleSearch.Rows.Count;

            if (dgvPeopleSearch.Rows.Count > 0)
            {
                try
                {
                    this.dgvPeopleSearch.Columns["ID"].Visible = false;
                    this.dgvPeopleSearch.Columns["Apellido"].Visible = false;
                    this.dgvPeopleSearch.Columns["FechaInicio"].Visible = true;
                    this.dgvPeopleSearch.Columns["FechaFin"].Visible = true;
                    this.dgvPeopleSearch.Columns["Aprobado"].Visible = true;
                    this.dgvPeopleSearch.Columns["Descripción"].Visible = false;
                    this.dgvPeopleSearch.Columns["FechaAviso"].Visible = false;
                }
                catch (MySqlException)
                {
                    if (!update)
                    {
                        MessageBox.Show("No se ha encontrado coincidencias");
                        SearchByEmail(null);
                    }
                }
            }
            else
            {
                if (!update)
                {
                    MessageBox.Show("No se han encontrado datos");
                    SearchByEmail(null);
                }
            }
        }
        private void SearchByName(string data)
        {
            CtrlSearchPeople person = new CtrlSearchPeople();
            dgvPeopleSearch.DataSource = person.consultationName(data);
            lblTotalResult.Visible = true;
            lblTotalResult.Text = "Total Resultados: " + dgvPeopleSearch.Rows.Count;

            if (dgvPeopleSearch.Rows.Count > 0)
            {
                try
                {
                    this.dgvPeopleSearch.Columns["ID"].Visible = false;
                    this.dgvPeopleSearch.Columns["Apellido"].Visible = false;
                    this.dgvPeopleSearch.Columns["FechaInicio"].Visible = true;
                    this.dgvPeopleSearch.Columns["FechaFin"].Visible = true;
                    this.dgvPeopleSearch.Columns["Aprobado"].Visible = true;
                    this.dgvPeopleSearch.Columns["Descripción"].Visible = false;
                    this.dgvPeopleSearch.Columns["FechaAviso"].Visible = false;
                }
                catch (MySqlException)
                {
                    if (!update)
                    {
                        MessageBox.Show("No se ha encontrado coincidencias");
                        SearchByName(null);
                    }
                }
            }
            else
            {
                if (!update)
                {
                    MessageBox.Show("No se han encontrado datos");
                    SearchByName(null);
                }
            }
        }
        private void SearchByCourse(int idArea, int idCourse)
        {
            CtrlSearchPeople person = new CtrlSearchPeople();
            dgvPeopleSearch.DataSource = person.consultationCourse(idArea,idCourse);
            lblTotalResult.Visible = true;
            lblTotalResult.Text = "Total Resultados: " + dgvPeopleSearch.Rows.Count;

            if (dgvPeopleSearch.Rows.Count > 0)
            {
                try
                {
                    this.dgvPeopleSearch.Columns["ID"].Visible = false;
                    this.dgvPeopleSearch.Columns["Apellido"].Visible = false;
                    this.dgvPeopleSearch.Columns["FechaInicio"].Visible = true;
                    this.dgvPeopleSearch.Columns["FechaFin"].Visible = true;
                    this.dgvPeopleSearch.Columns["Aprobado"].Visible = true;
                    this.dgvPeopleSearch.Columns["Descripción"].Visible = false;
                    this.dgvPeopleSearch.Columns["FechaAviso"].Visible = false;
                }
                catch (MySqlException)
                {
                    if (!update)
                    {
                        MessageBox.Show("No se ha encontrado coincidencias");
                        SearchByCourse(0,0);
                    }
                }
            }
            else
            {
                if (!update)
                {
                    MessageBox.Show("No se han encontrado datos");
                    SearchByCourse(0,0);
                }
            }
        }
        private void SearchCodeEmail(string data)
        {
            CtrlSearchPeople person = new CtrlSearchPeople();
            dgvPeopleSearch.DataSource = person.consultationCodeByEmailSent(data);
            lblTotalResult.Visible = true;
            lblTotalResult.Text = "Total Resultados: " + dgvPeopleSearch.Rows.Count;

            if (dgvPeopleSearch.Rows.Count > 0)
            {
                try
                {
                    this.dgvPeopleSearch.Columns["ID"].Visible = false;
                    this.dgvPeopleSearch.Columns["Apellido"].Visible = false;
                    this.dgvPeopleSearch.Columns["FechaInicio"].Visible = false;
                    this.dgvPeopleSearch.Columns["FechaFin"].Visible = false;
                    this.dgvPeopleSearch.Columns["Aprobado"].Visible = false;
                    this.dgvPeopleSearch.Columns["Descripción"].Visible = true;
                    this.dgvPeopleSearch.Columns["FechaAviso"].Visible = true;
                }
                catch (MySqlException)
                {
                    if (!update)
                    {
                        MessageBox.Show("No se ha encontrado coincidencias");
                        SearchCodeEmail(null);
                    }
                }
            }
            else
            {
                if (!update)
                {
                    MessageBox.Show("No se han encontrado datos");
                    SearchCodeEmail(null);
                }
            }
        }
        private void SearchEmailEmailSent(string data)
        {
            CtrlSearchPeople person = new CtrlSearchPeople();
            dgvPeopleSearch.DataSource = person.consultationEmailByEmailSent(data);
            lblTotalResult.Visible = true;
            lblTotalResult.Text = "Total Resultados: " + dgvPeopleSearch.Rows.Count;

            if (dgvPeopleSearch.Rows.Count > 0)
            {
                try
                {
                    this.dgvPeopleSearch.Columns["ID"].Visible = false;
                    this.dgvPeopleSearch.Columns["Apellido"].Visible = false;
                    this.dgvPeopleSearch.Columns["FechaInicio"].Visible = false;
                    this.dgvPeopleSearch.Columns["FechaFin"].Visible = false;
                    this.dgvPeopleSearch.Columns["Aprobado"].Visible = false;
                    this.dgvPeopleSearch.Columns["Descripción"].Visible = true;
                    this.dgvPeopleSearch.Columns["FechaAviso"].Visible = true;
                }
                catch (MySqlException)
                {
                    if (!update)
                    {
                        MessageBox.Show("No se ha encontrado coincidencias");
                        SearchCodeEmail(null);
                    }
                }
            }
            else
            {
                if (!update)
                {
                    MessageBox.Show("No se han encontrado datos");
                    SearchCodeEmail(null);
                }
            }
        }
        private void SearchByNameEmailSent(string data)
        {
            CtrlSearchPeople person = new CtrlSearchPeople();
            dgvPeopleSearch.DataSource = person.consultationNameByEmailSent(data);
            lblTotalResult.Visible = true;
            lblTotalResult.Text = "Total Resultados: " + dgvPeopleSearch.Rows.Count;

            if (dgvPeopleSearch.Rows.Count > 0)
            {
                try
                {
                    this.dgvPeopleSearch.Columns["ID"].Visible = false;
                    this.dgvPeopleSearch.Columns["Apellido"].Visible = false;
                    this.dgvPeopleSearch.Columns["FechaInicio"].Visible = false;
                    this.dgvPeopleSearch.Columns["FechaFin"].Visible = false;
                    this.dgvPeopleSearch.Columns["Aprobado"].Visible = false;
                    this.dgvPeopleSearch.Columns["Descripción"].Visible = true;
                    this.dgvPeopleSearch.Columns["FechaAviso"].Visible = true;
                }
                catch (MySqlException)
                {
                    if (!update)
                    {
                        MessageBox.Show("No se ha encontrado coincidencias");
                        SearchCodeEmail(null);
                    }
                }
            }
            else
            {
                if (!update)
                {
                    MessageBox.Show("No se han encontrado datos");
                    SearchCodeEmail(null);
                }
            }
        }
        private void SearchByCourseEmailSent(int idArea, int idCourse)
        {
            CtrlSearchPeople person = new CtrlSearchPeople();
            dgvPeopleSearch.DataSource = person.consultationCourseByEmailSent(idArea, idCourse);
            lblTotalResult.Visible = true;
            lblTotalResult.Text = "Total Resultados: " + dgvPeopleSearch.Rows.Count;

            if (dgvPeopleSearch.Rows.Count > 0)
            {
                try
                {
                    this.dgvPeopleSearch.Columns["ID"].Visible = false;
                    this.dgvPeopleSearch.Columns["Apellido"].Visible = false;
                    this.dgvPeopleSearch.Columns["FechaInicio"].Visible = false;
                    this.dgvPeopleSearch.Columns["FechaFin"].Visible = false;
                    this.dgvPeopleSearch.Columns["Aprobado"].Visible = false;
                    this.dgvPeopleSearch.Columns["Descripción"].Visible = true;
                    this.dgvPeopleSearch.Columns["FechaAviso"].Visible = true;
                }
                catch (MySqlException)
                {
                    if (!update)
                    {
                        MessageBox.Show("No se ha encontrado coincidencias");
                        SearchByCourse(0, 0);
                    }
                }
            }
            else
            {
                if (!update)
                {
                    MessageBox.Show("No se han encontrado datos");
                    SearchByCourse(0, 0);
                }
            }
        }
        private void SearchByCodeStatus(string data,int approved)
        {
            CtrlSearchPeople person = new CtrlSearchPeople();
            dgvPeopleSearch.DataSource = person.consultationCodeStatus(data,approved);
            lblTotalResult.Visible = true;
            lblTotalResult.Text = "Total Resultados: " + dgvPeopleSearch.Rows.Count;

            if (dgvPeopleSearch.Rows.Count > 0)
            {
                try
                {
                    this.dgvPeopleSearch.Columns["ID"].Visible = false;
                    this.dgvPeopleSearch.Columns["Apellido"].Visible = false;
                    this.dgvPeopleSearch.Columns["FechaInicio"].Visible = true;
                    this.dgvPeopleSearch.Columns["FechaFin"].Visible = true;
                    this.dgvPeopleSearch.Columns["Aprobado"].Visible = true;
                    this.dgvPeopleSearch.Columns["Descripción"].Visible = false;
                    this.dgvPeopleSearch.Columns["FechaAviso"].Visible = false;
                }
                catch (MySqlException)
                {
                    if (!update)
                    {
                        MessageBox.Show("No se ha encontrado coincidencias");
                        SearchByCode(null);
                    }
                }
            }
            else
            {
                if (!update)
                {
                    MessageBox.Show("No se han encontrado datos");
                    SearchByCode(null);
                }
            }
        }
        private void SearchByNameStatus(string data, int approved)
        {
            CtrlSearchPeople person = new CtrlSearchPeople();
            dgvPeopleSearch.DataSource = person.consultationNameStatus(data, approved);
            lblTotalResult.Visible = true;
            lblTotalResult.Text = "Total Resultados: " + dgvPeopleSearch.Rows.Count;

            if (dgvPeopleSearch.Rows.Count > 0)
            {
                try
                {
                    this.dgvPeopleSearch.Columns["ID"].Visible = false;
                    this.dgvPeopleSearch.Columns["Apellido"].Visible = false;
                    this.dgvPeopleSearch.Columns["FechaInicio"].Visible = true;
                    this.dgvPeopleSearch.Columns["FechaFin"].Visible = true;
                    this.dgvPeopleSearch.Columns["Aprobado"].Visible = true;
                    this.dgvPeopleSearch.Columns["Descripción"].Visible = false;
                    this.dgvPeopleSearch.Columns["FechaAviso"].Visible = false;
                }
                catch (MySqlException)
                {
                    if (!update)
                    {
                        MessageBox.Show("No se ha encontrado coincidencias");
                        SearchByCode(null);
                    }
                }
            }
            else
            {
                if (!update)
                {
                    MessageBox.Show("No se han encontrado datos");
                    SearchByCode(null);
                }
            }
        }
        private void SearchByEmailStatus(string data, int approved)
        {
            CtrlSearchPeople person = new CtrlSearchPeople();
            dgvPeopleSearch.DataSource = person.consultationEmailStatus(data, approved);
            lblTotalResult.Visible = true;
            lblTotalResult.Text = "Total Resultados: " + dgvPeopleSearch.Rows.Count;

            if (dgvPeopleSearch.Rows.Count > 0)
            {
                try
                {
                    this.dgvPeopleSearch.Columns["ID"].Visible = false;
                    this.dgvPeopleSearch.Columns["Apellido"].Visible = false;
                    this.dgvPeopleSearch.Columns["FechaInicio"].Visible = true;
                    this.dgvPeopleSearch.Columns["FechaFin"].Visible = true;
                    this.dgvPeopleSearch.Columns["Aprobado"].Visible = true;
                    this.dgvPeopleSearch.Columns["Descripción"].Visible = false;
                    this.dgvPeopleSearch.Columns["FechaAviso"].Visible = false;
                }
                catch (MySqlException)
                {
                    if (!update)
                    {
                        MessageBox.Show("No se ha encontrado coincidencias");
                        SearchByCode(null);
                    }
                }
            }
            else
            {
                if (!update)
                {
                    MessageBox.Show("No se han encontrado datos");
                    SearchByCode(null);
                }
            }
        }
        private void SearchByCourseStatus(int idArea, int idCourse, int approved)
        {
            CtrlSearchPeople person = new CtrlSearchPeople();
            dgvPeopleSearch.DataSource = person.consultationCourseByStatus(idArea, idCourse,approved);
            lblTotalResult.Visible = true;
            lblTotalResult.Text = "Total Resultados: " + dgvPeopleSearch.Rows.Count;

            if (dgvPeopleSearch.Rows.Count > 0)
            {
                try
                {
                    this.dgvPeopleSearch.Columns["ID"].Visible = false;
                    this.dgvPeopleSearch.Columns["Apellido"].Visible = false;
                    this.dgvPeopleSearch.Columns["FechaInicio"].Visible = false;
                    this.dgvPeopleSearch.Columns["FechaFin"].Visible = false;
                    this.dgvPeopleSearch.Columns["Aprobado"].Visible = false;
                    this.dgvPeopleSearch.Columns["Descripción"].Visible = true;
                    this.dgvPeopleSearch.Columns["FechaAviso"].Visible = true;
                }
                catch (MySqlException)
                {
                    if (!update)
                    {
                        MessageBox.Show("No se ha encontrado coincidencias");
                        SearchByCourse(0, 0);
                    }
                }
            }
            else
            {
                if (!update)
                {
                    MessageBox.Show("No se han encontrado datos");
                    SearchByCourse(0, 0);
                }
            }
        }


        private void LoadArea()
        {
            cmbSelectArea.DataSource = null;
            cmbSelectArea.Items.Clear();
            string sql = "SELECT IDarea, CONCAT(Nombre,'-',Convocatoria,'-', Año) AS infoArea FROM area ORDER BY Nombre";
            MySqlConnection connectionBD = Connection.connection();
            connectionBD.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                MySqlDataAdapter data = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                data.Fill(dataTable);

                cmbSelectArea.ValueMember = "IDarea";
                cmbSelectArea.DisplayMember = "infoArea";
                cmbSelectArea.DataSource = dataTable;
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
        private void LoadCourse()
        {
            cmbSelectCourse.DataSource = null;
            cmbSelectCourse.Items.Clear();
            int idArea = int.Parse(cmbSelectArea.SelectedValue.ToString());

            string sql = "SELECT IDcurso,Nombre FROM curso WHERE IDarea='" + idArea + "' ORDER BY Nombre";
            MySqlConnection connectionBD = Connection.connection();
            connectionBD.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                MySqlDataAdapter data = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                data.Fill(dataTable);

                cmbSelectCourse.ValueMember = "IDcurso";
                cmbSelectCourse.DisplayMember = "Nombre";
                cmbSelectCourse.DataSource = dataTable;
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


        private void Clean()
        {
            txtCode.Text = "";
            txtSearch.Text = "";
            cmbSelectArea.SelectedIndex = -1;
            cmbSelectCourse.DataSource=null;
            cmbSelectCourse.Items.Clear();
            rbttnEmailSent.Checked = false;
            rbttnStatus.Checked = false;
            rbttnInscribed.Checked = false;
            ckbApproved.Checked = false;
            rbttnConsulted.Checked = false;
        }
        private void ControlKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                CloseWindow();
            }
        }
        private void CloseWindow()
        {
            Menu Frm = new Menu();
            Frm.Show();
            this.Close();
        }

        private void rbttnCode_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbttnCode.Checked)
            {
                txtCode.Visible = true;
                txtSearch.Visible = false;
                lblType.Text = "Código";
                selectionType = 1;
            }
            else
            {
                txtCode.Visible = false;
            }
        }
        private void rbttnEmail_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbttnEmail.Checked)
            {
                txtSearch.Visible = true;
                lblType.Visible = true;
                lblType.Text = "Correo";
                selectionType = 2;
            }
            else
            {
                txtSearch.Visible = false;
                lblType.Visible = false;
            }
        }
        private void rbttnName_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbttnName.Checked)
            {
                txtSearch.Visible = true;
                lblType.Visible = true;
                lblType.Text = "Nombre";
                selectionType = 3;
            }
            else
            {
                txtSearch.Visible = false;
                lblType.Visible = false;
            }
        }
        private void rbttnCourse_CheckedChanged(object sender, EventArgs e)
        {
            if (rbttnCourse.Checked)
            {
                lblType.Visible = false;
                lblArea.Visible = true;
                lblCourse.Visible = true;
                cmbSelectArea.Visible = true;
                LoadArea();
                cmbSelectArea.SelectedIndex = -1;
                cmbSelectCourse.Visible = true;
                selectionType = 4;
            }
            else
            {
                lblArea.Visible = false;
                lblCourse.Visible = false;
                cmbSelectArea.Visible = false;
                cmbSelectCourse.Visible = false;
            }
        }

        private void rbttnStatus_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbttnStatus.Checked)
            {
                gpbStatus.Visible = true;
                emailOrStatus = 2;
            }
            else
            {
                gpbStatus.Visible = false;
                emailOrStatus = 0;
            }
        }
        private void rbttnEmailSent_CheckedChanged(object sender, EventArgs e)
        {
            if (rbttnEmailSent.Checked)
            {
                emailOrStatus = 1;
            }
            else
            {
                emailOrStatus = 0;
            }
        }
        private void rbttnInscribed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbttnInscribed.Checked)
            {
                ckbApproved.Visible = true;
            }
            else
            {
                ckbApproved.Visible = false;
            }
        }


        private void cmbSelectArea_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadCourse();
        }
    }
}
