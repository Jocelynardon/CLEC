
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
            this.txtbName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.lblTelNumber = new System.Windows.Forms.Label();
            this.bttnAddPerson = new System.Windows.Forms.Button();
            this.bttnReturnPerson = new System.Windows.Forms.Button();
            this.mtbTelephonPerson = new System.Windows.Forms.MaskedTextBox();
            this.bttnSearchPerson = new System.Windows.Forms.Button();
            this.bttnSavePerson = new System.Windows.Forms.Button();
            this.lblEscPerson = new System.Windows.Forms.Label();
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
            // txtbName
            // 
            this.txtbName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtbName.Location = new System.Drawing.Point(46, 76);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(439, 27);
            this.txtbName.TabIndex = 1;
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
            // txtbEmail
            // 
            this.txtbEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtbEmail.Location = new System.Drawing.Point(46, 191);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(439, 27);
            this.txtbEmail.TabIndex = 3;
            // 
            // lblTelNumber
            // 
            this.lblTelNumber.AutoSize = true;
            this.lblTelNumber.Location = new System.Drawing.Point(46, 271);
            this.lblTelNumber.Name = "lblTelNumber";
            this.lblTelNumber.Size = new System.Drawing.Size(67, 20);
            this.lblTelNumber.TabIndex = 4;
            this.lblTelNumber.Text = "Teléfono";
            // 
            // bttnAddPerson
            // 
            this.bttnAddPerson.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnAddPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnAddPerson.Location = new System.Drawing.Point(288, 371);
            this.bttnAddPerson.Name = "bttnAddPerson";
            this.bttnAddPerson.Size = new System.Drawing.Size(94, 29);
            this.bttnAddPerson.TabIndex = 6;
            this.bttnAddPerson.Text = "Agregar";
            this.bttnAddPerson.UseVisualStyleBackColor = false;
            // 
            // bttnReturnPerson
            // 
            this.bttnReturnPerson.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnReturnPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnReturnPerson.Location = new System.Drawing.Point(411, 371);
            this.bttnReturnPerson.Name = "bttnReturnPerson";
            this.bttnReturnPerson.Size = new System.Drawing.Size(94, 29);
            this.bttnReturnPerson.TabIndex = 7;
            this.bttnReturnPerson.Text = "Regresar";
            this.bttnReturnPerson.UseVisualStyleBackColor = false;
            this.bttnReturnPerson.Click += new System.EventHandler(this.bttnReturnPerson_Click);
            // 
            // mtbTelephonPerson
            // 
            this.mtbTelephonPerson.Location = new System.Drawing.Point(46, 294);
            this.mtbTelephonPerson.Mask = "0000-0000";
            this.mtbTelephonPerson.Name = "mtbTelephonPerson";
            this.mtbTelephonPerson.Size = new System.Drawing.Size(79, 27);
            this.mtbTelephonPerson.TabIndex = 8;
            // 
            // bttnSearchPerson
            // 
            this.bttnSearchPerson.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnSearchPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnSearchPerson.Location = new System.Drawing.Point(348, 294);
            this.bttnSearchPerson.Name = "bttnSearchPerson";
            this.bttnSearchPerson.Size = new System.Drawing.Size(94, 29);
            this.bttnSearchPerson.TabIndex = 9;
            this.bttnSearchPerson.Text = "Buscar";
            this.bttnSearchPerson.UseVisualStyleBackColor = false;
            this.bttnSearchPerson.Visible = false;
            // 
            // bttnSavePerson
            // 
            this.bttnSavePerson.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnSavePerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnSavePerson.Location = new System.Drawing.Point(288, 371);
            this.bttnSavePerson.Name = "bttnSavePerson";
            this.bttnSavePerson.Size = new System.Drawing.Size(94, 29);
            this.bttnSavePerson.TabIndex = 10;
            this.bttnSavePerson.Text = "Guardar";
            this.bttnSavePerson.UseVisualStyleBackColor = false;
            this.bttnSavePerson.Visible = false;
            // 
            // lblEscPerson
            // 
            this.lblEscPerson.AutoSize = true;
            this.lblEscPerson.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblEscPerson.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEscPerson.Location = new System.Drawing.Point(582, 27);
            this.lblEscPerson.Name = "lblEscPerson";
            this.lblEscPerson.Size = new System.Drawing.Size(165, 22);
            this.lblEscPerson.TabIndex = 11;
            this.lblEscPerson.Text = "(ESC) Regresar al Menú";
            // 
            // PersonReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEscPerson);
            this.Controls.Add(this.bttnSavePerson);
            this.Controls.Add(this.bttnSearchPerson);
            this.Controls.Add(this.mtbTelephonPerson);
            this.Controls.Add(this.bttnReturnPerson);
            this.Controls.Add(this.bttnAddPerson);
            this.Controls.Add(this.lblTelNumber);
            this.Controls.Add(this.txtbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.lblName);
            this.KeyPreview = true;
            this.Name = "PersonReg";
            this.Text = "PersonReg";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Access);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.Label lblTelNumber;
        private System.Windows.Forms.Button bttnAddPerson;
        private System.Windows.Forms.Button bttnReturnPerson;
        private System.Windows.Forms.MaskedTextBox mtbTelephonPerson;
        private System.Windows.Forms.Button bttnSearchPerson;
        private System.Windows.Forms.Button bttnSavePerson;
        private System.Windows.Forms.Label lblEscPerson;
    }
}