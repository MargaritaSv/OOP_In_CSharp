using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_System
{
    class CurrentStudents: Students
    {
        private string currentCourse;

        public CurrentStudents(string fName,string secName,int age,int number,double avgGraduate,string currCourse)
            :base(fName,secName,age,number,avgGraduate)
        {
            this.currentCourse = currCourse;
        }

        public string CurrentCourse
        {
            get { return this.currentCourse; }
            set { this.currentCourse = value; }
        }

    }
}
