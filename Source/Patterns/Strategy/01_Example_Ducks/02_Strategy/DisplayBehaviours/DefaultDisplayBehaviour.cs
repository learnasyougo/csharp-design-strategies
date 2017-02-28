using System;

namespace Strategy._01_Example_Ducks._02_Strategy.DisplayBehaviours
{
    public class DefaultDisplayBehaviour : RelayDisplayBehaviour
    {
        public DefaultDisplayBehaviour() 
            : base(type => type.Name) {
        }
    }
}
