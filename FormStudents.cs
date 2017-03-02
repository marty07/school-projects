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
    public partial class FormStudents : Form
    {
        public FormStudents()
        {
            InitializeComponent();
        }

        private void ShowStudents()
        {
            listBoxStudents.Items.Clear();

            for (int i = 0; i < studentList.Count(); i++)
            {
                listBoxStudents.Items.Add(studentList[i]);
            }
        }

        private void ResetAllFields()
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            dtpDOB.ResetText();
            textBoxFirstName.Focus();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        StudentList studentList;

        private void FormStudents_Load(object sender, EventArgs e)
        {
            studentList = new StudentList();
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            Student tempStudent = new Student();
            tempStudent.FirstName = textBoxFirstName.Text;
            tempStudent.LastName = textBoxLastName.Text;
            tempStudent.BirthDate = dtpDOB.Value;

            studentList.Add(tempStudent);

            ShowStudents();
            ResetAllFields();            
        }        
    }
}
