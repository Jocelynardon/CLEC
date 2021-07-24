
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
            this.Selection = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IDperson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNamePerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodePerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectAllcbx = new System.Windows.Forms.CheckBox();
            this.Modifybtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.txtbNamePerson.Size = new System.Drawing.Size(254, 27);
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
            this.lblTelNumber.Location = new System.Drawing.Point(665, 40);
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
            this.mtbTelephonPerson.Location = new System.Drawing.Point(665, 76);
            this.mtbTelephonPerson.Mask = "000000000";
            this.mtbTelephonPerson.Name = "mtbTelephonPerson";
            this.mtbTelephonPerson.Size = new System.Drawing.Size(82, 27);
            this.mtbTelephonPerson.TabIndex = 8;
            this.mtbTelephonPerson.Text = "00000000";
            // 
            // bttnSearchPerson
            // 
            this.bttnSearchPerson.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnSearchPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnSearchPerson.Location = new System.Drawing.Point(771, 195);
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
            this.lblLastNamePerson.Location = new System.Drawing.Point(339, 40);
            this.lblLastNamePerson.Name = "lblLastNamePerson";
            this.lblLastNamePerson.Size = new System.Drawing.Size(66, 20);
            this.lblLastNamePerson.TabIndex = 14;
            this.lblLastNamePerson.Text = "Apellido";
            // 
            // txtbLastNamePerson
            // 
            this.txtbLastNamePerson.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtbLastNamePerson.Location = new System.Drawing.Point(339, 76);
            this.txtbLastNamePerson.Name = "txtbLastNamePerson";
            this.txtbLastNamePerson.Size = new System.Drawing.Size(254, 27);
            this.txtbLastNamePerson.TabIndex = 15;
            // 
            // txtbCodePerson
            // 
            this.txtbCodePerson.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtbCodePerson.Location = new System.Drawing.Point(546, 197);
            this.txtbCodePerson.Name = "txtbCodePerson";
            this.txtbCodePerson.Size = new System.Drawing.Size(166, 27);
            this.txtbCodePerson.TabIndex = 16;
            // 
            // lblCodePerson
            // 
            this.lblCodePerson.AutoSize = true;
            this.lblCodePerson.Location = new System.Drawing.Point(546, 151);
            this.lblCodePerson.Name = "lblCodePerson";
            this.lblCodePerson.Size = new System.Drawing.Size(58, 20);
            this.lblCodePerson.TabIndex = 17;
            this.lblCodePerson.Text = "Código";
            // 
            // dgvPersonReg
            // 
            this.dgvPersonReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonReg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selection,
            this.IDperson,
            this.dgNamePerson,
            this.Email,
            this.Number,
            this.CodePerson});
            this.dgvPersonReg.Location = new System.Drawing.Point(74, 356);
            this.dgvPersonReg.Name = "dgvPersonReg";
            this.dgvPersonReg.RowHeadersWidth = 51;
            this.dgvPersonReg.RowTemplate.Height = 29;
            this.dgvPersonReg.Size = new System.Drawing.Size(913, 318);
            this.dgvPersonReg.TabIndex = 18;
            // 
            // Selection
            // 
            this.Selection.HeaderText = "Selección";
            this.Selection.MinimumWidth = 6;
            this.Selection.Name = "Selection";
            this.Selection.Width = 125;
            // 
            // IDperson
            // 
            this.IDperson.HeaderText = "ID";
            this.IDperson.MinimumWidth = 6;
            this.IDperson.Name = "IDperson";
            this.IDperson.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IDperson.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IDperson.Visible = false;
            this.IDperson.Width = 125;
            // 
            // dgNamePerson
            // 
            this.dgNamePerson.HeaderText = "Nombre";
            this.dgNamePerson.MinimumWidth = 6;
            this.dgNamePerson.Name = "dgNamePerson";
            this.dgNamePerson.ReadOnly = true;
            this.dgNamePerson.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Correo";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 125;
            // 
            // Number
            // 
            this.Number.HeaderText = "Teléfono";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 125;
            // 
            // CodePerson
            // 
            this.CodePerson.HeaderText = "Código";
            this.CodePerson.MinimumWidth = 6;
            this.CodePerson.Name = "CodePerson";
            this.CodePerson.ReadOnly = true;
            this.CodePerson.Width = 125;
            // 
            // SelectAllcbx
            // 
            this.SelectAllcbx.AutoSize = true;
            this.SelectAllcbx.Location = new System.Drawing.Point(46, 326);
            this.SelectAllcbx.Name = "SelectAllcbx";
            this.SelectAllcbx.Size = new System.Drawing.Size(151, 24);
            this.SelectAllcbx.TabIndex = 19;
            this.SelectAllcbx.Text = "Seleccionar Todos";
            this.SelectAllcbx.UseVisualStyleBackColor = true;
            // 
            // Modifybtn
            // 
            this.Modifybtn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Modifybtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Modifybtn.Location = new System.Drawing.Point(74, 691);
            this.Modifybtn.Name = "Modifybtn";
            this.Modifybtn.Size = new System.Drawing.Size(94, 29);
            this.Modifybtn.TabIndex = 20;
            this.Modifybtn.Text = "Modificar";
            this.Modifybtn.UseVisualStyleBackColor = false;
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.Honeydew;
            this.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Deletebtn.Location = new System.Drawing.Point(196, 691);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(94, 29);
            this.Deletebtn.TabIndex = 21;
            this.Deletebtn.Text = "Eliminar";
            this.Deletebtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(311, 691);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 22;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // PersonReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 732);
            this.Controls.Add(this.button1);
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
            this.Text = "PersonRegister";
            this.Load += new System.EventHandler(this.PersonReg_Load);
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selection;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDperson;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNamePerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodePerson;
        private System.Windows.Forms.CheckBox SelectAllcbx;
        private System.Windows.Forms.Button Modifybtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button button1;
    }
}