
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DescCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEnvioCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.lblEscReqData3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DescCol,
            this.FechaEnvioCol});
            this.dataGridView1.Location = new System.Drawing.Point(25, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(306, 356);
            this.dataGridView1.TabIndex = 0;
            // 
            // DescCol
            // 
            this.DescCol.HeaderText = "Descripción";
            this.DescCol.MinimumWidth = 6;
            this.DescCol.Name = "DescCol";
            this.DescCol.ReadOnly = true;
            this.DescCol.Width = 125;
            // 
            // FechaEnvioCol
            // 
            this.FechaEnvioCol.HeaderText = "Fecha Envío";
            this.FechaEnvioCol.MinimumWidth = 6;
            this.FechaEnvioCol.Name = "FechaEnvioCol";
            this.FechaEnvioCol.ReadOnly = true;
            this.FechaEnvioCol.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
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
            this.lblEscReqData3.TabIndex = 2;
            this.lblEscReqData3.Text = "(ESC) Regresar al Menú";
            // 
            // ReqData3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 436);
            this.Controls.Add(this.lblEscReqData3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.KeyPreview = true;
            this.Name = "ReqData3";
            this.Text = "ReqData3";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Access);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEnvioCol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblEscReqData3;
    }
}