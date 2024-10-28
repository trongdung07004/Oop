using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class Administrator : Person
    {
        public Administrator(string name, Date dateOfBirth, string gender) : base(name, dateOfBirth, gender)
        {
        }
    }
}
