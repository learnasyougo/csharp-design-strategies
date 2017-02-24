namespace Builder
{
    public class AcademicYear
    {
        public int Start { get; }
        public int End { get; }
        public string Code { get; }
        internal AcademicYear(int start, int end) {
            Start = start;
            End = end;
            Code = $"{Start}-{End.ToString().Substring(2, 2)}";
        }
    }
}
