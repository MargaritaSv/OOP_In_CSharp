namespace ConsoleApplication2
{
    using System.Collections.Generic;
    using Interfaces;

    using global::Interfaces;

    public class Database : IDatabase
    {
        public Database()
        {
            this.Comapanies = new List<Company>();
            this.TotalSalaries = new Dictionary<IPaidPerson, decimal>();
        }

        public ICollection<Company> Comapanies { get; private set; }

        public IDictionary<IPaidPerson, decimal> TotalSalaries { get; private set; }
    }
}
