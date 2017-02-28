namespace Strategy._01_Example_Ducks._02_Strategy.FlyBehaviours
{
    public sealed class DefaultFlyBehaviour : RelayFlyBehaviour
    {
        public DefaultFlyBehaviour() 
            : base(() => "Regular Flying") {
        }
    }
}
