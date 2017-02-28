using System;

namespace Strategy._01_Example_Ducks._02_Strategy
{
    public interface IDisplayBehaviour
    {
        string Display<T>()
            where T : Duck;
        string Display(Type duckType);
    }
}
