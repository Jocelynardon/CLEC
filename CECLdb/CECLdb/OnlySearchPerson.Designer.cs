
namespace CLEC
{
    partial class OnlySearchPerson
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
            this.txtTextSearchPerson = new System.Windows.Forms.TextBox();
            this.bttnSearchPerson = new System.Windows.Forms.Button();
            this.cmbTypeSearchPerson = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtTextSearchPerson
            // 
            this.txtTextSearchPerson.Location = new System.Drawing.Point(40, 46);
            this.txtTextSearchPerson.Name = "txtTextSearchPerson";
            this.txtTextSearchPerson.Size = new System.Drawing.Size(352, 27);
            this.txtTextSearchPerson.TabIndex = 0;
            // 
            // bttnSearchPerson
            // 
            this.bttnSearchPerson.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.bttnSearchPerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnSearchPerson.Location = new System.Drawing.Point(629, 46);
            this.bttnSearchPerson.Name = "bttnSearchPerson";
            this.bttnSearchPerson.Size = new System.Drawing.Size(136, 27);
            this.bttnSearchPerson.TabIndex = 1;
            this.bttnSearchPerson.Text = "Buscar";
            this.bttnSearchPerson.UseVisualStyleBackColor = false;
            // 
            // cmbTypeSearchPerson
            // 
            this.cmbTypeSearchPerson.BackColor = System.Drawing.Color.AliceBlue;
            this.cmbTypeSearchPerson.FormattingEnabled = true;
            this.cmbTypeSearchPerson.Location = new System.Drawing.Point(408, 46);
            this.cmbTypeSearchPerson.Name = "cmbTypeSearchPerson";
            this.cmbTypeSearchPerson.Size = new System.Drawing.Size(198, 28);
            this.cmbTypeSearchPerson.TabIndex = 2;
            // 
            // OnlySearchPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbTypeSearchPerson);
            this.Controls.Add(this.bttnSearchPerson);
            this.Controls.Add(this.txtTextSearchPerson);
            this.Name = "OnlySearchPerson";
            this.Text = "OnlySearchPerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTextSearchPerson;
        private System.Windows.Forms.Button bttnSearchPerson;
        private System.Windows.Forms.ComboBox cmbTypeSearchPerson;
    }
}