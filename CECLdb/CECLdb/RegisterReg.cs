using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CECLdb
{
    public partial class RegisterReg : Form
    {
        public RegisterReg()
        {
            InitializeComponent();
            if (Menu.action==2)
            {
                txtbPersonIDRegister.Enabled = true;
                txtbPersonIDRegister.ReadOnly = false;
                bttnAddRegister.Visible = false;
                bttnSaveRegister.Visible = true;
                bttnSearchRegister.Visible = true;
            }
        }

        private void bttnReturnRegister_Click(object sender, EventArgs e)
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
