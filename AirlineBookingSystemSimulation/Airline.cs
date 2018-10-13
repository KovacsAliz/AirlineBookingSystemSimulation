using System;

namespace AirlineBookingSystemSimulation
{
    public class Airline
    {
        public string Name { get; private set; }
        Random rnd = new Random();

        public Airline(string name)
        {
            Name = name
                ;
        }

        //public string GenerateAirlineName()
        //{
        //    char[] charsToName = new char[6];
        //    for (int i = 0; i < 6; i++)
        //    {
        //        int numOfIndex = rnd.Next(0, 26);
        //        char let = (char)('a' + numOfIndex);
        //        charsToName[i] = let;
        //    }
        //    string airlineName = new string(charsToName);
        //    Console.WriteLine(airlineName);
        //    return airlineName;
        //}

        public override string ToString()
        {
            return $"Airline's name: {Name}";
        }
    }
}
