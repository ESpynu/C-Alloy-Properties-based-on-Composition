using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    public class Niobium : Element
    {
        private readonly double _cost = 42.5;
        private readonly double _creep = 1.0352738E+16;
        public double _fraction;
        public Niobium(double fraction)
        {
            _fraction = fraction;
        }

        public override double getCreep()
        {
            return _fraction * _creep;
        }

        public override double getCost()
        {
            return _cost * _fraction / 100;
        }
        public override double getFraction()
        {
            return _fraction;
        }
    }
}
