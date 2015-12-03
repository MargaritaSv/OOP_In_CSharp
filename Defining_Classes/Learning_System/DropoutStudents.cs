using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_System
{
    class DropoutStudents : Students
    {
        private string dropOutStudents;

        public DropoutStudents(string fN, string sN, int age, int number, double avg, string dropOut)
            : base(fN, sN, age, number, avg)
        {
            this.dropOutStudents = dropOut;
        }

        public string DropOutStudents
        {
            get { return this.dropOutStudents; }
            set { this.dropOutStudents = value; }
        }

        public void Reapply()
        {
            Console.WriteLine(base.ToString() + " dropout for " + this.dropOutStudents);
        }
    }
}
