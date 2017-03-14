using Bridge._01_Example_Printing_Before.Manuscripts;
using System.Collections.Generic;

namespace Bridge._01_Example_Printing_After
{
    public class ConsumingClient
    {
        public void PrintAllManuscripts(IEnumerable<IManuscript> manuscripts)
        {
            foreach(var manuscript in manuscripts) {
                manuscript.Print();
            }
        }            
}
