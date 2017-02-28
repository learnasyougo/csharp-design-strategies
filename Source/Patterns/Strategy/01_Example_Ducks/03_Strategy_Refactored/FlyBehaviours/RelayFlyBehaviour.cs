using System;

namespace Strategy._01_Example_Ducks._03_Strategy_Refactored.FlyBehaviours
{
    public class RelayFlyBehaviour : IFlyBehaviour
    {
        private readonly Func<string> _flyBehaviourAlgorithm;

        public RelayFlyBehaviour(Func<string> flyBehaviourAlgorithm) {
            flyBehaviourAlgorithm = _flyBehaviourAlgorithm;
        }

        public string Fly() {
            return _flyBehaviourAlgorithm();
        }
    }
}
