
namespace CECLdb
{
    partial class RegisterReg
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
            this.txtbPersonIDRegister = new System.Windows.Forms.TextBox();
            this.lblPersonIDRegister = new System.Windows.Forms.Label();
            this.cmbSelectCourseRegister = new System.Windows.Forms.ComboBox();
            this.lblSelectCourseInscription = new System.Windows.Forms.Label();
            this.cmbSelectAreaRegister = new System.Windows.Forms.ComboBox();
            this.lblSelectAreaInscription = new System.Windows.Forms.Label();
            this.lblConsultationDate = new System.Windows.Forms.Label();
            this.dtpConsultationDateRegister = new System.Windows.Forms.DateTimePicker();
            this.bttnAddRegister = new System.Windows.Forms.Button();
            this.bttnReturnRegister = new System.Windows.Forms.Button();
            this.bttnSaveRegister = new System.Windows.Forms.Button();
            this.bttnSearchRegister = new System.Windows.Forms.Button();
            this.lblEscRegister = new System.Windows.Forms.Label();
            this.bttnImportRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbPersonIDRegister
            // 
            this.txtbPersonIDRegister.Location = new System.Drawing.Point(490, 141);
            this.txtbPersonIDRegister.Name = "txtbPersonIDRegister";
            this.txtbPersonIDRegister.Size = new System.Drawing.Size(234, 27);
            this.txtbPersonIDRegister.TabIndex = 13;
            // 
            // lblPersonIDRegister
            // 
            this.lblPersonIDRegister.AutoSize = true;
            this.lblPersonIDRegister.Location = new System.Drawing.Point(490, 104);
            this.lblPersonIDRegister.Name = "lblPersonIDRegister";
            this.lblPersonIDRegister.Size = new System.Drawing.Size(79, 20);
            this.lblPersonIDRegister.TabIndex = 12;
            this.lblPersonIDRegister.Text = "ID Persona";
            // 
            // cmbSelectCourseRegister
            // 
            this.cmbSelectCourseRegister.FormattingEnabled = true;
            this.cmbSelectCourseRegister.Location = new System.Drawing.Point(12, 140);
            this.cmbSelectCourseRegister.Name = "cmbSelectCourseRegister";
            this.cmbSelectCourseRegister.Size = new System.Drawing.Size(397, 28);
            this.cmbSelectCourseRegister.TabIndex = 11;
            // 
            // lblSelectCourseInscription
            // 
            this.lblSelectCourseInscription.AutoSize = true;
            this.lblSelectCourseInscription.Location = new System.Drawing.Point(12, 104);
            this.lblSelectCourseInscription.Name = "lblSelectCourseInscription";
            this.lblSelectCourseInscription.Size = new System.Drawing.Size(161, 20);
            this.lblSelectCourseInscription.TabIndex = 10;
            this.lblSelectCourseInscription.Text = "Curso al que pertenece";
            // 
            // cmbSelectAreaRegister
            // 
            this.cmbSelectAreaRegister.FormattingEnabled = true;
            this.cmbSelectAreaRegister.Location = new System.Drawing.Point(12, 51);
            this.cmbSelectAreaRegister.Name = "cmbSelectAreaRegister";
            this.cmbSelectAreaRegister.Size = new System.Drawing.Size(397, 28);
            this.cmbSelectAreaRegister.TabIndex = 9;
            this.cmbSelectAreaRegister.SelectionChangeCommitted += new System.EventHandler(this.cmbSelectAreaInscription_SelectionChangeCommitted);
            // 
            // lblSelectAreaInscription
            // 
            this.lblSelectAreaInscription.AutoSize = true;
            this.lblSelectAreaInscription.Location = new System.Drawing.Point(12, 16);
            this.lblSelectAreaInscription.Name = "lblSelectAreaInscription";
            this.lblSelectAreaInscription.Size = new System.Drawing.Size(167, 20);
            this.lblSelectAreaInscription.TabIndex = 8;
            this.lblSelectAreaInscription.Text = "Área a la que pertenece";
            // 
            // lblConsultationDate
            // 
            this.lblConsultationDate.AutoSize = true;
            this.lblConsultationDate.Location = new System.Drawing.Point(12, 193);
            this.lblConsultationDate.Name = "lblConsultationDate";
            this.lblConsultationDate.Size = new System.Drawing.Size(129, 20);
            this.lblConsultationDate.TabIndex = 16;
            this.lblConsultationDate.Text = "Fecha de Consulta";
            // 
            // dtpConsultationDateRegister
            // 
            this.dtpConsultationDateRegister.CustomFormat = "yyyy/MM/dd";
            this.dtpConsultationDateRegister.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpConsultationDateRegister.Location = new System.Drawing.Point(12, 230);
            this.dtpConsultationDateRegister.Name = "dtpConsultationDateRegister";
            this.dtpConsultationDateRegister.Size = new System.Drawing.Size(307, 27);
            this.dtpConsultationDateRegister.TabIndex = 17;
            // 
            // bttnAddRegister
            // 
            this.bttnAddRegister.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnAddRegister.Location = new System.Drawing.Point(316, 326);
            this.bttnAddRegister.Name = "bttnAddRegister";
            this.bttnAddRegister.Size = new System.Drawing.Size(93, 29);
            this.bttnAddRegister.TabIndex = 18;
            this.bttnAddRegister.Text = "Agregar";
            this.bttnAddRegister.UseVisualStyleBackColor = false;
            this.bttnAddRegister.Click += new System.EventHandler(this.bttnAddRegister_Click);
            // 
            // bttnReturnRegister
            // 
            this.bttnReturnRegister.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnReturnRegister.Location = new System.Drawing.Point(555, 326);
            this.bttnReturnRegister.Name = "bttnReturnRegister";
            this.bttnReturnRegister.Size = new System.Drawing.Size(93, 29);
            this.bttnReturnRegister.TabIndex = 19;
            this.bttnReturnRegister.Text = "Regresar";
            this.bttnReturnRegister.UseVisualStyleBackColor = false;
            this.bttnReturnRegister.Click += new System.EventHandler(this.bttnReturnRegister_Click);
            // 
            // bttnSaveRegister
            // 
            this.bttnSaveRegister.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnSaveRegister.Location = new System.Drawing.Point(434, 326);
            this.bttnSaveRegister.Name = "bttnSaveRegister";
            this.bttnSaveRegister.Size = new System.Drawing.Size(93, 29);
            this.bttnSaveRegister.TabIndex = 20;
            this.bttnSaveRegister.Text = "Guardar";
            this.bttnSaveRegister.UseVisualStyleBackColor = false;
            this.bttnSaveRegister.Visible = false;
            // 
            // bttnSearchRegister
            // 
            this.bttnSearchRegister.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnSearchRegister.Location = new System.Drawing.Point(762, 141);
            this.bttnSearchRegister.Name = "bttnSearchRegister";
            this.bttnSearchRegister.Size = new System.Drawing.Size(93, 29);
            this.bttnSearchRegister.TabIndex = 21;
            this.bttnSearchRegister.Text = "Buscar";
            this.bttnSearchRegister.UseVisualStyleBackColor = false;
            this.bttnSearchRegister.Click += new System.EventHandler(this.bttnSearchRegister_Click);
            // 
            // lblEscRegister
            // 
            this.lblEscRegister.AutoSize = true;
            this.lblEscRegister.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblEscRegister.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEscRegister.Location = new System.Drawing.Point(762, 16);
            this.lblEscRegister.Name = "lblEscRegister";
            this.lblEscRegister.Size = new System.Drawing.Size(165, 22);
            this.lblEscRegister.TabIndex = 22;
            this.lblEscRegister.Text = "(ESC) Regresar al Menú";
            // 
            // bttnImportRegister
            // 
            this.bttnImportRegister.BackColor = System.Drawing.Color.LightCoral;
            this.bttnImportRegister.Location = new System.Drawing.Point(434, 326);
            this.bttnImportRegister.Name = "bttnImportRegister";
            this.bttnImportRegister.Size = new System.Drawing.Size(93, 29);
            this.bttnImportRegister.TabIndex = 23;
            this.bttnImportRegister.Text = "Importar";
            this.bttnImportRegister.UseVisualStyleBackColor = false;
            // 
            // RegisterReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 422);
            this.Controls.Add(this.bttnImportRegister);
            this.Controls.Add(this.lblEscRegister);
            this.Controls.Add(this.bttnSearchRegister);
            this.Controls.Add(this.bttnSaveRegister);
            this.Controls.Add(this.bttnReturnRegister);
            this.Controls.Add(this.bttnAddRegister);
            this.Controls.Add(this.dtpConsultationDateRegister);
            this.Controls.Add(this.lblConsultationDate);
            this.Controls.Add(this.txtbPersonIDRegister);
            this.Controls.Add(this.lblPersonIDRegister);
            this.Controls.Add(this.cmbSelectCourseRegister);
            this.Controls.Add(this.lblSelectCourseInscription);
            this.Controls.Add(this.cmbSelectAreaRegister);
            this.Controls.Add(this.lblSelectAreaInscription);
            this.KeyPreview = true;
            this.Name = "RegisterReg";
            this.Text = " ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Access);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbPersonIDRegister;
        private System.Windows.Forms.Label lblPersonIDRegister;
        private System.Windows.Forms.ComboBox cmbSelectCourseRegister;
        private System.Windows.Forms.Label lblSelectCourseInscription;
        private System.Windows.Forms.ComboBox cmbSelectAreaRegister;
        private System.Windows.Forms.Label lblSelectAreaInscription;
        private System.Windows.Forms.Label lblConsultationDate;
        private System.Windows.Forms.DateTimePicker dtpConsultationDateRegister;
        private System.Windows.Forms.Button bttnAddRegister;
        private System.Windows.Forms.Button bttnReturnRegister;
        private System.Windows.Forms.Button bttnSaveRegister;
        private System.Windows.Forms.Button bttnSearchRegister;
        private System.Windows.Forms.Label lblEscRegister;
        private System.Windows.Forms.Button bttnImportRegister;
    }
}