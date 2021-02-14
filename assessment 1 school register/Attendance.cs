using System;
using System.Collections.Generic;
using System.Text;

namespace assessment_1_school_register
{
    class Attendance
    {
        private DateTime date = DateTime.Now;
        private string dayoftheweek;
        private string attendaced;
        private int minlate;

        public Attendance(DateTime date, string attendaced)
        {
            this.date = date;
            this.attendaced = attendaced;
            dayoftheweek = date.ToString("dddd");
        }

        public int getminlate()
        {
            return minlate;
        }
        public string getday()
        {
            return dayoftheweek;
        }

    }
}
