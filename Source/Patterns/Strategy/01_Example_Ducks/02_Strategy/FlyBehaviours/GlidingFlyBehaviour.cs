namespace Strategy._01_Example_Ducks._02_Strategy.FlyBehaviours
{
    public class GlidingFlyBehaviour : RelayFlyBehaviour
    {
        public GlidingFlyBehaviour()
            : base(() => "Gliding Flight") {
        }
    }
}
