namespace Strategy._01_Example_Ducks._03_Strategy_Refactored.QuackBehaviours
{
    public class PlasticQuackBehaviour : RelayQuackBehaviour
    {
        public PlasticQuackBehaviour()
            : base(() => "Squeeck Quack") {
        }
    }
}
