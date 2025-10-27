using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Helpers
{
    internal class TruckHelper
    {
        internal static double CalculateTruckDeprecation(double baseValue, double KmDriven, double cargoWeight, int maxCargoWeight = 25000)
        {
            //Eenvoudige formule voor afschrijving van een vrachtwagen
            //Afschrijving = (km gereden * afschrijvingsfactor)
            //Waarbij de afschrijvingsfactor 1% per 3000 km is
            //Basiswaarde van de vrachtwagen in euro's

            //Basis afschrijving: 1% per 3000 km
            double depreciationPercent = (KmDriven / 3000) * 0.01;

            //Extra 0.5% als de vracht boven 90% van de maximale capaciteit zit
            if (cargoWeight > 0.9 * maxCargoWeight)
            {
                depreciationPercent += 0.005;
            }

            //Nieuwe waarde na afschrijving
            baseValue *= (1 - depreciationPercent);

            //Voorkomen dat waarde negatief wordt
            return Math.Max(baseValue, 0);
        }
    }
}
