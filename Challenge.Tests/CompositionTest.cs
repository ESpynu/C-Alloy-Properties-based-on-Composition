using System.Diagnostics;
using Xunit;

namespace Challenge.Tests
{
    public class CompositionTest
    {
        [Theory]
        [InlineData(84,82,90, 12.5)]
        public void BaseFraction(double fr1, double fr2, double fr3, double fr4)
        {   Composition composition = new Composition();
            Assert.Contains( fr1, composition.NiValues);
            Assert.Contains(fr2, composition.NiValues);
            Assert.DoesNotContain(fr3 , composition.NiValues);
            Assert.DoesNotContain(fr4, composition.NiValues);
        }

        //it seems the generation of AllCombinations list of list takes a lot of processing power, might not run 
        [Theory]
        [InlineData(84, 82, 90, 12.5,5)]
        public void WrongCombinations(double fr1, double fr2, double fr3, double fr4, double fr5)
        {
            Composition composition = new Composition();
            List<double> combination =   new List<double> { fr1, fr2, fr3, fr4, fr5 };
            Assert.DoesNotContain(combination, composition.AllCombinations);

        }

        [Theory]
        [InlineData(14.5, 0, 0, 1.5, 84)]
        public void CorrectCombinations(double fr1, double fr2, double fr3, double fr4, double fr5)
        {
            Composition composition = new Composition();
            List<double> combination = new List<double> { fr1, fr2, fr3, fr4, fr5 };
            Assert.Contains(combination, composition.AllCombinations);

        }
    }
}
