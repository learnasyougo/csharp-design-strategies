namespace Builder
{
    public class AcademicYearBuilder01
    {
        public int Start { get; set; }
        public int End { get; set; }
        public AcademicYearBuilder01() { }

        public AcademicYear Build()
        {
            return new AcademicYear(Start, End);
        }


    }    
}
