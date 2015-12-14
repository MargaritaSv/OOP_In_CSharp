using Interfaces.Interfaces;
using System;
using System.Collections.Generic;

namespace Interfaces
{
    public class Company : ICompanyStructure
    {
        private string name;
        private CEO ceo;
       
        public Company(string name, CEO ceo)
        {
            this.Name = name;
            this.CEO = ceo;
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
            }
        }


        public CEO CEO
        {
            get { return this.ceo; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("CEO", "A company must be CEO");
                }
                this.ceo = value;
            }
        }

        public ICollection<Deparment> Department { get; set; }

        public ICollection<IEmployee> Employee { get; set; }

    }
}
