﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CECLdb
{
    public partial class PersonReg : Form
    {
        public PersonReg()
        {
            InitializeComponent();
        }

        public PersonReg(int action)
        {
            switch (action)
            {
                case 0:
                    bttnSave.Visible = false;
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttnReturnPerson_Click(object sender, EventArgs e)
        {
            Menu Frm = new Menu();
            Frm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
