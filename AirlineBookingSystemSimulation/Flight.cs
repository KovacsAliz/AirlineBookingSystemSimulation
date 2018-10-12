using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public int NumOfBookedSeat { get; private set; }
        public int NumOfFreeSea { get; private set; }
        Random random = new Random();

        private readonly Dictionary<string, Section> sections = new Dictionary<string, Section>();

        public Flight(string originAirport, string destinationAirport, string airline, DateTime departureTime, int numOfSeats, int numOfSeatRows)
        {
            OriginAirport = originAirport;
            DestinationAirport = destinationAirport;
            Airline = airline;
            FlightNumber = OriginAirport.Substring(1, 3) + random.Next(100, 999).ToString();
            DepartureTime = departureTime;
            NumOfSeats = numOfSeats;
            NumOfSeatRows = numOfSeatRows;
            NumOfBookedSeat = 0;
            NumOfFreeSea = numOfSeats;
        }

        public void CheckOriginAndDestination()
        {
            if(OriginAirport == DestinationAirport)
            {
                throw new ArgumentException();
            }
        }

        public void CreateSection(string typeOfSection, int numOfSeat, int numOfRow)
        {
            Section section = new Section(typeOfSection, numOfSeat, numOfRow);
            sections.Add(typeOfSection, section);
        }

        public bool CheckAvailableSeat(Section section, int numOfPass)
        {
            //TODO
        }
    }
}
