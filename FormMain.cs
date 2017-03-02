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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        FormStudents StudentForm;
        FormTeachers TeacherForm;

        private void FormMain_Load(object sender, EventArgs e)
        {
            StudentForm = new FormStudents();
            TeacherForm = new FormTeachers();
        }

        private void buttonTeachers_Click(object sender, EventArgs e)
        {
            TeacherForm.Show();
        }

        private void buttonStudents_Click(object sender, EventArgs e)
        {
            StudentForm.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
