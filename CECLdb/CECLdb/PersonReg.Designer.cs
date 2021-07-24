
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
            this.txtbNamePerson = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelNumber = new System.Windows.Forms.Label();
            this.bttnAddPerson = new System.Windows.Forms.Button();
            this.bttnReturnPerson = new System.Windows.Forms.Button();
            this.mtbTelephonPerson = new System.Windows.Forms.MaskedTextBox();
            this.bttnSearchPerson = new System.Windows.Forms.Button();
            this.lblEscPerson = new System.Windows.Forms.Label();
            this.txtEmailPerson = new System.Windows.Forms.TextBox();
            this.bttnImportPerson = new System.Windows.Forms.Button();
            this.lblLastNamePerson = new System.Windows.Forms.Label();
            this.txtbLastNamePerson = new System.Windows.Forms.TextBox();
            this.txtbCodePerson = new System.Windows.Forms.TextBox();
            this.lblCodePerson = new System.Windows.Forms.Label();
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
            // txtbNamePerson
            // 
            this.txtbNamePerson.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtbNamePerson.Location = new System.Drawing.Point(46, 76);
            this.txtbNamePerson.Name = "txtbNamePerson";
            this.txtbNamePerson.Size = new System.Drawing.Size(254, 27);
            this.txtbNamePerson.TabIndex = 1;
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
            this.bttnAddPerson.Location = new System.Drawing.Point(184, 371);
            this.bttnAddPerson.Name = "bttnAddPerson";
            this.bttnAddPerson.Size = new System.Drawing.Size(94, 29);
            this.bttnAddPerson.TabIndex = 6;
            this.bttnAddPerson.Text = "Agregar";
            this.bttnAddPerson.UseVisualStyleBackColor = false;
            this.bttnAddPerson.Click += new System.EventHandler(this.bttnAddPerson_Click);
            // 
            // bttnReturnPerson
            // 
            this.bttnReturnPerson.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnReturnPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnReturnPerson.Location = new System.Drawing.Point(296, 371);
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
            this.mtbTelephonPerson.Mask = "00000000";
            this.mtbTelephonPerson.Name = "mtbTelephonPerson";
            this.mtbTelephonPerson.Size = new System.Drawing.Size(79, 27);
            this.mtbTelephonPerson.TabIndex = 8;
            // 
            // bttnSearchPerson
            // 
            this.bttnSearchPerson.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnSearchPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnSearchPerson.Location = new System.Drawing.Point(296, 306);
            this.bttnSearchPerson.Name = "bttnSearchPerson";
            this.bttnSearchPerson.Size = new System.Drawing.Size(94, 29);
            this.bttnSearchPerson.TabIndex = 9;
            this.bttnSearchPerson.Text = "Buscar";
            this.bttnSearchPerson.UseVisualStyleBackColor = false;
            this.bttnSearchPerson.Visible = false;
            this.bttnSearchPerson.Click += new System.EventHandler(this.bttnSearchPerson_Click);
            // 
            // lblEscPerson
            // 
            this.lblEscPerson.AutoSize = true;
            this.lblEscPerson.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblEscPerson.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEscPerson.Location = new System.Drawing.Point(580, 30);
            this.lblEscPerson.Name = "lblEscPerson";
            this.lblEscPerson.Size = new System.Drawing.Size(165, 22);
            this.lblEscPerson.TabIndex = 11;
            this.lblEscPerson.Text = "(ESC) Regresar al Menú";
            // 
            // txtEmailPerson
            // 
            this.txtEmailPerson.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtEmailPerson.Location = new System.Drawing.Point(46, 197);
            this.txtEmailPerson.Name = "txtEmailPerson";
            this.txtEmailPerson.Size = new System.Drawing.Size(439, 27);
            this.txtEmailPerson.TabIndex = 12;
            // 
            // bttnImportPerson
            // 
            this.bttnImportPerson.BackColor = System.Drawing.Color.LightCoral;
            this.bttnImportPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnImportPerson.Location = new System.Drawing.Point(411, 371);
            this.bttnImportPerson.Name = "bttnImportPerson";
            this.bttnImportPerson.Size = new System.Drawing.Size(94, 29);
            this.bttnImportPerson.TabIndex = 13;
            this.bttnImportPerson.Text = "Importar";
            this.bttnImportPerson.UseVisualStyleBackColor = false;
            // 
            // lblLastNamePerson
            // 
            this.lblLastNamePerson.AutoSize = true;
            this.lblLastNamePerson.Location = new System.Drawing.Point(339, 40);
            this.lblLastNamePerson.Name = "lblLastNamePerson";
            this.lblLastNamePerson.Size = new System.Drawing.Size(66, 20);
            this.lblLastNamePerson.TabIndex = 14;
            this.lblLastNamePerson.Text = "Apellido";
            // 
            // txtbLastNamePerson
            // 
            this.txtbLastNamePerson.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtbLastNamePerson.Location = new System.Drawing.Point(339, 76);
            this.txtbLastNamePerson.Name = "txtbLastNamePerson";
            this.txtbLastNamePerson.Size = new System.Drawing.Size(254, 27);
            this.txtbLastNamePerson.TabIndex = 15;
            // 
            // txtbCodePerson
            // 
            this.txtbCodePerson.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtbCodePerson.Location = new System.Drawing.Point(546, 197);
            this.txtbCodePerson.Name = "txtbCodePerson";
            this.txtbCodePerson.Size = new System.Drawing.Size(166, 27);
            this.txtbCodePerson.TabIndex = 16;
            // 
            // lblCodePerson
            // 
            this.lblCodePerson.AutoSize = true;
            this.lblCodePerson.Location = new System.Drawing.Point(546, 151);
            this.lblCodePerson.Name = "lblCodePerson";
            this.lblCodePerson.Size = new System.Drawing.Size(58, 20);
            this.lblCodePerson.TabIndex = 17;
            this.lblCodePerson.Text = "Código";
            // 
            // PersonReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCodePerson);
            this.Controls.Add(this.txtbCodePerson);
            this.Controls.Add(this.txtbLastNamePerson);
            this.Controls.Add(this.lblLastNamePerson);
            this.Controls.Add(this.bttnImportPerson);
            this.Controls.Add(this.txtEmailPerson);
            this.Controls.Add(this.lblEscPerson);
            this.Controls.Add(this.bttnSearchPerson);
            this.Controls.Add(this.mtbTelephonPerson);
            this.Controls.Add(this.bttnReturnPerson);
            this.Controls.Add(this.bttnAddPerson);
            this.Controls.Add(this.lblTelNumber);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtbNamePerson);
            this.Controls.Add(this.lblName);
            this.KeyPreview = true;
            this.Name = "PersonReg";
            this.Text = "PersonReg";
            this.Load += new System.EventHandler(this.PersonReg_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Access);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtbNamePerson;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelNumber;
        private System.Windows.Forms.Button bttnAddPerson;
        private System.Windows.Forms.Button bttnReturnPerson;
        private System.Windows.Forms.MaskedTextBox mtbTelephonPerson;
        private System.Windows.Forms.Button bttnSearchPerson;
        private System.Windows.Forms.Label lblEscPerson;
        private System.Windows.Forms.TextBox txtEmailPerson;
        private System.Windows.Forms.Button bttnImportPerson;
        private System.Windows.Forms.Label lblLastNamePerson;
        private System.Windows.Forms.TextBox txtbLastNamePerson;
        private System.Windows.Forms.TextBox txtbCodePerson;
        private System.Windows.Forms.Label lblCodePerson;
    }
}