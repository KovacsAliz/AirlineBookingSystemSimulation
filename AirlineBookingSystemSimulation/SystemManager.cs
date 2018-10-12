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

            //airlineBookingSystem.flights["ac6"].CheckAvailableSeat();
            Console.ReadKey();
        }
    }
}
