using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Final
{
    public class Person
    {
        private string name;
        private Date dateOfBirth;
        private string gender;

        public Person(string name, Date dateOfBirth, string gender)
        {
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
        }

        public string Name { get => name; set => name = value; }
        public Date DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Gender { get => gender; set => gender = value; }
    }
}
