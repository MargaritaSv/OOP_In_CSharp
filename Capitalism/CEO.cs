using System.Collections.Generic;

namespace Interfaces.Interfaces
{
    public class CEO :PaidPerson, IBoss
    {

        public CEO(string firsdtname,string lastName,decimal salary)
            :base(firsdtname,lastName)
        {
            this.SubEmployee = new List<IEmployee>();
            this.Salary = salary;
        }

        public ICollection<IEmployee> SubEmployee { get; }
    }
}
