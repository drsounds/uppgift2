using System;
using Uppgift2.Interfaces;
namespace Uppgift2.Models
{
    public class Walk : ITransportation
	{
		public DateTime Departure { get; set; }
		public DateTime Arrival { get; set; }
		public string Route { get; set; }
		public decimal Cost { get; set; }
		public String Platform { get; set; }

        public void Ride()
        {
            Console.WriteLine("I am walking");
        }
    }
}
