using System;

namespace AirlineBookingSystemSimulation
{
    public class Airport
    {
        public string Name { get; private set; }
        Random rnd = new Random();

        public Airport(string name)
        {
            Name = name;
        }

        //public string GenerateAirportName()
        //{
        //    char[] charsToName = new char[3];
        //    for (int i = 0; i < 3; i++)
        //    {
        //        int numOfIndex = rnd.Next(0, 26);
        //        char let = (char)('a' + numOfIndex);
        //        charsToName[i] = let;
        //    }
        //    string airportName = new string(charsToName);
        //    Console.WriteLine(airportName);
        //    return airportName;
        //}

        public override string ToString()
        {
            return $"Airport's name: {Name}";
        }
    }
}
