using System;

namespace Factory
{
    public sealed class AcademicYear
    {
        public int Start { get; }
        public int End { get; }
        public string ShortNotation
            => $"{Start}-{End.ToString().Substring(2, 2)}";

        // Use factory pattern for all methods,
        // don't leave a public constructor out there
        // this way it's consistent to the outside world.
        private AcademicYear(int start, int end) {
            Start = start;
            End = end;
        }
        
        public static AcademicYear FromStartAndEnd(int start, int end) {
            return new AcademicYear(start, end);
        }
        public static AcademicYear FromShortNotation(string shortNotation) {
            var start = Int32.Parse(shortNotation.Substring(0, 4));
            var end = Int32.Parse($"{start.ToString().Substring(0, 2)}{shortNotation.Substring(5, 2)}");
            return new AcademicYear(start, end);
        }
    }
}
