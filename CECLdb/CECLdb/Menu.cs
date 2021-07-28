using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace CECLdb
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        //Variable global que indica en qué opción se trabajará
        public static int action = 0;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbttnAddAd_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbttnAddEmailSent_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {

            if (rbttnSearchPerson.Checked)
            {
                PeopleSearch Frm = new PeopleSearch();
                Frm.Show();
                this.Close();
            }
            else if (rbttnSearchCourseorAd.Checked)
            {
                Form1 Frm = new Form1();
                Frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione alguna opción");
            }
        }
        //Agregar
        private void bttnAddMenu_Click(object sender, EventArgs e)
        {
            action = 1;
            if (rbttnAddPerson.Checked)

            {
                PersonReg Frm = new PersonReg();
                Frm.Show();
                this.Close();
            }
            else if (rbttnAddRegister.Checked)
            {
                RegisterReg Frm = new RegisterReg();
                Frm.Show();
                this.Close();
            }
            else if (rbttnAddInscription.Checked)
            {
                InscriptionReg Frm = new InscriptionReg();
                Frm.Show();
                this.Close();
            }
            else if (rbttnAddAd.Checked)
            {
                AdReg Frm = new AdReg();
                Frm.Show();
                this.Close();
            }
            else if (rbttnAddCourse.Checked)
            {
                CourseReg Frm = new CourseReg();
                Frm.Show();
                this.Close();
            }
            else if (rbttnAddArea.Checked)
            {
                AreaReg Frm = new AreaReg();
                Frm.Show();
                this.Close();
            }
            else if (rbttnAddEmailSent.Checked)
            {
                EmailSentReg Frm = new EmailSentReg();
                Frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione alguna opción");
            }
        }

        private void ControlKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                Application.Exit();
            }
            else if (e.KeyCode==Keys.Enter)
            {
                action = 1;
                if (rbttnAddPerson.Checked)

                {
                    PersonReg Frm = new PersonReg();
                    Frm.Show();
                    this.Close();
                }
                else if (rbttnAddRegister.Checked)
                {
                    RegisterReg Frm = new RegisterReg();
                    Frm.Show();
                    this.Close();
                }
                else if (rbttnAddInscription.Checked)
                {
                    InscriptionReg Frm = new InscriptionReg();
                    Frm.Show();
                    this.Close();
                }
                else if (rbttnAddAd.Checked)
                {
                    AdReg Frm = new AdReg();
                    Frm.Show();
                    this.Close();
                }
                else if (rbttnAddCourse.Checked)
                {
                    CourseReg Frm = new CourseReg();
                    Frm.Show();
                    this.Close();
                }
                else if (rbttnAddArea.Checked)
                {
                    AreaReg Frm = new AreaReg();
                    Frm.Show();
                    this.Close();
                }
                else if (rbttnAddEmailSent.Checked)
                {
                    EmailSentReg Frm = new EmailSentReg();
                    Frm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Seleccione alguna opción");
                }
            }
        }
        //Modificar
        private void bttnModifyMenu_Click(object sender, EventArgs e)
        {
            action = 2;
                if (rbttnAddPerson.Checked)
                {
                    PersonReg Frm = new PersonReg();
                    Frm.Show();
                    this.Close();
                }
                else if (rbttnAddRegister.Checked)
                {
                    RegisterReg Frm = new RegisterReg();
                    Frm.Show();
                    this.Close();
                }
                else if (rbttnAddInscription.Checked)
                {
                    InscriptionReg Frm = new InscriptionReg();
                    Frm.Show();
                    this.Close();
                }
                else if (rbttnAddAd.Checked)
                {
                    AdReg Frm = new AdReg();
                    Frm.Show();
                    this.Close();
                }
                else if (rbttnAddCourse.Checked)
                {
                    CourseReg Frm = new CourseReg();
                    Frm.Show();
                    this.Close();
                }
                else if (rbttnAddArea.Checked)
                {
                    AreaReg Frm = new AreaReg();
                    Frm.Show();
                    this.Close();
                }
                else if (rbttnAddEmailSent.Checked)
                {
                    EmailSentReg Frm = new EmailSentReg();
                    Frm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Seleccione alguna opción");
                }
        }

        private void Aux(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void bttnDeleteMenu_Click(object sender, EventArgs e)
        {
            action = 3;
            if (rbttnAddPerson.Checked)

            {
                PersonReg personReg = new PersonReg();
                personReg.Show();
                this.Close();
            }
            else if (rbttnAddRegister.Checked)
            {
                GeneralDelete Frm = new GeneralDelete();
                Frm.Show();
                this.Close();
            }
            else if (rbttnAddInscription.Checked)
            {
                GeneralDelete Frm = new GeneralDelete();
                Frm.Show();
                this.Close();
            }
            else if (rbttnAddAd.Checked)
            {
                GeneralDelete Frm = new GeneralDelete();
                Frm.Show();
                this.Close();
            }
            else if (rbttnAddCourse.Checked)
            {
                GeneralDelete Frm = new GeneralDelete();
                Frm.Show();
                this.Close();
            }
            else if (rbttnAddArea.Checked)
            {
                GeneralDelete Frm = new GeneralDelete();
                Frm.Show();
                this.Close();
            }
            else if (rbttnAddEmailSent.Checked)
            {
                GeneralDelete Frm = new GeneralDelete();
                Frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione alguna opción");
            }
        }

    }
}
