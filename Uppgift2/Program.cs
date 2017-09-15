using System;
using Uppgift2.Interfaces;
using Uppgift2.Models;

namespace Uppgift2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Travel travel = new Travel()
            {
                Departure = new Tour()
                {
                    Transportations = new System.Collections.Generic.List<Interfaces.ITransportation>() {

                        new Walk() {
                            Platform = "Husabygatan",
                            Route = "Lidköpings Resecentrum",
                            Departure = new DateTime(2017, 9, 28, 8, 44, 0)
                        },
                        new Train() {
                            Route = "Herrljunga station",
                            Platform = "Lidköpings resecentrum, Läge 2",
                            Departure = new DateTime(2017,9,28, 10,27, 0)
                        },
                        new Train() {
                            Platform = "Herrljunga station läge 1",
                            Route = "Göteborg Central",
                            Departure = new DateTime(2017,09,28, 11,25, 0)
                        },
                        new Train() {
                            Departure = new DateTime(2017,9,28, 11,35, 0),
                            Platform = "Centralstationen Läge A",


                        },
                        new Walk() {
                            Departure = new DateTime(2017,9,28,11,39, 0),
                            Platform = "Scandinavium Läge B"
                        }
                    }
                },
                Home = new Tour()
                {
                    Transportations = new System.Collections.Generic.List<Interfaces.ITransportation>() {
                        new Walk() {
                            Platform = "Mässans gata",
                            Route = "Lisebergs station",
                            Departure = new DateTime(2017,09,28,16,32, 0)
                        },
                        new Bus() {
                            Platform = "Lisebergs station Läge 1",
                            Route = "Västtågen mot Götebborg",
                            Departure = new DateTime(2017,09,28,16,38, 0)
                        },
                        new Train() {
                            Departure = new DateTime(2017,09,28,16,55, 0),
                            Platform = "Göteborgs centralstation",
                            Route = "Lidköpings Resecentrum (tåg), Läge 2"
                        }

                    }
                }
            };
            Console.WriteLine("Resan dit");
            foreach (ITransportation t in travel.Departure.Transportations)
            {
                Console.WriteLine(String.Format("Take the {0} to {1} from plattform {2} at {3}", t.GetType().Name, t.Route, t.Platform, t.Departure));
            }
			Console.WriteLine("Resan hem");
			foreach (ITransportation t in travel.Home.Transportations)
			{
				Console.WriteLine(String.Format("Take the {0} to {1} from plattform {2} at {3}", t.GetType().Name, t.Route, t.Platform, t.Departure));
			}
            Console.ReadLine();
        }
    }
}
