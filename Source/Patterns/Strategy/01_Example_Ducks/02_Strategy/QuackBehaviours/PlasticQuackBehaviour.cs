namespace Strategy._01_Example_Ducks._02_Strategy.QuackBehaviours
{
    public class PlasticQuackBehaviour : RelayQuackBehaviour
    {
        public PlasticQuackBehaviour()
            : base(() => "Squeeck Quack") {
        }
    }
}
