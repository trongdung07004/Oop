using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    internal class Teacher : Person
    {
        private string teacherID;
        private List<string> subjectsTaught;

        public Teacher(string teacherID, List<string> subjectsTaught, string name, Date dateOfBirth, string gender) : base(name, dateOfBirth, gender)
        {
            this.teacherID = teacherID;
            this.subjectsTaught = subjectsTaught;
        }

        public string TeacherID { get => teacherID; set => teacherID = value; }
        public List<string> SubjectsTaught { get => subjectsTaught; set => subjectsTaught = value; }
    }
}
