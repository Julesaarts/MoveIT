using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Helpers
{
    internal class TaxiHelper
    {
        internal static double CalculateTaxiDeprecation(double baseValue, double KmDriven)
        {
            //Eenvoudige formule voor afschrijving van een taxi
            //Afschrijving = (km gereden * afschrijvingsfactor)
            //Waarbij de afschrijvingsfactor 1% per 2000 km is
            //Basiswaarde van de taxi in euro's
            //Basis afschrijving: 1% per 2000 km
            double depreciationPercent = (KmDriven / 2000) * 0.01;

            //Nieuwe waarde na afschrijving
            baseValue *= (1 - depreciationPercent);

            //Voorkomen dat waarde negatief wordt
            return Math.Max(baseValue, 0);
        }
    }
}