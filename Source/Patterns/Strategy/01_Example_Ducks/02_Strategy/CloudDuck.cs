using Strategy._01_Example_Ducks._02_Strategy.FlyBehaviours;

namespace Strategy._01_Example_Ducks._02_Strategy
{
    public class CloudDuck : Duck
    {
        public CloudDuck() 
            : base(
                  flyBehaviour: new GlidingFlyBehaviour()
            ) {
        }
    }
}
