using System;
using System.Collections.Generic;
using System.Text;

namespace assessment_1_school_register
{
    class FormGroup
    {
        private string formname;
        private string teachername;
        Student[] students = new Student[25];
        int numberofstudents = 25;
        int studentspresent;

        public FormGroup(string formname, string teachername)
        {
            this.formname = formname;
            this.teachername = teachername;
        }
        public void AddStudent(string StudentName, string DateOfBirth, string Gender)
        {
            if (studentspresent < numberofstudents)
            {
                students[studentspresent] = new Student(StudentName, DateOfBirth, Gender);
                studentspresent++;
            }
        }

        public void TakeAttendance(DateTime AttendanceDate)

        {
            for (int i = 0; i < numberofstudents; i++)
            {
                if (students[i] != null)
                {
                    Console.WriteLine(students[i].getstudentname() + " present(p), late(l), or absent(a)?");
                    string UserResponse = Console.ReadLine();
                    int LateMinutes = 0;


                    if (UserResponse == "l")
                    {
                        Console.WriteLine("How late were they(in minutes)?");
                        LateMinutes = Console.Read();

                    }
                    students[i].addattendance(AttendanceDate, UserResponse);
                }
            }
        }

    }
}
