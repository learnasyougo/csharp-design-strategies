using System;

namespace Factory
{
    // Immutable, but confusing because of constructor overloading...
    // And what if we add more ctors, and with the same signature?
    // See AcadmeicYear class for solution with Factory Pattern    
    public sealed class AcademicYearWithALotOfConstructors
    {
        public int Start { get; }
        public int End { get; }
        public string ShortNotation { get; }

        public AcademicYearWithALotOfConstructors(int start, int end) {
            Start = start;
            End = end;
            ShortNotation = $"{start}-{end.ToString().Substring(2, 2)}";
        }
        public AcademicYearWithALotOfConstructors(string shortNotation) {
            ShortNotation = shortNotation;
            Start = Int32.Parse(ShortNotation.Substring(0, 4));
            End = Int32.Parse($"{Start.ToString().Substring(0, 2)}{shortNotation.Substring(5, 2)}");
        }
    }
}
