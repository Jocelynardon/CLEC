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
        public static int id = 0;
        public static int type = 0;
        public int amountSelected = 0;
        public int PerID;

        public int amount = 0;
        public List<int> selectedIDList = new List<int>();
        //Falta agregar una lista con los seleccionados, mostrar las demás personas que no se encuentren en ese aviso
        public EmailSentReg()
        {
            InitializeComponent();
            if (Menu.action==2 || Menu.action==3)
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
            amountSelected = 0;
            string IDSearch = txtbTextSearch.Text.ToString();
            consultationAmount(IDSearch);
            if (amount>0)
            {
                dgvEmailSent.Visible = true;
                LoadTableID(IDSearch);
                this.Height = 574;
                bttnReturnEmailSent.Location = new Point(448, 484);
                SelectAllcbx.Visible = true;
                DeselectAllcbx.Visible = true;
                bttnViewSelected.Visible = true;
                bttnViewAll.Visible = true;
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
            if (amount == 0)
            {
                MessageBox.Show("No hay correos enviados con ese aviso");
            }
        }
        private void bttnViewAll_Click(object sender, EventArgs e)
        {
            List<Person> list = new List<Person>();
            CtrlPerson person = new CtrlPerson();
            dgvEmailSent.DataSource = person.consultationName(null);
            validateSelection();

            DataGridViewCheckBoxColumn CheckboxColumn = new DataGridViewCheckBoxColumn();
            if (dgvEmailSent.Rows.Count > 0)
            {
                try
                {
                    this.dgvEmailSent.Columns["ID"].Visible = false;
                }
                catch (MySqlException)
                {
                    MessageBox.Show("No se han ingresado personas");
                }
            }
            else
            {
                MessageBox.Show("No se han ingresado personas");
            }
        }
        private void bttnViewSelected_Click(object sender, EventArgs e)
        {
            if (amountSelected == 0)
            {
                MessageBox.Show("No se ha seleccionado a alguna persona");
            }
            else if (amountSelected >= 1)
            {
                LoadTableSelectedPerson(selectedIDList);
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
            CtrlPerson person = new CtrlPerson();
            dgvEmailSent.DataSource = person.consultationIDEmailSent(data);
            validateSelection();

            if (dgvEmailSent.Rows.Count > 0)
            {
                try
                {
                    this.dgvEmailSent.Columns["ID"].Visible = false;
                    this.dgvEmailSent.Columns["Apellido"].Visible = false;
                    CheckShow();

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
        private void LoadTableSelectedPerson(List<int> personSelected)
        {
            amountSelected = 0;
            CtrlPerson person = new CtrlPerson();
            int sentID = 0;
            for (int i = 0; i < personSelected.Count; i++)
            {
                sentID = int.Parse(personSelected[i].ToString());
                person.SelectedEmailSent(sentID);
            }
            dgvEmailSent.DataSource = person.listSelected;
            validateSelection();

            if (dgvEmailSent.Rows.Count > 0)
            {
                try
                {
                    this.dgvEmailSent.Columns["ID"].Visible = false;
                    this.dgvEmailSent.Columns["Apellido"].Visible = false;
                }
                catch (MySqlException)
                {
                    MessageBox.Show("No se ha seleccionado a alguna persona");
                    person.consultationName(null);
                }
            }
            else
            {
                MessageBox.Show("No se han seleccionado datos");
                person.consultationName(null);
            }
        }
        private void CheckShow()
        {
            foreach (DataGridViewRow row in dgvEmailSent.Rows)
            {
                    row.Cells["CheckSelection"].Value = true;
                    selectedIDList.Add(int.Parse(row.Cells["ID"].Value.ToString()));
            }
            amountSelected = selectedIDList.Count;
        }
        private void consultationAmount(string IDselected)
        {
            amount = 0;
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
                MessageBox.Show("No hay email enviados a los correos");
                amount = -1;
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
                    if (selectedIDList[i].Equals(row.Cells["ID"].Value))
                    {
                        row.Cells["CheckSelection"].Value = true;
                    }
                }
            }
            amountSelected = selectedIDList.Count;
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

        private void dgvEmailSent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dgvEmailSent.CurrentRow.Cells["ID"].Value.ToString());
            if (dgvEmailSent.CurrentRow.Cells["CheckSelection"].Value != null && (bool)dgvEmailSent.CurrentRow.Cells["CheckSelection"].Value)
            {
                dgvEmailSent.CurrentRow.Cells["CheckSelection"].Value = false;
                dgvEmailSent.CurrentRow.Cells["CheckSelection"].Value = null;
                amountSelected += -1;
                selectedIDList.Remove(id);
            }
            else if (dgvEmailSent.CurrentRow.Cells["CheckSelection"].Value == null)
            {
                dgvEmailSent.CurrentRow.Cells["CheckSelection"].Value = true;
                amountSelected += 1;
                selectedIDList.Add(id);
            }
        }
        private void txtbTextSearch_TextChanged(object sender, EventArgs e)
        {
            selectedIDList.Clear();
        }
    }
}
