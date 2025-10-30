using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Vehicles
{
    internal class Taxi : Vehicle
    {
        //Nieuwe property die alleen bij Taxi hoort
        public int PassengerCapacity { get; private set; }

        //Constructor voor Taxi, erft van Vehicle, inclusief nieuwe property
        public Taxi(string licensePlate, int mileage, float depreciation, int passengerCapacity) : base(licensePlate, mileage, depreciation)
        {
            PassengerCapacity = passengerCapacity;
        }

        public override int CalculateDepreciation()
        {
            throw new NotImplementedException();
        }


    }
}
