﻿
namespace CECLdb
{
    partial class ReqData2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ÁreaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CursoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aprobóCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicioCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFinCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.lblEscReqData2 = new System.Windows.Forms.Label();
            this.bttnExportReqData2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ÁreaCol,
            this.CursoCol,
            this.ConsultaCol,
            this.aprobóCol,
            this.FechaInicioCol,
            this.FechaFinCol});
            this.dataGridView1.Location = new System.Drawing.Point(37, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(804, 343);
            this.dataGridView1.TabIndex = 9;
            // 
            // ÁreaCol
            // 
            this.ÁreaCol.HeaderText = "Área";
            this.ÁreaCol.MinimumWidth = 6;
            this.ÁreaCol.Name = "ÁreaCol";
            this.ÁreaCol.ReadOnly = true;
            this.ÁreaCol.Width = 125;
            // 
            // CursoCol
            // 
            this.CursoCol.HeaderText = "Curso";
            this.CursoCol.MinimumWidth = 6;
            this.CursoCol.Name = "CursoCol";
            this.CursoCol.ReadOnly = true;
            this.CursoCol.Width = 125;
            // 
            // ConsultaCol
            // 
            this.ConsultaCol.HeaderText = "Fecha Consulta";
            this.ConsultaCol.MinimumWidth = 6;
            this.ConsultaCol.Name = "ConsultaCol";
            this.ConsultaCol.ReadOnly = true;
            this.ConsultaCol.Width = 125;
            // 
            // aprobóCol
            // 
            this.aprobóCol.HeaderText = "Aprobó";
            this.aprobóCol.MinimumWidth = 6;
            this.aprobóCol.Name = "aprobóCol";
            this.aprobóCol.ReadOnly = true;
            this.aprobóCol.Width = 125;
            // 
            // FechaInicioCol
            // 
            this.FechaInicioCol.HeaderText = "FechaInicio";
            this.FechaInicioCol.MinimumWidth = 6;
            this.FechaInicioCol.Name = "FechaInicioCol";
            this.FechaInicioCol.ReadOnly = true;
            this.FechaInicioCol.Width = 125;
            // 
            // FechaFinCol
            // 
            this.FechaFinCol.HeaderText = "Fecha Fin";
            this.FechaFinCol.MinimumWidth = 6;
            this.FechaFinCol.Name = "FechaFinCol";
            this.FechaFinCol.ReadOnly = true;
            this.FechaFinCol.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblEscReqData2
            // 
            this.lblEscReqData2.AutoSize = true;
            this.lblEscReqData2.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblEscReqData2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEscReqData2.Location = new System.Drawing.Point(856, 31);
            this.lblEscReqData2.Name = "lblEscReqData2";
            this.lblEscReqData2.Size = new System.Drawing.Size(165, 22);
            this.lblEscReqData2.TabIndex = 11;
            this.lblEscReqData2.Text = "(ESC) Regresar al Menú";
            // 
            // bttnExportReqData2
            // 
            this.bttnExportReqData2.BackColor = System.Drawing.Color.LightCoral;
            this.bttnExportReqData2.Location = new System.Drawing.Point(164, 393);
            this.bttnExportReqData2.Name = "bttnExportReqData2";
            this.bttnExportReqData2.Size = new System.Drawing.Size(94, 29);
            this.bttnExportReqData2.TabIndex = 12;
            this.bttnExportReqData2.Text = "Exportar";
            this.bttnExportReqData2.UseVisualStyleBackColor = false;
            // 
            // ReqData2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 450);
            this.Controls.Add(this.bttnExportReqData2);
            this.Controls.Add(this.lblEscReqData2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.KeyPreview = true;
            this.Name = "ReqData2";
            this.Text = "ReqData2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Access);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ÁreaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CursoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn aprobóCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicioCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFinCol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblEscReqData2;
        private System.Windows.Forms.Button bttnExportReqData2;
    }
}