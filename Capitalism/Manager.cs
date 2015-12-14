using System.Collections.Generic;

namespace Interfaces
{
    public class Manager : Employee, IBoss
    {
        public Manager(string firsdtname, string lastName, decimal salary,Deparment department)
            : base(firsdtname, lastName, salary,department)
        {
            this.SubEmployee = new List<IEmployee>();
        }

        public ICollection<IEmployee> SubEmployee { get; }
    }
}
