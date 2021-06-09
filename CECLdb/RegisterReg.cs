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
        }

        private void bttnReturnRegister_Click(object sender, EventArgs e)
        {
            Menu Frm = new Menu();
            Frm.Show();
            this.Close();
        }
    }
}
