using Bridge._02_Example_Printing_After.Manuscripts.Formatters;

namespace Bridge._01_Example_Printing_After.Manuscripts
{
    public abstract class Manuscript
    {
        protected readonly IFormatter _formatter;

        public Manuscript(IFormatter formatter) {
            _formatter = formatter ?? new DebugFormatter();
        }

        public void Print(IFormatter formatter = null) {
            PrintWithFormat(formatter ?? _formatter);
        }
        abstract protected void PrintWithFormat(IFormatter formatter);
    }
}
