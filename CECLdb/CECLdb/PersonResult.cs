using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CECLdb
{
    public partial class PersonResult : Form
    {
        public PersonResult()
        {
            InitializeComponent();
            if (PersonReg._action==2)
            {
                SelectAllcbx.Visible = false;
                Deletebtn.Visible = false;
                Modifybtn.Visible = true;
            }
            else if (PersonReg._action==3)
            {
                SelectAllcbx.Visible = true;
                Deletebtn.Visible = true;
                Modifybtn.Visible = false;
            }
        }

        private void Returnbtn_Click(object sender, EventArgs e)
        {
            PersonReg reg = new PersonReg();
            reg.Show();
            this.Close();
        }
    }
}
