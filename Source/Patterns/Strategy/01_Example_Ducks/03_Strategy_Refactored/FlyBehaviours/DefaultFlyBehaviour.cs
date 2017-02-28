namespace Strategy._01_Example_Ducks._03_Strategy_Refactored.FlyBehaviours
{
    public sealed class DefaultFlyBehaviour : RelayFlyBehaviour
    {
        public DefaultFlyBehaviour() 
            : base(() => "Regular Flying") {
        }
    }
}
