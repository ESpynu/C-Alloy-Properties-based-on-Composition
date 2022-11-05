using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    public class Cost : ITotalCost
    {
        // doubles for unit testing
        private readonly double _fr1;
        private readonly double _fr2;
        private readonly double _fr3;
        private readonly double _fr4;
        private readonly double _fr5;

        
        public double TotalCost => getTotalCost();

        public Cost(double fr1, double fr2, double fr3, double fr4, double fr5)
        {
            _fr1 = fr1;
            _fr2 = fr2;
            _fr3 = fr3;
            _fr4 = fr4;
            _fr5 = fr5;
        }

        protected List<Element> _totals = new List<Element>();
        public void Add(Element component)
        {
            this._totals.Add(component);
        }

        public void Remove(Element component)
        {
            this._totals.Remove(component);
        }
        public double getTotalCost()
        {
            int i = 0;
            double TotalCost = 0.0;

            foreach (Element component in this._totals)
            {
                TotalCost += component.getCost();
                i++;
            }
            return TotalCost;
        }


    }
}
