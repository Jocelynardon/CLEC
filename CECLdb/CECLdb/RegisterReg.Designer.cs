
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
            this.bttnReturnRegister = new System.Windows.Forms.Button();
            this.bttnSaveRegister = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbPersonIDRegister
            // 
            this.txtbPersonIDRegister.Location = new System.Drawing.Point(490, 141);
            this.txtbPersonIDRegister.Name = "txtbPersonIDRegister";
            this.txtbPersonIDRegister.Size = new System.Drawing.Size(234, 27);
            this.txtbPersonIDRegister.TabIndex = 2;
            // 
            // lblPersonIDRegister
            // 
            this.lblPersonIDRegister.AutoSize = true;
            this.lblPersonIDRegister.Location = new System.Drawing.Point(490, 104);
            this.lblPersonIDRegister.Name = "lblPersonIDRegister";
            this.lblPersonIDRegister.Size = new System.Drawing.Size(79, 20);
            this.lblPersonIDRegister.TabIndex = 12;
            this.lblPersonIDRegister.Text = "ID Persona";
            // 
            // cmbSelectCourseRegister
            // 
            this.cmbSelectCourseRegister.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectCourseRegister.FormattingEnabled = true;
            this.cmbSelectCourseRegister.Location = new System.Drawing.Point(12, 140);
            this.cmbSelectCourseRegister.Name = "cmbSelectCourseRegister";
            this.cmbSelectCourseRegister.Size = new System.Drawing.Size(397, 28);
            this.cmbSelectCourseRegister.TabIndex = 1;
            // 
            // lblSelectCourseInscription
            // 
            this.lblSelectCourseInscription.AutoSize = true;
            this.lblSelectCourseInscription.Location = new System.Drawing.Point(12, 104);
            this.lblSelectCourseInscription.Name = "lblSelectCourseInscription";
            this.lblSelectCourseInscription.Size = new System.Drawing.Size(161, 20);
            this.lblSelectCourseInscription.TabIndex = 10;
            this.lblSelectCourseInscription.Text = "Curso al que pertenece";
            // 
            // cmbSelectAreaRegister
            // 
            this.cmbSelectAreaRegister.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectAreaRegister.FormattingEnabled = true;
            this.cmbSelectAreaRegister.Location = new System.Drawing.Point(12, 51);
            this.cmbSelectAreaRegister.Name = "cmbSelectAreaRegister";
            this.cmbSelectAreaRegister.Size = new System.Drawing.Size(397, 28);
            this.cmbSelectAreaRegister.TabIndex = 0;
            this.cmbSelectAreaRegister.SelectionChangeCommitted += new System.EventHandler(this.cmbSelectAreaInscription_SelectionChangeCommitted);
            // 
            // lblSelectAreaInscription
            // 
            this.lblSelectAreaInscription.AutoSize = true;
            this.lblSelectAreaInscription.Location = new System.Drawing.Point(12, 16);
            this.lblSelectAreaInscription.Name = "lblSelectAreaInscription";
            this.lblSelectAreaInscription.Size = new System.Drawing.Size(167, 20);
            this.lblSelectAreaInscription.TabIndex = 8;
            this.lblSelectAreaInscription.Text = "Área a la que pertenece";
            // 
            // lblConsultationDate
            // 
            this.lblConsultationDate.AutoSize = true;
            this.lblConsultationDate.Location = new System.Drawing.Point(12, 193);
            this.lblConsultationDate.Name = "lblConsultationDate";
            this.lblConsultationDate.Size = new System.Drawing.Size(129, 20);
            this.lblConsultationDate.TabIndex = 16;
            this.lblConsultationDate.Text = "Fecha de Consulta";
            // 
            // dtpConsultationDateRegister
            // 
            this.dtpConsultationDateRegister.CustomFormat = "yyyy/MM/dd hh:mm";
            this.dtpConsultationDateRegister.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpConsultationDateRegister.Location = new System.Drawing.Point(12, 230);
            this.dtpConsultationDateRegister.Name = "dtpConsultationDateRegister";
            this.dtpConsultationDateRegister.Size = new System.Drawing.Size(307, 27);
            this.dtpConsultationDateRegister.TabIndex = 4;
            // 
            // bttnAddRegister
            // 
            this.bttnAddRegister.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnAddRegister.Location = new System.Drawing.Point(377, 275);
            this.bttnAddRegister.Name = "bttnAddRegister";
            this.bttnAddRegister.Size = new System.Drawing.Size(93, 29);
            this.bttnAddRegister.TabIndex = 5;
            this.bttnAddRegister.Text = "Agregar";
            this.bttnAddRegister.UseVisualStyleBackColor = false;
            this.bttnAddRegister.Visible = false;
            this.bttnAddRegister.Click += new System.EventHandler(this.bttnAddRegister_Click);
            // 
            // bttnReturnRegister
            // 
            this.bttnReturnRegister.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnReturnRegister.Location = new System.Drawing.Point(476, 275);
            this.bttnReturnRegister.Name = "bttnReturnRegister";
            this.bttnReturnRegister.Size = new System.Drawing.Size(93, 29);
            this.bttnReturnRegister.TabIndex = 7;
            this.bttnReturnRegister.Text = "Regresar";
            this.bttnReturnRegister.UseVisualStyleBackColor = false;
            this.bttnReturnRegister.Click += new System.EventHandler(this.bttnReturnRegister_Click);
            // 
            // bttnSaveRegister
            // 
            this.bttnSaveRegister.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnSaveRegister.Location = new System.Drawing.Point(377, 275);
            this.bttnSaveRegister.Name = "bttnSaveRegister";
            this.bttnSaveRegister.Size = new System.Drawing.Size(93, 29);
            this.bttnSaveRegister.TabIndex = 20;
            this.bttnSaveRegister.Text = "Guardar";
            this.bttnSaveRegister.UseVisualStyleBackColor = false;
            this.bttnSaveRegister.Visible = false;
            // 
            // bttnSearchPersonReg
            // 
            this.bttnSearchPersonReg.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnSearchPersonReg.Location = new System.Drawing.Point(762, 141);
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
            this.dgvRegister.Location = new System.Drawing.Point(27, 393);
            this.dgvRegister.Name = "dgvRegister";
            this.dgvRegister.ReadOnly = true;
            this.dgvRegister.RowHeadersWidth = 51;
            this.dgvRegister.RowTemplate.Height = 29;
            this.dgvRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegister.Size = new System.Drawing.Size(992, 330);
            this.dgvRegister.TabIndex = 23;
            this.dgvRegister.Visible = false;
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
            this.txtText.Location = new System.Drawing.Point(5, 319);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(564, 27);
            this.txtText.TabIndex = 39;
            this.txtText.Visible = false;
            // 
            // bttnEraserText
            // 
            this.bttnEraserText.BackColor = System.Drawing.Color.LightYellow;
            this.bttnEraserText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnEraserText.Location = new System.Drawing.Point(972, 319);
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
            this.bttnSearch.Location = new System.Drawing.Point(840, 319);
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
            this.cmbType.Location = new System.Drawing.Point(575, 318);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(249, 28);
            this.cmbType.TabIndex = 44;
            this.cmbType.Visible = false;
            // 
            // DeselectAllcbx
            // 
            this.DeselectAllcbx.AutoSize = true;
            this.DeselectAllcbx.Location = new System.Drawing.Point(179, 363);
            this.DeselectAllcbx.Name = "DeselectAllcbx";
            this.DeselectAllcbx.Size = new System.Drawing.Size(146, 24);
            this.DeselectAllcbx.TabIndex = 51;
            this.DeselectAllcbx.Text = "Desmarcar Todos";
            this.DeselectAllcbx.UseVisualStyleBackColor = true;
            this.DeselectAllcbx.Visible = false;
            // 
            // SelectAllcbx
            // 
            this.SelectAllcbx.AutoSize = true;
            this.SelectAllcbx.Location = new System.Drawing.Point(22, 363);
            this.SelectAllcbx.Name = "SelectAllcbx";
            this.SelectAllcbx.Size = new System.Drawing.Size(151, 24);
            this.SelectAllcbx.TabIndex = 50;
            this.SelectAllcbx.Text = "Seleccionar Todos";
            this.SelectAllcbx.UseVisualStyleBackColor = true;
            this.SelectAllcbx.Visible = false;
            // 
            // bttnViewSelected
            // 
            this.bttnViewSelected.BackColor = System.Drawing.Color.LightSalmon;
            this.bttnViewSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnViewSelected.Location = new System.Drawing.Point(559, 738);
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
            this.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Deletebtn.Location = new System.Drawing.Point(459, 738);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(94, 29);
            this.Deletebtn.TabIndex = 48;
            this.Deletebtn.Text = "Eliminar";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Visible = false;
            // 
            // Modifybtn
            // 
            this.Modifybtn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Modifybtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Modifybtn.Location = new System.Drawing.Point(359, 738);
            this.Modifybtn.Name = "Modifybtn";
            this.Modifybtn.Size = new System.Drawing.Size(94, 29);
            this.Modifybtn.TabIndex = 47;
            this.Modifybtn.Text = "Modificar";
            this.Modifybtn.UseVisualStyleBackColor = false;
            this.Modifybtn.Visible = false;
            // 
            // RegisterReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 780);
            this.Controls.Add(this.DeselectAllcbx);
            this.Controls.Add(this.SelectAllcbx);
            this.Controls.Add(this.bttnViewSelected);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Modifybtn);
            this.Controls.Add(this.bttnEraserText);
            this.Controls.Add(this.bttnSearch);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.dgvRegister);
            this.Controls.Add(this.lblEscRegister);
            this.Controls.Add(this.bttnSearchPersonReg);
            this.Controls.Add(this.bttnSaveRegister);
            this.Controls.Add(this.bttnReturnRegister);
            this.Controls.Add(this.bttnAddRegister);
            this.Controls.Add(this.dtpConsultationDateRegister);
            this.Controls.Add(this.lblConsultationDate);
            this.Controls.Add(this.txtbPersonIDRegister);
            this.Controls.Add(this.lblPersonIDRegister);
            this.Controls.Add(this.cmbSelectCourseRegister);
            this.Controls.Add(this.lblSelectCourseInscription);
            this.Controls.Add(this.cmbSelectAreaRegister);
            this.Controls.Add(this.lblSelectAreaInscription);
            this.KeyPreview = true;
            this.Name = "RegisterReg";
            this.Text = " ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Access);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegister)).EndInit();
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
        private System.Windows.Forms.Button bttnReturnRegister;
        private System.Windows.Forms.Button bttnSaveRegister;
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
    }
}