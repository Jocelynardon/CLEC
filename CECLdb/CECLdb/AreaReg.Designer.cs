﻿
namespace CECLdb
{
    partial class AreaReg
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
            this.lblYear = new System.Windows.Forms.Label();
            this.lblAnnouncement = new System.Windows.Forms.Label();
            this.cmbAnnouncement = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblAreaName = new System.Windows.Forms.Label();
            this.txtbAreaName = new System.Windows.Forms.TextBox();
            this.bttnAddArea = new System.Windows.Forms.Button();
            this.bttnReturnArea = new System.Windows.Forms.Button();
            this.bttnSaveArea = new System.Windows.Forms.Button();
            this.lblEscArea = new System.Windows.Forms.Label();
            this.bttnEraserText = new System.Windows.Forms.Button();
            this.bttnSearch = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.DeselectAllcbx = new System.Windows.Forms.CheckBox();
            this.SelectAllcbx = new System.Windows.Forms.CheckBox();
            this.bttnViewSelected = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Modifybtn = new System.Windows.Forms.Button();
            this.CheckSelection = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvArea = new System.Windows.Forms.DataGridView();
            this.btnSaveData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArea)).BeginInit();
            this.SuspendLayout();
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(43, 40);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(36, 20);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "Año";
            // 
            // lblAnnouncement
            // 
            this.lblAnnouncement.AutoSize = true;
            this.lblAnnouncement.Location = new System.Drawing.Point(244, 39);
            this.lblAnnouncement.Name = "lblAnnouncement";
            this.lblAnnouncement.Size = new System.Drawing.Size(97, 20);
            this.lblAnnouncement.TabIndex = 2;
            this.lblAnnouncement.Text = "Convocatoria";
            // 
            // cmbAnnouncement
            // 
            this.cmbAnnouncement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnnouncement.FormattingEnabled = true;
            this.cmbAnnouncement.Location = new System.Drawing.Point(244, 76);
            this.cmbAnnouncement.Name = "cmbAnnouncement";
            this.cmbAnnouncement.Size = new System.Drawing.Size(151, 28);
            this.cmbAnnouncement.TabIndex = 1;
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(43, 76);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(151, 28);
            this.cmbYear.TabIndex = 0;
            // 
            // lblAreaName
            // 
            this.lblAreaName.AutoSize = true;
            this.lblAreaName.Location = new System.Drawing.Point(43, 131);
            this.lblAreaName.Name = "lblAreaName";
            this.lblAreaName.Size = new System.Drawing.Size(124, 20);
            this.lblAreaName.TabIndex = 5;
            this.lblAreaName.Text = "Nombre del Área";
            // 
            // txtbAreaName
            // 
            this.txtbAreaName.Location = new System.Drawing.Point(43, 165);
            this.txtbAreaName.Name = "txtbAreaName";
            this.txtbAreaName.Size = new System.Drawing.Size(363, 27);
            this.txtbAreaName.TabIndex = 2;
            // 
            // bttnAddArea
            // 
            this.bttnAddArea.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnAddArea.Location = new System.Drawing.Point(212, 217);
            this.bttnAddArea.Name = "bttnAddArea";
            this.bttnAddArea.Size = new System.Drawing.Size(94, 30);
            this.bttnAddArea.TabIndex = 4;
            this.bttnAddArea.Text = "Agregar";
            this.bttnAddArea.UseVisualStyleBackColor = false;
            this.bttnAddArea.Visible = false;
            this.bttnAddArea.Click += new System.EventHandler(this.bttnAddArea_Click);
            // 
            // bttnReturnArea
            // 
            this.bttnReturnArea.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnReturnArea.Location = new System.Drawing.Point(312, 217);
            this.bttnReturnArea.Name = "bttnReturnArea";
            this.bttnReturnArea.Size = new System.Drawing.Size(94, 30);
            this.bttnReturnArea.TabIndex = 6;
            this.bttnReturnArea.Text = "Regresar";
            this.bttnReturnArea.UseVisualStyleBackColor = false;
            this.bttnReturnArea.Click += new System.EventHandler(this.bttnReturnArea_Click);
            // 
            // bttnSaveArea
            // 
            this.bttnSaveArea.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnSaveArea.Location = new System.Drawing.Point(212, 217);
            this.bttnSaveArea.Name = "bttnSaveArea";
            this.bttnSaveArea.Size = new System.Drawing.Size(94, 30);
            this.bttnSaveArea.TabIndex = 5;
            this.bttnSaveArea.Text = "Guardar";
            this.bttnSaveArea.UseVisualStyleBackColor = false;
            this.bttnSaveArea.Visible = false;
            // 
            // lblEscArea
            // 
            this.lblEscArea.AutoSize = true;
            this.lblEscArea.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblEscArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEscArea.Location = new System.Drawing.Point(707, 24);
            this.lblEscArea.Name = "lblEscArea";
            this.lblEscArea.Size = new System.Drawing.Size(165, 22);
            this.lblEscArea.TabIndex = 11;
            this.lblEscArea.Text = "(ESC) Regresar al Menu";
            // 
            // bttnEraserText
            // 
            this.bttnEraserText.BackColor = System.Drawing.Color.LightYellow;
            this.bttnEraserText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnEraserText.Location = new System.Drawing.Point(809, 276);
            this.bttnEraserText.Name = "bttnEraserText";
            this.bttnEraserText.Size = new System.Drawing.Size(63, 26);
            this.bttnEraserText.TabIndex = 50;
            this.bttnEraserText.Text = "Borrar";
            this.bttnEraserText.UseVisualStyleBackColor = false;
            this.bttnEraserText.Visible = false;
            this.bttnEraserText.Click += new System.EventHandler(this.bttnEraserText_Click);
            // 
            // bttnSearch
            // 
            this.bttnSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bttnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnSearch.Location = new System.Drawing.Point(687, 278);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(116, 26);
            this.bttnSearch.TabIndex = 49;
            this.bttnSearch.Text = "Buscar";
            this.bttnSearch.UseVisualStyleBackColor = false;
            this.bttnSearch.Visible = false;
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(481, 276);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(200, 28);
            this.cmbType.TabIndex = 48;
            this.cmbType.Visible = false;
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(12, 277);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(463, 27);
            this.txtText.TabIndex = 47;
            this.txtText.Visible = false;
            // 
            // DeselectAllcbx
            // 
            this.DeselectAllcbx.AutoSize = true;
            this.DeselectAllcbx.Location = new System.Drawing.Point(182, 310);
            this.DeselectAllcbx.Name = "DeselectAllcbx";
            this.DeselectAllcbx.Size = new System.Drawing.Size(146, 24);
            this.DeselectAllcbx.TabIndex = 53;
            this.DeselectAllcbx.Text = "Desmarcar Todos";
            this.DeselectAllcbx.UseVisualStyleBackColor = true;
            this.DeselectAllcbx.Visible = false;
            this.DeselectAllcbx.CheckedChanged += new System.EventHandler(this.DeselectAllcbx_CheckedChanged);
            // 
            // SelectAllcbx
            // 
            this.SelectAllcbx.AutoSize = true;
            this.SelectAllcbx.Location = new System.Drawing.Point(25, 310);
            this.SelectAllcbx.Name = "SelectAllcbx";
            this.SelectAllcbx.Size = new System.Drawing.Size(151, 24);
            this.SelectAllcbx.TabIndex = 52;
            this.SelectAllcbx.Text = "Seleccionar Todos";
            this.SelectAllcbx.UseVisualStyleBackColor = true;
            this.SelectAllcbx.Visible = false;
            this.SelectAllcbx.CheckedChanged += new System.EventHandler(this.SelectAllcbx_CheckedChanged);
            // 
            // bttnViewSelected
            // 
            this.bttnViewSelected.BackColor = System.Drawing.Color.LightSalmon;
            this.bttnViewSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnViewSelected.Location = new System.Drawing.Point(401, 687);
            this.bttnViewSelected.Name = "bttnViewSelected";
            this.bttnViewSelected.Size = new System.Drawing.Size(187, 29);
            this.bttnViewSelected.TabIndex = 57;
            this.bttnViewSelected.Text = "Ver seleccionados";
            this.bttnViewSelected.UseVisualStyleBackColor = false;
            this.bttnViewSelected.Visible = false;
            this.bttnViewSelected.Click += new System.EventHandler(this.bttnViewSelected_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.Honeydew;
            this.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Deletebtn.Location = new System.Drawing.Point(301, 687);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(94, 29);
            this.Deletebtn.TabIndex = 56;
            this.Deletebtn.Text = "Eliminar";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Visible = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Modifybtn
            // 
            this.Modifybtn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Modifybtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Modifybtn.Location = new System.Drawing.Point(201, 687);
            this.Modifybtn.Name = "Modifybtn";
            this.Modifybtn.Size = new System.Drawing.Size(94, 29);
            this.Modifybtn.TabIndex = 55;
            this.Modifybtn.Text = "Modificar";
            this.Modifybtn.UseVisualStyleBackColor = false;
            this.Modifybtn.Visible = false;
            this.Modifybtn.Click += new System.EventHandler(this.Modifybtn_Click);
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
            // dgvArea
            // 
            this.dgvArea.AllowUserToAddRows = false;
            this.dgvArea.AllowUserToDeleteRows = false;
            this.dgvArea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvArea.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvArea.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckSelection});
            this.dgvArea.Location = new System.Drawing.Point(25, 340);
            this.dgvArea.Name = "dgvArea";
            this.dgvArea.ReadOnly = true;
            this.dgvArea.RowHeadersWidth = 51;
            this.dgvArea.RowTemplate.Height = 29;
            this.dgvArea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArea.Size = new System.Drawing.Size(768, 330);
            this.dgvArea.TabIndex = 54;
            this.dgvArea.Visible = false;
            this.dgvArea.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArea_CellContentClick);
            // 
            // btnSaveData
            // 
            this.btnSaveData.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSaveData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveData.Location = new System.Drawing.Point(145, 218);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(161, 29);
            this.btnSaveData.TabIndex = 58;
            this.btnSaveData.Text = "Guardar Datos";
            this.btnSaveData.UseVisualStyleBackColor = false;
            this.btnSaveData.Visible = false;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // AreaReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 725);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.bttnViewSelected);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Modifybtn);
            this.Controls.Add(this.dgvArea);
            this.Controls.Add(this.DeselectAllcbx);
            this.Controls.Add(this.SelectAllcbx);
            this.Controls.Add(this.bttnEraserText);
            this.Controls.Add(this.bttnSearch);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.lblEscArea);
            this.Controls.Add(this.bttnSaveArea);
            this.Controls.Add(this.bttnReturnArea);
            this.Controls.Add(this.bttnAddArea);
            this.Controls.Add(this.txtbAreaName);
            this.Controls.Add(this.lblAreaName);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.cmbAnnouncement);
            this.Controls.Add(this.lblAnnouncement);
            this.Controls.Add(this.lblYear);
            this.KeyPreview = true;
            this.Name = "AreaReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AreaReg";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Exit);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblAnnouncement;
        private System.Windows.Forms.ComboBox cmbAnnouncement;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblAreaName;
        private System.Windows.Forms.TextBox txtbAreaName;
        private System.Windows.Forms.Button bttnAddArea;
        private System.Windows.Forms.Button bttnReturnArea;
        private System.Windows.Forms.Button bttnSaveArea;
        private System.Windows.Forms.Label lblEscArea;
        private System.Windows.Forms.Button bttnEraserText;
        private System.Windows.Forms.Button bttnSearch;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.CheckBox DeselectAllcbx;
        private System.Windows.Forms.CheckBox SelectAllcbx;
        private System.Windows.Forms.Button bttnViewSelected;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Modifybtn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckSelection;
        private System.Windows.Forms.DataGridView dgvArea;
        private System.Windows.Forms.Button btnSaveData;
    }
}