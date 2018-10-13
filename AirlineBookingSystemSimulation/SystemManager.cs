using System;

namespace AirlineBookingSystemSimulation
{
    public class SystemManager
    {
        static void Main(string[] args)
        {
            AirlineBookingSystem airlineBookingSystem = new AirlineBookingSystem();
            airlineBookingSystem.CreateAirline("najoez");
            airlineBookingSystem.CreateAirline("szuper");
            airlineBookingSystem.CreateAirline("luxury");
            airlineBookingSystem.PrintAirlines();

            airlineBookingSystem.CreateAirport("abc");
            airlineBookingSystem.CreateAirport("str");
            airlineBookingSystem.CreateAirport("cbc");
            airlineBookingSystem.PrintAirports();

            airlineBookingSystem.CreateFlight("najoez", "abc", "str", new DateTime(2018, 02, 01), 125, 15, "as5");
            airlineBookingSystem.CreateFlight("szuper", "atr", "cbc", new DateTime(2018, 05, 06), 100, 10, "ac6");
            airlineBookingSystem.PrintResult();

            airlineBookingSystem.CreateFlightSection("as5", "business", 6, 6);
            airlineBookingSystem.CreateFlightSection("as5", "economy", 10, 6);
            airlineBookingSystem.CreateFlightSection("as5", "first class", 4, 6);

            Console.WriteLine(airlineBookingSystem.GetAvailableFlight("abc", "str", new DateTime(2018, 02, 01), 5, SectionType.Business));
            Console.WriteLine(airlineBookingSystem.BookSeat("as5", 60, SectionType.Economy));
            Console.WriteLine(airlineBookingSystem.BookSeat("as5", 2, SectionType.Economy));
            Console.WriteLine(airlineBookingSystem.BookSeat("as5", 120, SectionType.Business));
            Console.WriteLine(airlineBookingSystem.BookSeat("as5", 36, SectionType.Business));
            Console.WriteLine(airlineBookingSystem.BookSeat("as5", 1, SectionType.Business));

            airlineBookingSystem.PrintResult();
            Console.ReadKey();
        }
    }
}
