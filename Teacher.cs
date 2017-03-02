using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_2
{
    class Teacher : Person
    {
        private DateTime _birthDate = DateTime.Today;

        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + BirthDate.ToShortDateString();
        }
    }
}
