using System.Diagnostics;
using Xunit;

namespace Challenge.Tests
{
    public class CostTest
    {
        [Theory]
        [InlineData(22, 25, 1.5, 6, 45.5, 28.852, 20)]
        public void Cost(double fr1, double fr2, double fr3, double fr4, double fr5, double expectedCost, double falseCost)
        {
            Cost tree = new Cost(fr1, fr2, fr3, fr4, fr5);
            tree.Add(new Chromium(fr1));
            tree.Add(new Cobalt(fr2));
            tree.Add(new Niobium(fr3));
            tree.Add(new Molybdenum(fr4));
            tree.Add(new Nickel(fr5));
            Assert.Equal(expectedCost, tree.TotalCost, 4);
            Assert.NotEqual(falseCost, tree.TotalCost, 4);
        }
    }
}
