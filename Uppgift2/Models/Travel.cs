using System;
using System.Collections.Generic;
using Uppgift2.Interfaces;

namespace Uppgift2.Models
{
    public class Travel
	{
        public Tour Departure { get; set; }
        public Tour Home { get; set; }
		public string Route { get; set; }
		decimal Cost { get; set; }
		String Platform { get; set; }
        public Travel() {
            Transports = new List<ITransportation>();
        }
        public List<ITransportation> Transports { get; set; }
    }
}
