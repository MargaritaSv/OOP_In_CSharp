namespace FurnitureManufacturer.Models
{
    using Interfaces;
    public class Chair : FurnitureBase, IChair
    {

        private int numberOfLegs;

        public Chair(string model, MaterialType materialType, decimal price, decimal height, int numberOfLegs)
            : base(model, materialType, price, height)
        {
            this.numberOfLegs = numberOfLegs;
        }

        public int NumberOfLegs
        {
            get { return this.numberOfLegs; }
        }

        public override string ToString()
        {
            return base.ToString() + ", Legs: {0}" + this.NumberOfLegs;
        }
    }
}
