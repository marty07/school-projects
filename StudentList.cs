using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_2
{
    class StudentList
    {
        private List<Student> student = new List<Student>();

        public void Add(Student tempStudent)
        {
            student.Add(tempStudent);
        }

        public void Add(string fName, string lName, DateTime bDay)
        {
            Student tempStudent = new Student();
            tempStudent.FirstName = fName;
            tempStudent.LastName = lName;
            tempStudent.BirthDate = bDay;
            student.Add(tempStudent);
        }

        public Student this[int i]
        {
            get
            {
                if (i < 0)
                {
                    throw new ArgumentException("minimum index is 0.");
                }

                return student[i];
            }
        }

        public Student GetStudentByIndex(int i)
        {
            if(i < 0)
            {
                throw new ArgumentException("minimum index is 0.");
            }

            else
            {
                return student[i];
            }
        }

        public int Count()
        {
            return student.Count();
        }
    }
}

