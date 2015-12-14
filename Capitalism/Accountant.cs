using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Accountant : Employee
    {
        public Accountant(string firstName, string lastName, Deparment department)
            : base(firstName, lastName, department)
        {
        }

        public Accountant(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }
    }
}
