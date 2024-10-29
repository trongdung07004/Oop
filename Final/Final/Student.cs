using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Final
{
    internal class Student : Person
    {
        private int studenID;
        private List<string> coursesEnrolled;
        private string grades;

        public Student(int studenID, List<string> coursesEnrolled, string grades, string name, Date dateOfBirth, string gender) : base(name, dateOfBirth, gender)
        {
            this.studenID = studenID;
            this.coursesEnrolled = coursesEnrolled;
            this.grades = grades;
        }

        public int StudenID { get => studenID; set => studenID = value; }
        public List<string> CoursesEnrolled { get => coursesEnrolled; set => coursesEnrolled = value; }
        public string Grades { get => grades; set => grades = value; }
    }
}
