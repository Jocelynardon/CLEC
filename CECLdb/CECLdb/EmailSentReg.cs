using CLEC;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CECLdb
{
    public partial class EmailSentReg : Form, AddID
    {
        public static int idAd = 0;
        public static int type = 0;
        public int amountSelectedAd = 0;
        public int PerID;

        public int amount = 0;
        public List<int> selectedIDList = new List<int>();
        //Falta agregar una lista con los seleccionados, mostrar las demás personas que no se encuentren en ese aviso
        public EmailSentReg()
        {
            InitializeComponent();
            if (Menu.action==2)
            {
                this.Height = 152;
            }
        }

        private void bttnReturnEmailSent_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }
        private void bttnEraserText_Click(object sender, EventArgs e)
        {
            txtbTextSearch.Text = "";
        }
        private void bttnSearch_Click(object sender, EventArgs e)
        {
            Menu.action = 5;
            AdReg frmAdd = new AdReg();
            frmAdd.Show(this);
        }
        private void bttnPersonSent_Click(object sender, EventArgs e)
        {
            string IDSearch = txtbTextSearch.Text.ToString();
            consultationAmount(IDSearch);
            if (amount!=0)
            {
                dgvEmailSent.Visible = true;
                LoadTableID(IDSearch);
                this.Height = 574;
                bttnReturnEmailSent.Location = new Point(448, 484);
                SelectAllcbx.Visible = true;
                DeselectAllcbx.Visible = true;
                bttnViewSelected.Visible = true;
                if (Menu.action == 2)
                {
                    Modifybtn.Visible = true;
                }
                if (Menu.action == 3)
                {
                    Deletebtn.Location = new Point(332, 484);
                    Deletebtn.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("No hay correos enviados con ese aviso");
            }
            
        }

        private void Access(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                CloseWindow();
            }

        }
        private void LoadTableID(string data)
        {
            List<Ad> list = new List<Ad>();
            CtrlPerson person = new CtrlPerson();
            dgvEmailSent.DataSource = person.consultationIDEmailSent(data);
            validateSelection();

            if (dgvEmailSent.Rows.Count > 0)
            {
                try
                {
                    this.dgvEmailSent.Columns["ID"].Visible = false;
                }
                catch (MySqlException)
                {
                    MessageBox.Show("No se ha encontrado coincidencias");
                }
            }
            else
            {
                MessageBox.Show("No se han encontrado datos");
            }
        }
        private void consultationAmount(string IDselected)
        {
            string sql = "SELECT COUNT(1) FROM correoenviado WHERE IDaviso= "+IDselected;
            MySqlConnection connectionBD = Connection.connection();
            connectionBD.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(sql, connectionBD);
                command.Parameters.AddWithValue(sql, amount);
                command.ExecuteNonQuery();
                amount = int.Parse(command.ExecuteScalar().ToString());
            }
            catch (MySqlException)
            {
                MessageBox.Show("No hay correos enviados de ese aviso");
            }
            finally
            {
                connectionBD.Close();
            }
        }
        public void validateSelection()
        {
            foreach (DataGridViewRow row in dgvEmailSent.Rows)
            {
                for (int i = 0; i < selectedIDList.Count; i++)
                {
                    if (selectedIDList[i].Equals(row.Cells["IDaviso"].Value))
                    {
                        row.Cells["CheckSelection"].Value = true;
                    }
                }
            }
            amountSelectedAd = selectedIDList.Count;
        }
        private void CloseWindow()
        {
            Menu Frm = new Menu();
            Frm.Show();
            this.Close();
        }

        
        //colocar ID seleccionado
        #region AddID data
        public void AddNewItem(DataGridViewCell row)
        {
            string idPersonChoosen = row.Value.ToString();
            this.txtbTextSearch.Text = idPersonChoosen;
        }
        #endregion
    }
}
