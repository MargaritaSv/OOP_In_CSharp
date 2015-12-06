namespace FurnitureManufacturer.Engine.Factories
{
    using System;

    using Interfaces;
    using Interfaces.Engine;
    using Models;

    public class FurnitureFactory : IFurnitureFactory
    {
        private const string Wooden = "wooden";
        private const string Leather = "leather";
        private const string Plastic = "plastic";
        private const string InvalidMaterialName = "Invalid material name: {0}";

        public ITable CreateTable(string model, string materialType, decimal price, decimal height, decimal length, decimal width)
        {
            MaterialType type = GetMaterialType(materialType);
            Table chair = new Table(model, type, price, height, length, width);
            return chair;
        }

        public IChair CreateChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            MaterialType type = GetMaterialType(materialType);
            Chair chair = new Chair( model,  type,  price,  height,  numberOfLegs);
            return chair;
        }

        public IAdjustableChair CreateAdjustableChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            MaterialType type = GetMaterialType(materialType);
            AdjustableChair chair = new AdjustableChair(model, type, price, height, numberOfLegs);
            return chair;
        }

        public IConvertibleChair CreateConvertibleChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            MaterialType type = GetMaterialType(materialType);
            ConvertibleChair chair = new ConvertibleChair(model, type, price, height, numberOfLegs);
            return chair;
        }

        private MaterialType GetMaterialType(string material)
        {
            switch (material)
            {
                case Wooden:
                    return MaterialType.Wooden;
                case Leather:
                    return MaterialType.Leather;
                case Plastic:
                    return MaterialType.Plastic;
                default:
                    throw new ArgumentException(string.Format(InvalidMaterialName, material));
            }
        }

    }
}
