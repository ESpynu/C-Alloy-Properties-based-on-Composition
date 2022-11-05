using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    internal interface IComposition
    {
        public List<List<double>> AllCombinations { get; }
        public List<double> NiValues { get; }
    }
}
