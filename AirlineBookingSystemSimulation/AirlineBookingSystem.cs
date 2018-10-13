using System;
using System.Collections.Generic;

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
            Airport airport1 = new Airport(name);
            foreach (var airport in airports)
            {
                if (airport.Key == airport1.Name)
                {
                    throw new ArgumentException();
                }
            }
            airports.Add(name, airport1);
        }

        public void CreateAirline(string name)
        {
            Airline airline1 = new Airline(name);
            foreach (var airline in airlines)
            {
                if (airline.Key == airline1.Name)
                {
                    throw new ArgumentException();
                }
            }
            airlines.Add(name, airline1);
        }

        public void CreateFlight(string airline, string originAirport, string destinationAirport, DateTime departureDate, int numOfSeats, int numOfRows, string flightNum)
        {
            Flight flight1 = new Flight(originAirport, destinationAirport, airline, departureDate, numOfSeats, numOfRows, flightNum);
            flights.Add(flightNum, flight1);
        }

        public void CreateFlightSection(string flightNum, string section, int seatRow, int seatColumn)
        {
            foreach (var flight in flights)
            {
                if (flight.Value.FlightNumber == flightNum)
                {
                    if (section == "business")
                    {
                        flight.Value.CreateSection(SectionType.Business, seatRow, seatColumn);
                    }
                    else if (section == "first class")
                    {
                        flight.Value.CreateSection(SectionType.FirstClass, seatRow, seatColumn);
                    }
                    else
                    {
                        flight.Value.CreateSection(SectionType.Economy, seatRow, seatColumn);
                    }
                }
            }
        }


        public bool GetAvailableFlight(string originAirport, string destinationAirport, DateTime departureDate, int numOfPass, SectionType section)
        {
            foreach (var flight in flights)
            {
                if (flight.Value.OriginAirport == originAirport && flight.Value.DestinationAirport == destinationAirport &&
                    flight.Value.DepartureTime == departureDate)
                {
                    if (flight.Value.CheckAvailableSeat(section, numOfPass) == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool BookSeat(string flightNumber, int numberOfPass, SectionType section)
        {
            foreach (var flight in flights)
            {
                if (flight.Value.FlightNumber == flightNumber && flight.Value.CheckAvailableSeat(section, numberOfPass) == true)
                {
                    flight.Value.BookFlightSeat(numberOfPass, section);
                    return true;
                }
            }
            return false;
        }

        public void PrintResult()
        {
            foreach (var flight in flights)
            {
                Console.WriteLine(flight.ToString()); 
            }
        }

        public void PrintAirlines()
        {
            foreach (var airline in airlines)
            {
                Console.WriteLine(airline.Value.ToString()); 
            }
        }

        public void PrintAirports()
        {
            foreach (var airport in airports)
            {
                Console.WriteLine(airport.Value.ToString()); 
            }
        }
    }
}
