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
        private int totalprententdays = 0;
        private int totalabsentdays = 0;
        private int totallatedays = 0;
        private int totalminuteslate = 0;
        private int i = 0;

        public Student(string studentname, string studentDOB, string gender)
        {
            this.studentname = studentname;
            this.studentDOB = studentDOB;
            this.gender = gender;
        }
        
        public void addattendance(DateTime date, string attendance, int minuteslate)
        {
            Attendances[i] = new Attendance(date, attendance, minuteslate);
            if(attendance == "yes")
            {
                totalprententdays++;
                if(minuteslate < 0)
                {
                    totallatedays++;
                    totalminuteslate = totalminuteslate + minuteslate;
                }
            }
            else
            {
                totalabsentdays++;
            }
            
        }



        public int gettotalnumberofprententsdays()
        {
            return totalprententdays;
        }

        public int gettotalnumberofabsentdays()
        {
            return totalabsentdays;
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

        public int gettotaldayslate()
        {
            return totallatedays;
        }
    }
}

