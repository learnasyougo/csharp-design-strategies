
namespace Decorator._01_Example_CoffeeShop
{
    public abstract class Beverage
    {
        public decimal Price { get; }

        public string Description
        {
            get; protected set;
        }

        public Beverage(decimal price, string description) {
            Price = price;
            Description = description;
        }

        public virtual decimal CalculateTotal() {
            return Price;
        }
    }
}
