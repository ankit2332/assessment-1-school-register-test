using System;
using System.Collections.Generic;
using System.Text;

namespace assessment_1_school_register
{
    class Student
    {
        private string studentname;
        private string studentDOB;
        private string gender;
        private Attendance[] Attendances = new Attendance[180];
        int i = 0;

        public Student(string studentname, string studentDOB, string gender)
        {
            this.studentname = studentname;
            this.studentDOB = studentDOB;
            this.gender = gender;
        }
        
        public void addattendance(DateTime date, string attendance)
        {
            Attendances[i] = new Attendance(date, attendance);
        }

        public string getstudentname()
        {
            return studentname;
        }

        public string getstudentDOB()
        {
            return studentDOB;
        }

        public string getstudentgender()
        {
            return gender;
        }
    }
}
