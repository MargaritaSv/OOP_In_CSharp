namespace FurnitureManufacturer.Models
{
    using Interfaces;
    public abstract class FurnitureBase : IFurniture
    {
        private decimal height;
        private MaterialType materialType; //za6toto taka ne mojem da napravim ot material ,koito ne e v enum
        private string model;
        private decimal price;

        public FurnitureBase(string model, MaterialType materialType, decimal price, decimal height)
        {
            this.Model = model;
            this.materialType = materialType;
            this.Price = price;
            this.Height = height;

        }
        public decimal Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public string Material
        {
            get { return this.materialType.ToString(); }
        }

        public string Model
        {
            get { return this.model; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentNullException("Model", "Model cannot be empty.");
                }
                if (value.Length < 3)
                {
                    throw new System.ArgumentException("Model", "Must be at least 3 characters.");
                }
                this.model = value;
            }

        }

        public decimal Price
        {
            get { return this.price; }

            set

            {
                //TODO  validation
                this.price = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Legs: {5}",
                this.GetType().Name, this.Model, this.Material, this.Price, this.Height);
        }
    }
}
