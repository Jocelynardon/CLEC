
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
            this.bttnReturnCourse = new System.Windows.Forms.Button();
            this.bttnSaveCourse = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectAreaCourse
            // 
            this.lblSelectAreaCourse.AutoSize = true;
            this.lblSelectAreaCourse.Location = new System.Drawing.Point(12, 86);
            this.lblSelectAreaCourse.Name = "lblSelectAreaCourse";
            this.lblSelectAreaCourse.Size = new System.Drawing.Size(167, 20);
            this.lblSelectAreaCourse.TabIndex = 0;
            this.lblSelectAreaCourse.Text = "Área a la que pertenece";
            // 
            // cmbSelectArea
            // 
            this.cmbSelectArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectArea.FormattingEnabled = true;
            this.cmbSelectArea.Location = new System.Drawing.Point(12, 130);
            this.cmbSelectArea.Name = "cmbSelectArea";
            this.cmbSelectArea.Size = new System.Drawing.Size(402, 28);
            this.cmbSelectArea.TabIndex = 0;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(436, 86);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(128, 20);
            this.lblCourseName.TabIndex = 2;
            this.lblCourseName.Text = "Nombre del curso";
            // 
            // txtbCourseName
            // 
            this.txtbCourseName.Location = new System.Drawing.Point(441, 130);
            this.txtbCourseName.Name = "txtbCourseName";
            this.txtbCourseName.Size = new System.Drawing.Size(392, 27);
            this.txtbCourseName.TabIndex = 1;
            // 
            // bttnAddCourse
            // 
            this.bttnAddCourse.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnAddCourse.Location = new System.Drawing.Point(288, 182);
            this.bttnAddCourse.Name = "bttnAddCourse";
            this.bttnAddCourse.Size = new System.Drawing.Size(108, 28);
            this.bttnAddCourse.TabIndex = 3;
            this.bttnAddCourse.Text = "Agregar";
            this.bttnAddCourse.UseVisualStyleBackColor = false;
            this.bttnAddCourse.Visible = false;
            this.bttnAddCourse.Click += new System.EventHandler(this.bttnAddCourse_Click);
            // 
            // bttnReturnCourse
            // 
            this.bttnReturnCourse.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnReturnCourse.Location = new System.Drawing.Point(416, 182);
            this.bttnReturnCourse.Name = "bttnReturnCourse";
            this.bttnReturnCourse.Size = new System.Drawing.Size(108, 28);
            this.bttnReturnCourse.TabIndex = 5;
            this.bttnReturnCourse.Text = "Regresar";
            this.bttnReturnCourse.UseVisualStyleBackColor = false;
            this.bttnReturnCourse.Click += new System.EventHandler(this.bttnReturnCourse_Click);
            // 
            // bttnSaveCourse
            // 
            this.bttnSaveCourse.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnSaveCourse.Location = new System.Drawing.Point(288, 182);
            this.bttnSaveCourse.Name = "bttnSaveCourse";
            this.bttnSaveCourse.Size = new System.Drawing.Size(108, 28);
            this.bttnSaveCourse.TabIndex = 4;
            this.bttnSaveCourse.Text = "Guardar";
            this.bttnSaveCourse.UseVisualStyleBackColor = false;
            this.bttnSaveCourse.Visible = false;
            // 
            // lblEscReturnMenu
            // 
            this.lblEscReturnMenu.AutoSize = true;
            this.lblEscReturnMenu.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblEscReturnMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEscReturnMenu.Location = new System.Drawing.Point(604, 39);
            this.lblEscReturnMenu.Name = "lblEscReturnMenu";
            this.lblEscReturnMenu.Size = new System.Drawing.Size(165, 22);
            this.lblEscReturnMenu.TabIndex = 8;
            this.lblEscReturnMenu.Text = "(ESC) Regresar al Menu";
            // 
            // DeselectAllcbx
            // 
            this.DeselectAllcbx.AutoSize = true;
            this.DeselectAllcbx.Location = new System.Drawing.Point(185, 272);
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
            this.SelectAllcbx.Location = new System.Drawing.Point(28, 272);
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
            this.bttnEraserText.Location = new System.Drawing.Point(808, 227);
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
            this.bttnSearch.Location = new System.Drawing.Point(686, 229);
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
            this.cmbType.Location = new System.Drawing.Point(480, 227);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(200, 28);
            this.cmbType.TabIndex = 55;
            this.cmbType.Visible = false;
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(11, 228);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(463, 27);
            this.txtText.TabIndex = 54;
            this.txtText.Visible = false;
            // 
            // bttnViewSelected
            // 
            this.bttnViewSelected.BackColor = System.Drawing.Color.LightSalmon;
            this.bttnViewSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnViewSelected.Location = new System.Drawing.Point(480, 646);
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
            this.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Deletebtn.Location = new System.Drawing.Point(380, 646);
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
            this.Modifybtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Modifybtn.Location = new System.Drawing.Point(271, 646);
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
            this.dgvCourse.Location = new System.Drawing.Point(47, 302);
            this.dgvCourse.Name = "dgvCourse";
            this.dgvCourse.ReadOnly = true;
            this.dgvCourse.RowHeadersWidth = 51;
            this.dgvCourse.RowTemplate.Height = 29;
            this.dgvCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourse.Size = new System.Drawing.Size(810, 330);
            this.dgvCourse.TabIndex = 60;
            this.dgvCourse.Visible = false;
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
            this.btnSaveData.Location = new System.Drawing.Point(235, 181);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(161, 29);
            this.btnSaveData.TabIndex = 64;
            this.btnSaveData.Text = "Guardar Datos";
            this.btnSaveData.UseVisualStyleBackColor = false;
            this.btnSaveData.Visible = false;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // CourseReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 683);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.bttnViewSelected);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Modifybtn);
            this.Controls.Add(this.dgvCourse);
            this.Controls.Add(this.DeselectAllcbx);
            this.Controls.Add(this.SelectAllcbx);
            this.Controls.Add(this.bttnEraserText);
            this.Controls.Add(this.bttnSearch);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.lblEscReturnMenu);
            this.Controls.Add(this.bttnSaveCourse);
            this.Controls.Add(this.bttnReturnCourse);
            this.Controls.Add(this.bttnAddCourse);
            this.Controls.Add(this.txtbCourseName);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.cmbSelectArea);
            this.Controls.Add(this.lblSelectAreaCourse);
            this.KeyPreview = true;
            this.Name = "CourseReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Curso";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Exit);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectAreaCourse;
        private System.Windows.Forms.ComboBox cmbSelectArea;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.TextBox txtbCourseName;
        private System.Windows.Forms.Button bttnAddCourse;
        private System.Windows.Forms.Button bttnReturnCourse;
        private System.Windows.Forms.Button bttnSaveCourse;
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
    }
}