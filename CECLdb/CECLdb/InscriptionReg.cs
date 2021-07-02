using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CECLdb
{
    public partial class InscriptionReg : Form
    {
        public InscriptionReg()
        {
            InitializeComponent();
            if (Menu.action==2)
            {
                txtbPersonIDInscription.ReadOnly = false;
                txtbPersonIDInscription.Enabled = true;
                bttnAddInscription.Visible = false;
                bttnSaveInscription.Visible = true;
                bttnSearchInscription.Visible = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bttnReturnInscription_Click(object sender, EventArgs e)
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
