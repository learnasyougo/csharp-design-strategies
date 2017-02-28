namespace Strategy._01_Example_Ducks._03_Strategy_Refactored.QuackBehaviours
{
    public class DefaultQuackBehaviour : RelayQuackBehaviour
    {
        public DefaultQuackBehaviour() 
            : base(() => "Regular Quack") {
        }
    }
}
