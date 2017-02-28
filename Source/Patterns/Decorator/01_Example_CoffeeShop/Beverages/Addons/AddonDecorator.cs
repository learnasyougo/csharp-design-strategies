namespace Decorator._01_Example_CoffeeShop.Beverages.Addons
{
    public abstract class AddonDecorator : Beverage
    {
        protected Beverage _beverage;

        protected AddonDecorator(Beverage beverage, decimal price, string description) : base(price, description) {
            _beverage = beverage;
        }

        public override decimal CalculateTotal() {
            return _beverage.CalculateTotal() + Price;
        }
    }
}
