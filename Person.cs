using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Person
    {
        public string Fname;
        public string Lname;
        public string city;
        public int YearOfBirth;

        public Person(string Fname, string Lname, int YearOfBirth, string city)
        {
            this.Fname = Fname;
            this.Lname = Lname;
            this.YearOfBirth = YearOfBirth;
            this.city = city;
        }


    }
}
