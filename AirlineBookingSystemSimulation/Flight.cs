using System;
using System.Collections.Generic;

namespace AirlineBookingSystemSimulation
{
    public class Flight
    {
        public string OriginAirport { get; private set; }
        public string DestinationAirport { get; private set; }
        public string Airline { get; private set; }
        public string FlightNumber { get; private set; }
        public DateTime DepartureTime { get; private set; }
        public int NumOfSeats { get; private set; }
        public int NumOfSeatRows { get; private set; }

        Random random = new Random();

        private readonly Dictionary<SectionType, Section> sections = new Dictionary<SectionType, Section>();

        public Flight(string originAirport, string destinationAirport, string airline, DateTime departureTime, int numOfSeats, int numOfSeatRows, string flightNumber)
        {
            OriginAirport = originAirport;
            DestinationAirport = destinationAirport;
            Airline = airline;
            FlightNumber = flightNumber; //OriginAirport.Substring(1, 3) + random.Next(100, 999).ToString();
            DepartureTime = departureTime;
            NumOfSeats = numOfSeats;
            NumOfSeatRows = numOfSeatRows;
        }

        public void CheckOriginAndDestination()
        {
            if (OriginAirport == DestinationAirport)
            {
                throw new ArgumentException();
            }
        }

        public void CreateSection(SectionType typeOfSection, int numOfSeatColumn, int numOfRow)
        {
            Section section = new Section(numOfRow, numOfSeatColumn, typeOfSection);
            sections.Add(typeOfSection, section);
        }

        public bool CheckAvailableSeat(SectionType section, int numOfPass)
        {
            foreach (var sec in sections)
            {
                if (sec.Value.TypeOfSection == section)
                {
                    if (sec.Value.NumOfFreeSea >= numOfPass)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void BookFlightSeat(int numberOfPass, SectionType sectionType)
        {
            foreach (var section in sections)
            {
                if (section.Value.TypeOfSection == sectionType)
                {
                    section.Value.ChangeStateOfSeat(numberOfPass);
                }
            }
        }

        public override string ToString()
        {
            return $"Flight number: {FlightNumber}, Origin Airport: {OriginAirport}, Destination Airport: {DestinationAirport}" +
                   $" Airline: {Airline}, Departure date: {DepartureTime}";
        }
    }
}
