namespace Strategy._01_Example_Ducks._02_Strategy.QuackBehaviours
{
    public class DefaultQuackBehaviour : RelayQuackBehaviour
    {
        public DefaultQuackBehaviour() 
            : base(() => "Regular Quack") {
        }
    }
}
