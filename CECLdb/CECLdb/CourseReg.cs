using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CECLdb
{
    public partial class CourseReg : Form
    {
        public CourseReg()
        {
            InitializeComponent();
        }

        private void lblSelectArea_Click(object sender, EventArgs e)
        {

        }

        private void bttnReturnCourse_Click(object sender, EventArgs e)
        {
            Menu Frm = new Menu();
            Frm.Show();
            this.Close();
        }
    }
}
