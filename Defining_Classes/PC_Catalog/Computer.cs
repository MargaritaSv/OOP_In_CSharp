using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PC_Catalog
{
    class Computer
    {
        private string name;
        private decimal price;

        public Computer(string name)
            : this(name, new Dictionary<string, Components>())
        {
        }

        public Computer(string name, Dictionary<string, Components> components)
        {
            this.name = name;
            this.Components = components;
            this.price = 0.00m;
        }

        public Dictionary<string, Components> Components { get; private set; }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Trim() == string.Empty || value == null)
                {
                    throw new ArgumentException("Missing value.");
                }
                this.name = value;
            }
        }

        public decimal Price
        {
            get
            {
                if (this.Components.Count() == 0)
                {
                    this.price = 0.00m;
                }
                else
                {
                    this.price = 0.00m;
                    foreach (var x in Components)
                    {
                        this.price += x.Value.Price;
                    }
                }
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public void DisplayInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Name: {0}", this.Name));
            if (this.Components.Count == 0)
            {
                sb.AppendLine("Add components to PC configuration!");
            }
            else
            {
                foreach (var x in this.Components)
                {
                    sb.AppendLine(string.Format("{0} {1}, {2}\n Price {3:C}", x.Key, x.Value.Name, x.Value.Details ?? string.Empty, x.Value.Price));
                }
            }

            sb.AppendLine(string.Format("Total price {0:C}", this.Price));
            Console.WriteLine(sb.ToString());
        }
    }
}
