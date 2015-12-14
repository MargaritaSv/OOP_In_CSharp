using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces
{
    public class CEO :PaidPerson, IBoss
    {

        public CEO(string firsdtname,string lastName, decimal salary)
            :base(firsdtname,lastName,salary)
        {
            this.SubEmployee = new List<IEmployee>();
        }

        public ICollection<IEmployee> SubEmployee { get; }
    }
}
