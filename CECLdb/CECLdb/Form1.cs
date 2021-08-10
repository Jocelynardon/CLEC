using CLEC;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CECLdb;
using System.IO;
using System.Diagnostics;
using System.Security;



namespace CECLdb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadAreaCheckList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CursoSrcBtn_Click(object sender, EventArgs e)
        {

        }

        private void bttnReturnSearchCourOrAd_Click(object sender, EventArgs e)
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

        private void LoadAreaCheckList()
        {
            //CtrlArea ctrlArea = new CtrlArea();
            //List<Area> areas = ctrlArea.GetAreasQuery(null, '0');

            ////validateSelection();

            //if (areas.Count > 0)
            //{
            //    foreach (var item in areas)
            //    {
            //        cLBarea.Items.Add(item.Nombre)
            //    }
            //}


            /*************************************************************************************/
            cLBarea.Items.Clear();
            string sql = "SELECT IDarea, CONCAT(Nombre,'-',Convocatoria,'-', Año) AS infoArea FROM area ORDER BY Nombre";
            MySqlConnection connectionBD = Connection.connection();
            connectionBD.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                MySqlDataAdapter data = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                DataSet dataSet = new DataSet();
                data.Fill(dataTable);

                cLBarea.ValueMember = "IDarea";
                cLBarea.DisplayMember = "infoArea";
                cLBarea.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar áreas" + ex.Message);
            }
            finally
            {
                connectionBD.Close();
            }
        }
    }
}
