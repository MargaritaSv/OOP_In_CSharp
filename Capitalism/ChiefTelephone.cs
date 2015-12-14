using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class ChiefTelephone : Employee
    {
        public ChiefTelephone(string firsdtname, string lastName, Deparment department)
            : base(firsdtname, lastName,department)
        {
        }

        public ChiefTelephone(string firsdtname, string lastName)
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
