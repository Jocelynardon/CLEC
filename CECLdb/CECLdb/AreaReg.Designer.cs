
namespace CECLdb
{
    partial class AreaReg
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
            this.lblYear = new System.Windows.Forms.Label();
            this.lblAnnouncement = new System.Windows.Forms.Label();
            this.cmbAnnouncement = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblAreaName = new System.Windows.Forms.Label();
            this.txtbAreaName = new System.Windows.Forms.TextBox();
            this.bttnAddArea = new System.Windows.Forms.Button();
            this.bttnReturnArea = new System.Windows.Forms.Button();
            this.bttnSearchArea = new System.Windows.Forms.Button();
            this.bttnSaveArea = new System.Windows.Forms.Button();
            this.lblEscArea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(43, 40);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(36, 20);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "Año";
            // 
            // lblAnnouncement
            // 
            this.lblAnnouncement.AutoSize = true;
            this.lblAnnouncement.Location = new System.Drawing.Point(43, 141);
            this.lblAnnouncement.Name = "lblAnnouncement";
            this.lblAnnouncement.Size = new System.Drawing.Size(97, 20);
            this.lblAnnouncement.TabIndex = 2;
            this.lblAnnouncement.Text = "Convocatoria";
            // 
            // cmbAnnouncement
            // 
            this.cmbAnnouncement.FormattingEnabled = true;
            this.cmbAnnouncement.Location = new System.Drawing.Point(43, 178);
            this.cmbAnnouncement.Name = "cmbAnnouncement";
            this.cmbAnnouncement.Size = new System.Drawing.Size(151, 28);
            this.cmbAnnouncement.TabIndex = 3;
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(43, 76);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(151, 28);
            this.cmbYear.TabIndex = 4;
            // 
            // lblAreaName
            // 
            this.lblAreaName.AutoSize = true;
            this.lblAreaName.Location = new System.Drawing.Point(43, 248);
            this.lblAreaName.Name = "lblAreaName";
            this.lblAreaName.Size = new System.Drawing.Size(124, 20);
            this.lblAreaName.TabIndex = 5;
            this.lblAreaName.Text = "Nombre del Área";
            this.lblAreaName.Click += new System.EventHandler(this.lblAreaName_Click);
            // 
            // txtbAreaName
            // 
            this.txtbAreaName.Location = new System.Drawing.Point(43, 282);
            this.txtbAreaName.Name = "txtbAreaName";
            this.txtbAreaName.Size = new System.Drawing.Size(363, 27);
            this.txtbAreaName.TabIndex = 6;
            // 
            // bttnAddArea
            // 
            this.bttnAddArea.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnAddArea.Location = new System.Drawing.Point(312, 349);
            this.bttnAddArea.Name = "bttnAddArea";
            this.bttnAddArea.Size = new System.Drawing.Size(94, 30);
            this.bttnAddArea.TabIndex = 7;
            this.bttnAddArea.Text = "Agregar";
            this.bttnAddArea.UseVisualStyleBackColor = false;
            // 
            // bttnReturnArea
            // 
            this.bttnReturnArea.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnReturnArea.Location = new System.Drawing.Point(412, 349);
            this.bttnReturnArea.Name = "bttnReturnArea";
            this.bttnReturnArea.Size = new System.Drawing.Size(94, 30);
            this.bttnReturnArea.TabIndex = 8;
            this.bttnReturnArea.Text = "Regresar";
            this.bttnReturnArea.UseVisualStyleBackColor = false;
            this.bttnReturnArea.Click += new System.EventHandler(this.bttnReturnArea_Click);
            // 
            // bttnSearchArea
            // 
            this.bttnSearchArea.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnSearchArea.Location = new System.Drawing.Point(449, 279);
            this.bttnSearchArea.Name = "bttnSearchArea";
            this.bttnSearchArea.Size = new System.Drawing.Size(94, 30);
            this.bttnSearchArea.TabIndex = 9;
            this.bttnSearchArea.Text = "Buscar";
            this.bttnSearchArea.UseVisualStyleBackColor = false;
            this.bttnSearchArea.Visible = false;
            // 
            // bttnSaveArea
            // 
            this.bttnSaveArea.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnSaveArea.Location = new System.Drawing.Point(312, 349);
            this.bttnSaveArea.Name = "bttnSaveArea";
            this.bttnSaveArea.Size = new System.Drawing.Size(94, 30);
            this.bttnSaveArea.TabIndex = 10;
            this.bttnSaveArea.Text = "Guardar";
            this.bttnSaveArea.UseVisualStyleBackColor = false;
            this.bttnSaveArea.Visible = false;
            // 
            // lblEscArea
            // 
            this.lblEscArea.AutoSize = true;
            this.lblEscArea.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblEscArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEscArea.Location = new System.Drawing.Point(587, 27);
            this.lblEscArea.Name = "lblEscArea";
            this.lblEscArea.Size = new System.Drawing.Size(165, 22);
            this.lblEscArea.TabIndex = 11;
            this.lblEscArea.Text = "(ESC) Regresar al Menu";
            // 
            // AreaReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEscArea);
            this.Controls.Add(this.bttnSaveArea);
            this.Controls.Add(this.bttnSearchArea);
            this.Controls.Add(this.bttnReturnArea);
            this.Controls.Add(this.bttnAddArea);
            this.Controls.Add(this.txtbAreaName);
            this.Controls.Add(this.lblAreaName);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.cmbAnnouncement);
            this.Controls.Add(this.lblAnnouncement);
            this.Controls.Add(this.lblYear);
            this.KeyPreview = true;
            this.Name = "AreaReg";
            this.Text = "AreaReg";
            this.Load += new System.EventHandler(this.AreaReg_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Exit);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblAnnouncement;
        private System.Windows.Forms.ComboBox cmbAnnouncement;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblAreaName;
        private System.Windows.Forms.TextBox txtbAreaName;
        private System.Windows.Forms.Button bttnAddArea;
        private System.Windows.Forms.Button bttnReturnArea;
        private System.Windows.Forms.Button bttnSearchArea;
        private System.Windows.Forms.Button bttnSaveArea;
        private System.Windows.Forms.Label lblEscArea;
    }
}