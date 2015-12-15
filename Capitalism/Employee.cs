using System;

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

        public double SalaryFactory 
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
