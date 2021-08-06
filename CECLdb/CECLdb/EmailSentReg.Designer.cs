
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
            this.lblAdNumberES = new System.Windows.Forms.Label();
            this.txtbTextSearch = new System.Windows.Forms.TextBox();
            this.bttnReturnEmailSent = new System.Windows.Forms.Button();
            this.lblEscES = new System.Windows.Forms.Label();
            this.dgvEmailSent = new System.Windows.Forms.DataGridView();
            this.CheckSelection = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Modifybtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.bttnViewSelected = new System.Windows.Forms.Button();
            this.bttnEraserText = new System.Windows.Forms.Button();
            this.bttnSearch = new System.Windows.Forms.Button();
            this.SelectAllcbx = new System.Windows.Forms.CheckBox();
            this.DeselectAllcbx = new System.Windows.Forms.CheckBox();
            this.bttnPersonSent = new System.Windows.Forms.Button();
            this.bttnViewAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmailSent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdNumberES
            // 
            this.lblAdNumberES.AutoSize = true;
            this.lblAdNumberES.Location = new System.Drawing.Point(41, 31);
            this.lblAdNumberES.Name = "lblAdNumberES";
            this.lblAdNumberES.Size = new System.Drawing.Size(72, 20);
            this.lblAdNumberES.TabIndex = 0;
            this.lblAdNumberES.Text = "No. Aviso";
            // 
            // txtbTextSearch
            // 
            this.txtbTextSearch.Location = new System.Drawing.Point(41, 63);
            this.txtbTextSearch.Name = "txtbTextSearch";
            this.txtbTextSearch.Size = new System.Drawing.Size(148, 27);
            this.txtbTextSearch.TabIndex = 1;
            // 
            // bttnReturnEmailSent
            // 
            this.bttnReturnEmailSent.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnReturnEmailSent.Location = new System.Drawing.Point(509, 62);
            this.bttnReturnEmailSent.Name = "bttnReturnEmailSent";
            this.bttnReturnEmailSent.Size = new System.Drawing.Size(87, 29);
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
            this.lblEscES.Location = new System.Drawing.Point(901, 48);
            this.lblEscES.Name = "lblEscES";
            this.lblEscES.Size = new System.Drawing.Size(165, 22);
            this.lblEscES.TabIndex = 13;
            this.lblEscES.Text = "(ESC) Regresar al Menu";
            // 
            // dgvEmailSent
            // 
            this.dgvEmailSent.AllowUserToAddRows = false;
            this.dgvEmailSent.AllowUserToDeleteRows = false;
            this.dgvEmailSent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvEmailSent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvEmailSent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmailSent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckSelection});
            this.dgvEmailSent.Location = new System.Drawing.Point(41, 136);
            this.dgvEmailSent.Name = "dgvEmailSent";
            this.dgvEmailSent.RowHeadersWidth = 51;
            this.dgvEmailSent.RowTemplate.Height = 29;
            this.dgvEmailSent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmailSent.Size = new System.Drawing.Size(992, 330);
            this.dgvEmailSent.TabIndex = 19;
            this.dgvEmailSent.Visible = false;
            this.dgvEmailSent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmailSent_CellClick);
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
            // Modifybtn
            // 
            this.Modifybtn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Modifybtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Modifybtn.Location = new System.Drawing.Point(340, 484);
            this.Modifybtn.Name = "Modifybtn";
            this.Modifybtn.Size = new System.Drawing.Size(94, 29);
            this.Modifybtn.TabIndex = 23;
            this.Modifybtn.Text = "Modificar";
            this.Modifybtn.UseVisualStyleBackColor = false;
            this.Modifybtn.Visible = false;
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.Honeydew;
            this.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Deletebtn.Location = new System.Drawing.Point(448, 484);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(94, 29);
            this.Deletebtn.TabIndex = 24;
            this.Deletebtn.Text = "Eliminar";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Visible = false;
            // 
            // bttnViewSelected
            // 
            this.bttnViewSelected.BackColor = System.Drawing.Color.LightSalmon;
            this.bttnViewSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnViewSelected.Location = new System.Drawing.Point(681, 486);
            this.bttnViewSelected.Name = "bttnViewSelected";
            this.bttnViewSelected.Size = new System.Drawing.Size(187, 29);
            this.bttnViewSelected.TabIndex = 33;
            this.bttnViewSelected.Text = "Ver seleccionados";
            this.bttnViewSelected.UseVisualStyleBackColor = false;
            this.bttnViewSelected.Visible = false;
            this.bttnViewSelected.Click += new System.EventHandler(this.bttnViewSelected_Click);
            // 
            // bttnEraserText
            // 
            this.bttnEraserText.BackColor = System.Drawing.Color.LightYellow;
            this.bttnEraserText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnEraserText.Location = new System.Drawing.Point(440, 63);
            this.bttnEraserText.Name = "bttnEraserText";
            this.bttnEraserText.Size = new System.Drawing.Size(63, 26);
            this.bttnEraserText.TabIndex = 38;
            this.bttnEraserText.Text = "Borrar";
            this.bttnEraserText.UseVisualStyleBackColor = false;
            this.bttnEraserText.Click += new System.EventHandler(this.bttnEraserText_Click);
            // 
            // bttnSearch
            // 
            this.bttnSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bttnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnSearch.Location = new System.Drawing.Point(196, 64);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(116, 26);
            this.bttnSearch.TabIndex = 39;
            this.bttnSearch.Text = "Buscar";
            this.bttnSearch.UseVisualStyleBackColor = false;
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
            // 
            // SelectAllcbx
            // 
            this.SelectAllcbx.AutoSize = true;
            this.SelectAllcbx.Location = new System.Drawing.Point(41, 106);
            this.SelectAllcbx.Name = "SelectAllcbx";
            this.SelectAllcbx.Size = new System.Drawing.Size(151, 24);
            this.SelectAllcbx.TabIndex = 40;
            this.SelectAllcbx.Text = "Seleccionar Todos";
            this.SelectAllcbx.UseVisualStyleBackColor = true;
            this.SelectAllcbx.Visible = false;
            // 
            // DeselectAllcbx
            // 
            this.DeselectAllcbx.AutoSize = true;
            this.DeselectAllcbx.Location = new System.Drawing.Point(207, 106);
            this.DeselectAllcbx.Name = "DeselectAllcbx";
            this.DeselectAllcbx.Size = new System.Drawing.Size(146, 24);
            this.DeselectAllcbx.TabIndex = 41;
            this.DeselectAllcbx.Text = "Desmarcar Todos";
            this.DeselectAllcbx.UseVisualStyleBackColor = true;
            this.DeselectAllcbx.Visible = false;
            // 
            // bttnPersonSent
            // 
            this.bttnPersonSent.BackColor = System.Drawing.Color.PaleGreen;
            this.bttnPersonSent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnPersonSent.Location = new System.Drawing.Point(318, 63);
            this.bttnPersonSent.Name = "bttnPersonSent";
            this.bttnPersonSent.Size = new System.Drawing.Size(116, 26);
            this.bttnPersonSent.TabIndex = 42;
            this.bttnPersonSent.Text = "Ver personas";
            this.bttnPersonSent.UseVisualStyleBackColor = false;
            this.bttnPersonSent.Click += new System.EventHandler(this.bttnPersonSent_Click);
            // 
            // bttnViewAll
            // 
            this.bttnViewAll.BackColor = System.Drawing.Color.Khaki;
            this.bttnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnViewAll.Location = new System.Drawing.Point(548, 484);
            this.bttnViewAll.Name = "bttnViewAll";
            this.bttnViewAll.Size = new System.Drawing.Size(127, 29);
            this.bttnViewAll.TabIndex = 43;
            this.bttnViewAll.Text = "Ver todos";
            this.bttnViewAll.UseVisualStyleBackColor = false;
            this.bttnViewAll.Visible = false;
            this.bttnViewAll.Click += new System.EventHandler(this.bttnViewAll_Click);
            // 
            // EmailSentReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 527);
            this.Controls.Add(this.bttnViewAll);
            this.Controls.Add(this.bttnPersonSent);
            this.Controls.Add(this.DeselectAllcbx);
            this.Controls.Add(this.SelectAllcbx);
            this.Controls.Add(this.bttnSearch);
            this.Controls.Add(this.bttnEraserText);
            this.Controls.Add(this.bttnViewSelected);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Modifybtn);
            this.Controls.Add(this.dgvEmailSent);
            this.Controls.Add(this.lblEscES);
            this.Controls.Add(this.bttnReturnEmailSent);
            this.Controls.Add(this.txtbTextSearch);
            this.Controls.Add(this.lblAdNumberES);
            this.KeyPreview = true;
            this.Name = "EmailSentReg";
            this.Text = " ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Access);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmailSent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdNumberES;
        private System.Windows.Forms.TextBox txtbTextSearch;
        private System.Windows.Forms.Button bttnReturnEmailSent;
        private System.Windows.Forms.Label lblEscES;
        private System.Windows.Forms.DataGridView dgvEmailSent;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckSelection;
        private System.Windows.Forms.Button Modifybtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button bttnViewSelected;
        private System.Windows.Forms.Button bttnEraserText;
        private System.Windows.Forms.Button bttnSearch;
        private System.Windows.Forms.CheckBox SelectAllcbx;
        private System.Windows.Forms.CheckBox DeselectAllcbx;
        private System.Windows.Forms.Button bttnPersonSent;
        private System.Windows.Forms.Button bttnViewAll;
    }
}