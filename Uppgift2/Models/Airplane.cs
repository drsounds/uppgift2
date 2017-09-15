﻿using System;
using Uppgift2.Interfaces;
namespace Uppgift2.Models
{
    public class Airplane : ITransportation 
    {
        public String Route { get; set; }
        public DateTime Departure { get; set; }
		public DateTime Arrival { get; set; }
		public decimal Cost { get; set; }
		public String Platform { get; set; }

        public void Ride() {
            Console.WriteLine("Riding the airplane");
        }

    }
}
