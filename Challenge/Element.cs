using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    public abstract class Element : IElement
    {
        
        // Fraction serves no purpose at the moment, but ideally the fraction ranges would be stored in each element and this would pass those values on 

        
        public double Creep => getCreep();
        public double Cost => getCost();
        public double Fraction => getFraction();

       

        public abstract double getCreep();
        public abstract double getCost();
        public abstract double getFraction();
        
        
    }

    
}
