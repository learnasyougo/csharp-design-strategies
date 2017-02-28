using System;

namespace Strategy._01_Example_Ducks._03_Strategy_Refactored
{
    public interface IDisplayBehaviour
    {
        string Display<T>()
            where T : Duck;
        string Display(Type duckType);
    }
}
