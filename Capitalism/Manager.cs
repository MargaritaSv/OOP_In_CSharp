using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Manager : PaidPerson, IBoss
    {

        public Manager(string firsdtname, string lastName, decimal salary)
            : base(firsdtname, lastName, salary)
        {
            this.SubEmployee = new List<IEmployee>();
        }


        public ICollection<IEmployee> SubEmployee { get; }

    }
}
