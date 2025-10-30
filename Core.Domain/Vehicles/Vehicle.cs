using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Vehicles
{
    public abstract class Vehicle
    {
        //Auto-property (dat is de field en property in 1 (zie customer.cs voor gescheidde variant))
        public int Id { get; }
        public string LicensePlate { get; }
        public int Mileage { get; private set; }
        public float Depreciation { get; private set; }
        public bool IsAvailable { get; private set; }

        //Constructor
        public Vehicle(string licensePlate, int mileage, float depreciation)
        {
            LicensePlate = licensePlate;
            Mileage = mileage;
            Depreciation = depreciation;
        }

        public abstract int CalculateDepreciation();



        //Method
        //ToDo: nog methods toevoegen
        // public float CalculateDepreciation(Depreciation)
        //{
        //float newDepreciation = 0;
        //if blablabla
        //return newDepreciation
        //}

        //public bool usableForRide(Ride ride)
        //{
        //    if (ride.Ongoing == false)
        //        return true;
        //    return false;
        //}
    }
}