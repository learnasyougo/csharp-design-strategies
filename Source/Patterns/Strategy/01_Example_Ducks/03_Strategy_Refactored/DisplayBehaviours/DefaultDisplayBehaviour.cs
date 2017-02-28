using System;

namespace Strategy._01_Example_Ducks._03_Strategy_Refactored.DisplayBehaviours
{
    public class DefaultDisplayBehaviour : RelayDisplayBehaviour
    {
        public DefaultDisplayBehaviour() 
            : base(type => type.Name) {
        }
    }
}
