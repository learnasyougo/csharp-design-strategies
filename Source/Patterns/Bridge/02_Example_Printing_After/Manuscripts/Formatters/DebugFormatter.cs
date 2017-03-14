

namespace Bridge._02_Example_Printing_After.Manuscripts.Formatters
{
    public class DebugFormatter : IFormatter
    {
        public string Format(string key, string value) {
            return $"{key.ToUpperInvariant()}: '{value}'";
        }
    }
}
