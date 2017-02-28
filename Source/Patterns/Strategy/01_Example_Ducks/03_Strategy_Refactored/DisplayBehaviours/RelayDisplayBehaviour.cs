using System;

namespace Strategy._01_Example_Ducks._03_Strategy_Refactored.DisplayBehaviours
{
    public class RelayDisplayBehaviour : IDisplayBehaviour
    {
        private readonly Func<Type, string> _displayBehaviour;

        public RelayDisplayBehaviour(Func<Type, string> displayBehaviour) {
            _displayBehaviour = displayBehaviour;
        }

        public string Display<T>() where T : Duck {
            return _displayBehaviour(typeof(T));
        }

        public string Display(Type duckType) {
            return _displayBehaviour(duckType);
        }
    }
}
