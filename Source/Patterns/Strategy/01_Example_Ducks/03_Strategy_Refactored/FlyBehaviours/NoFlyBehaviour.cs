namespace Strategy._01_Example_Ducks._03_Strategy_Refactored.FlyBehaviours
{
    public class NoFlyBehaviour : RelayFlyBehaviour
    {
        public NoFlyBehaviour()
            : base(() => string.Empty) {
        }
    }
}
