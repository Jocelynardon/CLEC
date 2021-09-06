using System;
using System.Windows.Forms;

namespace CECLdb
{
    public partial class ReqData3 : Form
    {
        public ReqData3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }

        private void Access(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                CloseWindow();
            }
        }
        private void CloseWindow()
        {
            Menu Frm = new Menu();
            Frm.Show();
            this.Close();
        }

    }
}
