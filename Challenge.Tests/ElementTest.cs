using System.Diagnostics;
using Xunit;

namespace Challenge.Tests
{
    public class ElementTest
    {   //testing for both negative and positive in each test, to make sure everything is working and doesn't always return either only True or only False.
        [Theory]
        [InlineData(14.5,12,2.03)]
        public void Cost(double fr1, double fr2, double expectedCost)
        {
            Element element1 = new Chromium(fr1);
            Element element2 = new Chromium(fr2);
            Assert.Equal(expectedCost, element1.Cost, 4);
            Assert.NotEqual(expectedCost, element2.Cost, 4);
        }

        [Theory]
        [InlineData(14.5, 12, 303214575000000000)]
        public void Creep(double fr1, double fr2, double expectedCreep)
        {
            Element element1 = new Chromium(fr1);
            Element element2 = new Chromium(fr2);
            Assert.Equal(expectedCreep, element1.Creep, 4);
            Assert.NotEqual(expectedCreep, element2.Creep, 4);
        }
    }
}
