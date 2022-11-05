using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    public interface IElement
    {
        double Creep { get; }
        double Cost { get; }
        double Fraction { get; }
    }
}
