using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class ChiefTelephone : Employee
    {

        public ChiefTelephone(string firsdtname, string lastName, decimal salary)
            : base(firsdtname, lastName, salary)
        {
        }

        protected override double SalaryFactor
        {
            get
            {
                return 0.98;
            }
        }
    }
}
