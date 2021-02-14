using System;

namespace assessment_1_school_register
{
    class Program
    {
        private const string ankitDOB = "25/10/2003";
        private const string premsDOB = "19/2/2004";
        private const string thoaiDOB = "13/3/2004";
        private const string premiDOB = "17/6/2004";
        static void Main(string[] args)
        {
            FormGroup y12FB = new FormGroup("Y12FB", "FB");
            y12FB.AddStudent("Ankit", studentDOB: ankitDOB, "Male");
            y12FB.AddStudent("Prem.s", studentDOB: premsDOB, "Male");
            y12FB.AddStudent("Thoai", studentDOB: thoaiDOB , "Male");
            y12FB.AddStudent("Prem.i", studentDOB: premiDOB , "Male");
        }
    }
}
