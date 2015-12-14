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
        }

        public ICollection<Company> Comapanies { get; set; }
    }
}
