﻿using System;
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
        public AdReg()
        {
            InitializeComponent();
            if (Menu.action==2)
            {
                bttnAddAd.Visible = false;
                bttnSaveAd.Visible = true;
                bttnSearchAd.Visible = true;
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bttnReturnAd_Click(object sender, EventArgs e)
        {
            Menu Frm = new Menu();
            Frm.Show();
            this.Close();
        }

        private void bttnSearchAd_Click(object sender, EventArgs e)
        {

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
                Menu Frm = new Menu();
                Frm.Show();
                this.Close();
            }
        }
    }
}
