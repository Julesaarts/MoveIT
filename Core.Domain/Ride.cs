using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class Ride
    {
        //Property
        public int Id { get; private set; }
            //Use DateTime for date and time representation in .NET
        public DateTime Date { get; private set; }
        public int Distance { get; private set; }
        public int Price { get; private set; }
        public bool Ongoing { get; private set; }

        //Constructor
        public Ride(DateTime date, int distance, int price, bool ongoing)
        {
            Date = date;
            Distance = distance;
            Price = price;
            Ongoing = ongoing;
        }

        //Method
        //public float CalculatePrice(Vehicle.type)
        //CompleteRide
    }
}
