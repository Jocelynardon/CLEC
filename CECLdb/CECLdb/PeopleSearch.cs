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
        public PeopleSearch()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PeopleSrcBtn_Click(object sender, EventArgs e)
        {

        }

        private void bttnReturn_Click(object sender, EventArgs e)
        {
            Menu Frm = new Menu();
            Frm.Show();
            this.Close();
        }

        private void Access(object sender, KeyEventArgs e)
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
