namespace Decorator._01_Example_CoffeeShop.Beverages.Addons
{
    public class SoyAddonDecorator : AddonDecorator
    {
        public SoyAddonDecorator(Beverage beverage) : base(beverage, 0.25M, "Soy") {
        }
    }
}