
namespace CECLdb
{
    partial class EmailSentReg
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bttnReturnEmailSent = new System.Windows.Forms.Button();
            this.lblEscES = new System.Windows.Forms.Label();
            this.dgvEmailSent = new System.Windows.Forms.DataGridView();
            this.ChangeStatusbtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Modifybtn = new System.Windows.Forms.Button();
            this.DeletedPreviewbtn = new System.Windows.Forms.Button();
            this.bttnViewSelected = new System.Windows.Forms.Button();
            this.bttnSearch = new System.Windows.Forms.Button();
            this.SelectAllcbx = new System.Windows.Forms.CheckBox();
            this.DeselectAllcbx = new System.Windows.Forms.CheckBox();
            this.bttnViewAll = new System.Windows.Forms.Button();
            this.txtNoAviso = new System.Windows.Forms.TextBox();
            this.Destinatarios = new System.Windows.Forms.GroupBox();
            this.bttnExport = new System.Windows.Forms.Button();
            this.cmbTypeSearch = new System.Windows.Forms.ComboBox();
            this.AddedPreviewbtn = new System.Windows.Forms.Button();
            this.txtTextSearch = new System.Windows.Forms.TextBox();
            this.bttnSearchPerson = new System.Windows.Forms.Button();
            this.Aviso = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmailSent)).BeginInit();
            this.Destinatarios.SuspendLayout();
            this.Aviso.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnReturnEmailSent
            // 
            this.bttnReturnEmailSent.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnReturnEmailSent.Location = new System.Drawing.Point(241, 21);
            this.bttnReturnEmailSent.Name = "bttnReturnEmailSent";
            this.bttnReturnEmailSent.Size = new System.Drawing.Size(98, 29);
            this.bttnReturnEmailSent.TabIndex = 10;
            this.bttnReturnEmailSent.Text = "Regresar";
            this.bttnReturnEmailSent.UseVisualStyleBackColor = false;
            this.bttnReturnEmailSent.Click += new System.EventHandler(this.bttnReturnEmailSent_Click);
            // 
            // lblEscES
            // 
            this.lblEscES.AutoSize = true;
            this.lblEscES.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblEscES.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEscES.Location = new System.Drawing.Point(864, 22);
            this.lblEscES.Name = "lblEscES";
            this.lblEscES.Size = new System.Drawing.Size(174, 22);
            this.lblEscES.TabIndex = 13;
            this.lblEscES.Text = "(ESC) Regresar al Menu";
            // 
            // dgvEmailSent
            // 
            this.dgvEmailSent.AllowUserToAddRows = false;
            this.dgvEmailSent.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvEmailSent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmailSent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvEmailSent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvEmailSent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmailSent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChangeStatusbtn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmailSent.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmailSent.Location = new System.Drawing.Point(16, 133);
            this.dgvEmailSent.Name = "dgvEmailSent";
            this.dgvEmailSent.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvEmailSent.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEmailSent.RowTemplate.Height = 29;
            this.dgvEmailSent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmailSent.Size = new System.Drawing.Size(987, 330);
            this.dgvEmailSent.TabIndex = 19;
            this.dgvEmailSent.Visible = false;
            this.dgvEmailSent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmailSent_CellContentClick);
            // 
            // ChangeStatusbtn
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.ChangeStatusbtn.DefaultCellStyle = dataGridViewCellStyle2;
            this.ChangeStatusbtn.HeaderText = "";
            this.ChangeStatusbtn.MinimumWidth = 6;
            this.ChangeStatusbtn.Name = "ChangeStatusbtn";
            this.ChangeStatusbtn.ReadOnly = true;
            this.ChangeStatusbtn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ChangeStatusbtn.Width = 6;
            // 
            // Modifybtn
            // 
            this.Modifybtn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Modifybtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Modifybtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Modifybtn.Location = new System.Drawing.Point(17, 484);
            this.Modifybtn.Name = "Modifybtn";
            this.Modifybtn.Size = new System.Drawing.Size(139, 29);
            this.Modifybtn.TabIndex = 23;
            this.Modifybtn.Text = "Guardar Cambios";
            this.Modifybtn.UseVisualStyleBackColor = false;
            this.Modifybtn.Visible = false;
            this.Modifybtn.Click += new System.EventHandler(this.Modifybtn_Click);
            // 
            // DeletedPreviewbtn
            // 
            this.DeletedPreviewbtn.BackColor = System.Drawing.Color.Tomato;
            this.DeletedPreviewbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeletedPreviewbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeletedPreviewbtn.Location = new System.Drawing.Point(500, 484);
            this.DeletedPreviewbtn.Name = "DeletedPreviewbtn";
            this.DeletedPreviewbtn.Size = new System.Drawing.Size(124, 29);
            this.DeletedPreviewbtn.TabIndex = 24;
            this.DeletedPreviewbtn.Text = "Ver Eliminados";
            this.DeletedPreviewbtn.UseVisualStyleBackColor = false;
            this.DeletedPreviewbtn.Click += new System.EventHandler(this.DeletedPreviewbtn_Click);
            // 
            // bttnViewSelected
            // 
            this.bttnViewSelected.BackColor = System.Drawing.Color.LightSalmon;
            this.bttnViewSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnViewSelected.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttnViewSelected.Location = new System.Drawing.Point(814, 484);
            this.bttnViewSelected.Name = "bttnViewSelected";
            this.bttnViewSelected.Size = new System.Drawing.Size(183, 29);
            this.bttnViewSelected.TabIndex = 33;
            this.bttnViewSelected.Text = "Actualizar Destinatarios";
            this.bttnViewSelected.UseVisualStyleBackColor = false;
            this.bttnViewSelected.Visible = false;
            this.bttnViewSelected.Click += new System.EventHandler(this.bttnViewSelected_Click);
            // 
            // bttnSearch
            // 
            this.bttnSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bttnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnSearch.Location = new System.Drawing.Point(46, 22);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(174, 26);
            this.bttnSearch.TabIndex = 39;
            this.bttnSearch.Text = "Buscar Aviso";
            this.bttnSearch.UseVisualStyleBackColor = false;
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
            // 
            // SelectAllcbx
            // 
            this.SelectAllcbx.AutoSize = true;
            this.SelectAllcbx.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectAllcbx.Location = new System.Drawing.Point(17, 103);
            this.SelectAllcbx.Name = "SelectAllcbx";
            this.SelectAllcbx.Size = new System.Drawing.Size(129, 24);
            this.SelectAllcbx.TabIndex = 40;
            this.SelectAllcbx.Text = "Agregar Todos";
            this.SelectAllcbx.UseVisualStyleBackColor = true;
            this.SelectAllcbx.Visible = false;
            this.SelectAllcbx.CheckedChanged += new System.EventHandler(this.SelectAllcbx_CheckedChanged);
            // 
            // DeselectAllcbx
            // 
            this.DeselectAllcbx.AutoSize = true;
            this.DeselectAllcbx.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeselectAllcbx.Location = new System.Drawing.Point(183, 103);
            this.DeselectAllcbx.Name = "DeselectAllcbx";
            this.DeselectAllcbx.Size = new System.Drawing.Size(129, 24);
            this.DeselectAllcbx.TabIndex = 41;
            this.DeselectAllcbx.Text = "Eliminar Todos";
            this.DeselectAllcbx.UseVisualStyleBackColor = true;
            this.DeselectAllcbx.Visible = false;
            this.DeselectAllcbx.CheckedChanged += new System.EventHandler(this.DeselectAllcbx_CheckedChanged);
            // 
            // bttnViewAll
            // 
            this.bttnViewAll.BackColor = System.Drawing.Color.Khaki;
            this.bttnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnViewAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttnViewAll.Location = new System.Drawing.Point(630, 484);
            this.bttnViewAll.Name = "bttnViewAll";
            this.bttnViewAll.Size = new System.Drawing.Size(178, 29);
            this.bttnViewAll.TabIndex = 43;
            this.bttnViewAll.Text = "Ver todas las personas";
            this.bttnViewAll.UseVisualStyleBackColor = false;
            this.bttnViewAll.Visible = false;
            this.bttnViewAll.Click += new System.EventHandler(this.bttnViewAll_Click);
            // 
            // txtNoAviso
            // 
            this.txtNoAviso.Enabled = false;
            this.txtNoAviso.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNoAviso.Location = new System.Drawing.Point(16, 26);
            this.txtNoAviso.Name = "txtNoAviso";
            this.txtNoAviso.Size = new System.Drawing.Size(140, 27);
            this.txtNoAviso.TabIndex = 44;
            // 
            // Destinatarios
            // 
            this.Destinatarios.BackColor = System.Drawing.SystemColors.Info;
            this.Destinatarios.Controls.Add(this.lblResult);
            this.Destinatarios.Controls.Add(this.bttnExport);
            this.Destinatarios.Controls.Add(this.cmbTypeSearch);
            this.Destinatarios.Controls.Add(this.AddedPreviewbtn);
            this.Destinatarios.Controls.Add(this.txtTextSearch);
            this.Destinatarios.Controls.Add(this.bttnSearchPerson);
            this.Destinatarios.Controls.Add(this.bttnViewAll);
            this.Destinatarios.Controls.Add(this.bttnViewSelected);
            this.Destinatarios.Controls.Add(this.DeselectAllcbx);
            this.Destinatarios.Controls.Add(this.SelectAllcbx);
            this.Destinatarios.Controls.Add(this.DeletedPreviewbtn);
            this.Destinatarios.Controls.Add(this.Modifybtn);
            this.Destinatarios.Controls.Add(this.dgvEmailSent);
            this.Destinatarios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Destinatarios.Location = new System.Drawing.Point(41, 159);
            this.Destinatarios.Name = "Destinatarios";
            this.Destinatarios.Size = new System.Drawing.Size(1027, 533);
            this.Destinatarios.TabIndex = 45;
            this.Destinatarios.TabStop = false;
            this.Destinatarios.Text = "Destinatarios";
            // 
            // bttnExport
            // 
            this.bttnExport.BackColor = System.Drawing.Color.Yellow;
            this.bttnExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnExport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttnExport.Location = new System.Drawing.Point(268, 484);
            this.bttnExport.Name = "bttnExport";
            this.bttnExport.Size = new System.Drawing.Size(96, 29);
            this.bttnExport.TabIndex = 50;
            this.bttnExport.Text = "Exportar";
            this.bttnExport.UseVisualStyleBackColor = false;
            this.bttnExport.Click += new System.EventHandler(this.bttnExport_Click);
            // 
            // cmbTypeSearch
            // 
            this.cmbTypeSearch.FormattingEnabled = true;
            this.cmbTypeSearch.Location = new System.Drawing.Point(496, 42);
            this.cmbTypeSearch.Name = "cmbTypeSearch";
            this.cmbTypeSearch.Size = new System.Drawing.Size(255, 28);
            this.cmbTypeSearch.TabIndex = 48;
            // 
            // AddedPreviewbtn
            // 
            this.AddedPreviewbtn.BackColor = System.Drawing.Color.PaleGreen;
            this.AddedPreviewbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddedPreviewbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddedPreviewbtn.Location = new System.Drawing.Point(370, 484);
            this.AddedPreviewbtn.Name = "AddedPreviewbtn";
            this.AddedPreviewbtn.Size = new System.Drawing.Size(124, 29);
            this.AddedPreviewbtn.TabIndex = 44;
            this.AddedPreviewbtn.Text = "Ver Agregados";
            this.AddedPreviewbtn.UseVisualStyleBackColor = false;
            this.AddedPreviewbtn.Click += new System.EventHandler(this.AddedPreviewbtn_Click);
            // 
            // txtTextSearch
            // 
            this.txtTextSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTextSearch.Location = new System.Drawing.Point(28, 43);
            this.txtTextSearch.Name = "txtTextSearch";
            this.txtTextSearch.Size = new System.Drawing.Size(439, 27);
            this.txtTextSearch.TabIndex = 47;
            // 
            // bttnSearchPerson
            // 
            this.bttnSearchPerson.BackColor = System.Drawing.Color.PaleTurquoise;
            this.bttnSearchPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnSearchPerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnSearchPerson.Location = new System.Drawing.Point(794, 41);
            this.bttnSearchPerson.Name = "bttnSearchPerson";
            this.bttnSearchPerson.Size = new System.Drawing.Size(94, 29);
            this.bttnSearchPerson.TabIndex = 49;
            this.bttnSearchPerson.Text = "Buscar";
            this.bttnSearchPerson.UseVisualStyleBackColor = false;
            this.bttnSearchPerson.Click += new System.EventHandler(this.bttnSearchPerson_Click);
            // 
            // Aviso
            // 
            this.Aviso.BackColor = System.Drawing.SystemColors.Info;
            this.Aviso.Controls.Add(this.txtNoAviso);
            this.Aviso.Location = new System.Drawing.Point(41, 71);
            this.Aviso.Name = "Aviso";
            this.Aviso.Size = new System.Drawing.Size(185, 70);
            this.Aviso.TabIndex = 46;
            this.Aviso.TabStop = false;
            this.Aviso.Text = "Aviso";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(804, 107);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(133, 20);
            this.lblResult.TabIndex = 51;
            this.lblResult.Text = "Total Resultados: ";
            this.lblResult.Visible = false;
            // 
            // EmailSentReg
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1080, 703);
            this.Controls.Add(this.Aviso);
            this.Controls.Add(this.Destinatarios);
            this.Controls.Add(this.bttnSearch);
            this.Controls.Add(this.lblEscES);
            this.Controls.Add(this.bttnReturnEmailSent);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "EmailSentReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Email Enviado";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Access);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmailSent)).EndInit();
            this.Destinatarios.ResumeLayout(false);
            this.Destinatarios.PerformLayout();
            this.Aviso.ResumeLayout(false);
            this.Aviso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttnReturnEmailSent;
        private System.Windows.Forms.Label lblEscES;
        private System.Windows.Forms.DataGridView dgvEmailSent;
        private System.Windows.Forms.Button Modifybtn;
        private System.Windows.Forms.Button DeletedPreviewbtn;
        private System.Windows.Forms.Button bttnViewSelected;
        private System.Windows.Forms.Button bttnSearch;
        private System.Windows.Forms.CheckBox SelectAllcbx;
        private System.Windows.Forms.CheckBox DeselectAllcbx;
        private System.Windows.Forms.Button bttnViewAll;
        private System.Windows.Forms.TextBox txtNoAviso;
        private System.Windows.Forms.GroupBox Destinatarios;
        private System.Windows.Forms.GroupBox Aviso;
        private System.Windows.Forms.DataGridViewButtonColumn ChangeStatusbtn;
        private System.Windows.Forms.Button AddedPreviewbtn;
        private System.Windows.Forms.ComboBox cmbTypeSearch;
        private System.Windows.Forms.TextBox txtTextSearch;
        private System.Windows.Forms.Button bttnSearchPerson;
        private System.Windows.Forms.Button bttnExport;
        private System.Windows.Forms.Label lblResult;
    }
}