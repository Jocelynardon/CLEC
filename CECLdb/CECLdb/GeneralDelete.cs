﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CECLdb
{
    public partial class GeneralDelete : Form
    {
        public GeneralDelete()
        {
            InitializeComponent();
        }

        private void Exit(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Menu Frm = new Menu();
                Frm.Show();
                this.Close();
            }
        }

        private void bttnSearchDelete_Click(object sender, EventArgs e)
        {

        }

        private void bttnReturnDelete_Click(object sender, EventArgs e)
        {
            Menu Frm = new Menu();
            Frm.Show();
            this.Close();
        }

        private void PersonDelete_Load(object sender, EventArgs e)
        {

        }
    }
}