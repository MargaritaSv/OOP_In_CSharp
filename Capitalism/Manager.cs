using System.Collections.Generic;

namespace Interfaces
{
    public class Manager : Employee, IBoss
    {
        public Manager(string firsdtname, string lastName,Deparment department)
            : base(firsdtname, lastName,department)
        {
            this.SubEmployee = new List<IEmployee>();
        }

        public Manager(string firsdtname, string lastName)
            : this(firsdtname, lastName,null)
        {
        }

        public ICollection<IEmployee> SubEmployee { get; }
    }
}
