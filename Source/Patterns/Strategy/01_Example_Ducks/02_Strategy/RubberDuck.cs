using Strategy._01_Example_Ducks._02_Strategy.FlyBehaviours;
using Strategy._01_Example_Ducks._02_Strategy.QuackBehaviours;

namespace Strategy._01_Example_Ducks._02_Strategy
{
    public class RubberDuck : Duck
    {
        public RubberDuck() : 
            base(
                quackBehaviour: new PlasticQuackBehaviour(),
                flyBehaviour: new NoFlyBehaviour()
            ) {
        }
    }
}
