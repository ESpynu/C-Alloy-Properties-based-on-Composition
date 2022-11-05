using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    public class Nickel : Element
    {
        private readonly double _cost = 8.9;
        private readonly double _fraction;
        private readonly double _creep = 0;


        public Nickel(double fraction)
        {
            _fraction = fraction;
        }

        public override double getCreep()
        {
            return _fraction * _creep;
        }

        public override double getCost()
        {
            return _cost * _fraction / 100 ;
        }
        public override double getFraction()
        {
            return _fraction;
        }
    }
}
