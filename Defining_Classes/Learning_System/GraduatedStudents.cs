using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_System
{
    class GraduatedStudents : Students
    {
        public GraduatedStudents(string firstName,string secName,int age,int number,double avg)
            : base(firstName,secName,age,number,avg)
        {
        }
    }
}
