namespace Quiz_2
{
    partial class FormMain
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
            this.buttonTeachers = new System.Windows.Forms.Button();
            this.buttonStudents = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTeachers
            // 
            this.buttonTeachers.Location = new System.Drawing.Point(48, 37);
            this.buttonTeachers.Name = "buttonTeachers";
            this.buttonTeachers.Size = new System.Drawing.Size(75, 23);
            this.buttonTeachers.TabIndex = 0;
            this.buttonTeachers.Text = "Teachers";
            this.buttonTeachers.UseVisualStyleBackColor = true;
            this.buttonTeachers.Click += new System.EventHandler(this.buttonTeachers_Click);
            // 
            // buttonStudents
            // 
            this.buttonStudents.Location = new System.Drawing.Point(176, 37);
            this.buttonStudents.Name = "buttonStudents";
            this.buttonStudents.Size = new System.Drawing.Size(75, 23);
            this.buttonStudents.TabIndex = 1;
            this.buttonStudents.Text = "Students";
            this.buttonStudents.UseVisualStyleBackColor = true;
            this.buttonStudents.Click += new System.EventHandler(this.buttonStudents_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(176, 94);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 147);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonStudents);
            this.Controls.Add(this.buttonTeachers);
            this.Name = "FormMain";
            this.Text = "Inheritance";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTeachers;
        private System.Windows.Forms.Button buttonStudents;
        private System.Windows.Forms.Button buttonExit;
    }
}

