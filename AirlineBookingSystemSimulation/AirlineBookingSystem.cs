using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineBookingSystemSimulation
{
    public class AirlineBookingSystem
    {
        private readonly Dictionary<string, Airport> airports = new Dictionary<string, Airport>(); 
        private readonly Dictionary<string, Airline> airlines = new Dictionary<string, Airline>(); 
        private readonly Dictionary<string, Flight> flights = new Dictionary<string, Flight>();

        public AirlineBookingSystem() { }

        public void CreateAirport(string name)
        {
            Airport airport = new Airport(name);
        }

        public void CreateAirline(string name)
        {
            Airline airline = new Airline(name);
        }

        public void CreateFlight(Airline airline, string originAirport, string destinationAirport, DateTime departureDate)
        {
            Flight flight = new Flight(airline, originAirport, destinationAirport, departureDate);
        }

        public void GetAvailableFlight(string originAirport, string destinationAirport, DateTime departureDate, int numOfPass)
        {
            foreach (var flight in flights.Values)
            {
                //if(flight.); //TODO
            }
        }

        public bool BookSeat(string flightNumber, int numberOfPass)
        {
            //TODO
        }

        public void PrintResult()
        {
            return flight.ToString();
        }
    }
}
