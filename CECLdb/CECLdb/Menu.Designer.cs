
namespace CECLdb
{
    partial class Menu
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.bttnAddMenu = new System.Windows.Forms.Button();
            this.gpbAdd = new System.Windows.Forms.GroupBox();
            this.rbttnAddArea = new System.Windows.Forms.RadioButton();
            this.rbttnAddEmailSent = new System.Windows.Forms.RadioButton();
            this.bttnDeleteMenu = new System.Windows.Forms.Button();
            this.bttnModifyMenu = new System.Windows.Forms.Button();
            this.rbttnAddCourse = new System.Windows.Forms.RadioButton();
            this.rbttnAddAd = new System.Windows.Forms.RadioButton();
            this.rbttnAddInscription = new System.Windows.Forms.RadioButton();
            this.rbttnAddRegister = new System.Windows.Forms.RadioButton();
            this.rbttnAddPerson = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbttnSearchCourseorAd = new System.Windows.Forms.RadioButton();
            this.bttnSearchMenu = new System.Windows.Forms.Button();
            this.rbttnSearchPerson = new System.Windows.Forms.RadioButton();
            this.lblEscExit = new System.Windows.Forms.Label();
            this.gpbAdd.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(259, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(215, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Base de Datos CECL";
            // 
            // bttnAddMenu
            // 
            this.bttnAddMenu.BackColor = System.Drawing.Color.GreenYellow;
            this.bttnAddMenu.Location = new System.Drawing.Point(200, 56);
            this.bttnAddMenu.Name = "bttnAddMenu";
            this.bttnAddMenu.Size = new System.Drawing.Size(165, 34);
            this.bttnAddMenu.TabIndex = 1;
            this.bttnAddMenu.Text = "Agregar";
            this.bttnAddMenu.UseVisualStyleBackColor = false;
            this.bttnAddMenu.Click += new System.EventHandler(this.bttnAddMenu_Click);
            // 
            // gpbAdd
            // 
            this.gpbAdd.Controls.Add(this.rbttnAddArea);
            this.gpbAdd.Controls.Add(this.rbttnAddEmailSent);
            this.gpbAdd.Controls.Add(this.bttnDeleteMenu);
            this.gpbAdd.Controls.Add(this.bttnModifyMenu);
            this.gpbAdd.Controls.Add(this.rbttnAddCourse);
            this.gpbAdd.Controls.Add(this.rbttnAddAd);
            this.gpbAdd.Controls.Add(this.bttnAddMenu);
            this.gpbAdd.Controls.Add(this.rbttnAddInscription);
            this.gpbAdd.Controls.Add(this.rbttnAddRegister);
            this.gpbAdd.Controls.Add(this.rbttnAddPerson);
            this.gpbAdd.Location = new System.Drawing.Point(59, 73);
            this.gpbAdd.Name = "gpbAdd";
            this.gpbAdd.Size = new System.Drawing.Size(396, 288);
            this.gpbAdd.TabIndex = 2;
            this.gpbAdd.TabStop = false;
            this.gpbAdd.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbttnAddArea
            // 
            this.rbttnAddArea.AutoSize = true;
            this.rbttnAddArea.Location = new System.Drawing.Point(30, 194);
            this.rbttnAddArea.Name = "rbttnAddArea";
            this.rbttnAddArea.Size = new System.Drawing.Size(61, 24);
            this.rbttnAddArea.TabIndex = 6;
            this.rbttnAddArea.TabStop = true;
            this.rbttnAddArea.Text = "Área";
            this.rbttnAddArea.UseVisualStyleBackColor = true;
            // 
            // rbttnAddEmailSent
            // 
            this.rbttnAddEmailSent.AutoSize = true;
            this.rbttnAddEmailSent.Location = new System.Drawing.Point(30, 224);
            this.rbttnAddEmailSent.Name = "rbttnAddEmailSent";
            this.rbttnAddEmailSent.Size = new System.Drawing.Size(124, 24);
            this.rbttnAddEmailSent.TabIndex = 5;
            this.rbttnAddEmailSent.TabStop = true;
            this.rbttnAddEmailSent.Text = "Email Enviado";
            this.rbttnAddEmailSent.UseVisualStyleBackColor = true;
            this.rbttnAddEmailSent.CheckedChanged += new System.EventHandler(this.rbttnAddEmailSent_CheckedChanged);
            // 
            // bttnDeleteMenu
            // 
            this.bttnDeleteMenu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bttnDeleteMenu.Location = new System.Drawing.Point(200, 182);
            this.bttnDeleteMenu.Name = "bttnDeleteMenu";
            this.bttnDeleteMenu.Size = new System.Drawing.Size(165, 34);
            this.bttnDeleteMenu.TabIndex = 9;
            this.bttnDeleteMenu.Text = "Eliminar";
            this.bttnDeleteMenu.UseVisualStyleBackColor = false;
            // 
            // bttnModifyMenu
            // 
            this.bttnModifyMenu.BackColor = System.Drawing.Color.LemonChiffon;
            this.bttnModifyMenu.Location = new System.Drawing.Point(200, 116);
            this.bttnModifyMenu.Name = "bttnModifyMenu";
            this.bttnModifyMenu.Size = new System.Drawing.Size(165, 34);
            this.bttnModifyMenu.TabIndex = 7;
            this.bttnModifyMenu.Text = "Modificar";
            this.bttnModifyMenu.UseVisualStyleBackColor = false;
            this.bttnModifyMenu.Click += new System.EventHandler(this.bttnModifyMenu_Click);
            // 
            // rbttnAddCourse
            // 
            this.rbttnAddCourse.AutoSize = true;
            this.rbttnAddCourse.Location = new System.Drawing.Point(30, 164);
            this.rbttnAddCourse.Name = "rbttnAddCourse";
            this.rbttnAddCourse.Size = new System.Drawing.Size(67, 24);
            this.rbttnAddCourse.TabIndex = 4;
            this.rbttnAddCourse.TabStop = true;
            this.rbttnAddCourse.Text = "Curso";
            this.rbttnAddCourse.UseVisualStyleBackColor = true;
            // 
            // rbttnAddAd
            // 
            this.rbttnAddAd.AutoSize = true;
            this.rbttnAddAd.Location = new System.Drawing.Point(31, 116);
            this.rbttnAddAd.Name = "rbttnAddAd";
            this.rbttnAddAd.Size = new System.Drawing.Size(66, 24);
            this.rbttnAddAd.TabIndex = 3;
            this.rbttnAddAd.TabStop = true;
            this.rbttnAddAd.Text = "Aviso";
            this.rbttnAddAd.UseVisualStyleBackColor = true;
            this.rbttnAddAd.CheckedChanged += new System.EventHandler(this.rbttnAddAd_CheckedChanged);
            // 
            // rbttnAddInscription
            // 
            this.rbttnAddInscription.AutoSize = true;
            this.rbttnAddInscription.Location = new System.Drawing.Point(30, 86);
            this.rbttnAddInscription.Name = "rbttnAddInscription";
            this.rbttnAddInscription.Size = new System.Drawing.Size(101, 24);
            this.rbttnAddInscription.TabIndex = 2;
            this.rbttnAddInscription.TabStop = true;
            this.rbttnAddInscription.Text = "Inscripción";
            this.rbttnAddInscription.UseVisualStyleBackColor = true;
            // 
            // rbttnAddRegister
            // 
            this.rbttnAddRegister.AutoSize = true;
            this.rbttnAddRegister.Location = new System.Drawing.Point(30, 56);
            this.rbttnAddRegister.Name = "rbttnAddRegister";
            this.rbttnAddRegister.Size = new System.Drawing.Size(85, 24);
            this.rbttnAddRegister.TabIndex = 1;
            this.rbttnAddRegister.TabStop = true;
            this.rbttnAddRegister.Text = "Registro";
            this.rbttnAddRegister.UseVisualStyleBackColor = true;
            // 
            // rbttnAddPerson
            // 
            this.rbttnAddPerson.AutoSize = true;
            this.rbttnAddPerson.Location = new System.Drawing.Point(30, 26);
            this.rbttnAddPerson.Name = "rbttnAddPerson";
            this.rbttnAddPerson.Size = new System.Drawing.Size(81, 24);
            this.rbttnAddPerson.TabIndex = 0;
            this.rbttnAddPerson.TabStop = true;
            this.rbttnAddPerson.Text = "Persona";
            this.rbttnAddPerson.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbttnSearchCourseorAd);
            this.groupBox3.Controls.Add(this.bttnSearchMenu);
            this.groupBox3.Controls.Add(this.rbttnSearchPerson);
            this.groupBox3.Location = new System.Drawing.Point(494, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 182);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // rbttnSearchCourseorAd
            // 
            this.rbttnSearchCourseorAd.AutoSize = true;
            this.rbttnSearchCourseorAd.Location = new System.Drawing.Point(30, 56);
            this.rbttnSearchCourseorAd.Name = "rbttnSearchCourseorAd";
            this.rbttnSearchCourseorAd.Size = new System.Drawing.Size(118, 24);
            this.rbttnSearchCourseorAd.TabIndex = 4;
            this.rbttnSearchCourseorAd.TabStop = true;
            this.rbttnSearchCourseorAd.Text = "Curso o aviso";
            this.rbttnSearchCourseorAd.UseVisualStyleBackColor = true;
            // 
            // bttnSearchMenu
            // 
            this.bttnSearchMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.bttnSearchMenu.Location = new System.Drawing.Point(7, 118);
            this.bttnSearchMenu.Name = "bttnSearchMenu";
            this.bttnSearchMenu.Size = new System.Drawing.Size(165, 34);
            this.bttnSearchMenu.TabIndex = 11;
            this.bttnSearchMenu.Text = "Consultar";
            this.bttnSearchMenu.UseVisualStyleBackColor = false;
            this.bttnSearchMenu.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // rbttnSearchPerson
            // 
            this.rbttnSearchPerson.AutoSize = true;
            this.rbttnSearchPerson.Location = new System.Drawing.Point(30, 26);
            this.rbttnSearchPerson.Name = "rbttnSearchPerson";
            this.rbttnSearchPerson.Size = new System.Drawing.Size(81, 24);
            this.rbttnSearchPerson.TabIndex = 0;
            this.rbttnSearchPerson.TabStop = true;
            this.rbttnSearchPerson.Text = "Persona";
            this.rbttnSearchPerson.UseVisualStyleBackColor = true;
            // 
            // lblEscExit
            // 
            this.lblEscExit.AutoSize = true;
            this.lblEscExit.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblEscExit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEscExit.Location = new System.Drawing.Point(26, 17);
            this.lblEscExit.Name = "lblEscExit";
            this.lblEscExit.Size = new System.Drawing.Size(79, 22);
            this.lblEscExit.TabIndex = 13;
            this.lblEscExit.Text = "(ESC) Salir";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 408);
            this.Controls.Add(this.lblEscExit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gpbAdd);
            this.Controls.Add(this.lblTitle);
            this.KeyPreview = true;
            this.Name = "Menu";
            this.Text = "Menu";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Exit);
            this.gpbAdd.ResumeLayout(false);
            this.gpbAdd.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button bttnAddMenu;
        private System.Windows.Forms.GroupBox gpbAdd;
        private System.Windows.Forms.RadioButton rbttnAddPerson;
        private System.Windows.Forms.RadioButton rbttnAddCourse;
        private System.Windows.Forms.RadioButton rbttnAddAd;
        private System.Windows.Forms.RadioButton rbttnAddInscription;
        private System.Windows.Forms.RadioButton rbttnAddRegister;
        private System.Windows.Forms.RadioButton rbttnAddArea;
        private System.Windows.Forms.RadioButton rbttnAddEmailSent;
        private System.Windows.Forms.Button bttnModifyMenu;
        private System.Windows.Forms.Button bttnDeleteMenu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbttnSearchCourseorAd;
        private System.Windows.Forms.RadioButton rbttnSearchPerson;
        private System.Windows.Forms.Button bttnSearchMenu;
        private System.Windows.Forms.Label lblEscExit;
    }
}