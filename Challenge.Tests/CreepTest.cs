using System.Diagnostics;
using Xunit;

namespace Challenge.Tests
{
    public class CreepTest
    {
        [Theory]
        [InlineData(22, 25, 1.5, 6, 2.819833089E+18, 35)]
        
        public void Creep(double fr1, double fr2, double fr3, double fr4,  double expectedCreep, double falseCreep)
        {
            Creep tree = new Creep(fr1, fr2, fr3, fr4);
            tree.Add(new Chromium(fr1));
            tree.Add(new Cobalt(fr2));
            tree.Add(new Niobium(fr3));
            tree.Add(new Molybdenum(fr4)); 
            Assert.Equal(expectedCreep, tree.TotalCreep, 4);
            Assert.NotEqual(falseCreep, tree.TotalCreep, 4);
        }

        
    }
}
