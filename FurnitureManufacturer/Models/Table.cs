namespace FurnitureManufacturer.Models
{
    using Interfaces;
    public class Table : FurnitureBase, ITable
    {
        private MaterialType type;
        private decimal length;
        private decimal widt;

        public Table(string model, MaterialType type, decimal price, decimal height, decimal length, decimal width)
            : base(model, type, price, height)
        {
            this.length = length;
            this.widt = width;
        }

        public decimal Area
        {
            get
            {
                return this.widt * this.length;
            }
        }

        public decimal Length
        {
            get { return this.length; }
        }

        public decimal Width
        {
            get { return this.widt; }
        }


        public override string ToString()
        {
            return base.ToString() + string.Format(", Length: {5}, Width: {6}, Area: {7}", this.Length, this.Width, this.Area);
        }
    }
}
