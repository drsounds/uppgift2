using System;
using System.Collections.Generic;
using Uppgift2.Interfaces;

namespace Uppgift2.Models
{
    public class Tour
    {
        public Tour()
        {
            Transportations = new List<ITransportation>();
        }
        public List<ITransportation> Transportations { get; set; }
    }
}
