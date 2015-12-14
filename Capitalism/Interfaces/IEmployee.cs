using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IEmployee :IPaidPerson
    {
        Deparment Department { get; set; } //IEmployee,dokato ne ne potrqbva da go slagame nqkude ne my dobavqme set

       // double SalaryFactory { get; }
    }
}
