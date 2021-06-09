
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
            this.txtbAdNumberES = new System.Windows.Forms.TextBox();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.txtbPersonIDES = new System.Windows.Forms.TextBox();
            this.lblPersonEmailES = new System.Windows.Forms.Label();
            this.txtbPersonEmailES = new System.Windows.Forms.TextBox();
            this.lblPersonNameES = new System.Windows.Forms.Label();
            this.txtbPersonNameES = new System.Windows.Forms.TextBox();
            this.bttnAddES = new System.Windows.Forms.Button();
            this.bttnImportDataEmailSent = new System.Windows.Forms.Button();
            this.bttnReturnEmailSent = new System.Windows.Forms.Button();
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
            // txtbAdNumberES
            // 
            this.txtbAdNumberES.Location = new System.Drawing.Point(41, 63);
            this.txtbAdNumberES.Name = "txtbAdNumberES";
            this.txtbAdNumberES.Size = new System.Drawing.Size(155, 27);
            this.txtbAdNumberES.TabIndex = 1;
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Location = new System.Drawing.Point(41, 192);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(134, 20);
            this.lblPersonID.TabIndex = 2;
            this.lblPersonID.Text = "Código de Persona";
            // 
            // txtbPersonIDES
            // 
            this.txtbPersonIDES.Location = new System.Drawing.Point(41, 228);
            this.txtbPersonIDES.Name = "txtbPersonIDES";
            this.txtbPersonIDES.Size = new System.Drawing.Size(155, 27);
            this.txtbPersonIDES.TabIndex = 3;
            // 
            // lblPersonEmailES
            // 
            this.lblPersonEmailES.AutoSize = true;
            this.lblPersonEmailES.Location = new System.Drawing.Point(41, 107);
            this.lblPersonEmailES.Name = "lblPersonEmailES";
            this.lblPersonEmailES.Size = new System.Drawing.Size(148, 20);
            this.lblPersonEmailES.TabIndex = 4;
            this.lblPersonEmailES.Text = "Correo de la persona";
            // 
            // txtbPersonEmailES
            // 
            this.txtbPersonEmailES.Location = new System.Drawing.Point(41, 139);
            this.txtbPersonEmailES.Name = "txtbPersonEmailES";
            this.txtbPersonEmailES.Size = new System.Drawing.Size(371, 27);
            this.txtbPersonEmailES.TabIndex = 5;
            // 
            // lblPersonNameES
            // 
            this.lblPersonNameES.AutoSize = true;
            this.lblPersonNameES.Location = new System.Drawing.Point(41, 286);
            this.lblPersonNameES.Name = "lblPersonNameES";
            this.lblPersonNameES.Size = new System.Drawing.Size(158, 20);
            this.lblPersonNameES.TabIndex = 6;
            this.lblPersonNameES.Text = "Nombre de la persona";
            // 
            // txtbPersonNameES
            // 
            this.txtbPersonNameES.Location = new System.Drawing.Point(41, 318);
            this.txtbPersonNameES.Name = "txtbPersonNameES";
            this.txtbPersonNameES.Size = new System.Drawing.Size(371, 27);
            this.txtbPersonNameES.TabIndex = 7;
            // 
            // bttnAddES
            // 
            this.bttnAddES.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnAddES.Location = new System.Drawing.Point(238, 377);
            this.bttnAddES.Name = "bttnAddES";
            this.bttnAddES.Size = new System.Drawing.Size(87, 29);
            this.bttnAddES.TabIndex = 8;
            this.bttnAddES.Text = "Guardar";
            this.bttnAddES.UseVisualStyleBackColor = false;
            // 
            // bttnImportDataEmailSent
            // 
            this.bttnImportDataEmailSent.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnImportDataEmailSent.Location = new System.Drawing.Point(350, 377);
            this.bttnImportDataEmailSent.Name = "bttnImportDataEmailSent";
            this.bttnImportDataEmailSent.Size = new System.Drawing.Size(138, 29);
            this.bttnImportDataEmailSent.TabIndex = 9;
            this.bttnImportDataEmailSent.Text = "Importar datos";
            this.bttnImportDataEmailSent.UseVisualStyleBackColor = false;
            // 
            // bttnReturnEmailSent
            // 
            this.bttnReturnEmailSent.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnReturnEmailSent.Location = new System.Drawing.Point(518, 377);
            this.bttnReturnEmailSent.Name = "bttnReturnEmailSent";
            this.bttnReturnEmailSent.Size = new System.Drawing.Size(87, 29);
            this.bttnReturnEmailSent.TabIndex = 10;
            this.bttnReturnEmailSent.Text = "Regresar";
            this.bttnReturnEmailSent.UseVisualStyleBackColor = false;
            this.bttnReturnEmailSent.Click += new System.EventHandler(this.bttnReturnEmailSent_Click);
            // 
            // EmailSentReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnReturnEmailSent);
            this.Controls.Add(this.bttnImportDataEmailSent);
            this.Controls.Add(this.bttnAddES);
            this.Controls.Add(this.txtbPersonNameES);
            this.Controls.Add(this.lblPersonNameES);
            this.Controls.Add(this.txtbPersonEmailES);
            this.Controls.Add(this.lblPersonEmailES);
            this.Controls.Add(this.txtbPersonIDES);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.txtbAdNumberES);
            this.Controls.Add(this.lblAdNumberES);
            this.Name = "EmailSentReg";
            this.Text = "EmailSentReg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdNumberES;
        private System.Windows.Forms.TextBox txtbAdNumberES;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.TextBox txtbPersonIDES;
        private System.Windows.Forms.Label lblPersonEmailES;
        private System.Windows.Forms.TextBox txtbPersonEmailES;
        private System.Windows.Forms.Label lblPersonNameES;
        private System.Windows.Forms.TextBox txtbPersonNameES;
        private System.Windows.Forms.Button bttnAddES;
        private System.Windows.Forms.Button bttnImportDataEmailSent;
        private System.Windows.Forms.Button bttnReturnEmailSent;
    }
}