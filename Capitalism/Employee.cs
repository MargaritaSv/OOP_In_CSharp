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
        public Deparment Department { get; }

        public Employee(string firsdtname, string lastName, decimal salary,Deparment department)
            :base(firsdtname,lastName,salary)
        {
            this.Department = department;
        }

        public Employee(string firsdtname, string lastName, decimal salary)
            : this(firsdtname,lastName,salary,null)
        {
        }

        protected virtual double SalaryFactor
        {
            get
            {
                return 1; //default=1;
            }
        }

    }
}
