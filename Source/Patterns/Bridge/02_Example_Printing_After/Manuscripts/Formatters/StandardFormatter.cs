using System;

namespace Bridge._02_Example_Printing_After.Manuscripts.Formatters
{
    public class StandardFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return value;
        }
    }
}
