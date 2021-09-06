
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
            this.rbttnStatus = new System.Windows.Forms.RadioButton();
            this.rbttnEmailSent = new System.Windows.Forms.RadioButton();
            this.PeopleSrcBtn = new System.Windows.Forms.Button();
            this.bttnReturn = new System.Windows.Forms.Button();
            this.gpbStatus = new System.Windows.Forms.GroupBox();
            this.rbttnInscribed = new System.Windows.Forms.RadioButton();
            this.ckbApproved = new System.Windows.Forms.CheckBox();
            this.rbttnConsulted = new System.Windows.Forms.RadioButton();
            this.lblType = new System.Windows.Forms.Label();
            this.rbttnCode = new System.Windows.Forms.RadioButton();
            this.gpbCode = new System.Windows.Forms.GroupBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.cmbSelectCourse = new System.Windows.Forms.ComboBox();
            this.cmbSelectArea = new System.Windows.Forms.ComboBox();
            this.rbttnCourse = new System.Windows.Forms.RadioButton();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.rbttnName = new System.Windows.Forms.RadioButton();
            this.rbttnEmail = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblEscReturnMenu = new System.Windows.Forms.Label();
            this.dgvPeopleSearch = new System.Windows.Forms.DataGridView();
            this.lblTotalResult = new System.Windows.Forms.Label();
            this.bttnEraserText = new System.Windows.Forms.Button();
            this.gpbStatus.SuspendLayout();
            this.gpbCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeopleSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // rbttnStatus
            // 
            this.rbttnStatus.AutoSize = true;
            this.rbttnStatus.Location = new System.Drawing.Point(338, 166);
            this.rbttnStatus.Name = "rbttnStatus";
            this.rbttnStatus.Size = new System.Drawing.Size(70, 24);
            this.rbttnStatus.TabIndex = 7;
            this.rbttnStatus.TabStop = true;
            this.rbttnStatus.Text = "Status";
            this.rbttnStatus.UseVisualStyleBackColor = true;
            this.rbttnStatus.CheckedChanged += new System.EventHandler(this.rbttnStatus_CheckedChanged_1);
            // 
            // rbttnEmailSent
            // 
            this.rbttnEmailSent.AutoSize = true;
            this.rbttnEmailSent.Location = new System.Drawing.Point(131, 166);
            this.rbttnEmailSent.Name = "rbttnEmailSent";
            this.rbttnEmailSent.Size = new System.Drawing.Size(144, 24);
            this.rbttnEmailSent.TabIndex = 8;
            this.rbttnEmailSent.TabStop = true;
            this.rbttnEmailSent.Text = "Correos Enviados";
            this.rbttnEmailSent.UseVisualStyleBackColor = true;
            this.rbttnEmailSent.CheckedChanged += new System.EventHandler(this.rbttnEmailSent_CheckedChanged);
            // 
            // PeopleSrcBtn
            // 
            this.PeopleSrcBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PeopleSrcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PeopleSrcBtn.Location = new System.Drawing.Point(12, 210);
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
            this.bttnReturn.Location = new System.Drawing.Point(131, 210);
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
            this.gpbStatus.Controls.Add(this.rbttnInscribed);
            this.gpbStatus.Controls.Add(this.ckbApproved);
            this.gpbStatus.Controls.Add(this.rbttnConsulted);
            this.gpbStatus.Location = new System.Drawing.Point(424, 156);
            this.gpbStatus.Name = "gpbStatus";
            this.gpbStatus.Size = new System.Drawing.Size(293, 83);
            this.gpbStatus.TabIndex = 11;
            this.gpbStatus.TabStop = false;
            this.gpbStatus.Visible = false;
            // 
            // rbttnInscribed
            // 
            this.rbttnInscribed.AutoSize = true;
            this.rbttnInscribed.Location = new System.Drawing.Point(26, 23);
            this.rbttnInscribed.Name = "rbttnInscribed";
            this.rbttnInscribed.Size = new System.Drawing.Size(101, 24);
            this.rbttnInscribed.TabIndex = 67;
            this.rbttnInscribed.TabStop = true;
            this.rbttnInscribed.Text = "Inscripción";
            this.rbttnInscribed.UseVisualStyleBackColor = true;
            this.rbttnInscribed.CheckedChanged += new System.EventHandler(this.rbttnInscribed_CheckedChanged);
            // 
            // ckbApproved
            // 
            this.ckbApproved.AutoSize = true;
            this.ckbApproved.Location = new System.Drawing.Point(59, 53);
            this.ckbApproved.Name = "ckbApproved";
            this.ckbApproved.Size = new System.Drawing.Size(99, 24);
            this.ckbApproved.TabIndex = 6;
            this.ckbApproved.Text = "Aprobado";
            this.ckbApproved.UseVisualStyleBackColor = true;
            this.ckbApproved.Visible = false;
            // 
            // rbttnConsulted
            // 
            this.rbttnConsulted.AutoSize = true;
            this.rbttnConsulted.Location = new System.Drawing.Point(153, 23);
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
            this.lblType.Location = new System.Drawing.Point(196, 67);
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
            this.gpbCode.Controls.Add(this.lblCourse);
            this.gpbCode.Controls.Add(this.lblArea);
            this.gpbCode.Controls.Add(this.cmbSelectCourse);
            this.gpbCode.Controls.Add(this.cmbSelectArea);
            this.gpbCode.Controls.Add(this.rbttnCourse);
            this.gpbCode.Controls.Add(this.txtCode);
            this.gpbCode.Controls.Add(this.rbttnName);
            this.gpbCode.Controls.Add(this.rbttnEmail);
            this.gpbCode.Controls.Add(this.rbttnCode);
            this.gpbCode.Controls.Add(this.lblType);
            this.gpbCode.Controls.Add(this.txtSearch);
            this.gpbCode.Location = new System.Drawing.Point(12, 19);
            this.gpbCode.Name = "gpbCode";
            this.gpbCode.Size = new System.Drawing.Size(1251, 131);
            this.gpbCode.TabIndex = 6;
            this.gpbCode.TabStop = false;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(519, 66);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(161, 20);
            this.lblCourse.TabIndex = 65;
            this.lblCourse.Text = "Curso al que pertenece";
            this.lblCourse.Visible = false;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(31, 66);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(167, 20);
            this.lblArea.TabIndex = 64;
            this.lblArea.Text = "Área a la que pertenece";
            this.lblArea.Visible = false;
            // 
            // cmbSelectCourse
            // 
            this.cmbSelectCourse.BackColor = System.Drawing.Color.MintCream;
            this.cmbSelectCourse.FormattingEnabled = true;
            this.cmbSelectCourse.Location = new System.Drawing.Point(519, 90);
            this.cmbSelectCourse.Name = "cmbSelectCourse";
            this.cmbSelectCourse.Size = new System.Drawing.Size(427, 28);
            this.cmbSelectCourse.TabIndex = 63;
            this.cmbSelectCourse.Visible = false;
            // 
            // cmbSelectArea
            // 
            this.cmbSelectArea.BackColor = System.Drawing.Color.MintCream;
            this.cmbSelectArea.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cmbSelectArea.FormattingEnabled = true;
            this.cmbSelectArea.Location = new System.Drawing.Point(31, 89);
            this.cmbSelectArea.Name = "cmbSelectArea";
            this.cmbSelectArea.Size = new System.Drawing.Size(427, 28);
            this.cmbSelectArea.TabIndex = 62;
            this.cmbSelectArea.Visible = false;
            this.cmbSelectArea.SelectionChangeCommitted += new System.EventHandler(this.cmbSelectArea_SelectionChangeCommitted);
            // 
            // rbttnCourse
            // 
            this.rbttnCourse.AutoSize = true;
            this.rbttnCourse.Location = new System.Drawing.Point(394, 26);
            this.rbttnCourse.Name = "rbttnCourse";
            this.rbttnCourse.Size = new System.Drawing.Size(92, 24);
            this.rbttnCourse.TabIndex = 50;
            this.rbttnCourse.TabStop = true;
            this.rbttnCourse.Text = "Por Curso";
            this.rbttnCourse.UseVisualStyleBackColor = true;
            this.rbttnCourse.CheckedChanged += new System.EventHandler(this.rbttnCourse_CheckedChanged);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(196, 90);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(123, 27);
            this.txtCode.TabIndex = 48;
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
            this.txtSearch.Location = new System.Drawing.Point(196, 90);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(298, 27);
            this.txtSearch.TabIndex = 49;
            this.txtSearch.WordWrap = false;
            // 
            // lblEscReturnMenu
            // 
            this.lblEscReturnMenu.AutoSize = true;
            this.lblEscReturnMenu.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblEscReturnMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEscReturnMenu.Location = new System.Drawing.Point(1112, 19);
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
            this.dgvPeopleSearch.Location = new System.Drawing.Point(18, 267);
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
            this.lblTotalResult.Location = new System.Drawing.Point(1032, 233);
            this.lblTotalResult.Name = "lblTotalResult";
            this.lblTotalResult.Size = new System.Drawing.Size(0, 20);
            this.lblTotalResult.TabIndex = 66;
            this.lblTotalResult.Visible = false;
            // 
            // bttnEraserText
            // 
            this.bttnEraserText.BackColor = System.Drawing.Color.LightYellow;
            this.bttnEraserText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnEraserText.Location = new System.Drawing.Point(247, 211);
            this.bttnEraserText.Name = "bttnEraserText";
            this.bttnEraserText.Size = new System.Drawing.Size(63, 26);
            this.bttnEraserText.TabIndex = 67;
            this.bttnEraserText.Text = "Borrar";
            this.bttnEraserText.UseVisualStyleBackColor = false;
            this.bttnEraserText.Click += new System.EventHandler(this.bttnEraserText_Click);
            // 
            // PeopleSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 609);
            this.Controls.Add(this.bttnEraserText);
            this.Controls.Add(this.lblTotalResult);
            this.Controls.Add(this.dgvPeopleSearch);
            this.Controls.Add(this.lblEscReturnMenu);
            this.Controls.Add(this.gpbStatus);
            this.Controls.Add(this.bttnReturn);
            this.Controls.Add(this.PeopleSrcBtn);
            this.Controls.Add(this.rbttnEmailSent);
            this.Controls.Add(this.rbttnStatus);
            this.Controls.Add(this.gpbCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "PeopleSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda por Persona";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ControlKey);
            this.gpbStatus.ResumeLayout(false);
            this.gpbStatus.PerformLayout();
            this.gpbCode.ResumeLayout(false);
            this.gpbCode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeopleSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbttnStatus;
        private System.Windows.Forms.RadioButton rbttnEmailSent;
        private System.Windows.Forms.Button PeopleSrcBtn;
        private System.Windows.Forms.Button bttnReturn;
        private System.Windows.Forms.GroupBox gpbStatus;
        private System.Windows.Forms.CheckBox ckbApproved;
        private System.Windows.Forms.RadioButton rbttnConsulted;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.RadioButton rbttnCode;
        private System.Windows.Forms.GroupBox gpbCode;
        private System.Windows.Forms.RadioButton rbttnName;
        private System.Windows.Forms.RadioButton rbttnEmail;
        private System.Windows.Forms.Label lblEscReturnMenu;
        private System.Windows.Forms.TextBox txtCode;
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
    }
}