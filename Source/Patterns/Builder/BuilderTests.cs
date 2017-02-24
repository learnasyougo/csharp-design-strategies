using Xunit;

namespace Builder
{
    public class BuilderTests
    {
        [Fact]
        public void BuilderPattern_Version_01() {
            var sut = new AcademicYearBuilder01 { Start = 2017, End = 2018 }.Build();
            Assert.Equal("2017-18", sut.Code);
        }
    }
}
