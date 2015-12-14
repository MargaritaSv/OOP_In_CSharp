using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    using Interfaces;
    public class Deparment : ICompanyStructure
    {
        private string name;
        private Manager manager;

        public Deparment(string name, Manager manager)
        {
            this.Name = name;
            this.Manager = manager;
            this.Employee = new List<IEmployee>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name", "The name cannot by empty.");
                }
                this.name = value;
            }
        }

        public Manager Manager
        {
            get { return this.manager; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("manager", "manager cannot be misinc");
                }
                this.manager = value;
            }
        }

        public ICollection<IEmployee> Employee { get; set; } //list ,za6toto ne znam kolko sa;kolekciq koqto ima indexator-IList s get i set
    }
}
