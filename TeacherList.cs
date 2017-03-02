using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_2
{
    class TeacherList
    {
        private List<Teacher> teacher = new List<Teacher>();

        public void Add(Teacher tempTeacher)
        {
            teacher.Add(tempTeacher);
        }

        public void Add(string fName, string lName, DateTime bDay)
        {
            Teacher tempTeacher = new Teacher();
            tempTeacher.FirstName = fName;
            tempTeacher.LastName = lName;
            tempTeacher.BirthDate = bDay;
            teacher.Add(tempTeacher);
        }
        
        public Teacher this[int i]
        {
            get
            {
                if (i < 0)
                {
                    throw new ArgumentException("minimum index is 0.");
                }

                return teacher[i];
            }        
        }

        public Teacher GetTeacherByIndex(int i)
        {
            if (i < 0)
            {
                throw new ArgumentException("minimum index is 0.");
            }

            else
            {
                return teacher[i];
            }
        }

        public int Count()
        {
            return teacher.Count();
        }
    }
}
