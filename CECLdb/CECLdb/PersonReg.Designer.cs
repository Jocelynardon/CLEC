
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
            this.bttnReturnPerson = new System.Windows.Forms.Button();
            this.bttnSearchPerson = new System.Windows.Forms.Button();
            this.lblEscPerson = new System.Windows.Forms.Label();
            this.txtEmailPerson = new System.Windows.Forms.TextBox();
            this.bttnImportPerson = new System.Windows.Forms.Button();
            this.lblLastNamePerson = new System.Windows.Forms.Label();
            this.txtbLastNamePerson = new System.Windows.Forms.TextBox();
            this.txtbCodePerson = new System.Windows.Forms.TextBox();
            this.lblCodePerson = new System.Windows.Forms.Label();
            this.dgvPersonReg = new System.Windows.Forms.DataGridView();
            this.CheckSelection = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SelectAllcbx = new System.Windows.Forms.CheckBox();
            this.Modifybtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.bttnSelectPerson = new System.Windows.Forms.Button();
            this.txtTextSearch = new System.Windows.Forms.TextBox();
            this.cmbTypeSearch = new System.Windows.Forms.ComboBox();
            this.txtbTelephone = new System.Windows.Forms.TextBox();
            this.lblModify = new System.Windows.Forms.Label();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.lblDataPerson = new System.Windows.Forms.Label();
            this.bttnSentEmail = new System.Windows.Forms.Button();
            this.bttnViewSelectedPerson = new System.Windows.Forms.Button();
            this.DeselectAllcbx = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonReg)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(46, 65);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            // 
            // txtbNamePerson
            // 
            this.txtbNamePerson.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtbNamePerson.Location = new System.Drawing.Point(46, 101);
            this.txtbNamePerson.Name = "txtbNamePerson";
            this.txtbNamePerson.Size = new System.Drawing.Size(353, 27);
            this.txtbNamePerson.TabIndex = 0;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(46, 151);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Correo";
            // 
            // lblTelNumber
            // 
            this.lblTelNumber.AutoSize = true;
            this.lblTelNumber.Location = new System.Drawing.Point(552, 161);
            this.lblTelNumber.Name = "lblTelNumber";
            this.lblTelNumber.Size = new System.Drawing.Size(67, 20);
            this.lblTelNumber.TabIndex = 4;
            this.lblTelNumber.Text = "Teléfono";
            // 
            // bttnAddPerson
            // 
            this.bttnAddPerson.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnAddPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnAddPerson.Location = new System.Drawing.Point(339, 273);
            this.bttnAddPerson.Name = "bttnAddPerson";
            this.bttnAddPerson.Size = new System.Drawing.Size(94, 29);
            this.bttnAddPerson.TabIndex = 5;
            this.bttnAddPerson.Text = "Agregar";
            this.bttnAddPerson.UseVisualStyleBackColor = false;
            this.bttnAddPerson.Click += new System.EventHandler(this.bttnAddPerson_Click);
            // 
            // bttnReturnPerson
            // 
            this.bttnReturnPerson.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnReturnPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnReturnPerson.Location = new System.Drawing.Point(480, 273);
            this.bttnReturnPerson.Name = "bttnReturnPerson";
            this.bttnReturnPerson.Size = new System.Drawing.Size(94, 29);
            this.bttnReturnPerson.TabIndex = 7;
            this.bttnReturnPerson.Text = "Regresar";
            this.bttnReturnPerson.UseVisualStyleBackColor = false;
            this.bttnReturnPerson.Click += new System.EventHandler(this.bttnReturnPerson_Click);
            // 
            // bttnSearchPerson
            // 
            this.bttnSearchPerson.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bttnSearchPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnSearchPerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnSearchPerson.Location = new System.Drawing.Point(840, 342);
            this.bttnSearchPerson.Name = "bttnSearchPerson";
            this.bttnSearchPerson.Size = new System.Drawing.Size(94, 29);
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
            this.lblEscPerson.Location = new System.Drawing.Point(853, 21);
            this.lblEscPerson.Name = "lblEscPerson";
            this.lblEscPerson.Size = new System.Drawing.Size(165, 22);
            this.lblEscPerson.TabIndex = 11;
            this.lblEscPerson.Text = "(ESC) Regresar al Menú";
            // 
            // txtEmailPerson
            // 
            this.txtEmailPerson.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtEmailPerson.Location = new System.Drawing.Point(46, 197);
            this.txtEmailPerson.Name = "txtEmailPerson";
            this.txtEmailPerson.Size = new System.Drawing.Size(439, 27);
            this.txtEmailPerson.TabIndex = 2;
            // 
            // bttnImportPerson
            // 
            this.bttnImportPerson.BackColor = System.Drawing.Color.LightCoral;
            this.bttnImportPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnImportPerson.Location = new System.Drawing.Point(618, 273);
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
            this.lblLastNamePerson.Location = new System.Drawing.Point(552, 65);
            this.lblLastNamePerson.Name = "lblLastNamePerson";
            this.lblLastNamePerson.Size = new System.Drawing.Size(66, 20);
            this.lblLastNamePerson.TabIndex = 14;
            this.lblLastNamePerson.Text = "Apellido";
            // 
            // txtbLastNamePerson
            // 
            this.txtbLastNamePerson.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtbLastNamePerson.Location = new System.Drawing.Point(552, 101);
            this.txtbLastNamePerson.Name = "txtbLastNamePerson";
            this.txtbLastNamePerson.Size = new System.Drawing.Size(353, 27);
            this.txtbLastNamePerson.TabIndex = 1;
            // 
            // txtbCodePerson
            // 
            this.txtbCodePerson.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtbCodePerson.Location = new System.Drawing.Point(739, 197);
            this.txtbCodePerson.Name = "txtbCodePerson";
            this.txtbCodePerson.Size = new System.Drawing.Size(166, 27);
            this.txtbCodePerson.TabIndex = 4;
            // 
            // lblCodePerson
            // 
            this.lblCodePerson.AutoSize = true;
            this.lblCodePerson.Location = new System.Drawing.Point(739, 151);
            this.lblCodePerson.Name = "lblCodePerson";
            this.lblCodePerson.Size = new System.Drawing.Size(58, 20);
            this.lblCodePerson.TabIndex = 17;
            this.lblCodePerson.Text = "Código";
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
            this.dgvPersonReg.Location = new System.Drawing.Point(74, 449);
            this.dgvPersonReg.Name = "dgvPersonReg";
            this.dgvPersonReg.ReadOnly = true;
            this.dgvPersonReg.RowHeadersWidth = 51;
            this.dgvPersonReg.RowTemplate.Height = 29;
            this.dgvPersonReg.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonReg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonReg.Size = new System.Drawing.Size(913, 319);
            this.dgvPersonReg.TabIndex = 18;
            this.dgvPersonReg.Visible = false;
            this.dgvPersonReg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonReg_CellClick);
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
            this.SelectAllcbx.Location = new System.Drawing.Point(46, 402);
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
            this.Modifybtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Modifybtn.Location = new System.Drawing.Point(374, 788);
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
            this.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Deletebtn.Location = new System.Drawing.Point(496, 788);
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
            this.bttnSelectPerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnSelectPerson.Location = new System.Drawing.Point(618, 788);
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
            this.txtTextSearch.Location = new System.Drawing.Point(74, 344);
            this.txtTextSearch.Name = "txtTextSearch";
            this.txtTextSearch.Size = new System.Drawing.Size(439, 27);
            this.txtTextSearch.TabIndex = 9;
            this.txtTextSearch.Visible = false;
            // 
            // cmbTypeSearch
            // 
            this.cmbTypeSearch.FormattingEnabled = true;
            this.cmbTypeSearch.Location = new System.Drawing.Point(542, 343);
            this.cmbTypeSearch.Name = "cmbTypeSearch";
            this.cmbTypeSearch.Size = new System.Drawing.Size(255, 28);
            this.cmbTypeSearch.TabIndex = 10;
            this.cmbTypeSearch.Visible = false;
            // 
            // txtbTelephone
            // 
            this.txtbTelephone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtbTelephone.Location = new System.Drawing.Point(552, 197);
            this.txtbTelephone.Name = "txtbTelephone";
            this.txtbTelephone.Size = new System.Drawing.Size(136, 27);
            this.txtbTelephone.TabIndex = 3;
            // 
            // lblModify
            // 
            this.lblModify.AutoSize = true;
            this.lblModify.BackColor = System.Drawing.SystemColors.Control;
            this.lblModify.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblModify.Location = new System.Drawing.Point(46, 23);
            this.lblModify.Name = "lblModify";
            this.lblModify.Size = new System.Drawing.Size(164, 20);
            this.lblModify.TabIndex = 26;
            this.lblModify.Text = "DATOS  A MODIFICAR";
            this.lblModify.Visible = false;
            // 
            // btnSaveData
            // 
            this.btnSaveData.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSaveData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveData.Location = new System.Drawing.Point(272, 273);
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
            this.btnClean.Location = new System.Drawing.Point(599, 273);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(129, 29);
            this.btnClean.TabIndex = 8;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Visible = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // lblDataPerson
            // 
            this.lblDataPerson.AutoSize = true;
            this.lblDataPerson.BackColor = System.Drawing.SystemColors.Control;
            this.lblDataPerson.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDataPerson.Location = new System.Drawing.Point(46, 23);
            this.lblDataPerson.Name = "lblDataPerson";
            this.lblDataPerson.Size = new System.Drawing.Size(180, 20);
            this.lblDataPerson.TabIndex = 29;
            this.lblDataPerson.Text = "DATOS  DE LA PERSONA";
            this.lblDataPerson.Visible = false;
            // 
            // bttnSentEmail
            // 
            this.bttnSentEmail.BackColor = System.Drawing.Color.DarkOrange;
            this.bttnSentEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnSentEmail.Location = new System.Drawing.Point(171, 788);
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
            this.bttnViewSelectedPerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnViewSelectedPerson.Location = new System.Drawing.Point(739, 788);
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
            this.DeselectAllcbx.Location = new System.Drawing.Point(207, 402);
            this.DeselectAllcbx.Name = "DeselectAllcbx";
            this.DeselectAllcbx.Size = new System.Drawing.Size(146, 24);
            this.DeselectAllcbx.TabIndex = 32;
            this.DeselectAllcbx.Text = "Desmarcar Todos";
            this.DeselectAllcbx.UseVisualStyleBackColor = true;
            this.DeselectAllcbx.Visible = false;
            this.DeselectAllcbx.CheckedChanged += new System.EventHandler(this.DeselectAllcbx_CheckedChanged);
            // 
            // PersonReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 828);
            this.Controls.Add(this.DeselectAllcbx);
            this.Controls.Add(this.bttnViewSelectedPerson);
            this.Controls.Add(this.bttnSentEmail);
            this.Controls.Add(this.lblDataPerson);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.lblModify);
            this.Controls.Add(this.txtbTelephone);
            this.Controls.Add(this.cmbTypeSearch);
            this.Controls.Add(this.txtTextSearch);
            this.Controls.Add(this.bttnSelectPerson);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Modifybtn);
            this.Controls.Add(this.SelectAllcbx);
            this.Controls.Add(this.dgvPersonReg);
            this.Controls.Add(this.lblCodePerson);
            this.Controls.Add(this.txtbCodePerson);
            this.Controls.Add(this.txtbLastNamePerson);
            this.Controls.Add(this.lblLastNamePerson);
            this.Controls.Add(this.bttnImportPerson);
            this.Controls.Add(this.txtEmailPerson);
            this.Controls.Add(this.lblEscPerson);
            this.Controls.Add(this.bttnSearchPerson);
            this.Controls.Add(this.bttnReturnPerson);
            this.Controls.Add(this.bttnAddPerson);
            this.Controls.Add(this.lblTelNumber);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtbNamePerson);
            this.Controls.Add(this.lblName);
            this.KeyPreview = true;
            this.Name = "PersonReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PersonRegister";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Access);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonReg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtbNamePerson;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelNumber;
        private System.Windows.Forms.Button bttnAddPerson;
        private System.Windows.Forms.Button bttnReturnPerson;
        private System.Windows.Forms.Button bttnSearchPerson;
        private System.Windows.Forms.Label lblEscPerson;
        private System.Windows.Forms.TextBox txtEmailPerson;
        private System.Windows.Forms.Button bttnImportPerson;
        private System.Windows.Forms.Label lblLastNamePerson;
        private System.Windows.Forms.TextBox txtbLastNamePerson;
        private System.Windows.Forms.TextBox txtbCodePerson;
        private System.Windows.Forms.Label lblCodePerson;
        private System.Windows.Forms.DataGridView dgvPersonReg;
        private System.Windows.Forms.CheckBox SelectAllcbx;
        private System.Windows.Forms.Button Modifybtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button bttnSelectPerson;
        private System.Windows.Forms.TextBox txtTextSearch;
        private System.Windows.Forms.ComboBox cmbTypeSearch;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckSelection;
        private System.Windows.Forms.TextBox txtbTelephone;
        private System.Windows.Forms.Label lblModify;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label lblDataPerson;
        private System.Windows.Forms.Button bttnSentEmail;
        private System.Windows.Forms.Button bttnViewSelectedPerson;
        private System.Windows.Forms.CheckBox DeselectAllcbx;
    }
}