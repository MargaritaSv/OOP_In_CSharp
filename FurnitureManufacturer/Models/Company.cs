using System.Collections.Generic;
using System.Linq;
using System.Text;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer
{
    public class Company : ICompany
    {
        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnituries = new List<IFurniture>(); //t.e. ako nqma mebeli da e prazen spisuk

        public Company(string name, string registrationNumber)
        {
            this.name = name;
            this.registrationNumber = registrationNumber;
        }

        public ICollection<IFurniture> Furnitures
        {
            get
            {
                return this.furnituries;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set { this.name = value; }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }
            set { this.registrationNumber = value; }
        }

        public void Add(IFurniture furniture)
        {
            this.furnituries.Add(furniture);
        }

        public string Catalog()
        {

            StringBuilder sb = new StringBuilder();
            string catalogHeader = string.Format("{0} - {1} - {2} {3}", this.Name, this.RegistrationNumber,
            this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
            this.Furnitures.Count != 1 ? "furnitures" : "furniture");

            sb.Append(catalogHeader);
            foreach (var f in this.furnituries.OrderBy(x => x.Price).ThenBy(x => x.Model))
            {
                sb.AppendLine();
                string fuunitureStr = f.ToString();
                sb.Append(fuunitureStr);
            }
            return sb.ToString();
        }

        public IFurniture Find(string model)
        {
            return this.furnituries.Where(x => x.Model.ToLowerInvariant() == model.ToLowerInvariant()).FirstOrDefault();
        }

        public void Remove(IFurniture furniture)
        {
            this.furnituries.Remove(furniture);
        }
    }
}