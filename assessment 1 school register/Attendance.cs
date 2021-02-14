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
        private int minuteslate;

        public Attendance(DateTime date, string attendaced, int minuteslate)
        {
            this.date = date;
            this.attendaced = attendaced;
            dayoftheweek = date.ToString("dddd");
        }

        public int getminlate()
        {
            return minuteslate;
        }
        public string getday()
        {
            return dayoftheweek;
        }

    }
}
