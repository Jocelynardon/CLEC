using CLEC;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
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
        public PeopleSearch()
        {
            InitializeComponent();
            rbttnCode.Checked=true;
            rbttnEmailSent.Checked = true;
            Allrbtn.Checked = true;
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
                    if (rbttnEmailSent.Checked)
                    {
                        if (txtSearch.Text == "") 
                        {
                            SearchCodeEmail(null);
                        }
                        else
                        {
                            SearchCodeEmail(txtSearch.Text);
                        }
                    }
                    else if (rbttnInscribed.Checked)
                    {
                        if (Passedrbtn.Checked)
                        {
                            if (txtSearch.Text == "")
                            {
                                SearchByCodeStatus(null, 1);
                            }
                            else
                            {
                                SearchByCodeStatus(txtSearch.Text, 1);
                            }
                        }
                        else if (NotPassedrbtn.Checked)
                        {
                            if (txtSearch.Text == "")
                            {
                                SearchByCodeStatus(null, 0);
                            }
                            else
                            {
                                SearchByCodeStatus(txtSearch.Text, 0);
                            }
                        }
                        else
                        {
                            if (txtSearch.Text == "")
                            {
                                SearchByCodeStatus(null, 2);
                            }
                            else
                            {
                                SearchByCodeStatus(txtSearch.Text, 2);
                            }
                        }
                    }
                    if (rbttnConsulted.Checked)
                    {
                        if (txtSearch.Text == "")
                        {
                            SearchCodeRegister(null);
                        }
                        else
                        {
                            SearchCodeRegister(txtSearch.Text);
                        }
                    }
                    break;
                case 2:
                    if (rbttnEmailSent.Checked)
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
                    if (rbttnInscribed.Checked == true)
                    {
                        if (Passedrbtn.Checked)
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
                        else if (NotPassedrbtn.Checked)
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
                        else
                        {
                            if (txtSearch.Text == "")
                            {
                                SearchByEmailStatus(null, 2);
                            }
                            if (txtSearch.Text != "")
                            {
                                SearchByEmailStatus(txtSearch.Text, 2);
                            }
                        }
                    }
                    if (rbttnConsulted.Checked)
                    {
                        if (txtSearch.Text == "")
                        {
                            SearchByEmailRegister(null);
                        }
                        if (txtSearch.Text != "")
                        {
                            SearchByEmailRegister(txtSearch.Text);
                        }
                    }
                    break;
                case 3:
                    if (rbttnEmailSent.Checked)
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
                    if (rbttnInscribed.Checked == true)
                    {
                        if (Passedrbtn.Checked)
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
                        else if (NotPassedrbtn.Checked)
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
                        else
                        {
                            if (txtSearch.Text == "")
                            {
                                SearchByNameStatus(null, 2);
                            }
                            if (txtSearch.Text != "")
                            {
                                SearchByNameStatus(txtSearch.Text, 2);
                            }
                        }
                    }
                    if (rbttnConsulted.Checked == true)
                    {
                        if (txtSearch.Text == "")
                        {
                            SearchByNameRegister(null);
                        }
                        if (txtSearch.Text != "")
                        {
                            SearchByNameRegister(txtSearch.Text);
                        }
                    }
                    break;
                case 4:
                    if (rbttnEmailSent.Checked)
                    {
                        if (cmbSelectArea.Text == "")
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
                    if (rbttnInscribed.Checked)
                    {
                        if (Passedrbtn.Checked)
                        {
                            if (cmbSelectArea.Text == "")
                            {
                                SearchByCourseStatus(0, 0, 1);
                            }
                            if (cmbSelectArea.Text != "")
                            {
                                int idArea = int.Parse(cmbSelectArea.SelectedValue.ToString());
                                int idCourse = int.Parse(cmbSelectCourse.SelectedValue.ToString());
                                SearchByCourseStatus(idArea, idCourse, 1);
                            }
                        }
                        else if (NotPassedrbtn.Checked)
                        {
                            if (cmbSelectArea.Text == "")
                            {
                                SearchByCourseStatus(0, 0, 0);
                            }
                            if (cmbSelectArea.Text != "")
                            {
                                int idArea = int.Parse(cmbSelectArea.SelectedValue.ToString());
                                int idCourse = int.Parse(cmbSelectCourse.SelectedValue.ToString());
                                SearchByCourseStatus(idArea, idCourse, 0);
                            }
                        }
                        else
                        {
                            if (cmbSelectArea.Text == "")
                            {
                                SearchByCourseStatus(0, 0, 2);
                            }
                            if (cmbSelectArea.Text != "")
                            {
                                int idArea = int.Parse(cmbSelectArea.SelectedValue.ToString());
                                int idCourse = int.Parse(cmbSelectCourse.SelectedValue.ToString());
                                SearchByCourseStatus(idArea, idCourse, 2);
                            }
                        }
                    }
                    if (rbttnConsulted.Checked == true)
                    {
                        if (cmbSelectArea.Text == "")
                        {
                            SearchByCourseRegister(0, 0);
                        }
                        if (cmbSelectArea.Text != "")
                        {
                            int idArea = int.Parse(cmbSelectArea.SelectedValue.ToString());
                            int idCourse = int.Parse(cmbSelectCourse.SelectedValue.ToString());
                            SearchByCourseRegister(idArea, idCourse);
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
                    this.dgvPeopleSearch.Columns["FechaConsulta"].Visible = false;
                    this.dgvPeopleSearch.Columns["Código"].Visible = true;
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
                    this.dgvPeopleSearch.Columns["FechaConsulta"].Visible = false;
                    this.dgvPeopleSearch.Columns["Código"].Visible = true;
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
                    this.dgvPeopleSearch.Columns["FechaConsulta"].Visible = false;
                    this.dgvPeopleSearch.Columns["Código"].Visible = true;
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
                    this.dgvPeopleSearch.Columns["FechaConsulta"].Visible = false;
                    this.dgvPeopleSearch.Columns["Código"].Visible = true;
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
                    this.dgvPeopleSearch.Columns["FechaConsulta"].Visible = false;
                    this.dgvPeopleSearch.Columns["Código"].Visible = true;
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
                    this.dgvPeopleSearch.Columns["FechaConsulta"].Visible = false;
                    this.dgvPeopleSearch.Columns["Código"].Visible = true;
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
                    this.dgvPeopleSearch.Columns["FechaConsulta"].Visible = false;
                    this.dgvPeopleSearch.Columns["Código"].Visible = true;
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
                    this.dgvPeopleSearch.Columns["FechaConsulta"].Visible = false;
                    this.dgvPeopleSearch.Columns["Código"].Visible = true;
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
                    this.dgvPeopleSearch.Columns["FechaConsulta"].Visible = false;
                    this.dgvPeopleSearch.Columns["Código"].Visible = true;
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
                    this.dgvPeopleSearch.Columns["FechaConsulta"].Visible = false;
                    this.dgvPeopleSearch.Columns["Código"].Visible = true;
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
                    this.dgvPeopleSearch.Columns["FechaConsulta"].Visible = false;
                    this.dgvPeopleSearch.Columns["Código"].Visible = true;
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
                }
            }
        }
        private void SearchByCourseStatus(int idArea, int idCourse, int approved)
        {
            CtrlSearchPeople person = new CtrlSearchPeople();
            dgvPeopleSearch.DataSource = person.consultationCourseByStatus(idArea, idCourse,approved);
            lblTotalResult.Visible = true;
            lblTotalResult.Text = "Total Resultados: " + dgvPeopleSearch.Rows.Count;
            // approved -> 0 = notpassed, 1 = passed, 2 = all
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
                    this.dgvPeopleSearch.Columns["FechaConsulta"].Visible = false;
                    this.dgvPeopleSearch.Columns["Código"].Visible = true;
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
                }
            }
        }
        private void SearchCodeRegister(string data)
        {
            CtrlSearchPeople person = new CtrlSearchPeople();
            dgvPeopleSearch.DataSource = person.consultationCodeRegister(data);
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
                    this.dgvPeopleSearch.Columns["Descripción"].Visible = false;
                    this.dgvPeopleSearch.Columns["FechaAviso"].Visible = false;
                    this.dgvPeopleSearch.Columns["FechaConsulta"].Visible = true;
                    this.dgvPeopleSearch.Columns["Código"].Visible = true;
                }
                catch (MySqlException)
                {
                    if (!update)
                    {
                        MessageBox.Show("No se ha encontrado coincidencias");
                        SearchCodeRegister(null);
                    }
                }
            }
            else
            {
                if (!update)
                {
                    MessageBox.Show("No se han encontrado datos");
                }
            }
        }
        private void SearchByEmailRegister(string data)
        {
            CtrlSearchPeople person = new CtrlSearchPeople();
            dgvPeopleSearch.DataSource = person.consultationEmailRegister(data);
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
                    this.dgvPeopleSearch.Columns["Descripción"].Visible = false;
                    this.dgvPeopleSearch.Columns["FechaAviso"].Visible = false;
                    this.dgvPeopleSearch.Columns["FechaConsulta"].Visible = true;
                    this.dgvPeopleSearch.Columns["Código"].Visible = false;
                }
                catch (MySqlException)
                {
                    if (!update)
                    {
                        MessageBox.Show("No se ha encontrado coincidencias");
                        SearchByEmailRegister(null);
                    }
                }
            }
            else
            {
                if (!update)
                {
                    MessageBox.Show("No se han encontrado datos");
                }
            }
        }
        private void SearchByNameRegister(string data)
        {
            CtrlSearchPeople person = new CtrlSearchPeople();
            dgvPeopleSearch.DataSource = person.consultationNameRegister(data);
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
                    this.dgvPeopleSearch.Columns["Descripción"].Visible = false;
                    this.dgvPeopleSearch.Columns["FechaAviso"].Visible = false;
                    this.dgvPeopleSearch.Columns["FechaConsulta"].Visible = true;
                    this.dgvPeopleSearch.Columns["Código"].Visible = false;
                }
                catch (MySqlException)
                {
                    if (!update)
                    {
                        MessageBox.Show("No se ha encontrado coincidencias");
                        SearchByEmailRegister(null);
                    }
                }
            }
            else
            {
                if (!update)
                {
                    MessageBox.Show("No se han encontrado datos");
                }
            }
        }
        private void SearchByCourseRegister(int idArea,int idCourse)
        {
            CtrlSearchPeople person = new CtrlSearchPeople();
            dgvPeopleSearch.DataSource = person.consultationCourseRegister(idArea,idCourse);
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
                    this.dgvPeopleSearch.Columns["Descripción"].Visible = false;
                    this.dgvPeopleSearch.Columns["FechaAviso"].Visible = false;
                    this.dgvPeopleSearch.Columns["FechaConsulta"].Visible = true;
                    this.dgvPeopleSearch.Columns["Código"].Visible = false;
                }
                catch (MySqlException)
                {
                    if (!update)
                    {
                        MessageBox.Show("No se ha encontrado coincidencias");
                        SearchByEmailRegister(null);
                    }
                }
            }
            else
            {
                if (!update)
                {
                    MessageBox.Show("No se han encontrado datos");
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
            txtSearch.Text = "";
            cmbSelectArea.SelectedIndex = -1;
            cmbSelectCourse.DataSource=null;
            cmbSelectCourse.Items.Clear();
            rbttnEmailSent.Checked = false;
            rbttnInscribed.Checked = false;
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
                txtSearch.Enabled = true;
                lblType.Enabled = true;
                lblType.Text = "Código";
                selectionType = 1;
                rbttnCourse.Checked = false;
            }
        }
        private void rbttnEmail_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbttnEmail.Checked)
            {
                txtSearch.Enabled = true;
                lblType.Enabled = true;
                lblType.Text = "Correo";
                selectionType = 2;
                rbttnCourse.Checked = false;
            }
        }
        private void rbttnName_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbttnName.Checked)
            {
                txtSearch.Enabled = true;
                lblType.Enabled = true;
                lblType.Text = "Nombre";
                selectionType = 3;
                rbttnCourse.Checked = false;
            }
        }
        private void rbttnCourse_CheckedChanged(object sender, EventArgs e)
        {
            if (rbttnCourse.Checked)
            {
                rbttnEmail.Checked = false;
                rbttnName.Checked = false;
                rbttnCode.Checked = false;
                lblType.Enabled = false;
                txtSearch.Enabled = false;
                lblArea.Enabled = true;
                lblCourse.Enabled = true;
                cmbSelectArea.Enabled = true;
                LoadArea();
                cmbSelectArea.SelectedIndex = -1;
                cmbSelectCourse.Enabled = true;
                selectionType = 4;
            }
            else
            {
                lblArea.Enabled = false;
                lblCourse.Enabled = false;
                cmbSelectArea.Enabled = false;
                cmbSelectCourse.Enabled = false;
            }
        }

        private void rbttnStatus_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }
        private void rbttnInscribed_CheckedChanged(object sender, EventArgs e)
        { 
            if (rbttnInscribed.Checked)
            {
                gpbStatus.Visible = true;
            }
            else
            {
                gpbStatus.Visible = false;
            }
        }


        private void cmbSelectArea_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadCourse();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (selectionType == 1)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
