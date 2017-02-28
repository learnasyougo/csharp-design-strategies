namespace Strategy._01_Example_Ducks._03_Strategy_Refactored.FlyBehaviours
{
    public class GlidingFlyBehaviour : RelayFlyBehaviour
    {
        public GlidingFlyBehaviour()
            : base(() => "Gliding Flight") {
        }
    }
}
