using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    public class Cobalt : Element
    {
        private readonly double _cost = 80.5;
        private readonly double _fraction;
        private readonly double _creep = 7.2380280E+16;


        public Cobalt(double fraction)
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
