﻿
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
            this.mtbTelephonPerson = new System.Windows.Forms.MaskedTextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonReg)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(46, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbNamePerson
            // 
            this.txtbNamePerson.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtbNamePerson.Location = new System.Drawing.Point(46, 76);
            this.txtbNamePerson.Name = "txtbNamePerson";
            this.txtbNamePerson.Size = new System.Drawing.Size(353, 27);
            this.txtbNamePerson.TabIndex = 1;
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
            this.lblTelNumber.Location = new System.Drawing.Point(579, 161);
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
            this.bttnAddPerson.TabIndex = 6;
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
            // mtbTelephonPerson
            // 
            this.mtbTelephonPerson.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.mtbTelephonPerson.Location = new System.Drawing.Point(579, 197);
            this.mtbTelephonPerson.Mask = "000000000";
            this.mtbTelephonPerson.Name = "mtbTelephonPerson";
            this.mtbTelephonPerson.Size = new System.Drawing.Size(82, 27);
            this.mtbTelephonPerson.TabIndex = 8;
            this.mtbTelephonPerson.Text = "00000000";
            // 
            // bttnSearchPerson
            // 
            this.bttnSearchPerson.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bttnSearchPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnSearchPerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnSearchPerson.Location = new System.Drawing.Point(840, 342);
            this.bttnSearchPerson.Name = "bttnSearchPerson";
            this.bttnSearchPerson.Size = new System.Drawing.Size(94, 29);
            this.bttnSearchPerson.TabIndex = 9;
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
            this.txtEmailPerson.TabIndex = 12;
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
            // 
            // lblLastNamePerson
            // 
            this.lblLastNamePerson.AutoSize = true;
            this.lblLastNamePerson.Location = new System.Drawing.Point(552, 40);
            this.lblLastNamePerson.Name = "lblLastNamePerson";
            this.lblLastNamePerson.Size = new System.Drawing.Size(66, 20);
            this.lblLastNamePerson.TabIndex = 14;
            this.lblLastNamePerson.Text = "Apellido";
            // 
            // txtbLastNamePerson
            // 
            this.txtbLastNamePerson.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtbLastNamePerson.Location = new System.Drawing.Point(552, 76);
            this.txtbLastNamePerson.Name = "txtbLastNamePerson";
            this.txtbLastNamePerson.Size = new System.Drawing.Size(353, 27);
            this.txtbLastNamePerson.TabIndex = 15;
            // 
            // txtbCodePerson
            // 
            this.txtbCodePerson.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtbCodePerson.Location = new System.Drawing.Point(739, 197);
            this.txtbCodePerson.Name = "txtbCodePerson";
            this.txtbCodePerson.Size = new System.Drawing.Size(166, 27);
            this.txtbCodePerson.TabIndex = 16;
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
            this.CheckSelection.Width = 125;
            // 
            // SelectAllcbx
            // 
            this.SelectAllcbx.AutoSize = true;
            this.SelectAllcbx.Location = new System.Drawing.Point(46, 402);
            this.SelectAllcbx.Name = "SelectAllcbx";
            this.SelectAllcbx.Size = new System.Drawing.Size(151, 24);
            this.SelectAllcbx.TabIndex = 19;
            this.SelectAllcbx.Text = "Seleccionar Todos";
            this.SelectAllcbx.UseVisualStyleBackColor = true;
            this.SelectAllcbx.Visible = false;
            // 
            // Modifybtn
            // 
            this.Modifybtn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Modifybtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Modifybtn.Location = new System.Drawing.Point(374, 788);
            this.Modifybtn.Name = "Modifybtn";
            this.Modifybtn.Size = new System.Drawing.Size(94, 29);
            this.Modifybtn.TabIndex = 20;
            this.Modifybtn.Text = "Modificar";
            this.Modifybtn.UseVisualStyleBackColor = false;
            this.Modifybtn.Visible = false;
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.Honeydew;
            this.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Deletebtn.Location = new System.Drawing.Point(496, 788);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(94, 29);
            this.Deletebtn.TabIndex = 21;
            this.Deletebtn.Text = "Eliminar";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Visible = false;
            // 
            // bttnSelectPerson
            // 
            this.bttnSelectPerson.BackColor = System.Drawing.Color.Khaki;
            this.bttnSelectPerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnSelectPerson.Location = new System.Drawing.Point(618, 788);
            this.bttnSelectPerson.Name = "bttnSelectPerson";
            this.bttnSelectPerson.Size = new System.Drawing.Size(94, 29);
            this.bttnSelectPerson.TabIndex = 22;
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
            this.txtTextSearch.TabIndex = 23;
            this.txtTextSearch.Visible = false;
            // 
            // cmbTypeSearch
            // 
            this.cmbTypeSearch.FormattingEnabled = true;
            this.cmbTypeSearch.Location = new System.Drawing.Point(542, 343);
            this.cmbTypeSearch.Name = "cmbTypeSearch";
            this.cmbTypeSearch.Size = new System.Drawing.Size(255, 28);
            this.cmbTypeSearch.TabIndex = 24;
            this.cmbTypeSearch.Visible = false;
            // 
            // PersonReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 828);
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
            this.Controls.Add(this.mtbTelephonPerson);
            this.Controls.Add(this.bttnReturnPerson);
            this.Controls.Add(this.bttnAddPerson);
            this.Controls.Add(this.lblTelNumber);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtbNamePerson);
            this.Controls.Add(this.lblName);
            this.KeyPreview = true;
            this.Name = "PersonReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.MaskedTextBox mtbTelephonPerson;
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
    }
}