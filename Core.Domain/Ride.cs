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
        //Field
        //Marco heeft hier een list met Queues, maar dat is voor mijn app niet toepasbaar. (ook niet met passengers)
        //private readonly List<Passengers> _passengers = new List<Passengers>();

        //Property
        public int Id { get; private set; }
        //Use DateTime for date and time representation in .NET
        //public DateTime Date { get; private set; }
        public int Distance { get; private set; }
        public int Price { get; private set; }
        //public bool Ongoing { get; private set; }


        //onderstaande 3-slash comments krijg je wanneer je 3x '/' typt direct methode, klasse, property of constructor hangt
        /// <summary>
        /// 
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="price"></param>
        /// <param name="ongoing"></param>
        /// <exception cref="ArgumentException">Throws ArgumentException when invalid distance filled in</exception>

        //Constructor
        public Ride(//DateTime date,
                    int distance, int price/*, bool ongoing*/)
        {
            //Voorbeeld van Validatie in de domain laag
            //ToDo: add more validation
            //Waarom gebruiken we niet RideResult hier? omdat we in de constructor van een object geen return type kunnen zetten (zoals bij methodes)
            //Gebruik exceptions in exceptionele gevallen. In voorspelbare gevallen (zoals user input) kun je beter result objecten gebruiken
            if (distance < 2)
            {
                throw new ArgumentException("Distance cant be less than 0.", nameof(distance));
            }

            //Date = date;
            Distance = distance;
            Price = price;
            //Ongoing = ongoing;
        }

        //Method
        public double CalculatePrice(int distance)
        {
            double price = 10 + (distance * 0.12);
            return price;
        }

        public RideResult CompleteRide()
        {
            if (/*Ongoing == false*/ true)
            {
                return new RideResult("Ride is already completed.");
            }
            return new RideResult();
        }
    }
}