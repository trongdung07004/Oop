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
        private string[] subjectsTaught;

        public Teacher(string teacherID, string[] subjectsTaught, string name, Date dateOfBirth, string gender) : base(name, dateOfBirth, gender)
        {
            this.teacherID = teacherID;
            this.subjectsTaught = subjectsTaught;
        }

        public string TeacherID { get => teacherID; set => teacherID = value; }
        public string[] SubjectsTaught { get => subjectsTaught; set => subjectsTaught = value; }
    }
}
