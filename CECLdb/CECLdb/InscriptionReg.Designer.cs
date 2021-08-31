
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
            this.mtbStartDate = new System.Windows.Forms.MaskedTextBox();
            this.mtbFinalDate = new System.Windows.Forms.MaskedTextBox();
            this.bttnSearchPerson = new System.Windows.Forms.Button();
            this.lblEscInscription = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.dgvInscription = new System.Windows.Forms.DataGridView();
            this.CheckSelection = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Modifybtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.bttnViewSelected = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.bttnSearch = new System.Windows.Forms.Button();
            this.SelectAllcbx = new System.Windows.Forms.CheckBox();
            this.DeselectAllcbx = new System.Windows.Forms.CheckBox();
            this.bttnEraserText = new System.Windows.Forms.Button();
            this.SearchGBox = new System.Windows.Forms.GroupBox();
            this.DataGBox = new System.Windows.Forms.GroupBox();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mTxBxCode = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscription)).BeginInit();
            this.SearchGBox.SuspendLayout();
            this.DataGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectAreaInscription
            // 
            this.lblSelectAreaInscription.AutoSize = true;
            this.lblSelectAreaInscription.Location = new System.Drawing.Point(20, 31);
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
            this.cmbSelectAreaInscription.Location = new System.Drawing.Point(20, 67);
            this.cmbSelectAreaInscription.Name = "cmbSelectAreaInscription";
            this.cmbSelectAreaInscription.Size = new System.Drawing.Size(397, 28);
            this.cmbSelectAreaInscription.TabIndex = 0;
            this.cmbSelectAreaInscription.SelectionChangeCommitted += new System.EventHandler(this.cmbSelectAreaInscription_SelectionChangeCommitted_1);
            // 
            // lblSelectCourseInscription
            // 
            this.lblSelectCourseInscription.AutoSize = true;
            this.lblSelectCourseInscription.Location = new System.Drawing.Point(471, 31);
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
            this.cmbSelectCourseInscription.Location = new System.Drawing.Point(471, 68);
            this.cmbSelectCourseInscription.Name = "cmbSelectCourseInscription";
            this.cmbSelectCourseInscription.Size = new System.Drawing.Size(365, 28);
            this.cmbSelectCourseInscription.TabIndex = 1;
            // 
            // lblPersonIDInscription
            // 
            this.lblPersonIDInscription.AutoSize = true;
            this.lblPersonIDInscription.Location = new System.Drawing.Point(20, 113);
            this.lblPersonIDInscription.Name = "lblPersonIDInscription";
            this.lblPersonIDInscription.Size = new System.Drawing.Size(79, 20);
            this.lblPersonIDInscription.TabIndex = 4;
            this.lblPersonIDInscription.Text = "ID Persona";
            // 
            // txtbPersonIDInscription
            // 
            this.txtbPersonIDInscription.Location = new System.Drawing.Point(20, 145);
            this.txtbPersonIDInscription.Name = "txtbPersonIDInscription";
            this.txtbPersonIDInscription.Size = new System.Drawing.Size(172, 27);
            this.txtbPersonIDInscription.TabIndex = 2;
            // 
            // ckbApproved
            // 
            this.ckbApproved.AutoSize = true;
            this.ckbApproved.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ckbApproved.Location = new System.Drawing.Point(536, 147);
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
            this.lblStartDate.Location = new System.Drawing.Point(760, 113);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(108, 20);
            this.lblStartDate.TabIndex = 10;
            this.lblStartDate.Text = "Fecha de Inicio";
            // 
            // lblFinalDateInscription
            // 
            this.lblFinalDateInscription.AutoSize = true;
            this.lblFinalDateInscription.Location = new System.Drawing.Point(904, 113);
            this.lblFinalDateInscription.Name = "lblFinalDateInscription";
            this.lblFinalDateInscription.Size = new System.Drawing.Size(91, 20);
            this.lblFinalDateInscription.TabIndex = 13;
            this.lblFinalDateInscription.Text = "Fecha de Fin";
            this.lblFinalDateInscription.Visible = false;
            // 
            // bttnAddInscription
            // 
            this.bttnAddInscription.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnAddInscription.Location = new System.Drawing.Point(354, 199);
            this.bttnAddInscription.Name = "bttnAddInscription";
            this.bttnAddInscription.Size = new System.Drawing.Size(97, 27);
            this.bttnAddInscription.TabIndex = 7;
            this.bttnAddInscription.Text = "Agregar";
            this.bttnAddInscription.UseVisualStyleBackColor = false;
            this.bttnAddInscription.Visible = false;
            this.bttnAddInscription.Click += new System.EventHandler(this.bttnAddInscription_Click);
            // 
            // mtbStartDate
            // 
            this.mtbStartDate.AccessibleDescription = "";
            this.mtbStartDate.Location = new System.Drawing.Point(771, 144);
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
            this.mtbFinalDate.Location = new System.Drawing.Point(907, 144);
            this.mtbFinalDate.Mask = "0000/00/00";
            this.mtbFinalDate.Name = "mtbFinalDate";
            this.mtbFinalDate.Size = new System.Drawing.Size(97, 27);
            this.mtbFinalDate.TabIndex = 6;
            this.mtbFinalDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbFinalDate.ValidatingType = typeof(System.DateTime);
            this.mtbFinalDate.Visible = false;
            // 
            // bttnSearchPerson
            // 
            this.bttnSearchPerson.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnSearchPerson.Location = new System.Drawing.Point(216, 145);
            this.bttnSearchPerson.Name = "bttnSearchPerson";
            this.bttnSearchPerson.Size = new System.Drawing.Size(97, 27);
            this.bttnSearchPerson.TabIndex = 3;
            this.bttnSearchPerson.Text = "Buscar";
            this.bttnSearchPerson.UseVisualStyleBackColor = false;
            this.bttnSearchPerson.Click += new System.EventHandler(this.bttnSearchPerson_Click);
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
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClean.Location = new System.Drawing.Point(536, 196);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(129, 29);
            this.btnClean.TabIndex = 44;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Visible = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // dgvInscription
            // 
            this.dgvInscription.AllowUserToAddRows = false;
            this.dgvInscription.AllowUserToDeleteRows = false;
            this.dgvInscription.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvInscription.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvInscription.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvInscription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInscription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscription.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckSelection});
            this.dgvInscription.Location = new System.Drawing.Point(12, 122);
            this.dgvInscription.Name = "dgvInscription";
            this.dgvInscription.ReadOnly = true;
            this.dgvInscription.RowHeadersWidth = 51;
            this.dgvInscription.RowTemplate.Height = 29;
            this.dgvInscription.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInscription.Size = new System.Drawing.Size(992, 330);
            this.dgvInscription.TabIndex = 22;
            this.dgvInscription.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInscription_CellContentClick);
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
            // Modifybtn
            // 
            this.Modifybtn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Modifybtn.Enabled = false;
            this.Modifybtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Modifybtn.Location = new System.Drawing.Point(385, 458);
            this.Modifybtn.Name = "Modifybtn";
            this.Modifybtn.Size = new System.Drawing.Size(94, 29);
            this.Modifybtn.TabIndex = 33;
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
            this.Deletebtn.Location = new System.Drawing.Point(485, 458);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(94, 29);
            this.Deletebtn.TabIndex = 34;
            this.Deletebtn.Text = "Eliminar";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Visible = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // bttnViewSelected
            // 
            this.bttnViewSelected.BackColor = System.Drawing.Color.LightSalmon;
            this.bttnViewSelected.Enabled = false;
            this.bttnViewSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnViewSelected.Location = new System.Drawing.Point(585, 458);
            this.bttnViewSelected.Name = "bttnViewSelected";
            this.bttnViewSelected.Size = new System.Drawing.Size(187, 29);
            this.bttnViewSelected.TabIndex = 36;
            this.bttnViewSelected.Text = "Ver seleccionados";
            this.bttnViewSelected.UseVisualStyleBackColor = false;
            this.bttnViewSelected.Visible = false;
            this.bttnViewSelected.Click += new System.EventHandler(this.bttnViewSelected_Click);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(12, 47);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(536, 27);
            this.txtText.TabIndex = 38;
            this.txtText.Visible = false;
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(564, 47);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(249, 28);
            this.cmbType.TabIndex = 39;
            this.cmbType.Visible = false;
            // 
            // bttnSearch
            // 
            this.bttnSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bttnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnSearch.Location = new System.Drawing.Point(829, 48);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(116, 26);
            this.bttnSearch.TabIndex = 40;
            this.bttnSearch.Text = "Buscar";
            this.bttnSearch.UseVisualStyleBackColor = false;
            this.bttnSearch.Visible = false;
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click_1);
            // 
            // SelectAllcbx
            // 
            this.SelectAllcbx.AutoSize = true;
            this.SelectAllcbx.Enabled = false;
            this.SelectAllcbx.Location = new System.Drawing.Point(11, 92);
            this.SelectAllcbx.Name = "SelectAllcbx";
            this.SelectAllcbx.Size = new System.Drawing.Size(151, 24);
            this.SelectAllcbx.TabIndex = 41;
            this.SelectAllcbx.Text = "Seleccionar Todos";
            this.SelectAllcbx.UseVisualStyleBackColor = true;
            this.SelectAllcbx.Visible = false;
            this.SelectAllcbx.CheckedChanged += new System.EventHandler(this.SelectAllcbx_CheckedChanged);
            // 
            // DeselectAllcbx
            // 
            this.DeselectAllcbx.AutoSize = true;
            this.DeselectAllcbx.Enabled = false;
            this.DeselectAllcbx.Location = new System.Drawing.Point(168, 92);
            this.DeselectAllcbx.Name = "DeselectAllcbx";
            this.DeselectAllcbx.Size = new System.Drawing.Size(146, 24);
            this.DeselectAllcbx.TabIndex = 42;
            this.DeselectAllcbx.Text = "Desmarcar Todos";
            this.DeselectAllcbx.UseVisualStyleBackColor = true;
            this.DeselectAllcbx.Visible = false;
            this.DeselectAllcbx.CheckedChanged += new System.EventHandler(this.DeselectAllcbx_CheckedChanged);
            // 
            // bttnEraserText
            // 
            this.bttnEraserText.BackColor = System.Drawing.Color.LightYellow;
            this.bttnEraserText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnEraserText.Location = new System.Drawing.Point(961, 48);
            this.bttnEraserText.Name = "bttnEraserText";
            this.bttnEraserText.Size = new System.Drawing.Size(63, 26);
            this.bttnEraserText.TabIndex = 43;
            this.bttnEraserText.Text = "Borrar";
            this.bttnEraserText.UseVisualStyleBackColor = false;
            this.bttnEraserText.Visible = false;
            this.bttnEraserText.Click += new System.EventHandler(this.bttnEraserText_Click);
            // 
            // SearchGBox
            // 
            this.SearchGBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchGBox.Controls.Add(this.bttnEraserText);
            this.SearchGBox.Controls.Add(this.DeselectAllcbx);
            this.SearchGBox.Controls.Add(this.SelectAllcbx);
            this.SearchGBox.Controls.Add(this.bttnSearch);
            this.SearchGBox.Controls.Add(this.cmbType);
            this.SearchGBox.Controls.Add(this.txtText);
            this.SearchGBox.Controls.Add(this.bttnViewSelected);
            this.SearchGBox.Controls.Add(this.Deletebtn);
            this.SearchGBox.Controls.Add(this.Modifybtn);
            this.SearchGBox.Controls.Add(this.dgvInscription);
            this.SearchGBox.Location = new System.Drawing.Point(19, 312);
            this.SearchGBox.Name = "SearchGBox";
            this.SearchGBox.Size = new System.Drawing.Size(1040, 505);
            this.SearchGBox.TabIndex = 45;
            this.SearchGBox.TabStop = false;
            this.SearchGBox.Text = "BÚSQUEDA";
            // 
            // DataGBox
            // 
            this.DataGBox.BackColor = System.Drawing.Color.Ivory;
            this.DataGBox.Controls.Add(this.mTxBxCode);
            this.DataGBox.Controls.Add(this.label1);
            this.DataGBox.Controls.Add(this.SaveChanges);
            this.DataGBox.Controls.Add(this.btnClean);
            this.DataGBox.Controls.Add(this.bttnSearchPerson);
            this.DataGBox.Controls.Add(this.mtbFinalDate);
            this.DataGBox.Controls.Add(this.mtbStartDate);
            this.DataGBox.Controls.Add(this.bttnAddInscription);
            this.DataGBox.Controls.Add(this.lblFinalDateInscription);
            this.DataGBox.Controls.Add(this.lblStartDate);
            this.DataGBox.Controls.Add(this.ckbApproved);
            this.DataGBox.Controls.Add(this.txtbPersonIDInscription);
            this.DataGBox.Controls.Add(this.lblPersonIDInscription);
            this.DataGBox.Controls.Add(this.cmbSelectCourseInscription);
            this.DataGBox.Controls.Add(this.lblSelectCourseInscription);
            this.DataGBox.Controls.Add(this.cmbSelectAreaInscription);
            this.DataGBox.Controls.Add(this.lblSelectAreaInscription);
            this.DataGBox.Location = new System.Drawing.Point(19, 47);
            this.DataGBox.Name = "DataGBox";
            this.DataGBox.Size = new System.Drawing.Size(1040, 240);
            this.DataGBox.TabIndex = 46;
            this.DataGBox.TabStop = false;
            // 
            // SaveChanges
            // 
            this.SaveChanges.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SaveChanges.Enabled = false;
            this.SaveChanges.Location = new System.Drawing.Point(318, 198);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(133, 27);
            this.SaveChanges.TabIndex = 45;
            this.SaveChanges.Text = "Guardar Cambios";
            this.SaveChanges.UseVisualStyleBackColor = false;
            this.SaveChanges.Visible = false;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(885, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Código asignado";
            // 
            // mTxBxCode
            // 
            this.mTxBxCode.Location = new System.Drawing.Point(885, 68);
            this.mTxBxCode.Mask = "0000000";
            this.mTxBxCode.Name = "mTxBxCode";
            this.mTxBxCode.Size = new System.Drawing.Size(123, 27);
            this.mTxBxCode.TabIndex = 47;
            // 
            // InscriptionReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1090, 829);
            this.Controls.Add(this.DataGBox);
            this.Controls.Add(this.SearchGBox);
            this.Controls.Add(this.lblEscInscription);
            this.KeyPreview = true;
            this.Name = "InscriptionReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inscripción";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InscriptionReg_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscription)).EndInit();
            this.SearchGBox.ResumeLayout(false);
            this.SearchGBox.PerformLayout();
            this.DataGBox.ResumeLayout(false);
            this.DataGBox.PerformLayout();
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
        private System.Windows.Forms.MaskedTextBox mtbStartDate;
        private System.Windows.Forms.MaskedTextBox mtbFinalDate;
        private System.Windows.Forms.Button bttnSearchPerson;
        private System.Windows.Forms.Label lblEscInscription;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.DataGridView dgvInscription;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckSelection;
        private System.Windows.Forms.Button Modifybtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button bttnViewSelected;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button bttnSearch;
        private System.Windows.Forms.CheckBox SelectAllcbx;
        private System.Windows.Forms.CheckBox DeselectAllcbx;
        private System.Windows.Forms.Button bttnEraserText;
        private System.Windows.Forms.GroupBox SearchGBox;
        private System.Windows.Forms.GroupBox DataGBox;
        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.MaskedTextBox mTxBxCode;
        private System.Windows.Forms.Label label1;
    }
}