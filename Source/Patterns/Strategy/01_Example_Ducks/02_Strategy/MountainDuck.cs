using Strategy._01_Example_Ducks._02_Strategy.FlyBehaviours;

namespace Strategy._01_Example_Ducks._02_Strategy
{
    public class MountainDuck : Duck
    {
        public MountainDuck() : 
            base(                
                flyBehaviour: new GlidingFlyBehaviour()
            ) {
        }
    }
}
