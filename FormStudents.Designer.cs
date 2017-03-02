namespace Quiz_2
{
    partial class FormStudents
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
            this.groupBoxStudentList = new System.Windows.Forms.GroupBox();
            this.buttonShowStudents = new System.Windows.Forms.Button();
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.groupBoxAddStudent = new System.Windows.Forms.GroupBox();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxStudentList.SuspendLayout();
            this.groupBoxAddStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxStudentList
            // 
            this.groupBoxStudentList.Controls.Add(this.buttonShowStudents);
            this.groupBoxStudentList.Controls.Add(this.listBoxStudents);
            this.groupBoxStudentList.Location = new System.Drawing.Point(20, 12);
            this.groupBoxStudentList.Name = "groupBoxStudentList";
            this.groupBoxStudentList.Size = new System.Drawing.Size(225, 236);
            this.groupBoxStudentList.TabIndex = 3;
            this.groupBoxStudentList.TabStop = false;
            this.groupBoxStudentList.Text = "Student List";
            // 
            // buttonShowStudents
            // 
            this.buttonShowStudents.Location = new System.Drawing.Point(115, 198);
            this.buttonShowStudents.Name = "buttonShowStudents";
            this.buttonShowStudents.Size = new System.Drawing.Size(91, 23);
            this.buttonShowStudents.TabIndex = 1;
            this.buttonShowStudents.Text = "Show Students";
            this.buttonShowStudents.UseVisualStyleBackColor = true;
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.Location = new System.Drawing.Point(18, 20);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(188, 160);
            this.listBoxStudents.TabIndex = 0;
            // 
            // groupBoxAddStudent
            // 
            this.groupBoxAddStudent.Controls.Add(this.buttonAddStudent);
            this.groupBoxAddStudent.Controls.Add(this.label3);
            this.groupBoxAddStudent.Controls.Add(this.label2);
            this.groupBoxAddStudent.Controls.Add(this.label1);
            this.groupBoxAddStudent.Controls.Add(this.dtpDOB);
            this.groupBoxAddStudent.Controls.Add(this.textBoxLastName);
            this.groupBoxAddStudent.Controls.Add(this.textBoxFirstName);
            this.groupBoxAddStudent.Location = new System.Drawing.Point(264, 12);
            this.groupBoxAddStudent.Name = "groupBoxAddStudent";
            this.groupBoxAddStudent.Size = new System.Drawing.Size(279, 166);
            this.groupBoxAddStudent.TabIndex = 4;
            this.groupBoxAddStudent.TabStop = false;
            this.groupBoxAddStudent.Text = "Add Student";
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(158, 114);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(91, 23);
            this.buttonAddStudent.TabIndex = 1;
            this.buttonAddStudent.Text = "Add Student";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date of Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(18, 117);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(100, 20);
            this.dtpDOB.TabIndex = 2;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(149, 41);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 1;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(18, 41);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(422, 209);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Close Form";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 261);
            this.Controls.Add(this.groupBoxStudentList);
            this.Controls.Add(this.groupBoxAddStudent);
            this.Controls.Add(this.buttonClose);
            this.Name = "FormStudents";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.FormStudents_Load);
            this.groupBoxStudentList.ResumeLayout(false);
            this.groupBoxAddStudent.ResumeLayout(false);
            this.groupBoxAddStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxStudentList;
        private System.Windows.Forms.Button buttonShowStudents;
        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.GroupBox groupBoxAddStudent;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Button buttonClose;
    }
}