using Decorator._01_Example_CoffeeShop.Beverages;
using Decorator._01_Example_CoffeeShop.Beverages.Addons;
using Xunit;

namespace Decorator._01_Example_CoffeeShop
{
    public class Order
    {
        [Fact]
        public void DecafWithCaramelAndSoy() {
            var sut =
                new SoyAddonDecorator(new CaramelAddonDecorator(new Decaf()));

            Assert.Equal(3.00M, sut.CalculateTotal());
        }

        [Fact]
        public void EspressoWithDoubleCaramelAndSoy() {
            var sut =
                new SoyAddonDecorator(new CaramelAddonDecorator(new CaramelAddonDecorator(new Espresso())));

            Assert.Equal(4.25M, sut.CalculateTotal());
        }
    }
}
