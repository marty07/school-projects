using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_2
{
    public partial class FormTeachers : Form
    {
        public FormTeachers()
        {
            InitializeComponent();
        }

        private void ShowTeachers()
        {
            listBoxTeachers.Items.Clear();

            for (int i = 0; i < teacherList.Count(); i++)
            {
                listBoxTeachers.Items.Add(teacherList[i]);
            }
        }

        private void ResetAllFields()
        {
            textBoxFName.Clear();
            textBoxLName.Clear();
            dtpDOB.ResetText();
            textBoxFName.Focus();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        TeacherList teacherList;

        private void FormTeachers_Load(object sender, EventArgs e)
        {
            teacherList = new TeacherList();
        }

        private void buttonAddTeacher_Click(object sender, EventArgs e)
        {
            Teacher tempTeacher = new Teacher();

            tempTeacher.FirstName = textBoxFName.Text;
            tempTeacher.LastName = textBoxLName.Text;
            tempTeacher.BirthDate = dtpDOB.Value;

            teacherList.Add(tempTeacher);

            ShowTeachers();
            ResetAllFields();            
        }
    }
}
