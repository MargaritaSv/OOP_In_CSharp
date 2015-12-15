using Interfaces;
using System.Collections.Generic;

namespace ConsoleApplication2.Interfaces
{
    public interface IDatabase
    {
        ICollection<Company> Comapanies { get;}

        IDictionary<IPaidPerson,decimal> TotalSalaries { get; }
    }
}
