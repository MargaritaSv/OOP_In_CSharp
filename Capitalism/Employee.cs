using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Employee : PaidPerson, IEmployee
    {

        public Employee(string firsdtname, string lastName, Deparment department)
            : base(firsdtname, lastName)
        {
            this.Department = department;
        }

        public Employee(string firsdtname, string lastName)
            : this(firsdtname, lastName,null)
        {
        }

        public virtual double SalaryFactor
        {
            get
            {
                return 1;
            }
        }

        public Deparment Department { get; set; }

    }
}
