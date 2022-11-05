using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    public class Composition : IComposition
    {
        private double _totalfr = 100;

        public List<List<double>> AllCombinations => getCombinations();
        public List<double> NiValues => getBaseFraction();
        public List<double> CrValues = Range(14.5, 22, 0.5).ToList();
        public List<double> CoValues = Range(0.0, 25, 1).ToList();
        public List<double> NbValues = Range(0.0, 1.5, 0.1).ToList();
        public List<double> MoValues = Range(1.5, 6, 0.5).ToList();

        public static IEnumerable<double> Range(double start, double end, double step)
        {
            while (start <= end)
            {
                yield return start;
                start += step;
            }
            if (step <= 0) { throw new ArgumentOutOfRangeException("step", "Invalid step size"); }
        }
        
        
         
        public List<double> getBaseFraction()

        {   
            List<double> NiValuesDupes = new List<double>();
            List<double> _NiValues = new List<double>();
            for (int i = 0; i < CrValues.Count; i++)
            {
                for (int j = 0; j < CoValues.Count; j++)
                {
                    for (int k = 0; k < NbValues.Count; k++)
                    {
                        for (int l = 0; l < MoValues.Count; l++)
                        {
                            double BaseFraction = _totalfr - CrValues[i] - CoValues[j] - NbValues[k] - MoValues[l];
                            NiValuesDupes.Add(BaseFraction);
                        }
                    }
                }
                
            }
            
            _NiValues = NiValuesDupes.Distinct().ToList();
            return _NiValues;
        }

        

        public List<List<double>> getCombinations()
        {
            List<List< double >> AllCombinations = new List<List<double>>();
            
            for (int i = 0; i < CrValues.Count; i++)
            {
                List<double> Combination = new List<double>();
                Combination.Add(CrValues[i]);
                for (int j = 0; j < CoValues.Count; j++)
                {
                    Combination.Add(CoValues[j]);
                    for (int k = 0; k < NbValues.Count; k++)
                    {   
                        Combination.Add(NbValues[k]);
                        for (int l = 0; l < MoValues.Count; l++)
                        {
                            Combination.Add(MoValues[l]);
                            for (int m = 0; m < NiValues.Count; m++)
                            {
                                Combination.Add(NiValues[m]);
                                AllCombinations.Add(Combination);
                                Combination.Remove(NiValues[m]);
                            }
                            Combination.Remove(MoValues[l]);

                        }
                        Combination.Remove(NbValues[k]);
                    }
                    Combination.Remove(CoValues[j]);
                }
                Combination.Remove(CrValues[i]);

            }
            return AllCombinations;
        }



        
       
       
            
    }
}
