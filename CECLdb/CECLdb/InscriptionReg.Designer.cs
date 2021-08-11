
namespace CECLdb
{
    partial class InscriptionReg
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
            this.lblSelectAreaInscription = new System.Windows.Forms.Label();
            this.cmbSelectAreaInscription = new System.Windows.Forms.ComboBox();
            this.lblSelectCourseInscription = new System.Windows.Forms.Label();
            this.cmbSelectCourseInscription = new System.Windows.Forms.ComboBox();
            this.lblPersonIDInscription = new System.Windows.Forms.Label();
            this.txtbPersonIDInscription = new System.Windows.Forms.TextBox();
            this.ckbApproved = new System.Windows.Forms.CheckBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblFinalDateInscription = new System.Windows.Forms.Label();
            this.bttnAddInscription = new System.Windows.Forms.Button();
            this.bttnReturnInscription = new System.Windows.Forms.Button();
            this.mtbStartDate = new System.Windows.Forms.MaskedTextBox();
            this.mtbFinalDate = new System.Windows.Forms.MaskedTextBox();
            this.bttnSearchPerson = new System.Windows.Forms.Button();
            this.bttnSaveInscription = new System.Windows.Forms.Button();
            this.lblEscInscription = new System.Windows.Forms.Label();
            this.dgvInscription = new System.Windows.Forms.DataGridView();
            this.CheckSelection = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bttnViewSelected = new System.Windows.Forms.Button();
            this.bttnSelect = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Modifybtn = new System.Windows.Forms.Button();
            this.bttnEraserText = new System.Windows.Forms.Button();
            this.DeselectAllcbx = new System.Windows.Forms.CheckBox();
            this.SelectAllcbx = new System.Windows.Forms.CheckBox();
            this.bttnSearch = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.btnClean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscription)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectAreaInscription
            // 
            this.lblSelectAreaInscription.AutoSize = true;
            this.lblSelectAreaInscription.Location = new System.Drawing.Point(26, 43);
            this.lblSelectAreaInscription.Name = "lblSelectAreaInscription";
            this.lblSelectAreaInscription.Size = new System.Drawing.Size(167, 20);
            this.lblSelectAreaInscription.TabIndex = 0;
            this.lblSelectAreaInscription.Text = "Área a la que pertenece";
            // 
            // cmbSelectAreaInscription
            // 
            this.cmbSelectAreaInscription.BackColor = System.Drawing.Color.MintCream;
            this.cmbSelectAreaInscription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectAreaInscription.FormattingEnabled = true;
            this.cmbSelectAreaInscription.Location = new System.Drawing.Point(26, 79);
            this.cmbSelectAreaInscription.Name = "cmbSelectAreaInscription";
            this.cmbSelectAreaInscription.Size = new System.Drawing.Size(397, 28);
            this.cmbSelectAreaInscription.TabIndex = 0;
            this.cmbSelectAreaInscription.SelectionChangeCommitted += new System.EventHandler(this.cmbSelectAreaInscription_SelectionChangeCommitted_1);
            // 
            // lblSelectCourseInscription
            // 
            this.lblSelectCourseInscription.AutoSize = true;
            this.lblSelectCourseInscription.Location = new System.Drawing.Point(477, 43);
            this.lblSelectCourseInscription.Name = "lblSelectCourseInscription";
            this.lblSelectCourseInscription.Size = new System.Drawing.Size(161, 20);
            this.lblSelectCourseInscription.TabIndex = 2;
            this.lblSelectCourseInscription.Text = "Curso al que pertenece";
            // 
            // cmbSelectCourseInscription
            // 
            this.cmbSelectCourseInscription.BackColor = System.Drawing.Color.MintCream;
            this.cmbSelectCourseInscription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectCourseInscription.FormattingEnabled = true;
            this.cmbSelectCourseInscription.Location = new System.Drawing.Point(477, 79);
            this.cmbSelectCourseInscription.Name = "cmbSelectCourseInscription";
            this.cmbSelectCourseInscription.Size = new System.Drawing.Size(397, 28);
            this.cmbSelectCourseInscription.TabIndex = 1;
            // 
            // lblPersonIDInscription
            // 
            this.lblPersonIDInscription.AutoSize = true;
            this.lblPersonIDInscription.Location = new System.Drawing.Point(26, 125);
            this.lblPersonIDInscription.Name = "lblPersonIDInscription";
            this.lblPersonIDInscription.Size = new System.Drawing.Size(79, 20);
            this.lblPersonIDInscription.TabIndex = 4;
            this.lblPersonIDInscription.Text = "ID Persona";
            // 
            // txtbPersonIDInscription
            // 
            this.txtbPersonIDInscription.Location = new System.Drawing.Point(26, 157);
            this.txtbPersonIDInscription.Name = "txtbPersonIDInscription";
            this.txtbPersonIDInscription.Size = new System.Drawing.Size(172, 27);
            this.txtbPersonIDInscription.TabIndex = 2;
            // 
            // ckbApproved
            // 
            this.ckbApproved.AutoSize = true;
            this.ckbApproved.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ckbApproved.Location = new System.Drawing.Point(542, 159);
            this.ckbApproved.Name = "ckbApproved";
            this.ckbApproved.Size = new System.Drawing.Size(96, 24);
            this.ckbApproved.TabIndex = 4;
            this.ckbApproved.Text = "¿Aprobó?";
            this.ckbApproved.UseVisualStyleBackColor = false;
            this.ckbApproved.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(755, 125);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(108, 20);
            this.lblStartDate.TabIndex = 10;
            this.lblStartDate.Text = "Fecha de Inicio";
            // 
            // lblFinalDateInscription
            // 
            this.lblFinalDateInscription.AutoSize = true;
            this.lblFinalDateInscription.Location = new System.Drawing.Point(910, 125);
            this.lblFinalDateInscription.Name = "lblFinalDateInscription";
            this.lblFinalDateInscription.Size = new System.Drawing.Size(91, 20);
            this.lblFinalDateInscription.TabIndex = 13;
            this.lblFinalDateInscription.Text = "Fecha de Fin";
            this.lblFinalDateInscription.Visible = false;
            // 
            // bttnAddInscription
            // 
            this.bttnAddInscription.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnAddInscription.Location = new System.Drawing.Point(360, 211);
            this.bttnAddInscription.Name = "bttnAddInscription";
            this.bttnAddInscription.Size = new System.Drawing.Size(97, 27);
            this.bttnAddInscription.TabIndex = 7;
            this.bttnAddInscription.Text = "Agregar";
            this.bttnAddInscription.UseVisualStyleBackColor = false;
            this.bttnAddInscription.Visible = false;
            this.bttnAddInscription.Click += new System.EventHandler(this.bttnAddInscription_Click);
            // 
            // bttnReturnInscription
            // 
            this.bttnReturnInscription.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnReturnInscription.Location = new System.Drawing.Point(477, 211);
            this.bttnReturnInscription.Name = "bttnReturnInscription";
            this.bttnReturnInscription.Size = new System.Drawing.Size(97, 27);
            this.bttnReturnInscription.TabIndex = 9;
            this.bttnReturnInscription.Text = "Regresar";
            this.bttnReturnInscription.UseVisualStyleBackColor = false;
            this.bttnReturnInscription.Click += new System.EventHandler(this.bttnReturnInscription_Click);
            // 
            // mtbStartDate
            // 
            this.mtbStartDate.AccessibleDescription = "";
            this.mtbStartDate.Location = new System.Drawing.Point(766, 156);
            this.mtbStartDate.Mask = "0000/00/00";
            this.mtbStartDate.Name = "mtbStartDate";
            this.mtbStartDate.Size = new System.Drawing.Size(88, 27);
            this.mtbStartDate.TabIndex = 5;
            this.mtbStartDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbStartDate.ValidatingType = typeof(System.DateTime);
            // 
            // mtbFinalDate
            // 
            this.mtbFinalDate.HidePromptOnLeave = true;
            this.mtbFinalDate.Location = new System.Drawing.Point(913, 156);
            this.mtbFinalDate.Mask = "0000/00/00";
            this.mtbFinalDate.Name = "mtbFinalDate";
            this.mtbFinalDate.Size = new System.Drawing.Size(88, 27);
            this.mtbFinalDate.TabIndex = 6;
            this.mtbFinalDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbFinalDate.ValidatingType = typeof(System.DateTime);
            this.mtbFinalDate.Visible = false;
            // 
            // bttnSearchPerson
            // 
            this.bttnSearchPerson.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnSearchPerson.Location = new System.Drawing.Point(222, 157);
            this.bttnSearchPerson.Name = "bttnSearchPerson";
            this.bttnSearchPerson.Size = new System.Drawing.Size(97, 27);
            this.bttnSearchPerson.TabIndex = 3;
            this.bttnSearchPerson.Text = "Buscar";
            this.bttnSearchPerson.UseVisualStyleBackColor = false;
            this.bttnSearchPerson.Click += new System.EventHandler(this.bttnSearchPerson_Click);
            // 
            // bttnSaveInscription
            // 
            this.bttnSaveInscription.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnSaveInscription.Location = new System.Drawing.Point(360, 210);
            this.bttnSaveInscription.Name = "bttnSaveInscription";
            this.bttnSaveInscription.Size = new System.Drawing.Size(97, 27);
            this.bttnSaveInscription.TabIndex = 20;
            this.bttnSaveInscription.Text = "Guardar";
            this.bttnSaveInscription.UseVisualStyleBackColor = false;
            this.bttnSaveInscription.Visible = false;
            // 
            // lblEscInscription
            // 
            this.lblEscInscription.AutoSize = true;
            this.lblEscInscription.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblEscInscription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEscInscription.Location = new System.Drawing.Point(904, 22);
            this.lblEscInscription.Name = "lblEscInscription";
            this.lblEscInscription.Size = new System.Drawing.Size(165, 22);
            this.lblEscInscription.TabIndex = 21;
            this.lblEscInscription.Text = "(ESC) Regresar al Menú";
            // 
            // dgvInscription
            // 
            this.dgvInscription.AllowUserToAddRows = false;
            this.dgvInscription.AllowUserToDeleteRows = false;
            this.dgvInscription.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvInscription.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvInscription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscription.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckSelection});
            this.dgvInscription.Location = new System.Drawing.Point(38, 341);
            this.dgvInscription.Name = "dgvInscription";
            this.dgvInscription.RowHeadersWidth = 51;
            this.dgvInscription.RowTemplate.Height = 29;
            this.dgvInscription.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInscription.Size = new System.Drawing.Size(992, 330);
            this.dgvInscription.TabIndex = 22;
            this.dgvInscription.Visible = false;
            // 
            // CheckSelection
            // 
            this.CheckSelection.HeaderText = "Seleccionar";
            this.CheckSelection.MinimumWidth = 6;
            this.CheckSelection.Name = "CheckSelection";
            this.CheckSelection.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckSelection.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CheckSelection.Width = 114;
            // 
            // bttnViewSelected
            // 
            this.bttnViewSelected.BackColor = System.Drawing.Color.LightSalmon;
            this.bttnViewSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnViewSelected.Location = new System.Drawing.Point(611, 677);
            this.bttnViewSelected.Name = "bttnViewSelected";
            this.bttnViewSelected.Size = new System.Drawing.Size(187, 29);
            this.bttnViewSelected.TabIndex = 36;
            this.bttnViewSelected.Text = "Ver seleccionados";
            this.bttnViewSelected.UseVisualStyleBackColor = false;
            this.bttnViewSelected.Visible = false;
            // 
            // bttnSelect
            // 
            this.bttnSelect.BackColor = System.Drawing.Color.Khaki;
            this.bttnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnSelect.Location = new System.Drawing.Point(514, 677);
            this.bttnSelect.Name = "bttnSelect";
            this.bttnSelect.Size = new System.Drawing.Size(94, 29);
            this.bttnSelect.TabIndex = 35;
            this.bttnSelect.Text = "Seleccionar";
            this.bttnSelect.UseVisualStyleBackColor = false;
            this.bttnSelect.Visible = false;
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.Honeydew;
            this.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Deletebtn.Location = new System.Drawing.Point(414, 677);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(94, 29);
            this.Deletebtn.TabIndex = 34;
            this.Deletebtn.Text = "Eliminar";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Visible = false;
            // 
            // Modifybtn
            // 
            this.Modifybtn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Modifybtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Modifybtn.Location = new System.Drawing.Point(314, 677);
            this.Modifybtn.Name = "Modifybtn";
            this.Modifybtn.Size = new System.Drawing.Size(94, 29);
            this.Modifybtn.TabIndex = 33;
            this.Modifybtn.Text = "Modificar";
            this.Modifybtn.UseVisualStyleBackColor = false;
            this.Modifybtn.Visible = false;
            // 
            // bttnEraserText
            // 
            this.bttnEraserText.BackColor = System.Drawing.Color.LightYellow;
            this.bttnEraserText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnEraserText.Location = new System.Drawing.Point(987, 267);
            this.bttnEraserText.Name = "bttnEraserText";
            this.bttnEraserText.Size = new System.Drawing.Size(63, 26);
            this.bttnEraserText.TabIndex = 43;
            this.bttnEraserText.Text = "Borrar";
            this.bttnEraserText.UseVisualStyleBackColor = false;
            this.bttnEraserText.Visible = false;
            this.bttnEraserText.Click += new System.EventHandler(this.bttnEraserText_Click);
            // 
            // DeselectAllcbx
            // 
            this.DeselectAllcbx.AutoSize = true;
            this.DeselectAllcbx.Location = new System.Drawing.Point(186, 299);
            this.DeselectAllcbx.Name = "DeselectAllcbx";
            this.DeselectAllcbx.Size = new System.Drawing.Size(146, 24);
            this.DeselectAllcbx.TabIndex = 42;
            this.DeselectAllcbx.Text = "Desmarcar Todos";
            this.DeselectAllcbx.UseVisualStyleBackColor = true;
            this.DeselectAllcbx.Visible = false;
            // 
            // SelectAllcbx
            // 
            this.SelectAllcbx.AutoSize = true;
            this.SelectAllcbx.Location = new System.Drawing.Point(29, 299);
            this.SelectAllcbx.Name = "SelectAllcbx";
            this.SelectAllcbx.Size = new System.Drawing.Size(151, 24);
            this.SelectAllcbx.TabIndex = 41;
            this.SelectAllcbx.Text = "Seleccionar Todos";
            this.SelectAllcbx.UseVisualStyleBackColor = true;
            this.SelectAllcbx.Visible = false;
            // 
            // bttnSearch
            // 
            this.bttnSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bttnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnSearch.Location = new System.Drawing.Point(855, 267);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(116, 26);
            this.bttnSearch.TabIndex = 40;
            this.bttnSearch.Text = "Buscar";
            this.bttnSearch.UseVisualStyleBackColor = false;
            this.bttnSearch.Visible = false;
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click_1);
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(590, 266);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(249, 28);
            this.cmbType.TabIndex = 39;
            this.cmbType.Visible = false;
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(10, 266);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(564, 27);
            this.txtText.TabIndex = 38;
            this.txtText.Visible = false;
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClean.Location = new System.Drawing.Point(592, 210);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(129, 29);
            this.btnClean.TabIndex = 44;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Visible = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // InscriptionReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 714);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.bttnEraserText);
            this.Controls.Add(this.DeselectAllcbx);
            this.Controls.Add(this.SelectAllcbx);
            this.Controls.Add(this.bttnSearch);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.bttnViewSelected);
            this.Controls.Add(this.bttnSelect);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Modifybtn);
            this.Controls.Add(this.dgvInscription);
            this.Controls.Add(this.lblEscInscription);
            this.Controls.Add(this.bttnSaveInscription);
            this.Controls.Add(this.bttnSearchPerson);
            this.Controls.Add(this.mtbFinalDate);
            this.Controls.Add(this.mtbStartDate);
            this.Controls.Add(this.bttnReturnInscription);
            this.Controls.Add(this.bttnAddInscription);
            this.Controls.Add(this.lblFinalDateInscription);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.ckbApproved);
            this.Controls.Add(this.txtbPersonIDInscription);
            this.Controls.Add(this.lblPersonIDInscription);
            this.Controls.Add(this.cmbSelectCourseInscription);
            this.Controls.Add(this.lblSelectCourseInscription);
            this.Controls.Add(this.cmbSelectAreaInscription);
            this.Controls.Add(this.lblSelectAreaInscription);
            this.KeyPreview = true;
            this.Name = "InscriptionReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InscriptionReg";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InscriptionReg_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectAreaInscription;
        private System.Windows.Forms.ComboBox cmbSelectAreaInscription;
        private System.Windows.Forms.Label lblSelectCourseInscription;
        private System.Windows.Forms.ComboBox cmbSelectCourseInscription;
        private System.Windows.Forms.Label lblPersonIDInscription;
        private System.Windows.Forms.TextBox txtbPersonIDInscription;
        private System.Windows.Forms.CheckBox ckbApproved;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblFinalDateInscription;
        private System.Windows.Forms.Button bttnAddInscription;
        private System.Windows.Forms.Button bttnReturnInscription;
        private System.Windows.Forms.MaskedTextBox mtbStartDate;
        private System.Windows.Forms.MaskedTextBox mtbFinalDate;
        private System.Windows.Forms.Button bttnSearchPerson;
        private System.Windows.Forms.Button bttnSaveInscription;
        private System.Windows.Forms.Label lblEscInscription;
        private System.Windows.Forms.DataGridView dgvInscription;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckSelection;
        private System.Windows.Forms.Button bttnViewSelected;
        private System.Windows.Forms.Button bttnSelect;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Modifybtn;
        private System.Windows.Forms.Button bttnEraserText;
        private System.Windows.Forms.CheckBox DeselectAllcbx;
        private System.Windows.Forms.CheckBox SelectAllcbx;
        private System.Windows.Forms.Button bttnSearch;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button btnClean;
    }
}