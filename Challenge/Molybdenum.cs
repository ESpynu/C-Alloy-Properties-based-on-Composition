using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    public class Molybdenum: Element
    {
        private readonly double _cost = 16.0;
        private readonly double _fraction;
        private readonly double _creep = 8.9124547E+16;

        public Molybdenum(double fraction)
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
