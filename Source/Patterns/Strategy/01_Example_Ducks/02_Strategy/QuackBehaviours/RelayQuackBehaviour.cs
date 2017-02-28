using System;

namespace Strategy._01_Example_Ducks._02_Strategy.QuackBehaviours
{
    public class RelayQuackBehaviour : IQuackBehaviour
    {
        private readonly Func<string> _quackBehaviourAlgorithm;

        public RelayQuackBehaviour(Func<string> quackBehaviourAlgorithm) {
            _quackBehaviourAlgorithm = quackBehaviourAlgorithm;
        }

        public string Quack() {
            return _quackBehaviourAlgorithm();
        }
    }
}
