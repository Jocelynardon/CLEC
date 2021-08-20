
namespace CECLdb
{
    partial class ReqData3
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
            this.dgvReqData3 = new System.Windows.Forms.DataGridView();
            this.DescCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEnvioCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.lblEscReqData3 = new System.Windows.Forms.Label();
            this.bttnExportReqData3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReqData3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReqData3
            // 
            this.dgvReqData3.AllowUserToAddRows = false;
            this.dgvReqData3.AllowUserToDeleteRows = false;
            this.dgvReqData3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvReqData3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvReqData3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReqData3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DescCol,
            this.FechaEnvioCol});
            this.dgvReqData3.Location = new System.Drawing.Point(25, 30);
            this.dgvReqData3.Name = "dgvReqData3";
            this.dgvReqData3.ReadOnly = true;
            this.dgvReqData3.RowHeadersWidth = 51;
            this.dgvReqData3.RowTemplate.Height = 29;
            this.dgvReqData3.Size = new System.Drawing.Size(306, 356);
            this.dgvReqData3.TabIndex = 0;
            // 
            // DescCol
            // 
            this.DescCol.HeaderText = "Descripción";
            this.DescCol.MinimumWidth = 6;
            this.DescCol.Name = "DescCol";
            this.DescCol.ReadOnly = true;
            this.DescCol.Width = 116;
            // 
            // FechaEnvioCol
            // 
            this.FechaEnvioCol.HeaderText = "Fecha Envío";
            this.FechaEnvioCol.MinimumWidth = 6;
            this.FechaEnvioCol.Name = "FechaEnvioCol";
            this.FechaEnvioCol.ReadOnly = true;
            this.FechaEnvioCol.Width = 116;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblEscReqData3
            // 
            this.lblEscReqData3.AutoSize = true;
            this.lblEscReqData3.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblEscReqData3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEscReqData3.Location = new System.Drawing.Point(356, 30);
            this.lblEscReqData3.Name = "lblEscReqData3";
            this.lblEscReqData3.Size = new System.Drawing.Size(165, 22);
            this.lblEscReqData3.TabIndex = 4;
            this.lblEscReqData3.Text = "(ESC) Regresar al Menú";
            // 
            // bttnExportReqData3
            // 
            this.bttnExportReqData3.BackColor = System.Drawing.Color.LightCoral;
            this.bttnExportReqData3.Location = new System.Drawing.Point(25, 395);
            this.bttnExportReqData3.Name = "bttnExportReqData3";
            this.bttnExportReqData3.Size = new System.Drawing.Size(94, 29);
            this.bttnExportReqData3.TabIndex = 1;
            this.bttnExportReqData3.Text = "Exportar";
            this.bttnExportReqData3.UseVisualStyleBackColor = false;
            // 
            // ReqData3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 436);
            this.Controls.Add(this.bttnExportReqData3);
            this.Controls.Add(this.lblEscReqData3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvReqData3);
            this.KeyPreview = true;
            this.Name = "ReqData3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReqData3";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Access);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReqData3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReqData3;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEnvioCol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblEscReqData3;
        private System.Windows.Forms.Button bttnExportReqData3;
    }
}