using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    public class Chromium : Element
    {
        private readonly double _cost = 14.0;
        private readonly double _fraction;
        private readonly double _creep = 2.0911350E+16;

        

        public Chromium(double fraction)
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
