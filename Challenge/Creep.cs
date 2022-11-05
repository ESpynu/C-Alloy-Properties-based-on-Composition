using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    public class Creep : ITotalCreep
    {
        // doubles for unit testing
        private readonly double _fr1;
        private readonly double _fr2;
        private readonly double _fr3;
        private readonly double _fr4;
       
       
        public double TotalCreep => getTotalCreep();
      
        public Creep(double fr1, double fr2, double fr3, double fr4)
        {
            _fr1 = fr1;
            _fr2 = fr2;
            _fr3 = fr3;
            _fr4 = fr4;
            
        }

        protected List<Element> _totals = new List<Element>();

        public  void Add(Element component)
        {
            this._totals.Add(component);
        }

        public  void Remove(Element component)
        {
            this._totals.Remove(component);
        }

        public  double getTotalCreep()
        {
            int i = 0;
            double TotalCreep = 0.0;

            foreach(Element component in this._totals)
            {
                TotalCreep += component.getCreep();
                i++;
            }
            return TotalCreep;
        }  
   
    }
}
