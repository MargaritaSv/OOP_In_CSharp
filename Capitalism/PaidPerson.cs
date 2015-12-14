using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    using Interfaces;
    public abstract class PaidPerson : IPaidPerson
    {
        private string firstName;
        private string secName;
        private decimal salary;


        protected PaidPerson(string firsdtname, string lastName, decimal salary)
        {
            this.FirstName = firsdtname;
            this.LastName = lastName;
            this.Salary = salary;
        }

        public string FirstName
        {
            get { return this.firstName; }

            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2) //length tr da e sled null ina4e 6te grumne
                {
                    throw new ArgumentException("The name should be valid.");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.secName; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2) //length tr da e sled null ina4e 6te grumne
                {
                    throw new ArgumentException("The name should be valid.");
                }
                this.firstName = value;
            }
        }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("salary", "Salary cannot be zero in negative value");
                }
                this.salary = value;
            }
        }
    }
}
