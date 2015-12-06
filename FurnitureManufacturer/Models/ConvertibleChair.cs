namespace FurnitureManufacturer.Models
{
    using Interfaces;
    public class ConvertibleChair : Chair, IConvertibleChair
    {
        private bool isConverted = false;
        private decimal initionalH;  //trqbva da zapazim purvonachalnata stoinost


        public ConvertibleChair(string model, MaterialType materialType, decimal price, decimal height, int numberOfLegs)
            : base(model, materialType, price, height, numberOfLegs)
        {
            this.initionalH = height;
        }

        public void SetHeight(decimal height)
        {
            this.Height = height;
        }

        public bool IsConverted
        {
            get { return this.isConverted; }
        }

        public void Convert()
        {
            if (isConverted)
            {
                //converted--> normal
                this.Height = this.initionalH;
                this.isConverted = false;
            }
            else
            {
                //normal--> converted
                this.Height = 0.10m;
                this.isConverted = true;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " State: {0}" + (this.IsConverted ? "Converted" : "Normal");
        }
    }
}
