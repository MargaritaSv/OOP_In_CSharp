using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Interfaces
{
    public interface IDatabase
    {
        ICollection<Company> Comapanies { get;}

        IDictionary<IPaidPerson,decimal> TotalSalaries { get; }
    }
}
