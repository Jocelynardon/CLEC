 
namespace CECLdb
{
    partial class AdReg
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
            this.lblSelectAreaAd = new System.Windows.Forms.Label();
            this.cmbSelectAreaAd = new System.Windows.Forms.ComboBox();
            this.lblSelectCourseAd = new System.Windows.Forms.Label();
            this.cmbSelectCourseAd = new System.Windows.Forms.ComboBox();
            this.lblDateAd = new System.Windows.Forms.Label();
            this.dtpDateAd = new System.Windows.Forms.DateTimePicker();
            this.lblDescriptionAd = new System.Windows.Forms.Label();
            this.rtbDescriptionAd = new System.Windows.Forms.RichTextBox();
            this.bttnAddAd = new System.Windows.Forms.Button();
            this.bttnReturnAd = new System.Windows.Forms.Button();
            this.lblSearchAd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnSaveAd = new System.Windows.Forms.Button();
            this.lblEscAd = new System.Windows.Forms.Label();
            this.bttnEmailSent = new System.Windows.Forms.Button();
            this.dgvAdReg = new System.Windows.Forms.DataGridView();
            this.CheckSelection = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtTextAd = new System.Windows.Forms.TextBox();
            this.cmbTypeAd = new System.Windows.Forms.ComboBox();
            this.bttnSearchAd = new System.Windows.Forms.Button();
            this.ModifybtnAd = new System.Windows.Forms.Button();
            this.DeletebtnAd = new System.Windows.Forms.Button();
            this.bttnSelectPerson = new System.Windows.Forms.Button();
            this.bttnViewSelectedAd = new System.Windows.Forms.Button();
            this.btnCleanAd = new System.Windows.Forms.Button();
            this.SelectAllcbx = new System.Windows.Forms.CheckBox();
            this.DeselectAllcbx = new System.Windows.Forms.CheckBox();
            this.bttnEraserText = new System.Windows.Forms.Button();
            this.bttnConfirm = new System.Windows.Forms.Button();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtCurso = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdReg)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectAreaAd
            // 
            this.lblSelectAreaAd.AutoSize = true;
            this.lblSelectAreaAd.Location = new System.Drawing.Point(42, 23);
            this.lblSelectAreaAd.Name = "lblSelectAreaAd";
            this.lblSelectAreaAd.Size = new System.Drawing.Size(167, 20);
            this.lblSelectAreaAd.TabIndex = 0;
            this.lblSelectAreaAd.Text = "Área a la que pertenece";
            // 
            // cmbSelectAreaAd
            // 
            this.cmbSelectAreaAd.BackColor = System.Drawing.Color.MintCream;
            this.cmbSelectAreaAd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectAreaAd.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cmbSelectAreaAd.FormattingEnabled = true;
            this.cmbSelectAreaAd.Location = new System.Drawing.Point(42, 56);
            this.cmbSelectAreaAd.Name = "cmbSelectAreaAd";
            this.cmbSelectAreaAd.Size = new System.Drawing.Size(427, 28);
            this.cmbSelectAreaAd.TabIndex = 1;
            this.cmbSelectAreaAd.SelectionChangeCommitted += new System.EventHandler(this.cmbSelectAreaAd_SelectionChangeCommitted);
            // 
            // lblSelectCourseAd
            // 
            this.lblSelectCourseAd.AutoSize = true;
            this.lblSelectCourseAd.Location = new System.Drawing.Point(42, 110);
            this.lblSelectCourseAd.Name = "lblSelectCourseAd";
            this.lblSelectCourseAd.Size = new System.Drawing.Size(161, 20);
            this.lblSelectCourseAd.TabIndex = 2;
            this.lblSelectCourseAd.Text = "Curso al que pertenece";
            // 
            // cmbSelectCourseAd
            // 
            this.cmbSelectCourseAd.BackColor = System.Drawing.Color.MintCream;
            this.cmbSelectCourseAd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectCourseAd.FormattingEnabled = true;
            this.cmbSelectCourseAd.Location = new System.Drawing.Point(42, 146);
            this.cmbSelectCourseAd.Name = "cmbSelectCourseAd";
            this.cmbSelectCourseAd.Size = new System.Drawing.Size(427, 28);
            this.cmbSelectCourseAd.TabIndex = 2;
            // 
            // lblDateAd
            // 
            this.lblDateAd.AutoSize = true;
            this.lblDateAd.Location = new System.Drawing.Point(605, 110);
            this.lblDateAd.Name = "lblDateAd";
            this.lblDateAd.Size = new System.Drawing.Size(47, 20);
            this.lblDateAd.TabIndex = 4;
            this.lblDateAd.Text = "Fecha";
            // 
            // dtpDateAd
            // 
            this.dtpDateAd.CalendarFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDateAd.CalendarMonthBackground = System.Drawing.Color.LightCyan;
            this.dtpDateAd.CalendarTitleBackColor = System.Drawing.Color.LightSeaGreen;
            this.dtpDateAd.CustomFormat = "yyyy/MM/dd";
            this.dtpDateAd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateAd.Location = new System.Drawing.Point(605, 147);
            this.dtpDateAd.Name = "dtpDateAd";
            this.dtpDateAd.Size = new System.Drawing.Size(312, 27);
            this.dtpDateAd.TabIndex = 3;
            // 
            // lblDescriptionAd
            // 
            this.lblDescriptionAd.AutoSize = true;
            this.lblDescriptionAd.Location = new System.Drawing.Point(42, 193);
            this.lblDescriptionAd.Name = "lblDescriptionAd";
            this.lblDescriptionAd.Size = new System.Drawing.Size(91, 20);
            this.lblDescriptionAd.TabIndex = 6;
            this.lblDescriptionAd.Text = "Descripción ";
            // 
            // rtbDescriptionAd
            // 
            this.rtbDescriptionAd.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rtbDescriptionAd.Location = new System.Drawing.Point(42, 216);
            this.rtbDescriptionAd.Name = "rtbDescriptionAd";
            this.rtbDescriptionAd.Size = new System.Drawing.Size(452, 229);
            this.rtbDescriptionAd.TabIndex = 4;
            this.rtbDescriptionAd.Text = "";
            // 
            // bttnAddAd
            // 
            this.bttnAddAd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnAddAd.Location = new System.Drawing.Point(303, 467);
            this.bttnAddAd.Name = "bttnAddAd";
            this.bttnAddAd.Size = new System.Drawing.Size(114, 30);
            this.bttnAddAd.TabIndex = 5;
            this.bttnAddAd.Text = "Agregar";
            this.bttnAddAd.UseVisualStyleBackColor = false;
            this.bttnAddAd.Click += new System.EventHandler(this.bttnAddAd_Click);
            // 
            // bttnReturnAd
            // 
            this.bttnReturnAd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnReturnAd.Location = new System.Drawing.Point(423, 468);
            this.bttnReturnAd.Name = "bttnReturnAd";
            this.bttnReturnAd.Size = new System.Drawing.Size(114, 30);
            this.bttnReturnAd.TabIndex = 7;
            this.bttnReturnAd.Text = "Regresar";
            this.bttnReturnAd.UseVisualStyleBackColor = false;
            this.bttnReturnAd.Click += new System.EventHandler(this.bttnReturnAd_Click);
            // 
            // lblSearchAd
            // 
            this.lblSearchAd.AutoSize = true;
            this.lblSearchAd.Location = new System.Drawing.Point(744, 75);
            this.lblSearchAd.Name = "lblSearchAd";
            this.lblSearchAd.Size = new System.Drawing.Size(0, 20);
            this.lblSearchAd.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(815, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 14;
            // 
            // bttnSaveAd
            // 
            this.bttnSaveAd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnSaveAd.Location = new System.Drawing.Point(303, 467);
            this.bttnSaveAd.Name = "bttnSaveAd";
            this.bttnSaveAd.Size = new System.Drawing.Size(114, 30);
            this.bttnSaveAd.TabIndex = 6;
            this.bttnSaveAd.Text = "Guardar";
            this.bttnSaveAd.UseVisualStyleBackColor = false;
            this.bttnSaveAd.Visible = false;
            this.bttnSaveAd.Click += new System.EventHandler(this.bttnSaveAd_Click);
            // 
            // lblEscAd
            // 
            this.lblEscAd.AutoSize = true;
            this.lblEscAd.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblEscAd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEscAd.Location = new System.Drawing.Point(829, 23);
            this.lblEscAd.Name = "lblEscAd";
            this.lblEscAd.Size = new System.Drawing.Size(165, 22);
            this.lblEscAd.TabIndex = 17;
            this.lblEscAd.Text = "(ESC) Regresar al Menu";
            // 
            // bttnEmailSent
            // 
            this.bttnEmailSent.BackColor = System.Drawing.Color.MediumTurquoise;
            this.bttnEmailSent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnEmailSent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bttnEmailSent.Location = new System.Drawing.Point(678, 468);
            this.bttnEmailSent.Name = "bttnEmailSent";
            this.bttnEmailSent.Size = new System.Drawing.Size(114, 30);
            this.bttnEmailSent.TabIndex = 8;
            this.bttnEmailSent.Text = "Destinatario";
            this.bttnEmailSent.UseVisualStyleBackColor = false;
            this.bttnEmailSent.Visible = false;
            this.bttnEmailSent.Click += new System.EventHandler(this.bttnEmailSent_Click);
            // 
            // dgvAdReg
            // 
            this.dgvAdReg.AllowUserToAddRows = false;
            this.dgvAdReg.AllowUserToDeleteRows = false;
            this.dgvAdReg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvAdReg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvAdReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdReg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckSelection});
            this.dgvAdReg.Location = new System.Drawing.Point(29, 602);
            this.dgvAdReg.Name = "dgvAdReg";
            this.dgvAdReg.RowHeadersWidth = 51;
            this.dgvAdReg.RowTemplate.Height = 29;
            this.dgvAdReg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdReg.Size = new System.Drawing.Size(992, 330);
            this.dgvAdReg.TabIndex = 18;
            this.dgvAdReg.Visible = false;
            this.dgvAdReg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdReg_CellContentClick);
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
            // txtTextAd
            // 
            this.txtTextAd.Location = new System.Drawing.Point(12, 554);
            this.txtTextAd.Name = "txtTextAd";
            this.txtTextAd.Size = new System.Drawing.Size(564, 27);
            this.txtTextAd.TabIndex = 19;
            this.txtTextAd.Visible = false;
            // 
            // cmbTypeAd
            // 
            this.cmbTypeAd.BackColor = System.Drawing.SystemColors.Window;
            this.cmbTypeAd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeAd.FormattingEnabled = true;
            this.cmbTypeAd.Location = new System.Drawing.Point(592, 554);
            this.cmbTypeAd.Name = "cmbTypeAd";
            this.cmbTypeAd.Size = new System.Drawing.Size(249, 28);
            this.cmbTypeAd.TabIndex = 20;
            this.cmbTypeAd.Visible = false;
            // 
            // bttnSearchAd
            // 
            this.bttnSearchAd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bttnSearchAd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnSearchAd.Location = new System.Drawing.Point(857, 555);
            this.bttnSearchAd.Name = "bttnSearchAd";
            this.bttnSearchAd.Size = new System.Drawing.Size(116, 26);
            this.bttnSearchAd.TabIndex = 21;
            this.bttnSearchAd.Text = "Buscar";
            this.bttnSearchAd.UseVisualStyleBackColor = false;
            this.bttnSearchAd.Visible = false;
            this.bttnSearchAd.Click += new System.EventHandler(this.bttnSearchAd_Click_1);
            // 
            // ModifybtnAd
            // 
            this.ModifybtnAd.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ModifybtnAd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ModifybtnAd.Location = new System.Drawing.Point(260, 938);
            this.ModifybtnAd.Name = "ModifybtnAd";
            this.ModifybtnAd.Size = new System.Drawing.Size(94, 29);
            this.ModifybtnAd.TabIndex = 22;
            this.ModifybtnAd.Text = "Modificar";
            this.ModifybtnAd.UseVisualStyleBackColor = false;
            this.ModifybtnAd.Visible = false;
            this.ModifybtnAd.Click += new System.EventHandler(this.ModifybtnAd_Click);
            // 
            // DeletebtnAd
            // 
            this.DeletebtnAd.BackColor = System.Drawing.Color.Honeydew;
            this.DeletebtnAd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeletebtnAd.Location = new System.Drawing.Point(360, 938);
            this.DeletebtnAd.Name = "DeletebtnAd";
            this.DeletebtnAd.Size = new System.Drawing.Size(94, 29);
            this.DeletebtnAd.TabIndex = 23;
            this.DeletebtnAd.Text = "Eliminar";
            this.DeletebtnAd.UseVisualStyleBackColor = false;
            this.DeletebtnAd.Visible = false;
            this.DeletebtnAd.Click += new System.EventHandler(this.DeletebtnAd_Click);
            // 
            // bttnSelectPerson
            // 
            this.bttnSelectPerson.BackColor = System.Drawing.Color.Khaki;
            this.bttnSelectPerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnSelectPerson.Location = new System.Drawing.Point(460, 938);
            this.bttnSelectPerson.Name = "bttnSelectPerson";
            this.bttnSelectPerson.Size = new System.Drawing.Size(94, 29);
            this.bttnSelectPerson.TabIndex = 24;
            this.bttnSelectPerson.Text = "Seleccionar";
            this.bttnSelectPerson.UseVisualStyleBackColor = false;
            this.bttnSelectPerson.Visible = false;
            this.bttnSelectPerson.Click += new System.EventHandler(this.bttnSelectPerson_Click);
            // 
            // bttnViewSelectedAd
            // 
            this.bttnViewSelectedAd.BackColor = System.Drawing.Color.LightSalmon;
            this.bttnViewSelectedAd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnViewSelectedAd.Location = new System.Drawing.Point(557, 938);
            this.bttnViewSelectedAd.Name = "bttnViewSelectedAd";
            this.bttnViewSelectedAd.Size = new System.Drawing.Size(187, 29);
            this.bttnViewSelectedAd.TabIndex = 32;
            this.bttnViewSelectedAd.Text = "Ver seleccionados";
            this.bttnViewSelectedAd.UseVisualStyleBackColor = false;
            this.bttnViewSelectedAd.Visible = false;
            this.bttnViewSelectedAd.Click += new System.EventHandler(this.bttnViewSelectedAd_Click);
            // 
            // btnCleanAd
            // 
            this.btnCleanAd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCleanAd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCleanAd.Location = new System.Drawing.Point(543, 467);
            this.btnCleanAd.Name = "btnCleanAd";
            this.btnCleanAd.Size = new System.Drawing.Size(129, 29);
            this.btnCleanAd.TabIndex = 33;
            this.btnCleanAd.Text = "Limpiar";
            this.btnCleanAd.UseVisualStyleBackColor = false;
            this.btnCleanAd.Visible = false;
            this.btnCleanAd.Click += new System.EventHandler(this.btnCleanAd_Click);
            // 
            // SelectAllcbx
            // 
            this.SelectAllcbx.AutoSize = true;
            this.SelectAllcbx.Location = new System.Drawing.Point(38, 512);
            this.SelectAllcbx.Name = "SelectAllcbx";
            this.SelectAllcbx.Size = new System.Drawing.Size(151, 24);
            this.SelectAllcbx.TabIndex = 34;
            this.SelectAllcbx.Text = "Seleccionar Todos";
            this.SelectAllcbx.UseVisualStyleBackColor = true;
            this.SelectAllcbx.Visible = false;
            this.SelectAllcbx.CheckedChanged += new System.EventHandler(this.SelectAllcbx_CheckedChanged);
            // 
            // DeselectAllcbx
            // 
            this.DeselectAllcbx.AutoSize = true;
            this.DeselectAllcbx.Location = new System.Drawing.Point(195, 512);
            this.DeselectAllcbx.Name = "DeselectAllcbx";
            this.DeselectAllcbx.Size = new System.Drawing.Size(146, 24);
            this.DeselectAllcbx.TabIndex = 36;
            this.DeselectAllcbx.Text = "Desmarcar Todos";
            this.DeselectAllcbx.UseVisualStyleBackColor = true;
            this.DeselectAllcbx.Visible = false;
            // 
            // bttnEraserText
            // 
            this.bttnEraserText.BackColor = System.Drawing.Color.LightYellow;
            this.bttnEraserText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnEraserText.Location = new System.Drawing.Point(989, 555);
            this.bttnEraserText.Name = "bttnEraserText";
            this.bttnEraserText.Size = new System.Drawing.Size(63, 26);
            this.bttnEraserText.TabIndex = 37;
            this.bttnEraserText.Text = "Borrar";
            this.bttnEraserText.UseVisualStyleBackColor = false;
            this.bttnEraserText.Visible = false;
            this.bttnEraserText.Click += new System.EventHandler(this.bttnEraserText_Click);
            // 
            // bttnConfirm
            // 
            this.bttnConfirm.BackColor = System.Drawing.Color.RoyalBlue;
            this.bttnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bttnConfirm.Location = new System.Drawing.Point(592, 516);
            this.bttnConfirm.Name = "bttnConfirm";
            this.bttnConfirm.Size = new System.Drawing.Size(114, 30);
            this.bttnConfirm.TabIndex = 38;
            this.bttnConfirm.Text = "Confirmar";
            this.bttnConfirm.UseVisualStyleBackColor = false;
            this.bttnConfirm.Visible = false;
            this.bttnConfirm.Click += new System.EventHandler(this.bttnConfirm_Click);
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(42, 55);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(392, 27);
            this.txtArea.TabIndex = 39;
            this.txtArea.Visible = false;
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(42, 146);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(392, 27);
            this.txtCurso.TabIndex = 40;
            this.txtCurso.Visible = false;
            // 
            // AdReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 975);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.bttnConfirm);
            this.Controls.Add(this.bttnEraserText);
            this.Controls.Add(this.DeselectAllcbx);
            this.Controls.Add(this.SelectAllcbx);
            this.Controls.Add(this.btnCleanAd);
            this.Controls.Add(this.bttnViewSelectedAd);
            this.Controls.Add(this.bttnSelectPerson);
            this.Controls.Add(this.DeletebtnAd);
            this.Controls.Add(this.ModifybtnAd);
            this.Controls.Add(this.bttnSearchAd);
            this.Controls.Add(this.cmbTypeAd);
            this.Controls.Add(this.txtTextAd);
            this.Controls.Add(this.dgvAdReg);
            this.Controls.Add(this.bttnEmailSent);
            this.Controls.Add(this.lblEscAd);
            this.Controls.Add(this.bttnSaveAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSearchAd);
            this.Controls.Add(this.bttnReturnAd);
            this.Controls.Add(this.bttnAddAd);
            this.Controls.Add(this.rtbDescriptionAd);
            this.Controls.Add(this.lblDescriptionAd);
            this.Controls.Add(this.dtpDateAd);
            this.Controls.Add(this.lblDateAd);
            this.Controls.Add(this.cmbSelectCourseAd);
            this.Controls.Add(this.lblSelectCourseAd);
            this.Controls.Add(this.cmbSelectAreaAd);
            this.Controls.Add(this.lblSelectAreaAd);
            this.KeyPreview = true;
            this.Name = "AdReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AdReg";
            this.Click += new System.EventHandler(this.bttnSaveAd_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Exit);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdReg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectAreaAd;
        private System.Windows.Forms.ComboBox cmbSelectAreaAd;
        private System.Windows.Forms.Label lblSelectCourseAd;
        private System.Windows.Forms.ComboBox cmbSelectCourseAd;
        private System.Windows.Forms.Label lblDateAd;
        private System.Windows.Forms.DateTimePicker dtpDateAd;
        private System.Windows.Forms.Label lblDescriptionAd;
        private System.Windows.Forms.RichTextBox rtbDescriptionAd;
        private System.Windows.Forms.Button bttnAddAd;
        private System.Windows.Forms.Button bttnReturnAd;
        private System.Windows.Forms.Label lblSearchAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnSaveAd;
        private System.Windows.Forms.Label lblEscAd;
        private System.Windows.Forms.Button bttnEmailSent;
        private System.Windows.Forms.DataGridView dgvAdReg;
        private System.Windows.Forms.TextBox txtTextAd;
        private System.Windows.Forms.ComboBox cmbTypeAd;
        private System.Windows.Forms.Button bttnSearchAd;
        private System.Windows.Forms.Button ModifybtnAd;
        private System.Windows.Forms.Button DeletebtnAd;
        private System.Windows.Forms.Button bttnSelectPerson;
        private System.Windows.Forms.Button bttnViewSelectedAd;
        private System.Windows.Forms.Button btnCleanAd;
        private System.Windows.Forms.CheckBox SelectAllcbx;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckSelection;
        private System.Windows.Forms.CheckBox DeselectAllcbx;
        private System.Windows.Forms.Button bttnEraserText;
        private System.Windows.Forms.Button bttnConfirm;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtCurso;
    }
}