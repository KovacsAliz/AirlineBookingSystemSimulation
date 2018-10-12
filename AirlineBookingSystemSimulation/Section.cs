using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineBookingSystemSimulation
{
    public class Section
    {
        public int NumOfSeatRow { get; private set; }
        public int NumOfSeatColumn { get; private set; }
        public string TypeOfSection { get; private set; }
        private readonly bool[,] seats;

        public Section(int numOfSeatRow, int numOfSeatColumn, string typeOfSection)
        {
            NumOfSeatRow = numOfSeatRow;
            NumOfSeatColumn = numOfSeatColumn;
            TypeOfSection = typeOfSection;
            seats = new bool[numOfSeatColumn, numOfSeatRow];
        }
    }
}
