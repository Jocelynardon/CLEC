using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CECLdb
{
    public partial class AreaReg : Form
    {
        public AreaReg()
        {
            InitializeComponent();
            if (Menu.action == 2)
            {
                bttnSaveArea.Visible = true;
                bttnAddArea.Visible = false;
                bttnSearchArea.Visible = true;
            }
        }

        private void lblAreaName_Click(object sender, EventArgs e)
        {

        }

        private void bttnReturnArea_Click(object sender, EventArgs e)
        {
            Menu Frm = new Menu();
            Frm.Show();
            this.Close();
        }

        private void AreaReg_Load(object sender, EventArgs e)
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
