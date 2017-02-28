namespace Decorator._01_Example_CoffeeShop.Beverages.Addons
{
    public class CaramelAddonDecorator : AddonDecorator
    {
        public CaramelAddonDecorator(Beverage beverage) : base(beverage, 0.75M, "Caramel") {
        }
    }
}
