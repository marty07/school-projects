using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_2
{
    class Student : Person
    {
        private DateTime _birthDate = DateTime.Today;
        private int _studentNum = 0;

        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        public int StudentNum
        {
            get { return _studentNum; }
            set { _studentNum = value; }
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + BirthDate.ToShortDateString();
        }
    }
}
