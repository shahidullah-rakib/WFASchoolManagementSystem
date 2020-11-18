namespace WFASchoolManagementSystem
{
    partial class formStudent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPersonalInfo = new System.Windows.Forms.Button();
            this.panelLibrary = new System.Windows.Forms.Panel();
            this.btnAllBooks = new System.Windows.Forms.Button();
            this.btnSearchBooks = new System.Windows.Forms.Button();
            this.btnLibrary = new System.Windows.Forms.Button();
            this.panelAcademics = new System.Windows.Forms.Panel();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.bthCourses = new System.Windows.Forms.Button();
            this.btnAcademics = new System.Windows.Forms.Button();
            this.btnStudentLogOut = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelLibrary.SuspendLayout();
            this.panelAcademics.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 143);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "- where leaders are created.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "AMERICAN INTERNATIONAL \r\nSCHOOL,BANGLADESH";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WFASchoolManagementSystem.Properties.Resources.Screenshot_4;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lblWelcome);
            this.panel2.Location = new System.Drawing.Point(718, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(562, 78);
            this.panel2.TabIndex = 2;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(145, 21);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(296, 36);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Student Dashboard : ";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.btnPersonalInfo);
            this.panel3.Controls.Add(this.panelLibrary);
            this.panel3.Controls.Add(this.btnLibrary);
            this.panel3.Controls.Add(this.panelAcademics);
            this.panel3.Controls.Add(this.btnAcademics);
            this.panel3.Controls.Add(this.btnStudentLogOut);
            this.panel3.Location = new System.Drawing.Point(0, 151);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(336, 687);
            this.panel3.TabIndex = 3;
            // 
            // btnPersonalInfo
            // 
            this.btnPersonalInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPersonalInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersonalInfo.Location = new System.Drawing.Point(0, 327);
            this.btnPersonalInfo.Name = "btnPersonalInfo";
            this.btnPersonalInfo.Size = new System.Drawing.Size(336, 57);
            this.btnPersonalInfo.TabIndex = 12;
            this.btnPersonalInfo.Text = "Personal Information";
            this.btnPersonalInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonalInfo.UseVisualStyleBackColor = false;
            this.btnPersonalInfo.Click += new System.EventHandler(this.btnPersonalInfo_Click);
            // 
            // panelLibrary
            // 
            this.panelLibrary.Controls.Add(this.btnAllBooks);
            this.panelLibrary.Controls.Add(this.btnSearchBooks);
            this.panelLibrary.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLibrary.Location = new System.Drawing.Point(0, 221);
            this.panelLibrary.Name = "panelLibrary";
            this.panelLibrary.Size = new System.Drawing.Size(336, 106);
            this.panelLibrary.TabIndex = 11;
            // 
            // btnAllBooks
            // 
            this.btnAllBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllBooks.Location = new System.Drawing.Point(0, 52);
            this.btnAllBooks.Name = "btnAllBooks";
            this.btnAllBooks.Size = new System.Drawing.Size(336, 52);
            this.btnAllBooks.TabIndex = 0;
            this.btnAllBooks.Text = "All Books";
            this.btnAllBooks.UseVisualStyleBackColor = true;
            this.btnAllBooks.Click += new System.EventHandler(this.btnAllBooks_Click);
            // 
            // btnSearchBooks
            // 
            this.btnSearchBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchBooks.Location = new System.Drawing.Point(0, 0);
            this.btnSearchBooks.Name = "btnSearchBooks";
            this.btnSearchBooks.Size = new System.Drawing.Size(336, 52);
            this.btnSearchBooks.TabIndex = 1;
            this.btnSearchBooks.Text = "Search Books";
            this.btnSearchBooks.UseVisualStyleBackColor = true;
            this.btnSearchBooks.Click += new System.EventHandler(this.btnSearchBooks_Click);
            // 
            // btnLibrary
            // 
            this.btnLibrary.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLibrary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLibrary.Location = new System.Drawing.Point(0, 164);
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.Size = new System.Drawing.Size(336, 57);
            this.btnLibrary.TabIndex = 10;
            this.btnLibrary.Text = "Library";
            this.btnLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLibrary.UseVisualStyleBackColor = false;
            this.btnLibrary.Click += new System.EventHandler(this.btnLibrary_Click);
            // 
            // panelAcademics
            // 
            this.panelAcademics.Controls.Add(this.btnCalendar);
            this.panelAcademics.Controls.Add(this.bthCourses);
            this.panelAcademics.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAcademics.Location = new System.Drawing.Point(0, 57);
            this.panelAcademics.Name = "panelAcademics";
            this.panelAcademics.Size = new System.Drawing.Size(336, 107);
            this.panelAcademics.TabIndex = 9;
            // 
            // btnCalendar
            // 
            this.btnCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalendar.Location = new System.Drawing.Point(0, 52);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(336, 55);
            this.btnCalendar.TabIndex = 3;
            this.btnCalendar.Text = "Calendar";
            this.btnCalendar.UseVisualStyleBackColor = true;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // bthCourses
            // 
            this.bthCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this.bthCourses.Location = new System.Drawing.Point(0, 0);
            this.bthCourses.Name = "bthCourses";
            this.bthCourses.Size = new System.Drawing.Size(336, 52);
            this.bthCourses.TabIndex = 1;
            this.bthCourses.Text = "Courses";
            this.bthCourses.UseVisualStyleBackColor = true;
            this.bthCourses.Click += new System.EventHandler(this.bthCourses_Click);
            // 
            // btnAcademics
            // 
            this.btnAcademics.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAcademics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAcademics.Location = new System.Drawing.Point(0, 0);
            this.btnAcademics.Name = "btnAcademics";
            this.btnAcademics.Size = new System.Drawing.Size(336, 57);
            this.btnAcademics.TabIndex = 2;
            this.btnAcademics.Text = "Academics";
            this.btnAcademics.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAcademics.UseVisualStyleBackColor = false;
            this.btnAcademics.Click += new System.EventHandler(this.btnAcademics_Click);
            // 
            // btnStudentLogOut
            // 
            this.btnStudentLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStudentLogOut.Location = new System.Drawing.Point(3, 639);
            this.btnStudentLogOut.Name = "btnStudentLogOut";
            this.btnStudentLogOut.Size = new System.Drawing.Size(98, 45);
            this.btnStudentLogOut.TabIndex = 0;
            this.btnStudentLogOut.Text = "Logout";
            this.btnStudentLogOut.UseVisualStyleBackColor = true;
            this.btnStudentLogOut.Click += new System.EventHandler(this.btnStudentLogOut_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.Menu;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(342, 151);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(935, 684);
            this.panel4.TabIndex = 4;
            // 
            // formStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1278, 838);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "formStudent";
            this.Text = "Student";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formStudent_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelLibrary.ResumeLayout(false);
            this.panelAcademics.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnStudentLogOut;
        private System.Windows.Forms.Button btnAcademics;
        private System.Windows.Forms.Panel panelLibrary;
        private System.Windows.Forms.Button btnAllBooks;
        private System.Windows.Forms.Button btnSearchBooks;
        private System.Windows.Forms.Button btnLibrary;
        private System.Windows.Forms.Panel panelAcademics;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Button bthCourses;
        private System.Windows.Forms.Button btnPersonalInfo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblWelcome;

    }
}