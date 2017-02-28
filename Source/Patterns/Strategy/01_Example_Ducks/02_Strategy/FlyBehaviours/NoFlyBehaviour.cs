namespace Strategy._01_Example_Ducks._02_Strategy.FlyBehaviours
{
    public class NoFlyBehaviour : RelayFlyBehaviour
    {
        public NoFlyBehaviour()
            : base(() => string.Empty) {
        }
    }
}
