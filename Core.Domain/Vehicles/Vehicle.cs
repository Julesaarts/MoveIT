using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Vehicles
{
    public class Vehicle
    {
        //Auto-property (dat is de field en property in 1 (zie customer.cs voor gescheidde variant))
        public string Type { get; }
        public int KmDriven { get; private set; }
        public int Value { get; protected set; }
        public string LicensePlate { get; private set; }

        //Constructor
        public Vehicle(string type, int kmDriven, int value, string licensePlate)
        {
            Type = type;
            KmDriven = kmDriven;
            Value = value;
            LicensePlate = licensePlate;
        }

        //public abstract int CalculateDepreciation();



        //Method
        //ToDo: nog methods toevoegen
        // public float CalculateDepreciation(Value)
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