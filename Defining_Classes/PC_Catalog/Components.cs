using System;

namespace PC_Catalog
{
    internal class Components
    {
        private string name;
        private string details;
        private decimal price;

        public Components(string name, decimal price)
            : this(name, null, price)
        {
        }

        public Components(string name, string details, decimal price)
        {
            this.name = name;
            this.details = details;
            this.price = price;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == null || value.Trim() == string.Empty)
                {
                    throw new ArgumentException("Value must be either null or non-empty string!");
                }
                this.name = value;
            }
        }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (value == null || value.Trim() == string.Empty)
                {
                    throw new ArgumentException("Value must be either null or non-empty string!");
                }
                this.details = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Cannot be negative.");
                }
                this.price = value;
            }
        }
    }
}
