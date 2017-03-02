namespace Quiz_2
{
    partial class FormTeachers
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
            this.groupBoxTeacherList = new System.Windows.Forms.GroupBox();
            this.listBoxTeachers = new System.Windows.Forms.ListBox();
            this.buttonShowTeachers = new System.Windows.Forms.Button();
            this.groupBoxAddTeacher = new System.Windows.Forms.GroupBox();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddTeacher = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxTeacherList.SuspendLayout();
            this.groupBoxAddTeacher.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTeacherList
            // 
            this.groupBoxTeacherList.Controls.Add(this.buttonShowTeachers);
            this.groupBoxTeacherList.Controls.Add(this.listBoxTeachers);
            this.groupBoxTeacherList.Location = new System.Drawing.Point(12, 13);
            this.groupBoxTeacherList.Name = "groupBoxTeacherList";
            this.groupBoxTeacherList.Size = new System.Drawing.Size(225, 236);
            this.groupBoxTeacherList.TabIndex = 0;
            this.groupBoxTeacherList.TabStop = false;
            this.groupBoxTeacherList.Text = "Teacher List";
            // 
            // listBoxTeachers
            // 
            this.listBoxTeachers.FormattingEnabled = true;
            this.listBoxTeachers.Location = new System.Drawing.Point(18, 20);
            this.listBoxTeachers.Name = "listBoxTeachers";
            this.listBoxTeachers.Size = new System.Drawing.Size(188, 160);
            this.listBoxTeachers.TabIndex = 0;
            // 
            // buttonShowTeachers
            // 
            this.buttonShowTeachers.Location = new System.Drawing.Point(115, 198);
            this.buttonShowTeachers.Name = "buttonShowTeachers";
            this.buttonShowTeachers.Size = new System.Drawing.Size(91, 23);
            this.buttonShowTeachers.TabIndex = 1;
            this.buttonShowTeachers.Text = "Show Teachers";
            this.buttonShowTeachers.UseVisualStyleBackColor = true;
            // 
            // groupBoxAddTeacher
            // 
            this.groupBoxAddTeacher.Controls.Add(this.buttonAddTeacher);
            this.groupBoxAddTeacher.Controls.Add(this.label3);
            this.groupBoxAddTeacher.Controls.Add(this.label2);
            this.groupBoxAddTeacher.Controls.Add(this.label1);
            this.groupBoxAddTeacher.Controls.Add(this.dtpDOB);
            this.groupBoxAddTeacher.Controls.Add(this.textBoxLName);
            this.groupBoxAddTeacher.Controls.Add(this.textBoxFName);
            this.groupBoxAddTeacher.Location = new System.Drawing.Point(256, 13);
            this.groupBoxAddTeacher.Name = "groupBoxAddTeacher";
            this.groupBoxAddTeacher.Size = new System.Drawing.Size(279, 166);
            this.groupBoxAddTeacher.TabIndex = 1;
            this.groupBoxAddTeacher.TabStop = false;
            this.groupBoxAddTeacher.Text = "Add Teacher";
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(18, 41);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFName.TabIndex = 0;
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(149, 41);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLName.TabIndex = 1;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(18, 117);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(100, 20);
            this.dtpDOB.TabIndex = 2;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
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
            // buttonAddTeacher
            // 
            this.buttonAddTeacher.Location = new System.Drawing.Point(158, 114);
            this.buttonAddTeacher.Name = "buttonAddTeacher";
            this.buttonAddTeacher.Size = new System.Drawing.Size(91, 23);
            this.buttonAddTeacher.TabIndex = 1;
            this.buttonAddTeacher.Text = "Add Teacher";
            this.buttonAddTeacher.UseVisualStyleBackColor = true;
            this.buttonAddTeacher.Click += new System.EventHandler(this.buttonAddTeacher_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(414, 210);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close Form";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 261);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxAddTeacher);
            this.Controls.Add(this.groupBoxTeacherList);
            this.Name = "FormTeachers";
            this.Text = "Teachers";
            this.Load += new System.EventHandler(this.FormTeachers_Load);
            this.groupBoxTeacherList.ResumeLayout(false);
            this.groupBoxAddTeacher.ResumeLayout(false);
            this.groupBoxAddTeacher.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTeacherList;
        private System.Windows.Forms.Button buttonShowTeachers;
        private System.Windows.Forms.ListBox listBoxTeachers;
        private System.Windows.Forms.GroupBox groupBoxAddTeacher;
        private System.Windows.Forms.Button buttonAddTeacher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.Button buttonClose;
    }
}