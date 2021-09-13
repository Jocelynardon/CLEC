
namespace CECLdb
{
    partial class PeopleSearch
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
            this.rbttnEmailSent = new System.Windows.Forms.RadioButton();
            this.PeopleSrcBtn = new System.Windows.Forms.Button();
            this.bttnReturn = new System.Windows.Forms.Button();
            this.gpbStatus = new System.Windows.Forms.GroupBox();
            this.NotPassedrbtn = new System.Windows.Forms.RadioButton();
            this.Passedrbtn = new System.Windows.Forms.RadioButton();
            this.Allrbtn = new System.Windows.Forms.RadioButton();
            this.rbttnInscribed = new System.Windows.Forms.RadioButton();
            this.rbttnConsulted = new System.Windows.Forms.RadioButton();
            this.lblType = new System.Windows.Forms.Label();
            this.rbttnCode = new System.Windows.Forms.RadioButton();
            this.gpbCode = new System.Windows.Forms.GroupBox();
            this.rbttnName = new System.Windows.Forms.RadioButton();
            this.rbttnEmail = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.cmbSelectCourse = new System.Windows.Forms.ComboBox();
            this.cmbSelectArea = new System.Windows.Forms.ComboBox();
            this.rbttnCourse = new System.Windows.Forms.RadioButton();
            this.lblEscReturnMenu = new System.Windows.Forms.Label();
            this.dgvPeopleSearch = new System.Windows.Forms.DataGridView();
            this.lblTotalResult = new System.Windows.Forms.Label();
            this.bttnEraserText = new System.Windows.Forms.Button();
            this.CursoGBx = new System.Windows.Forms.GroupBox();
            this.gpbStatus.SuspendLayout();
            this.gpbCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeopleSearch)).BeginInit();
            this.CursoGBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbttnEmailSent
            // 
            this.rbttnEmailSent.AutoSize = true;
            this.rbttnEmailSent.Location = new System.Drawing.Point(142, 199);
            this.rbttnEmailSent.Name = "rbttnEmailSent";
            this.rbttnEmailSent.Size = new System.Drawing.Size(144, 24);
            this.rbttnEmailSent.TabIndex = 8;
            this.rbttnEmailSent.TabStop = true;
            this.rbttnEmailSent.Text = "Correos Enviados";
            this.rbttnEmailSent.UseVisualStyleBackColor = true;
            // 
            // PeopleSrcBtn
            // 
            this.PeopleSrcBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PeopleSrcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PeopleSrcBtn.Location = new System.Drawing.Point(23, 293);
            this.PeopleSrcBtn.Name = "PeopleSrcBtn";
            this.PeopleSrcBtn.Size = new System.Drawing.Size(94, 29);
            this.PeopleSrcBtn.TabIndex = 9;
            this.PeopleSrcBtn.Text = "BUSCAR";
            this.PeopleSrcBtn.UseVisualStyleBackColor = false;
            this.PeopleSrcBtn.Click += new System.EventHandler(this.PeopleSrcBtn_Click);
            // 
            // bttnReturn
            // 
            this.bttnReturn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnReturn.Location = new System.Drawing.Point(142, 293);
            this.bttnReturn.Name = "bttnReturn";
            this.bttnReturn.Size = new System.Drawing.Size(94, 29);
            this.bttnReturn.TabIndex = 10;
            this.bttnReturn.Text = "Regresar";
            this.bttnReturn.UseVisualStyleBackColor = false;
            this.bttnReturn.Click += new System.EventHandler(this.bttnReturn_Click);
            // 
            // gpbStatus
            // 
            this.gpbStatus.BackColor = System.Drawing.Color.LightYellow;
            this.gpbStatus.Controls.Add(this.NotPassedrbtn);
            this.gpbStatus.Controls.Add(this.Passedrbtn);
            this.gpbStatus.Controls.Add(this.Allrbtn);
            this.gpbStatus.Location = new System.Drawing.Point(439, 229);
            this.gpbStatus.Name = "gpbStatus";
            this.gpbStatus.Size = new System.Drawing.Size(352, 57);
            this.gpbStatus.TabIndex = 11;
            this.gpbStatus.TabStop = false;
            this.gpbStatus.Visible = false;
            // 
            // NotPassedrbtn
            // 
            this.NotPassedrbtn.AutoSize = true;
            this.NotPassedrbtn.Location = new System.Drawing.Point(196, 13);
            this.NotPassedrbtn.Name = "NotPassedrbtn";
            this.NotPassedrbtn.Size = new System.Drawing.Size(145, 24);
            this.NotPassedrbtn.TabIndex = 2;
            this.NotPassedrbtn.TabStop = true;
            this.NotPassedrbtn.Text = "No Ha Aprobado";
            this.NotPassedrbtn.UseVisualStyleBackColor = true;
            // 
            // Passedrbtn
            // 
            this.Passedrbtn.AutoSize = true;
            this.Passedrbtn.Location = new System.Drawing.Point(98, 13);
            this.Passedrbtn.Name = "Passedrbtn";
            this.Passedrbtn.Size = new System.Drawing.Size(81, 24);
            this.Passedrbtn.TabIndex = 1;
            this.Passedrbtn.TabStop = true;
            this.Passedrbtn.Text = "Aprobó";
            this.Passedrbtn.UseVisualStyleBackColor = true;
            // 
            // Allrbtn
            // 
            this.Allrbtn.AutoSize = true;
            this.Allrbtn.Location = new System.Drawing.Point(6, 13);
            this.Allrbtn.Name = "Allrbtn";
            this.Allrbtn.Size = new System.Drawing.Size(70, 24);
            this.Allrbtn.TabIndex = 0;
            this.Allrbtn.TabStop = true;
            this.Allrbtn.Text = "Todos";
            this.Allrbtn.UseVisualStyleBackColor = true;
            // 
            // rbttnInscribed
            // 
            this.rbttnInscribed.AutoSize = true;
            this.rbttnInscribed.Location = new System.Drawing.Point(415, 199);
            this.rbttnInscribed.Name = "rbttnInscribed";
            this.rbttnInscribed.Size = new System.Drawing.Size(101, 24);
            this.rbttnInscribed.TabIndex = 67;
            this.rbttnInscribed.TabStop = true;
            this.rbttnInscribed.Text = "Inscripción";
            this.rbttnInscribed.UseVisualStyleBackColor = true;
            this.rbttnInscribed.CheckedChanged += new System.EventHandler(this.rbttnInscribed_CheckedChanged);
            // 
            // rbttnConsulted
            // 
            this.rbttnConsulted.AutoSize = true;
            this.rbttnConsulted.Location = new System.Drawing.Point(310, 199);
            this.rbttnConsulted.Name = "rbttnConsulted";
            this.rbttnConsulted.Size = new System.Drawing.Size(87, 24);
            this.rbttnConsulted.TabIndex = 13;
            this.rbttnConsulted.TabStop = true;
            this.rbttnConsulted.Text = "Consulta";
            this.rbttnConsulted.UseVisualStyleBackColor = true;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(98, 65);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(58, 20);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Código";
            // 
            // rbttnCode
            // 
            this.rbttnCode.AutoSize = true;
            this.rbttnCode.Location = new System.Drawing.Point(6, 26);
            this.rbttnCode.Name = "rbttnCode";
            this.rbttnCode.Size = new System.Drawing.Size(102, 24);
            this.rbttnCode.TabIndex = 12;
            this.rbttnCode.TabStop = true;
            this.rbttnCode.Text = "Por código";
            this.rbttnCode.UseVisualStyleBackColor = true;
            this.rbttnCode.CheckedChanged += new System.EventHandler(this.rbttnCode_CheckedChanged_1);
            // 
            // gpbCode
            // 
            this.gpbCode.BackColor = System.Drawing.Color.Ivory;
            this.gpbCode.Controls.Add(this.rbttnName);
            this.gpbCode.Controls.Add(this.rbttnEmail);
            this.gpbCode.Controls.Add(this.rbttnCode);
            this.gpbCode.Controls.Add(this.lblType);
            this.gpbCode.Controls.Add(this.txtSearch);
            this.gpbCode.Location = new System.Drawing.Point(23, 40);
            this.gpbCode.Name = "gpbCode";
            this.gpbCode.Size = new System.Drawing.Size(521, 143);
            this.gpbCode.TabIndex = 6;
            this.gpbCode.TabStop = false;
            this.gpbCode.Text = "Por Persona";
            // 
            // rbttnName
            // 
            this.rbttnName.AutoSize = true;
            this.rbttnName.Location = new System.Drawing.Point(264, 26);
            this.rbttnName.Name = "rbttnName";
            this.rbttnName.Size = new System.Drawing.Size(110, 24);
            this.rbttnName.TabIndex = 14;
            this.rbttnName.TabStop = true;
            this.rbttnName.Text = "Por Nombre";
            this.rbttnName.UseVisualStyleBackColor = true;
            this.rbttnName.CheckedChanged += new System.EventHandler(this.rbttnName_CheckedChanged_1);
            // 
            // rbttnEmail
            // 
            this.rbttnEmail.AutoSize = true;
            this.rbttnEmail.Location = new System.Drawing.Point(135, 26);
            this.rbttnEmail.Name = "rbttnEmail";
            this.rbttnEmail.Size = new System.Drawing.Size(98, 24);
            this.rbttnEmail.TabIndex = 13;
            this.rbttnEmail.TabStop = true;
            this.rbttnEmail.Text = "Por correo";
            this.rbttnEmail.UseVisualStyleBackColor = true;
            this.rbttnEmail.CheckedChanged += new System.EventHandler(this.rbttnEmail_CheckedChanged_1);
            // 
            // txtSearch
            // 
            this.txtSearch.Enabled = false;
            this.txtSearch.Location = new System.Drawing.Point(98, 88);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(298, 27);
            this.txtSearch.TabIndex = 49;
            this.txtSearch.WordWrap = false;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Enabled = false;
            this.lblCourse.Location = new System.Drawing.Point(395, 68);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(161, 20);
            this.lblCourse.TabIndex = 65;
            this.lblCourse.Text = "Curso al que pertenece";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Enabled = false;
            this.lblArea.Location = new System.Drawing.Point(17, 68);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(167, 20);
            this.lblArea.TabIndex = 64;
            this.lblArea.Text = "Área a la que pertenece";
            // 
            // cmbSelectCourse
            // 
            this.cmbSelectCourse.BackColor = System.Drawing.Color.MintCream;
            this.cmbSelectCourse.Enabled = false;
            this.cmbSelectCourse.FormattingEnabled = true;
            this.cmbSelectCourse.Location = new System.Drawing.Point(395, 91);
            this.cmbSelectCourse.Name = "cmbSelectCourse";
            this.cmbSelectCourse.Size = new System.Drawing.Size(322, 28);
            this.cmbSelectCourse.TabIndex = 63;
            // 
            // cmbSelectArea
            // 
            this.cmbSelectArea.BackColor = System.Drawing.Color.MintCream;
            this.cmbSelectArea.Enabled = false;
            this.cmbSelectArea.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cmbSelectArea.FormattingEnabled = true;
            this.cmbSelectArea.Location = new System.Drawing.Point(17, 91);
            this.cmbSelectArea.Name = "cmbSelectArea";
            this.cmbSelectArea.Size = new System.Drawing.Size(349, 28);
            this.cmbSelectArea.TabIndex = 62;
            this.cmbSelectArea.SelectionChangeCommitted += new System.EventHandler(this.cmbSelectArea_SelectionChangeCommitted);
            // 
            // rbttnCourse
            // 
            this.rbttnCourse.AutoSize = true;
            this.rbttnCourse.Location = new System.Drawing.Point(17, 29);
            this.rbttnCourse.Name = "rbttnCourse";
            this.rbttnCourse.Size = new System.Drawing.Size(92, 24);
            this.rbttnCourse.TabIndex = 50;
            this.rbttnCourse.TabStop = true;
            this.rbttnCourse.Text = "Por Curso";
            this.rbttnCourse.UseVisualStyleBackColor = true;
            this.rbttnCourse.CheckedChanged += new System.EventHandler(this.rbttnCourse_CheckedChanged);
            // 
            // lblEscReturnMenu
            // 
            this.lblEscReturnMenu.AutoSize = true;
            this.lblEscReturnMenu.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblEscReturnMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEscReturnMenu.Location = new System.Drawing.Point(1143, 12);
            this.lblEscReturnMenu.Name = "lblEscReturnMenu";
            this.lblEscReturnMenu.Size = new System.Drawing.Size(165, 22);
            this.lblEscReturnMenu.TabIndex = 12;
            this.lblEscReturnMenu.Text = "(ESC) Regresar al Menu";
            // 
            // dgvPeopleSearch
            // 
            this.dgvPeopleSearch.AllowUserToAddRows = false;
            this.dgvPeopleSearch.AllowUserToDeleteRows = false;
            this.dgvPeopleSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPeopleSearch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPeopleSearch.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvPeopleSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPeopleSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeopleSearch.Location = new System.Drawing.Point(23, 339);
            this.dgvPeopleSearch.Name = "dgvPeopleSearch";
            this.dgvPeopleSearch.ReadOnly = true;
            this.dgvPeopleSearch.RowHeadersWidth = 51;
            this.dgvPeopleSearch.RowTemplate.Height = 29;
            this.dgvPeopleSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeopleSearch.Size = new System.Drawing.Size(1269, 330);
            this.dgvPeopleSearch.TabIndex = 61;
            // 
            // lblTotalResult
            // 
            this.lblTotalResult.AutoSize = true;
            this.lblTotalResult.Location = new System.Drawing.Point(1021, 316);
            this.lblTotalResult.Name = "lblTotalResult";
            this.lblTotalResult.Size = new System.Drawing.Size(41, 20);
            this.lblTotalResult.TabIndex = 66;
            this.lblTotalResult.Text = "Hola";
            this.lblTotalResult.Visible = false;
            // 
            // bttnEraserText
            // 
            this.bttnEraserText.BackColor = System.Drawing.Color.LightYellow;
            this.bttnEraserText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnEraserText.Location = new System.Drawing.Point(258, 294);
            this.bttnEraserText.Name = "bttnEraserText";
            this.bttnEraserText.Size = new System.Drawing.Size(63, 26);
            this.bttnEraserText.TabIndex = 67;
            this.bttnEraserText.Text = "Borrar";
            this.bttnEraserText.UseVisualStyleBackColor = false;
            this.bttnEraserText.Click += new System.EventHandler(this.bttnEraserText_Click);
            // 
            // CursoGBx
            // 
            this.CursoGBx.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CursoGBx.Controls.Add(this.rbttnCourse);
            this.CursoGBx.Controls.Add(this.cmbSelectArea);
            this.CursoGBx.Controls.Add(this.lblArea);
            this.CursoGBx.Controls.Add(this.lblCourse);
            this.CursoGBx.Controls.Add(this.cmbSelectCourse);
            this.CursoGBx.Location = new System.Drawing.Point(571, 37);
            this.CursoGBx.Name = "CursoGBx";
            this.CursoGBx.Size = new System.Drawing.Size(737, 145);
            this.CursoGBx.TabIndex = 68;
            this.CursoGBx.TabStop = false;
            this.CursoGBx.Text = "Por Curso";
            // 
            // PeopleSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 692);
            this.Controls.Add(this.rbttnInscribed);
            this.Controls.Add(this.rbttnConsulted);
            this.Controls.Add(this.CursoGBx);
            this.Controls.Add(this.bttnEraserText);
            this.Controls.Add(this.lblTotalResult);
            this.Controls.Add(this.dgvPeopleSearch);
            this.Controls.Add(this.lblEscReturnMenu);
            this.Controls.Add(this.gpbStatus);
            this.Controls.Add(this.bttnReturn);
            this.Controls.Add(this.PeopleSrcBtn);
            this.Controls.Add(this.rbttnEmailSent);
            this.Controls.Add(this.gpbCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "PeopleSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda Avanzada";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ControlKey);
            this.gpbStatus.ResumeLayout(false);
            this.gpbStatus.PerformLayout();
            this.gpbCode.ResumeLayout(false);
            this.gpbCode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeopleSearch)).EndInit();
            this.CursoGBx.ResumeLayout(false);
            this.CursoGBx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbttnEmailSent;
        private System.Windows.Forms.Button PeopleSrcBtn;
        private System.Windows.Forms.Button bttnReturn;
        private System.Windows.Forms.GroupBox gpbStatus;
        private System.Windows.Forms.RadioButton rbttnConsulted;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.RadioButton rbttnCode;
        private System.Windows.Forms.GroupBox gpbCode;
        private System.Windows.Forms.RadioButton rbttnName;
        private System.Windows.Forms.RadioButton rbttnEmail;
        private System.Windows.Forms.Label lblEscReturnMenu;
        private System.Windows.Forms.DataGridView dgvPeopleSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rbttnCourse;
        private System.Windows.Forms.ComboBox cmbSelectArea;
        private System.Windows.Forms.ComboBox cmbSelectCourse;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblTotalResult;
        private System.Windows.Forms.RadioButton rbttnInscribed;
        private System.Windows.Forms.Button bttnEraserText;
        private System.Windows.Forms.GroupBox CursoGBx;
        private System.Windows.Forms.RadioButton NotPassedrbtn;
        private System.Windows.Forms.RadioButton Passedrbtn;
        private System.Windows.Forms.RadioButton Allrbtn;
    }
}