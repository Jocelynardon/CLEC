using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CECLdb
{
    public partial class EmailSentReg : Form
    {
        public EmailSentReg()
        {
            InitializeComponent();
            if (Menu.action==2)
            {
                bttnAddES.Visible = false;
                bttnSaveES.Visible = true;
                bttnSearchES.Visible = true;
                bttnImportDataEmailSent.Visible = false;
            }
        }

        private void bttnReturnEmailSent_Click(object sender, EventArgs e)
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
