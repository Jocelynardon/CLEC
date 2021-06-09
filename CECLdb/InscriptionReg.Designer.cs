
namespace CECLdb
{
    partial class InscriptionReg
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
            this.lblSelectAreaInscription = new System.Windows.Forms.Label();
            this.cmbSelectAreaInscription = new System.Windows.Forms.ComboBox();
            this.lblSelectCourseInscription = new System.Windows.Forms.Label();
            this.cmbSelectCourseInscription = new System.Windows.Forms.ComboBox();
            this.lblPersonIDInscription = new System.Windows.Forms.Label();
            this.txtbPersonIDInscription = new System.Windows.Forms.TextBox();
            this.lblPersonNameInscription = new System.Windows.Forms.Label();
            this.txtbPersonNameInscription = new System.Windows.Forms.TextBox();
            this.ckbApproved = new System.Windows.Forms.CheckBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblFinalDateInscription = new System.Windows.Forms.Label();
            this.bttnAddInscription = new System.Windows.Forms.Button();
            this.bttnReturnInscription = new System.Windows.Forms.Button();
            this.mtbStartDate = new System.Windows.Forms.MaskedTextBox();
            this.mtbFinalDate = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblSelectAreaInscription
            // 
            this.lblSelectAreaInscription.AutoSize = true;
            this.lblSelectAreaInscription.Location = new System.Drawing.Point(26, 22);
            this.lblSelectAreaInscription.Name = "lblSelectAreaInscription";
            this.lblSelectAreaInscription.Size = new System.Drawing.Size(167, 20);
            this.lblSelectAreaInscription.TabIndex = 0;
            this.lblSelectAreaInscription.Text = "Área a la que pertenece";
            // 
            // cmbSelectAreaInscription
            // 
            this.cmbSelectAreaInscription.FormattingEnabled = true;
            this.cmbSelectAreaInscription.Location = new System.Drawing.Point(26, 57);
            this.cmbSelectAreaInscription.Name = "cmbSelectAreaInscription";
            this.cmbSelectAreaInscription.Size = new System.Drawing.Size(397, 28);
            this.cmbSelectAreaInscription.TabIndex = 1;
            // 
            // lblSelectCourseInscription
            // 
            this.lblSelectCourseInscription.AutoSize = true;
            this.lblSelectCourseInscription.Location = new System.Drawing.Point(26, 110);
            this.lblSelectCourseInscription.Name = "lblSelectCourseInscription";
            this.lblSelectCourseInscription.Size = new System.Drawing.Size(161, 20);
            this.lblSelectCourseInscription.TabIndex = 2;
            this.lblSelectCourseInscription.Text = "Curso al que pertenece";
            // 
            // cmbSelectCourseInscription
            // 
            this.cmbSelectCourseInscription.FormattingEnabled = true;
            this.cmbSelectCourseInscription.Location = new System.Drawing.Point(26, 146);
            this.cmbSelectCourseInscription.Name = "cmbSelectCourseInscription";
            this.cmbSelectCourseInscription.Size = new System.Drawing.Size(397, 28);
            this.cmbSelectCourseInscription.TabIndex = 3;
            // 
            // lblPersonIDInscription
            // 
            this.lblPersonIDInscription.AutoSize = true;
            this.lblPersonIDInscription.Location = new System.Drawing.Point(504, 22);
            this.lblPersonIDInscription.Name = "lblPersonIDInscription";
            this.lblPersonIDInscription.Size = new System.Drawing.Size(79, 20);
            this.lblPersonIDInscription.TabIndex = 4;
            this.lblPersonIDInscription.Text = "ID Persona";
            // 
            // txtbPersonIDInscription
            // 
            this.txtbPersonIDInscription.Location = new System.Drawing.Point(504, 57);
            this.txtbPersonIDInscription.Name = "txtbPersonIDInscription";
            this.txtbPersonIDInscription.ReadOnly = true;
            this.txtbPersonIDInscription.Size = new System.Drawing.Size(234, 27);
            this.txtbPersonIDInscription.TabIndex = 5;
            // 
            // lblPersonNameInscription
            // 
            this.lblPersonNameInscription.AutoSize = true;
            this.lblPersonNameInscription.Location = new System.Drawing.Point(504, 110);
            this.lblPersonNameInscription.Name = "lblPersonNameInscription";
            this.lblPersonNameInscription.Size = new System.Drawing.Size(158, 20);
            this.lblPersonNameInscription.TabIndex = 6;
            this.lblPersonNameInscription.Text = "Nombre de la persona";
            // 
            // txtbPersonNameInscription
            // 
            this.txtbPersonNameInscription.Location = new System.Drawing.Point(504, 146);
            this.txtbPersonNameInscription.Name = "txtbPersonNameInscription";
            this.txtbPersonNameInscription.ReadOnly = true;
            this.txtbPersonNameInscription.Size = new System.Drawing.Size(498, 27);
            this.txtbPersonNameInscription.TabIndex = 7;
            // 
            // ckbApproved
            // 
            this.ckbApproved.AutoSize = true;
            this.ckbApproved.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ckbApproved.Location = new System.Drawing.Point(26, 205);
            this.ckbApproved.Name = "ckbApproved";
            this.ckbApproved.Size = new System.Drawing.Size(96, 24);
            this.ckbApproved.TabIndex = 9;
            this.ckbApproved.Text = "¿Aprobó?";
            this.ckbApproved.UseVisualStyleBackColor = false;
            this.ckbApproved.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(26, 260);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(108, 20);
            this.lblStartDate.TabIndex = 10;
            this.lblStartDate.Text = "Fecha de Inicio";
            // 
            // lblFinalDateInscription
            // 
            this.lblFinalDateInscription.AutoSize = true;
            this.lblFinalDateInscription.Location = new System.Drawing.Point(26, 338);
            this.lblFinalDateInscription.Name = "lblFinalDateInscription";
            this.lblFinalDateInscription.Size = new System.Drawing.Size(91, 20);
            this.lblFinalDateInscription.TabIndex = 13;
            this.lblFinalDateInscription.Text = "Fecha de Fin";
            // 
            // bttnAddInscription
            // 
            this.bttnAddInscription.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnAddInscription.Location = new System.Drawing.Point(440, 419);
            this.bttnAddInscription.Name = "bttnAddInscription";
            this.bttnAddInscription.Size = new System.Drawing.Size(97, 27);
            this.bttnAddInscription.TabIndex = 15;
            this.bttnAddInscription.Text = "Guardar";
            this.bttnAddInscription.UseVisualStyleBackColor = false;
            // 
            // bttnReturnInscription
            // 
            this.bttnReturnInscription.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnReturnInscription.Location = new System.Drawing.Point(565, 419);
            this.bttnReturnInscription.Name = "bttnReturnInscription";
            this.bttnReturnInscription.Size = new System.Drawing.Size(97, 27);
            this.bttnReturnInscription.TabIndex = 16;
            this.bttnReturnInscription.Text = "Regresar";
            this.bttnReturnInscription.UseVisualStyleBackColor = false;
            this.bttnReturnInscription.Click += new System.EventHandler(this.bttnReturnInscription_Click);
            // 
            // mtbStartDate
            // 
            this.mtbStartDate.Location = new System.Drawing.Point(26, 294);
            this.mtbStartDate.Mask = "00/00/0000";
            this.mtbStartDate.Name = "mtbStartDate";
            this.mtbStartDate.Size = new System.Drawing.Size(88, 27);
            this.mtbStartDate.TabIndex = 17;
            this.mtbStartDate.ValidatingType = typeof(System.DateTime);
            // 
            // mtbFinalDate
            // 
            this.mtbFinalDate.Location = new System.Drawing.Point(26, 373);
            this.mtbFinalDate.Mask = "00/00/0000";
            this.mtbFinalDate.Name = "mtbFinalDate";
            this.mtbFinalDate.Size = new System.Drawing.Size(88, 27);
            this.mtbFinalDate.TabIndex = 18;
            this.mtbFinalDate.ValidatingType = typeof(System.DateTime);
            // 
            // InscriptionReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 495);
            this.Controls.Add(this.mtbFinalDate);
            this.Controls.Add(this.mtbStartDate);
            this.Controls.Add(this.bttnReturnInscription);
            this.Controls.Add(this.bttnAddInscription);
            this.Controls.Add(this.lblFinalDateInscription);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.ckbApproved);
            this.Controls.Add(this.txtbPersonNameInscription);
            this.Controls.Add(this.lblPersonNameInscription);
            this.Controls.Add(this.txtbPersonIDInscription);
            this.Controls.Add(this.lblPersonIDInscription);
            this.Controls.Add(this.cmbSelectCourseInscription);
            this.Controls.Add(this.lblSelectCourseInscription);
            this.Controls.Add(this.cmbSelectAreaInscription);
            this.Controls.Add(this.lblSelectAreaInscription);
            this.Name = "InscriptionReg";
            this.Text = "InscriptionReg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectAreaInscription;
        private System.Windows.Forms.ComboBox cmbSelectAreaInscription;
        private System.Windows.Forms.Label lblSelectCourseInscription;
        private System.Windows.Forms.ComboBox cmbSelectCourseInscription;
        private System.Windows.Forms.Label lblPersonIDInscription;
        private System.Windows.Forms.TextBox txtbPersonIDInscription;
        private System.Windows.Forms.Label lblPersonNameInscription;
        private System.Windows.Forms.TextBox txtbPersonNameInscription;
        private System.Windows.Forms.CheckBox ckbApproved;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblFinalDateInscription;
        private System.Windows.Forms.Button bttnAddInscription;
        private System.Windows.Forms.Button bttnReturnInscription;
        private System.Windows.Forms.MaskedTextBox mtbStartDate;
        private System.Windows.Forms.MaskedTextBox mtbFinalDate;
    }
}