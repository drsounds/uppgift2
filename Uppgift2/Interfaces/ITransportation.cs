using System;
namespace Uppgift2.Interfaces
{
    public interface ITransportation
    {
        void Ride();
        String Route { get; set; }
        DateTime Departure { get; set; }
        DateTime Arrival { get; set; }
        decimal Cost { get; set; }
        String Platform { get; set; }
    }
}
