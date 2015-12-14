using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class CleaningLady : Employee
    {
        public CleaningLady(string firsdtname, string lastName, Deparment department)
            : base(firsdtname, lastName,department)
        {
        }

        public CleaningLady(string firsdtname, string lastName)
            : base(firsdtname, lastName)
        {
        }

        public override double SalaryFactor
        {
            get
            {
                return 0.98;
            }
        }
    }
}
