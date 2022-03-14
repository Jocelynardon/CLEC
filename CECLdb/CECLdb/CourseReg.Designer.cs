
namespace CECLdb
{
    partial class CourseReg
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
            this.lblSelectAreaCourse = new System.Windows.Forms.Label();
            this.cmbSelectArea = new System.Windows.Forms.ComboBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.txtbCourseName = new System.Windows.Forms.TextBox();
            this.bttnAddCourse = new System.Windows.Forms.Button();
            this.lblEscReturnMenu = new System.Windows.Forms.Label();
            this.DeselectAllcbx = new System.Windows.Forms.CheckBox();
            this.SelectAllcbx = new System.Windows.Forms.CheckBox();
            this.bttnEraserText = new System.Windows.Forms.Button();
            this.bttnSearch = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.bttnViewSelected = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Modifybtn = new System.Windows.Forms.Button();
            this.dgvCourse = new System.Windows.Forms.DataGridView();
            this.CheckSelection = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.DataGBox = new System.Windows.Forms.GroupBox();
            this.SearchGBox = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).BeginInit();
            this.DataGBox.SuspendLayout();
            this.SearchGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectAreaCourse
            // 
            this.lblSelectAreaCourse.AutoSize = true;
            this.lblSelectAreaCourse.Location = new System.Drawing.Point(15, 35);
            this.lblSelectAreaCourse.Name = "lblSelectAreaCourse";
            this.lblSelectAreaCourse.Size = new System.Drawing.Size(167, 20);
            this.lblSelectAreaCourse.TabIndex = 0;
            this.lblSelectAreaCourse.Text = "Área a la que pertenece";
            // 
            // cmbSelectArea
            // 
            this.cmbSelectArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectArea.FormattingEnabled = true;
            this.cmbSelectArea.Location = new System.Drawing.Point(15, 68);
            this.cmbSelectArea.Name = "cmbSelectArea";
            this.cmbSelectArea.Size = new System.Drawing.Size(402, 28);
            this.cmbSelectArea.TabIndex = 0;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(445, 35);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(128, 20);
            this.lblCourseName.TabIndex = 2;
            this.lblCourseName.Text = "Nombre del curso";
            // 
            // txtbCourseName
            // 
            this.txtbCourseName.Location = new System.Drawing.Point(445, 68);
            this.txtbCourseName.Name = "txtbCourseName";
            this.txtbCourseName.Size = new System.Drawing.Size(392, 27);
            this.txtbCourseName.TabIndex = 1;
            // 
            // bttnAddCourse
            // 
            this.bttnAddCourse.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnAddCourse.Location = new System.Drawing.Point(380, 131);
            this.bttnAddCourse.Name = "bttnAddCourse";
            this.bttnAddCourse.Size = new System.Drawing.Size(108, 28);
            this.bttnAddCourse.TabIndex = 3;
            this.bttnAddCourse.Text = "Agregar";
            this.bttnAddCourse.UseVisualStyleBackColor = false;
            this.bttnAddCourse.Visible = false;
            this.bttnAddCourse.Click += new System.EventHandler(this.bttnAddCourse_Click);
            // 
            // lblEscReturnMenu
            // 
            this.lblEscReturnMenu.AutoSize = true;
            this.lblEscReturnMenu.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblEscReturnMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEscReturnMenu.Location = new System.Drawing.Point(714, 9);
            this.lblEscReturnMenu.Name = "lblEscReturnMenu";
            this.lblEscReturnMenu.Size = new System.Drawing.Size(165, 22);
            this.lblEscReturnMenu.TabIndex = 8;
            this.lblEscReturnMenu.Text = "(ESC) Regresar al Menu";
            // 
            // DeselectAllcbx
            // 
            this.DeselectAllcbx.AutoSize = true;
            this.DeselectAllcbx.Enabled = false;
            this.DeselectAllcbx.Location = new System.Drawing.Point(169, 77);
            this.DeselectAllcbx.Name = "DeselectAllcbx";
            this.DeselectAllcbx.Size = new System.Drawing.Size(146, 24);
            this.DeselectAllcbx.TabIndex = 59;
            this.DeselectAllcbx.Text = "Desmarcar Todos";
            this.DeselectAllcbx.UseVisualStyleBackColor = true;
            this.DeselectAllcbx.Visible = false;
            this.DeselectAllcbx.CheckedChanged += new System.EventHandler(this.DeselectAllcbx_CheckedChanged);
            // 
            // SelectAllcbx
            // 
            this.SelectAllcbx.AutoSize = true;
            this.SelectAllcbx.Enabled = false;
            this.SelectAllcbx.Location = new System.Drawing.Point(12, 77);
            this.SelectAllcbx.Name = "SelectAllcbx";
            this.SelectAllcbx.Size = new System.Drawing.Size(151, 24);
            this.SelectAllcbx.TabIndex = 58;
            this.SelectAllcbx.Text = "Seleccionar Todos";
            this.SelectAllcbx.UseVisualStyleBackColor = true;
            this.SelectAllcbx.Visible = false;
            this.SelectAllcbx.CheckedChanged += new System.EventHandler(this.SelectAllcbx_CheckedChanged);
            // 
            // bttnEraserText
            // 
            this.bttnEraserText.BackColor = System.Drawing.Color.LightYellow;
            this.bttnEraserText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnEraserText.Location = new System.Drawing.Point(806, 32);
            this.bttnEraserText.Name = "bttnEraserText";
            this.bttnEraserText.Size = new System.Drawing.Size(63, 26);
            this.bttnEraserText.TabIndex = 57;
            this.bttnEraserText.Text = "Borrar";
            this.bttnEraserText.UseVisualStyleBackColor = false;
            this.bttnEraserText.Visible = false;
            this.bttnEraserText.Click += new System.EventHandler(this.bttnEraserText_Click);
            // 
            // bttnSearch
            // 
            this.bttnSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bttnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnSearch.Location = new System.Drawing.Point(684, 32);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(116, 26);
            this.bttnSearch.TabIndex = 56;
            this.bttnSearch.Text = "Buscar";
            this.bttnSearch.UseVisualStyleBackColor = false;
            this.bttnSearch.Visible = false;
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(467, 32);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(200, 28);
            this.cmbType.TabIndex = 55;
            this.cmbType.Visible = false;
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(11, 33);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(449, 27);
            this.txtText.TabIndex = 54;
            this.txtText.Visible = false;
            // 
            // bttnViewSelected
            // 
            this.bttnViewSelected.BackColor = System.Drawing.Color.LightSalmon;
            this.bttnViewSelected.Enabled = false;
            this.bttnViewSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnViewSelected.Location = new System.Drawing.Point(480, 451);
            this.bttnViewSelected.Name = "bttnViewSelected";
            this.bttnViewSelected.Size = new System.Drawing.Size(187, 29);
            this.bttnViewSelected.TabIndex = 63;
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
            this.Deletebtn.Location = new System.Drawing.Point(380, 451);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(94, 29);
            this.Deletebtn.TabIndex = 62;
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
            this.Modifybtn.Location = new System.Drawing.Point(271, 451);
            this.Modifybtn.Name = "Modifybtn";
            this.Modifybtn.Size = new System.Drawing.Size(94, 29);
            this.Modifybtn.TabIndex = 61;
            this.Modifybtn.Text = "Modificar";
            this.Modifybtn.UseVisualStyleBackColor = false;
            this.Modifybtn.Visible = false;
            this.Modifybtn.Click += new System.EventHandler(this.Modifybtn_Click);
            // 
            // dgvCourse
            // 
            this.dgvCourse.AllowUserToAddRows = false;
            this.dgvCourse.AllowUserToDeleteRows = false;
            this.dgvCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvCourse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvCourse.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvCourse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckSelection});
            this.dgvCourse.Location = new System.Drawing.Point(11, 107);
            this.dgvCourse.Name = "dgvCourse";
            this.dgvCourse.ReadOnly = true;
            this.dgvCourse.RowHeadersWidth = 51;
            this.dgvCourse.RowTemplate.Height = 29;
            this.dgvCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourse.Size = new System.Drawing.Size(810, 330);
            this.dgvCourse.TabIndex = 60;
            this.dgvCourse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCourse_CellContentClick);
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
            // btnSaveData
            // 
            this.btnSaveData.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSaveData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveData.Location = new System.Drawing.Point(348, 130);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(161, 29);
            this.btnSaveData.TabIndex = 64;
            this.btnSaveData.Text = "Guardar Datos";
            this.btnSaveData.UseVisualStyleBackColor = false;
            this.btnSaveData.Visible = false;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // DataGBox
            // 
            this.DataGBox.BackColor = System.Drawing.Color.Ivory;
            this.DataGBox.Controls.Add(this.txtbCourseName);
            this.DataGBox.Controls.Add(this.btnSaveData);
            this.DataGBox.Controls.Add(this.lblCourseName);
            this.DataGBox.Controls.Add(this.cmbSelectArea);
            this.DataGBox.Controls.Add(this.lblSelectAreaCourse);
            this.DataGBox.Controls.Add(this.bttnAddCourse);
            this.DataGBox.Location = new System.Drawing.Point(13, 34);
            this.DataGBox.Name = "DataGBox";
            this.DataGBox.Size = new System.Drawing.Size(866, 174);
            this.DataGBox.TabIndex = 65;
            this.DataGBox.TabStop = false;
            // 
            // SearchGBox
            // 
            this.SearchGBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchGBox.Controls.Add(this.lblResult);
            this.SearchGBox.Controls.Add(this.bttnViewSelected);
            this.SearchGBox.Controls.Add(this.Deletebtn);
            this.SearchGBox.Controls.Add(this.Modifybtn);
            this.SearchGBox.Controls.Add(this.dgvCourse);
            this.SearchGBox.Controls.Add(this.DeselectAllcbx);
            this.SearchGBox.Controls.Add(this.SelectAllcbx);
            this.SearchGBox.Controls.Add(this.bttnEraserText);
            this.SearchGBox.Controls.Add(this.bttnSearch);
            this.SearchGBox.Controls.Add(this.cmbType);
            this.SearchGBox.Controls.Add(this.txtText);
            this.SearchGBox.Location = new System.Drawing.Point(13, 229);
            this.SearchGBox.Name = "SearchGBox";
            this.SearchGBox.Size = new System.Drawing.Size(875, 496);
            this.SearchGBox.TabIndex = 66;
            this.SearchGBox.TabStop = false;
            this.SearchGBox.Text = "BÚSQUEDA";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(669, 78);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(121, 20);
            this.lblResult.TabIndex = 64;
            this.lblResult.Text = "Total Resultados:";
            this.lblResult.Visible = false;
            // 
            // CourseReg
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(917, 736);
            this.ControlBox = false;
            this.Controls.Add(this.SearchGBox);
            this.Controls.Add(this.DataGBox);
            this.Controls.Add(this.lblEscReturnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "CourseReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Curso";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Exit);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).EndInit();
            this.DataGBox.ResumeLayout(false);
            this.DataGBox.PerformLayout();
            this.SearchGBox.ResumeLayout(false);
            this.SearchGBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectAreaCourse;
        private System.Windows.Forms.ComboBox cmbSelectArea;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.TextBox txtbCourseName;
        private System.Windows.Forms.Button bttnAddCourse;
        private System.Windows.Forms.Label lblEscReturnMenu;
        private System.Windows.Forms.CheckBox DeselectAllcbx;
        private System.Windows.Forms.CheckBox SelectAllcbx;
        private System.Windows.Forms.Button bttnEraserText;
        private System.Windows.Forms.Button bttnSearch;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button bttnViewSelected;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Modifybtn;
        private System.Windows.Forms.DataGridView dgvCourse;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckSelection;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.GroupBox DataGBox;
        private System.Windows.Forms.GroupBox SearchGBox;
        private System.Windows.Forms.Label lblResult;
    }
}