using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Vehicles
{
    internal class Truck : Vehicle
    {
        // Nieuwe property die alleen bij Truck hoort
        public int MaxCapacity { get; private set; }
        public int MaxWeight { get; private set; }

        // Constructor voor Truck, inclusief nieuwe properties
        public Truck(string type, int kmDriven, int value, string licensePlate, int maxCapacity, int maxWeight) : base(type, kmDriven, value, licensePlate)
        {
            MaxCapacity = maxCapacity;
            MaxWeight = maxWeight;
        }

        //public override int CalculateDepreciation()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
