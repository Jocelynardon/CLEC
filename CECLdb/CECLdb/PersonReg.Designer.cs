
namespace CECLdb
{
    partial class PersonReg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblName = new System.Windows.Forms.Label();
            this.txtbNamePerson = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelNumber = new System.Windows.Forms.Label();
            this.bttnAddPerson = new System.Windows.Forms.Button();
            this.bttnSearchPerson = new System.Windows.Forms.Button();
            this.lblEscPerson = new System.Windows.Forms.Label();
            this.txtEmailPerson = new System.Windows.Forms.TextBox();
            this.bttnImportPerson = new System.Windows.Forms.Button();
            this.lblLastNamePerson = new System.Windows.Forms.Label();
            this.txtbLastNamePerson = new System.Windows.Forms.TextBox();
            this.dgvPersonReg = new System.Windows.Forms.DataGridView();
            this.CheckSelection = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SelectAllcbx = new System.Windows.Forms.CheckBox();
            this.Modifybtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.bttnSelectPerson = new System.Windows.Forms.Button();
            this.txtTextSearch = new System.Windows.Forms.TextBox();
            this.cmbTypeSearch = new System.Windows.Forms.ComboBox();
            this.txtbTelephone = new System.Windows.Forms.TextBox();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.bttnSentEmail = new System.Windows.Forms.Button();
            this.bttnViewSelectedPerson = new System.Windows.Forms.Button();
            this.DeselectAllcbx = new System.Windows.Forms.CheckBox();
            this.bttnEraserText = new System.Windows.Forms.Button();
            this.DataGBox = new System.Windows.Forms.GroupBox();
            this.SearchGBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonReg)).BeginInit();
            this.DataGBox.SuspendLayout();
            this.SearchGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            // 
            // txtbNamePerson
            // 
            this.txtbNamePerson.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtbNamePerson.Location = new System.Drawing.Point(12, 71);
            this.txtbNamePerson.Name = "txtbNamePerson";
            this.txtbNamePerson.Size = new System.Drawing.Size(353, 27);
            this.txtbNamePerson.TabIndex = 0;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 121);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Correo";
            // 
            // lblTelNumber
            // 
            this.lblTelNumber.AutoSize = true;
            this.lblTelNumber.Location = new System.Drawing.Point(518, 131);
            this.lblTelNumber.Name = "lblTelNumber";
            this.lblTelNumber.Size = new System.Drawing.Size(67, 20);
            this.lblTelNumber.TabIndex = 4;
            this.lblTelNumber.Text = "Teléfono";
            // 
            // bttnAddPerson
            // 
            this.bttnAddPerson.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnAddPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnAddPerson.Location = new System.Drawing.Point(364, 242);
            this.bttnAddPerson.Name = "bttnAddPerson";
            this.bttnAddPerson.Size = new System.Drawing.Size(94, 29);
            this.bttnAddPerson.TabIndex = 5;
            this.bttnAddPerson.Text = "Agregar";
            this.bttnAddPerson.UseVisualStyleBackColor = false;
            this.bttnAddPerson.Click += new System.EventHandler(this.bttnAddPerson_Click);
            // 
            // bttnSearchPerson
            // 
            this.bttnSearchPerson.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bttnSearchPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnSearchPerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnSearchPerson.Location = new System.Drawing.Point(777, 34);
            this.bttnSearchPerson.Name = "bttnSearchPerson";
            this.bttnSearchPerson.Size = new System.Drawing.Size(94, 26);
            this.bttnSearchPerson.TabIndex = 11;
            this.bttnSearchPerson.Text = "Buscar";
            this.bttnSearchPerson.UseVisualStyleBackColor = false;
            this.bttnSearchPerson.Visible = false;
            this.bttnSearchPerson.Click += new System.EventHandler(this.bttnSearchPerson_Click);
            // 
            // lblEscPerson
            // 
            this.lblEscPerson.AutoSize = true;
            this.lblEscPerson.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblEscPerson.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEscPerson.Location = new System.Drawing.Point(853, 9);
            this.lblEscPerson.Name = "lblEscPerson";
            this.lblEscPerson.Size = new System.Drawing.Size(165, 22);
            this.lblEscPerson.TabIndex = 11;
            this.lblEscPerson.Text = "(ESC) Regresar al Menú";
            // 
            // txtEmailPerson
            // 
            this.txtEmailPerson.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtEmailPerson.Location = new System.Drawing.Point(12, 167);
            this.txtEmailPerson.Name = "txtEmailPerson";
            this.txtEmailPerson.Size = new System.Drawing.Size(439, 27);
            this.txtEmailPerson.TabIndex = 2;
            // 
            // bttnImportPerson
            // 
            this.bttnImportPerson.BackColor = System.Drawing.Color.LightCoral;
            this.bttnImportPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnImportPerson.Location = new System.Drawing.Point(635, 242);
            this.bttnImportPerson.Name = "bttnImportPerson";
            this.bttnImportPerson.Size = new System.Drawing.Size(94, 29);
            this.bttnImportPerson.TabIndex = 13;
            this.bttnImportPerson.Text = "Importar";
            this.bttnImportPerson.UseVisualStyleBackColor = false;
            this.bttnImportPerson.Click += new System.EventHandler(this.bttnImportPerson_Click);
            // 
            // lblLastNamePerson
            // 
            this.lblLastNamePerson.AutoSize = true;
            this.lblLastNamePerson.Location = new System.Drawing.Point(518, 35);
            this.lblLastNamePerson.Name = "lblLastNamePerson";
            this.lblLastNamePerson.Size = new System.Drawing.Size(66, 20);
            this.lblLastNamePerson.TabIndex = 14;
            this.lblLastNamePerson.Text = "Apellido";
            // 
            // txtbLastNamePerson
            // 
            this.txtbLastNamePerson.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtbLastNamePerson.Location = new System.Drawing.Point(518, 71);
            this.txtbLastNamePerson.Name = "txtbLastNamePerson";
            this.txtbLastNamePerson.Size = new System.Drawing.Size(353, 27);
            this.txtbLastNamePerson.TabIndex = 1;
            // 
            // dgvPersonReg
            // 
            this.dgvPersonReg.AllowUserToAddRows = false;
            this.dgvPersonReg.AllowUserToDeleteRows = false;
            this.dgvPersonReg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPersonReg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPersonReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonReg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckSelection});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPersonReg.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPersonReg.Location = new System.Drawing.Point(24, 124);
            this.dgvPersonReg.Name = "dgvPersonReg";
            this.dgvPersonReg.ReadOnly = true;
            this.dgvPersonReg.RowHeadersWidth = 51;
            this.dgvPersonReg.RowTemplate.Height = 29;
            this.dgvPersonReg.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonReg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonReg.Size = new System.Drawing.Size(936, 319);
            this.dgvPersonReg.TabIndex = 18;
            this.dgvPersonReg.Visible = false;
            this.dgvPersonReg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonReg_CellContentClick);
            // 
            // CheckSelection
            // 
            this.CheckSelection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CheckSelection.HeaderText = "Selección";
            this.CheckSelection.MinimumWidth = 6;
            this.CheckSelection.Name = "CheckSelection";
            this.CheckSelection.ReadOnly = true;
            this.CheckSelection.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CheckSelection.Width = 78;
            // 
            // SelectAllcbx
            // 
            this.SelectAllcbx.AutoSize = true;
            this.SelectAllcbx.BackColor = System.Drawing.SystemColors.Control;
            this.SelectAllcbx.Enabled = false;
            this.SelectAllcbx.Location = new System.Drawing.Point(24, 94);
            this.SelectAllcbx.Name = "SelectAllcbx";
            this.SelectAllcbx.Size = new System.Drawing.Size(151, 24);
            this.SelectAllcbx.TabIndex = 15;
            this.SelectAllcbx.Text = "Seleccionar Todos";
            this.SelectAllcbx.UseVisualStyleBackColor = false;
            this.SelectAllcbx.Visible = false;
            this.SelectAllcbx.CheckedChanged += new System.EventHandler(this.SelectAllcbx_CheckedChanged);
            // 
            // Modifybtn
            // 
            this.Modifybtn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Modifybtn.Enabled = false;
            this.Modifybtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Modifybtn.Location = new System.Drawing.Point(347, 463);
            this.Modifybtn.Name = "Modifybtn";
            this.Modifybtn.Size = new System.Drawing.Size(94, 29);
            this.Modifybtn.TabIndex = 12;
            this.Modifybtn.Text = "Modificar";
            this.Modifybtn.UseVisualStyleBackColor = false;
            this.Modifybtn.Visible = false;
            this.Modifybtn.Click += new System.EventHandler(this.Modifybtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.Honeydew;
            this.Deletebtn.Enabled = false;
            this.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Deletebtn.Location = new System.Drawing.Point(469, 463);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(94, 29);
            this.Deletebtn.TabIndex = 13;
            this.Deletebtn.Text = "Eliminar";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Visible = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // bttnSelectPerson
            // 
            this.bttnSelectPerson.BackColor = System.Drawing.Color.Khaki;
            this.bttnSelectPerson.Enabled = false;
            this.bttnSelectPerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnSelectPerson.Location = new System.Drawing.Point(591, 463);
            this.bttnSelectPerson.Name = "bttnSelectPerson";
            this.bttnSelectPerson.Size = new System.Drawing.Size(94, 29);
            this.bttnSelectPerson.TabIndex = 14;
            this.bttnSelectPerson.Text = "Seleccionar";
            this.bttnSelectPerson.UseVisualStyleBackColor = false;
            this.bttnSelectPerson.Visible = false;
            this.bttnSelectPerson.Click += new System.EventHandler(this.bttnSelectPerson_Click);
            // 
            // txtTextSearch
            // 
            this.txtTextSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTextSearch.Location = new System.Drawing.Point(24, 36);
            this.txtTextSearch.Name = "txtTextSearch";
            this.txtTextSearch.Size = new System.Drawing.Size(434, 27);
            this.txtTextSearch.TabIndex = 9;
            this.txtTextSearch.Visible = false;
            // 
            // cmbTypeSearch
            // 
            this.cmbTypeSearch.FormattingEnabled = true;
            this.cmbTypeSearch.Location = new System.Drawing.Point(483, 34);
            this.cmbTypeSearch.Name = "cmbTypeSearch";
            this.cmbTypeSearch.Size = new System.Drawing.Size(269, 28);
            this.cmbTypeSearch.TabIndex = 10;
            this.cmbTypeSearch.Visible = false;
            // 
            // txtbTelephone
            // 
            this.txtbTelephone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtbTelephone.Location = new System.Drawing.Point(518, 167);
            this.txtbTelephone.Name = "txtbTelephone";
            this.txtbTelephone.Size = new System.Drawing.Size(136, 27);
            this.txtbTelephone.TabIndex = 3;
            // 
            // btnSaveData
            // 
            this.btnSaveData.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSaveData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveData.Location = new System.Drawing.Point(297, 242);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(161, 29);
            this.btnSaveData.TabIndex = 6;
            this.btnSaveData.Text = "Guardar Datos";
            this.btnSaveData.UseVisualStyleBackColor = false;
            this.btnSaveData.Visible = false;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClean.Location = new System.Drawing.Point(483, 242);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(129, 29);
            this.btnClean.TabIndex = 8;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Visible = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // bttnSentEmail
            // 
            this.bttnSentEmail.BackColor = System.Drawing.Color.DarkOrange;
            this.bttnSentEmail.Enabled = false;
            this.bttnSentEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnSentEmail.Location = new System.Drawing.Point(144, 463);
            this.bttnSentEmail.Name = "bttnSentEmail";
            this.bttnSentEmail.Size = new System.Drawing.Size(187, 29);
            this.bttnSentEmail.TabIndex = 30;
            this.bttnSentEmail.Text = "Registrar como enviado";
            this.bttnSentEmail.UseVisualStyleBackColor = false;
            this.bttnSentEmail.Visible = false;
            this.bttnSentEmail.Click += new System.EventHandler(this.bttnSentEmail_Click);
            // 
            // bttnViewSelectedPerson
            // 
            this.bttnViewSelectedPerson.BackColor = System.Drawing.Color.LightSalmon;
            this.bttnViewSelectedPerson.Enabled = false;
            this.bttnViewSelectedPerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnViewSelectedPerson.Location = new System.Drawing.Point(712, 463);
            this.bttnViewSelectedPerson.Name = "bttnViewSelectedPerson";
            this.bttnViewSelectedPerson.Size = new System.Drawing.Size(187, 29);
            this.bttnViewSelectedPerson.TabIndex = 31;
            this.bttnViewSelectedPerson.Text = "Ver seleccionados";
            this.bttnViewSelectedPerson.UseVisualStyleBackColor = false;
            this.bttnViewSelectedPerson.Visible = false;
            this.bttnViewSelectedPerson.Click += new System.EventHandler(this.bttnViewSelectedPerson_Click);
            // 
            // DeselectAllcbx
            // 
            this.DeselectAllcbx.AutoSize = true;
            this.DeselectAllcbx.Enabled = false;
            this.DeselectAllcbx.Location = new System.Drawing.Point(185, 94);
            this.DeselectAllcbx.Name = "DeselectAllcbx";
            this.DeselectAllcbx.Size = new System.Drawing.Size(146, 24);
            this.DeselectAllcbx.TabIndex = 32;
            this.DeselectAllcbx.Text = "Desmarcar Todos";
            this.DeselectAllcbx.UseVisualStyleBackColor = true;
            this.DeselectAllcbx.Visible = false;
            this.DeselectAllcbx.CheckedChanged += new System.EventHandler(this.DeselectAllcbx_CheckedChanged);
            // 
            // bttnEraserText
            // 
            this.bttnEraserText.BackColor = System.Drawing.Color.LightYellow;
            this.bttnEraserText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnEraserText.Location = new System.Drawing.Point(886, 34);
            this.bttnEraserText.Name = "bttnEraserText";
            this.bttnEraserText.Size = new System.Drawing.Size(63, 26);
            this.bttnEraserText.TabIndex = 51;
            this.bttnEraserText.Text = "Borrar";
            this.bttnEraserText.UseVisualStyleBackColor = false;
            this.bttnEraserText.Visible = false;
            this.bttnEraserText.Click += new System.EventHandler(this.bttnEraserText_Click);
            // 
            // DataGBox
            // 
            this.DataGBox.BackColor = System.Drawing.Color.Ivory;
            this.DataGBox.Controls.Add(this.btnClean);
            this.DataGBox.Controls.Add(this.btnSaveData);
            this.DataGBox.Controls.Add(this.txtbTelephone);
            this.DataGBox.Controls.Add(this.txtbLastNamePerson);
            this.DataGBox.Controls.Add(this.lblLastNamePerson);
            this.DataGBox.Controls.Add(this.bttnImportPerson);
            this.DataGBox.Controls.Add(this.txtEmailPerson);
            this.DataGBox.Controls.Add(this.bttnAddPerson);
            this.DataGBox.Controls.Add(this.lblTelNumber);
            this.DataGBox.Controls.Add(this.lblEmail);
            this.DataGBox.Controls.Add(this.txtbNamePerson);
            this.DataGBox.Controls.Add(this.lblName);
            this.DataGBox.Location = new System.Drawing.Point(34, 46);
            this.DataGBox.Name = "DataGBox";
            this.DataGBox.Size = new System.Drawing.Size(984, 290);
            this.DataGBox.TabIndex = 52;
            this.DataGBox.TabStop = false;
            this.DataGBox.Text = "DATOS DE LA PERSONA";
            // 
            // SearchGBox
            // 
            this.SearchGBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchGBox.Controls.Add(this.bttnEraserText);
            this.SearchGBox.Controls.Add(this.DeselectAllcbx);
            this.SearchGBox.Controls.Add(this.bttnViewSelectedPerson);
            this.SearchGBox.Controls.Add(this.bttnSentEmail);
            this.SearchGBox.Controls.Add(this.cmbTypeSearch);
            this.SearchGBox.Controls.Add(this.txtTextSearch);
            this.SearchGBox.Controls.Add(this.bttnSelectPerson);
            this.SearchGBox.Controls.Add(this.Deletebtn);
            this.SearchGBox.Controls.Add(this.Modifybtn);
            this.SearchGBox.Controls.Add(this.SelectAllcbx);
            this.SearchGBox.Controls.Add(this.dgvPersonReg);
            this.SearchGBox.Controls.Add(this.bttnSearchPerson);
            this.SearchGBox.Location = new System.Drawing.Point(34, 351);
            this.SearchGBox.Name = "SearchGBox";
            this.SearchGBox.Size = new System.Drawing.Size(983, 513);
            this.SearchGBox.TabIndex = 53;
            this.SearchGBox.TabStop = false;
            this.SearchGBox.Text = "BÚSQUEDA";
            // 
            // PersonReg
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1045, 878);
            this.Controls.Add(this.SearchGBox);
            this.Controls.Add(this.DataGBox);
            this.Controls.Add(this.lblEscPerson);
            this.KeyPreview = true;
            this.Name = "PersonReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de persona";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Access);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonReg)).EndInit();
            this.DataGBox.ResumeLayout(false);
            this.DataGBox.PerformLayout();
            this.SearchGBox.ResumeLayout(false);
            this.SearchGBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtbNamePerson;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelNumber;
        private System.Windows.Forms.Button bttnAddPerson;
        private System.Windows.Forms.Button bttnSearchPerson;
        private System.Windows.Forms.Label lblEscPerson;
        private System.Windows.Forms.TextBox txtEmailPerson;
        private System.Windows.Forms.Button bttnImportPerson;
        private System.Windows.Forms.Label lblLastNamePerson;
        private System.Windows.Forms.TextBox txtbLastNamePerson;
        private System.Windows.Forms.DataGridView dgvPersonReg;
        private System.Windows.Forms.CheckBox SelectAllcbx;
        private System.Windows.Forms.Button Modifybtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button bttnSelectPerson;
        private System.Windows.Forms.TextBox txtTextSearch;
        private System.Windows.Forms.ComboBox cmbTypeSearch;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckSelection;
        private System.Windows.Forms.TextBox txtbTelephone;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button bttnSentEmail;
        private System.Windows.Forms.Button bttnViewSelectedPerson;
        private System.Windows.Forms.CheckBox DeselectAllcbx;
        private System.Windows.Forms.Button bttnEraserText;
        private System.Windows.Forms.GroupBox DataGBox;
        private System.Windows.Forms.GroupBox SearchGBox;
    }
}