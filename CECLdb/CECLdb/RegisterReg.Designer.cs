
namespace CECLdb
{
    partial class RegisterReg
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
            this.txtbPersonIDRegister = new System.Windows.Forms.TextBox();
            this.lblPersonIDRegister = new System.Windows.Forms.Label();
            this.cmbSelectCourseRegister = new System.Windows.Forms.ComboBox();
            this.lblSelectCourseInscription = new System.Windows.Forms.Label();
            this.cmbSelectAreaRegister = new System.Windows.Forms.ComboBox();
            this.lblSelectAreaInscription = new System.Windows.Forms.Label();
            this.lblConsultationDate = new System.Windows.Forms.Label();
            this.dtpConsultationDateRegister = new System.Windows.Forms.DateTimePicker();
            this.bttnAddRegister = new System.Windows.Forms.Button();
            this.bttnSearchPersonReg = new System.Windows.Forms.Button();
            this.lblEscRegister = new System.Windows.Forms.Label();
            this.dgvRegister = new System.Windows.Forms.DataGridView();
            this.CheckSelection = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtText = new System.Windows.Forms.TextBox();
            this.bttnEraserText = new System.Windows.Forms.Button();
            this.bttnSearch = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.DeselectAllcbx = new System.Windows.Forms.CheckBox();
            this.SelectAllcbx = new System.Windows.Forms.CheckBox();
            this.bttnViewSelected = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Modifybtn = new System.Windows.Forms.Button();
            this.SearchGBox = new System.Windows.Forms.GroupBox();
            this.DataGBox = new System.Windows.Forms.GroupBox();
            this.SaveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegister)).BeginInit();
            this.SearchGBox.SuspendLayout();
            this.DataGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbPersonIDRegister
            // 
            this.txtbPersonIDRegister.Location = new System.Drawing.Point(574, 58);
            this.txtbPersonIDRegister.Name = "txtbPersonIDRegister";
            this.txtbPersonIDRegister.Size = new System.Drawing.Size(234, 27);
            this.txtbPersonIDRegister.TabIndex = 2;
            // 
            // lblPersonIDRegister
            // 
            this.lblPersonIDRegister.AutoSize = true;
            this.lblPersonIDRegister.Location = new System.Drawing.Point(574, 21);
            this.lblPersonIDRegister.Name = "lblPersonIDRegister";
            this.lblPersonIDRegister.Size = new System.Drawing.Size(79, 20);
            this.lblPersonIDRegister.TabIndex = 12;
            this.lblPersonIDRegister.Text = "ID Persona";
            // 
            // cmbSelectCourseRegister
            // 
            this.cmbSelectCourseRegister.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectCourseRegister.FormattingEnabled = true;
            this.cmbSelectCourseRegister.Location = new System.Drawing.Point(42, 150);
            this.cmbSelectCourseRegister.Name = "cmbSelectCourseRegister";
            this.cmbSelectCourseRegister.Size = new System.Drawing.Size(397, 28);
            this.cmbSelectCourseRegister.TabIndex = 1;
            // 
            // lblSelectCourseInscription
            // 
            this.lblSelectCourseInscription.AutoSize = true;
            this.lblSelectCourseInscription.Location = new System.Drawing.Point(42, 114);
            this.lblSelectCourseInscription.Name = "lblSelectCourseInscription";
            this.lblSelectCourseInscription.Size = new System.Drawing.Size(161, 20);
            this.lblSelectCourseInscription.TabIndex = 10;
            this.lblSelectCourseInscription.Text = "Curso al que pertenece";
            // 
            // cmbSelectAreaRegister
            // 
            this.cmbSelectAreaRegister.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectAreaRegister.FormattingEnabled = true;
            this.cmbSelectAreaRegister.Location = new System.Drawing.Point(42, 57);
            this.cmbSelectAreaRegister.Name = "cmbSelectAreaRegister";
            this.cmbSelectAreaRegister.Size = new System.Drawing.Size(397, 28);
            this.cmbSelectAreaRegister.TabIndex = 0;
            this.cmbSelectAreaRegister.SelectionChangeCommitted += new System.EventHandler(this.cmbSelectAreaInscription_SelectionChangeCommitted);
            // 
            // lblSelectAreaInscription
            // 
            this.lblSelectAreaInscription.AutoSize = true;
            this.lblSelectAreaInscription.Location = new System.Drawing.Point(42, 22);
            this.lblSelectAreaInscription.Name = "lblSelectAreaInscription";
            this.lblSelectAreaInscription.Size = new System.Drawing.Size(167, 20);
            this.lblSelectAreaInscription.TabIndex = 8;
            this.lblSelectAreaInscription.Text = "Área a la que pertenece";
            // 
            // lblConsultationDate
            // 
            this.lblConsultationDate.AutoSize = true;
            this.lblConsultationDate.Location = new System.Drawing.Point(574, 114);
            this.lblConsultationDate.Name = "lblConsultationDate";
            this.lblConsultationDate.Size = new System.Drawing.Size(129, 20);
            this.lblConsultationDate.TabIndex = 16;
            this.lblConsultationDate.Text = "Fecha de Consulta";
            // 
            // dtpConsultationDateRegister
            // 
            this.dtpConsultationDateRegister.CustomFormat = "yyyy/MM/dd hh:mm";
            this.dtpConsultationDateRegister.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpConsultationDateRegister.Location = new System.Drawing.Point(574, 151);
            this.dtpConsultationDateRegister.Name = "dtpConsultationDateRegister";
            this.dtpConsultationDateRegister.Size = new System.Drawing.Size(307, 27);
            this.dtpConsultationDateRegister.TabIndex = 4;
            // 
            // bttnAddRegister
            // 
            this.bttnAddRegister.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnAddRegister.Location = new System.Drawing.Point(494, 205);
            this.bttnAddRegister.Name = "bttnAddRegister";
            this.bttnAddRegister.Size = new System.Drawing.Size(93, 29);
            this.bttnAddRegister.TabIndex = 5;
            this.bttnAddRegister.Text = "Agregar";
            this.bttnAddRegister.UseVisualStyleBackColor = false;
            this.bttnAddRegister.Visible = false;
            this.bttnAddRegister.Click += new System.EventHandler(this.bttnAddRegister_Click);
            // 
            // bttnSearchPersonReg
            // 
            this.bttnSearchPersonReg.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnSearchPersonReg.Location = new System.Drawing.Point(846, 58);
            this.bttnSearchPersonReg.Name = "bttnSearchPersonReg";
            this.bttnSearchPersonReg.Size = new System.Drawing.Size(93, 29);
            this.bttnSearchPersonReg.TabIndex = 3;
            this.bttnSearchPersonReg.Text = "Buscar";
            this.bttnSearchPersonReg.UseVisualStyleBackColor = false;
            this.bttnSearchPersonReg.Click += new System.EventHandler(this.bttnSearchPersonReg_Click);
            // 
            // lblEscRegister
            // 
            this.lblEscRegister.AutoSize = true;
            this.lblEscRegister.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblEscRegister.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEscRegister.Location = new System.Drawing.Point(762, 16);
            this.lblEscRegister.Name = "lblEscRegister";
            this.lblEscRegister.Size = new System.Drawing.Size(165, 22);
            this.lblEscRegister.TabIndex = 22;
            this.lblEscRegister.Text = "(ESC) Regresar al Menú";
            // 
            // dgvRegister
            // 
            this.dgvRegister.AllowUserToAddRows = false;
            this.dgvRegister.AllowUserToDeleteRows = false;
            this.dgvRegister.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvRegister.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvRegister.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvRegister.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckSelection});
            this.dgvRegister.Location = new System.Drawing.Point(9, 104);
            this.dgvRegister.Name = "dgvRegister";
            this.dgvRegister.ReadOnly = true;
            this.dgvRegister.RowHeadersWidth = 51;
            this.dgvRegister.RowTemplate.Height = 29;
            this.dgvRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegister.Size = new System.Drawing.Size(992, 330);
            this.dgvRegister.TabIndex = 23;
            this.dgvRegister.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegister_CellContentClick);
            // 
            // CheckSelection
            // 
            this.CheckSelection.HeaderText = "Seleccionar";
            this.CheckSelection.MinimumWidth = 6;
            this.CheckSelection.Name = "CheckSelection";
            this.CheckSelection.ReadOnly = true;
            this.CheckSelection.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckSelection.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CheckSelection.Width = 114;
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(9, 31);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(526, 27);
            this.txtText.TabIndex = 39;
            this.txtText.Visible = false;
            // 
            // bttnEraserText
            // 
            this.bttnEraserText.BackColor = System.Drawing.Color.LightYellow;
            this.bttnEraserText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnEraserText.Location = new System.Drawing.Point(938, 31);
            this.bttnEraserText.Name = "bttnEraserText";
            this.bttnEraserText.Size = new System.Drawing.Size(63, 26);
            this.bttnEraserText.TabIndex = 46;
            this.bttnEraserText.Text = "Borrar";
            this.bttnEraserText.UseVisualStyleBackColor = false;
            this.bttnEraserText.Visible = false;
            this.bttnEraserText.Click += new System.EventHandler(this.bttnEraserText_Click);
            // 
            // bttnSearch
            // 
            this.bttnSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bttnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnSearch.Location = new System.Drawing.Point(806, 31);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(116, 26);
            this.bttnSearch.TabIndex = 45;
            this.bttnSearch.Text = "Buscar";
            this.bttnSearch.UseVisualStyleBackColor = false;
            this.bttnSearch.Visible = false;
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(541, 30);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(249, 28);
            this.cmbType.TabIndex = 44;
            this.cmbType.Visible = false;
            // 
            // DeselectAllcbx
            // 
            this.DeselectAllcbx.AutoSize = true;
            this.DeselectAllcbx.Enabled = false;
            this.DeselectAllcbx.Location = new System.Drawing.Point(165, 74);
            this.DeselectAllcbx.Name = "DeselectAllcbx";
            this.DeselectAllcbx.Size = new System.Drawing.Size(146, 24);
            this.DeselectAllcbx.TabIndex = 51;
            this.DeselectAllcbx.Text = "Desmarcar Todos";
            this.DeselectAllcbx.UseVisualStyleBackColor = true;
            this.DeselectAllcbx.Visible = false;
            this.DeselectAllcbx.CheckedChanged += new System.EventHandler(this.DeselectAllcbx_CheckedChanged);
            // 
            // SelectAllcbx
            // 
            this.SelectAllcbx.AutoSize = true;
            this.SelectAllcbx.Enabled = false;
            this.SelectAllcbx.Location = new System.Drawing.Point(8, 74);
            this.SelectAllcbx.Name = "SelectAllcbx";
            this.SelectAllcbx.Size = new System.Drawing.Size(151, 24);
            this.SelectAllcbx.TabIndex = 50;
            this.SelectAllcbx.Text = "Seleccionar Todos";
            this.SelectAllcbx.UseVisualStyleBackColor = true;
            this.SelectAllcbx.Visible = false;
            this.SelectAllcbx.CheckedChanged += new System.EventHandler(this.SelectAllcbx_CheckedChanged);
            // 
            // bttnViewSelected
            // 
            this.bttnViewSelected.BackColor = System.Drawing.Color.LightSalmon;
            this.bttnViewSelected.Enabled = false;
            this.bttnViewSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnViewSelected.Location = new System.Drawing.Point(541, 449);
            this.bttnViewSelected.Name = "bttnViewSelected";
            this.bttnViewSelected.Size = new System.Drawing.Size(187, 29);
            this.bttnViewSelected.TabIndex = 49;
            this.bttnViewSelected.Text = "Ver seleccionados";
            this.bttnViewSelected.UseVisualStyleBackColor = false;
            this.bttnViewSelected.Visible = false;
            this.bttnViewSelected.Click += new System.EventHandler(this.bttnViewSelected_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.Honeydew;
            this.Deletebtn.Enabled = false;
            this.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Deletebtn.Location = new System.Drawing.Point(441, 449);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(94, 29);
            this.Deletebtn.TabIndex = 48;
            this.Deletebtn.Text = "Eliminar";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Visible = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Modifybtn
            // 
            this.Modifybtn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Modifybtn.Enabled = false;
            this.Modifybtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Modifybtn.Location = new System.Drawing.Point(341, 449);
            this.Modifybtn.Name = "Modifybtn";
            this.Modifybtn.Size = new System.Drawing.Size(94, 29);
            this.Modifybtn.TabIndex = 47;
            this.Modifybtn.Text = "Modificar";
            this.Modifybtn.UseVisualStyleBackColor = false;
            this.Modifybtn.Visible = false;
            this.Modifybtn.Click += new System.EventHandler(this.Modifybtn_Click);
            // 
            // SearchGBox
            // 
            this.SearchGBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchGBox.Controls.Add(this.DeselectAllcbx);
            this.SearchGBox.Controls.Add(this.SelectAllcbx);
            this.SearchGBox.Controls.Add(this.bttnViewSelected);
            this.SearchGBox.Controls.Add(this.Deletebtn);
            this.SearchGBox.Controls.Add(this.Modifybtn);
            this.SearchGBox.Controls.Add(this.bttnEraserText);
            this.SearchGBox.Controls.Add(this.bttnSearch);
            this.SearchGBox.Controls.Add(this.cmbType);
            this.SearchGBox.Controls.Add(this.txtText);
            this.SearchGBox.Controls.Add(this.dgvRegister);
            this.SearchGBox.Location = new System.Drawing.Point(14, 326);
            this.SearchGBox.Name = "SearchGBox";
            this.SearchGBox.Size = new System.Drawing.Size(1017, 486);
            this.SearchGBox.TabIndex = 52;
            this.SearchGBox.TabStop = false;
            this.SearchGBox.Text = "BÚSQUEDA";
            // 
            // DataGBox
            // 
            this.DataGBox.BackColor = System.Drawing.Color.Ivory;
            this.DataGBox.Controls.Add(this.SaveChanges);
            this.DataGBox.Controls.Add(this.bttnSearchPersonReg);
            this.DataGBox.Controls.Add(this.bttnAddRegister);
            this.DataGBox.Controls.Add(this.dtpConsultationDateRegister);
            this.DataGBox.Controls.Add(this.lblConsultationDate);
            this.DataGBox.Controls.Add(this.txtbPersonIDRegister);
            this.DataGBox.Controls.Add(this.lblPersonIDRegister);
            this.DataGBox.Controls.Add(this.cmbSelectCourseRegister);
            this.DataGBox.Controls.Add(this.lblSelectCourseInscription);
            this.DataGBox.Controls.Add(this.cmbSelectAreaRegister);
            this.DataGBox.Controls.Add(this.lblSelectAreaInscription);
            this.DataGBox.Location = new System.Drawing.Point(14, 46);
            this.DataGBox.Name = "DataGBox";
            this.DataGBox.Size = new System.Drawing.Size(1020, 254);
            this.DataGBox.TabIndex = 53;
            this.DataGBox.TabStop = false;
            // 
            // SaveChanges
            // 
            this.SaveChanges.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SaveChanges.Enabled = false;
            this.SaveChanges.Location = new System.Drawing.Point(431, 205);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(156, 29);
            this.SaveChanges.TabIndex = 21;
            this.SaveChanges.Text = "Guardar Cambios";
            this.SaveChanges.UseVisualStyleBackColor = false;
            this.SaveChanges.Visible = false;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // RegisterReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 827);
            this.Controls.Add(this.DataGBox);
            this.Controls.Add(this.SearchGBox);
            this.Controls.Add(this.lblEscRegister);
            this.KeyPreview = true;
            this.Name = "RegisterReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Consulta";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Access);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegister)).EndInit();
            this.SearchGBox.ResumeLayout(false);
            this.SearchGBox.PerformLayout();
            this.DataGBox.ResumeLayout(false);
            this.DataGBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPersonIDRegister;
        private System.Windows.Forms.ComboBox cmbSelectCourseRegister;
        private System.Windows.Forms.Label lblSelectCourseInscription;
        private System.Windows.Forms.ComboBox cmbSelectAreaRegister;
        private System.Windows.Forms.Label lblSelectAreaInscription;
        private System.Windows.Forms.Label lblConsultationDate;
        private System.Windows.Forms.DateTimePicker dtpConsultationDateRegister;
        private System.Windows.Forms.Button bttnAddRegister;
        private System.Windows.Forms.Button bttnSearchPersonReg;
        private System.Windows.Forms.Label lblEscRegister;
        public System.Windows.Forms.TextBox txtbPersonIDRegister;
        private System.Windows.Forms.DataGridView dgvRegister;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckSelection;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button bttnEraserText;
        private System.Windows.Forms.Button bttnSearch;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.CheckBox DeselectAllcbx;
        private System.Windows.Forms.CheckBox SelectAllcbx;
        private System.Windows.Forms.Button bttnViewSelected;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Modifybtn;
        private System.Windows.Forms.GroupBox SearchGBox;
        private System.Windows.Forms.GroupBox DataGBox;
        private System.Windows.Forms.Button SaveChanges;
    }
}