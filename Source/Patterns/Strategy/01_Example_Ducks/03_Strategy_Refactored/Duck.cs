using Strategy._01_Example_Ducks._03_Strategy_Refactored.DisplayBehaviours;
using Strategy._01_Example_Ducks._03_Strategy_Refactored.FlyBehaviours;
using Strategy._01_Example_Ducks._03_Strategy_Refactored.QuackBehaviours;

namespace Strategy._01_Example_Ducks._03_Strategy_Refactored
{
    // sealed the class
    public sealed class Duck
    {
        private readonly IDisplayBehaviour _displayBehaviour;
        private readonly IQuackBehaviour _quackBehaviour;
        private readonly IFlyBehaviour _flyBehaviour;

        // How to inject the behaviour, in stead of having them hardcoded as in "02_Strategy"
        // Use constructor injection and get default behaviours if you want
        // And get rid of the concrete implementations of "SomeTypOfDuck.cs" etc..
        public Duck(
                IDisplayBehaviour displayBehaviour = null,
                IQuackBehaviour quackBehaviour = null,
                IFlyBehaviour flyBehaviour = null
            ) {
            _displayBehaviour = displayBehaviour ?? new DefaultDisplayBehaviour();
            _quackBehaviour = quackBehaviour ?? new DefaultQuackBehaviour();
            _flyBehaviour = flyBehaviour ?? new DefaultFlyBehaviour();
        }

        // Removed "virtual"
        public string Quack() {
            return _quackBehaviour.Quack();
        }

        // Removed "virtual"
        public string Display() {
            return _displayBehaviour.Display(this.GetType());
        }

        // Removed "virtual"
        public string Fly() {
            return _flyBehaviour.Fly();
        }
    }
}
