
namespace CECLdb
{
    partial class CourseReg
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
            this.lblSelectAreaCourse = new System.Windows.Forms.Label();
            this.cmbSelectArea = new System.Windows.Forms.ComboBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.txtbCourseName = new System.Windows.Forms.TextBox();
            this.bttnAddCourse = new System.Windows.Forms.Button();
            this.bttnReturnCourse = new System.Windows.Forms.Button();
            this.bttnSearchCourse = new System.Windows.Forms.Button();
            this.bttnSaveCourse = new System.Windows.Forms.Button();
            this.lblEscReturnMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSelectAreaCourse
            // 
            this.lblSelectAreaCourse.AutoSize = true;
            this.lblSelectAreaCourse.Location = new System.Drawing.Point(52, 64);
            this.lblSelectAreaCourse.Name = "lblSelectAreaCourse";
            this.lblSelectAreaCourse.Size = new System.Drawing.Size(167, 20);
            this.lblSelectAreaCourse.TabIndex = 0;
            this.lblSelectAreaCourse.Text = "Área a la que pertenece";
            this.lblSelectAreaCourse.Click += new System.EventHandler(this.lblSelectArea_Click);
            // 
            // cmbSelectArea
            // 
            this.cmbSelectArea.FormattingEnabled = true;
            this.cmbSelectArea.Location = new System.Drawing.Point(52, 108);
            this.cmbSelectArea.Name = "cmbSelectArea";
            this.cmbSelectArea.Size = new System.Drawing.Size(367, 28);
            this.cmbSelectArea.TabIndex = 1;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(47, 202);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(128, 20);
            this.lblCourseName.TabIndex = 2;
            this.lblCourseName.Text = "Nombre del curso";
            // 
            // txtbCourseName
            // 
            this.txtbCourseName.Location = new System.Drawing.Point(52, 246);
            this.txtbCourseName.Name = "txtbCourseName";
            this.txtbCourseName.Size = new System.Drawing.Size(358, 27);
            this.txtbCourseName.TabIndex = 3;
            // 
            // bttnAddCourse
            // 
            this.bttnAddCourse.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnAddCourse.Location = new System.Drawing.Point(293, 343);
            this.bttnAddCourse.Name = "bttnAddCourse";
            this.bttnAddCourse.Size = new System.Drawing.Size(108, 28);
            this.bttnAddCourse.TabIndex = 4;
            this.bttnAddCourse.Text = "Agregar";
            this.bttnAddCourse.UseVisualStyleBackColor = false;
            // 
            // bttnReturnCourse
            // 
            this.bttnReturnCourse.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnReturnCourse.Location = new System.Drawing.Point(416, 343);
            this.bttnReturnCourse.Name = "bttnReturnCourse";
            this.bttnReturnCourse.Size = new System.Drawing.Size(108, 28);
            this.bttnReturnCourse.TabIndex = 5;
            this.bttnReturnCourse.Text = "Regresar";
            this.bttnReturnCourse.UseVisualStyleBackColor = false;
            this.bttnReturnCourse.Click += new System.EventHandler(this.bttnReturnCourse_Click);
            // 
            // bttnSearchCourse
            // 
            this.bttnSearchCourse.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnSearchCourse.Location = new System.Drawing.Point(442, 246);
            this.bttnSearchCourse.Name = "bttnSearchCourse";
            this.bttnSearchCourse.Size = new System.Drawing.Size(108, 28);
            this.bttnSearchCourse.TabIndex = 6;
            this.bttnSearchCourse.Text = "Buscar";
            this.bttnSearchCourse.UseVisualStyleBackColor = false;
            this.bttnSearchCourse.Visible = false;
            // 
            // bttnSaveCourse
            // 
            this.bttnSaveCourse.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnSaveCourse.Location = new System.Drawing.Point(293, 343);
            this.bttnSaveCourse.Name = "bttnSaveCourse";
            this.bttnSaveCourse.Size = new System.Drawing.Size(108, 28);
            this.bttnSaveCourse.TabIndex = 7;
            this.bttnSaveCourse.Text = "Guardar";
            this.bttnSaveCourse.UseVisualStyleBackColor = false;
            this.bttnSaveCourse.Visible = false;
            // 
            // lblEscReturnMenu
            // 
            this.lblEscReturnMenu.AutoSize = true;
            this.lblEscReturnMenu.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblEscReturnMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEscReturnMenu.Location = new System.Drawing.Point(604, 39);
            this.lblEscReturnMenu.Name = "lblEscReturnMenu";
            this.lblEscReturnMenu.Size = new System.Drawing.Size(165, 22);
            this.lblEscReturnMenu.TabIndex = 8;
            this.lblEscReturnMenu.Text = "(ESC) Regresar al Menu";
            // 
            // CourseReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEscReturnMenu);
            this.Controls.Add(this.bttnSaveCourse);
            this.Controls.Add(this.bttnSearchCourse);
            this.Controls.Add(this.bttnReturnCourse);
            this.Controls.Add(this.bttnAddCourse);
            this.Controls.Add(this.txtbCourseName);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.cmbSelectArea);
            this.Controls.Add(this.lblSelectAreaCourse);
            this.KeyPreview = true;
            this.Name = "CourseReg";
            this.Text = "CourseReg";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Exit);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectAreaCourse;
        private System.Windows.Forms.ComboBox cmbSelectArea;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.TextBox txtbCourseName;
        private System.Windows.Forms.Button bttnAddCourse;
        private System.Windows.Forms.Button bttnReturnCourse;
        private System.Windows.Forms.Button bttnSearchCourse;
        private System.Windows.Forms.Button bttnSaveCourse;
        private System.Windows.Forms.Label lblEscReturnMenu;
    }
}