using Xunit;

namespace Factory
{
    public class SimpleImmutability
    {
        [Fact]
        public void Test_NormalImplemenation_AcademicYearWithALotOfConstructors() {
            var sut = new AcademicYearWithALotOfConstructors("2017-18");
            Assert.Equal(2017, sut.Start);
            Assert.Equal(2018, sut.End);

            sut = new AcademicYearWithALotOfConstructors(2017, 2018);
            Assert.Equal("2017-18", sut.ShortNotation);            
        }

        [Fact]
        public void Test_FactoryPattern_AcademicYearWithALotOfConstructors() {
            var sut = AcademicYear.FromShortNotation("2017-18");
            Assert.Equal(2017, sut.Start);
            Assert.Equal(2018, sut.End);

            sut = AcademicYear.FromStartAndEnd(2017, 2018);
            Assert.Equal("2017-18", sut.ShortNotation);
        }
    }
}
