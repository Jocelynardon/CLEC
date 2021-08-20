
namespace CECLdb
{
    partial class GeneralDelete
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
            this.DGVDelete = new System.Windows.Forms.DataGridView();
            this.NamePersonDelete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailPersonDelete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelephonePersonDelete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbtextDelete = new System.Windows.Forms.TextBox();
            this.cmbTypeDelete = new System.Windows.Forms.ComboBox();
            this.bttnSearchDelete = new System.Windows.Forms.Button();
            this.bttnReturnDelete = new System.Windows.Forms.Button();
            this.lblESCDelete = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVDelete
            // 
            this.DGVDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDelete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NamePersonDelete,
            this.EmailPersonDelete,
            this.TelephonePersonDelete});
            this.DGVDelete.Location = new System.Drawing.Point(155, 143);
            this.DGVDelete.Name = "DGVDelete";
            this.DGVDelete.RowHeadersWidth = 51;
            this.DGVDelete.RowTemplate.Height = 29;
            this.DGVDelete.Size = new System.Drawing.Size(662, 188);
            this.DGVDelete.TabIndex = 0;
            // 
            // NamePersonDelete
            // 
            this.NamePersonDelete.HeaderText = "Nombre";
            this.NamePersonDelete.MinimumWidth = 6;
            this.NamePersonDelete.Name = "NamePersonDelete";
            this.NamePersonDelete.Width = 125;
            // 
            // EmailPersonDelete
            // 
            this.EmailPersonDelete.HeaderText = "Correo";
            this.EmailPersonDelete.MinimumWidth = 6;
            this.EmailPersonDelete.Name = "EmailPersonDelete";
            this.EmailPersonDelete.Width = 125;
            // 
            // TelephonePersonDelete
            // 
            this.TelephonePersonDelete.HeaderText = "Teléfono";
            this.TelephonePersonDelete.MinimumWidth = 6;
            this.TelephonePersonDelete.Name = "TelephonePersonDelete";
            this.TelephonePersonDelete.Width = 125;
            // 
            // txtbtextDelete
            // 
            this.txtbtextDelete.Location = new System.Drawing.Point(155, 57);
            this.txtbtextDelete.Name = "txtbtextDelete";
            this.txtbtextDelete.Size = new System.Drawing.Size(352, 27);
            this.txtbtextDelete.TabIndex = 1;
            // 
            // cmbTypeDelete
            // 
            this.cmbTypeDelete.FormattingEnabled = true;
            this.cmbTypeDelete.Location = new System.Drawing.Point(540, 56);
            this.cmbTypeDelete.Name = "cmbTypeDelete";
            this.cmbTypeDelete.Size = new System.Drawing.Size(151, 28);
            this.cmbTypeDelete.TabIndex = 2;
            // 
            // bttnSearchDelete
            // 
            this.bttnSearchDelete.BackColor = System.Drawing.Color.Moccasin;
            this.bttnSearchDelete.Location = new System.Drawing.Point(723, 55);
            this.bttnSearchDelete.Name = "bttnSearchDelete";
            this.bttnSearchDelete.Size = new System.Drawing.Size(94, 29);
            this.bttnSearchDelete.TabIndex = 3;
            this.bttnSearchDelete.Text = "Buscar";
            this.bttnSearchDelete.UseVisualStyleBackColor = false;
            this.bttnSearchDelete.Click += new System.EventHandler(this.bttnSearchDelete_Click);
            // 
            // bttnReturnDelete
            // 
            this.bttnReturnDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnReturnDelete.Location = new System.Drawing.Point(438, 406);
            this.bttnReturnDelete.Name = "bttnReturnDelete";
            this.bttnReturnDelete.Size = new System.Drawing.Size(94, 29);
            this.bttnReturnDelete.TabIndex = 4;
            this.bttnReturnDelete.Text = "Regresar";
            this.bttnReturnDelete.UseVisualStyleBackColor = false;
            this.bttnReturnDelete.Click += new System.EventHandler(this.bttnReturnDelete_Click);
            // 
            // lblESCDelete
            // 
            this.lblESCDelete.AutoSize = true;
            this.lblESCDelete.BackColor = System.Drawing.Color.MistyRose;
            this.lblESCDelete.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblESCDelete.Location = new System.Drawing.Point(792, 19);
            this.lblESCDelete.Name = "lblESCDelete";
            this.lblESCDelete.Size = new System.Drawing.Size(165, 22);
            this.lblESCDelete.TabIndex = 5;
            this.lblESCDelete.Text = "(ESC) Regresar al Menu";
            // 
            // GeneralDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 513);
            this.Controls.Add(this.lblESCDelete);
            this.Controls.Add(this.bttnReturnDelete);
            this.Controls.Add(this.bttnSearchDelete);
            this.Controls.Add(this.cmbTypeDelete);
            this.Controls.Add(this.txtbtextDelete);
            this.Controls.Add(this.DGVDelete);
            this.KeyPreview = true;
            this.Name = "GeneralDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GeneralDelete";
            this.Load += new System.EventHandler(this.PersonDelete_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Exit);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamePersonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailPersonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelephonePersonDelete;
        private System.Windows.Forms.TextBox txtbtextDelete;
        private System.Windows.Forms.ComboBox cmbTypeDelete;
        private System.Windows.Forms.Button bttnSearchDelete;
        private System.Windows.Forms.Button bttnReturnDelete;
        private System.Windows.Forms.Label lblESCDelete;
    }
}