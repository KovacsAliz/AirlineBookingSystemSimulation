namespace AirlineBookingSystemSimulation
{
    public class Section
    {
        public int NumOfSeatRow { get; private set; }
        public int NumOfSeatColumn { get; private set; }
        public int NumOfBookedSeat { get; private set; }
        public int NumOfFreeSea { get; private set; }
        public SectionType TypeOfSection { get; private set; }
        private readonly bool[,] seats;

        public Section(int numOfSeatRow, int numOfSeatColumn, SectionType typeOfSection)
        {
            NumOfSeatRow = numOfSeatRow;
            NumOfSeatColumn = numOfSeatColumn;
            TypeOfSection = typeOfSection;
            NumOfBookedSeat = 0;
            NumOfFreeSea = numOfSeatRow * numOfSeatColumn;
            seats = new bool[numOfSeatColumn, numOfSeatRow];
        }

        public void ChangeStateOfSeat(int numberOfPass)
        {
            int numOfChangedSeat = 0;
            for (int i = 0; i < seats.GetLength(0); i++)
            {
                for (int j = 0; j < seats.GetLength(1); j++)
                {
                    if (seats[i, j] == false)
                    {
                        seats[i, j] = true;
                        NumOfBookedSeat++;
                        NumOfFreeSea--;
                        numOfChangedSeat++;
                        if (numOfChangedSeat >= numberOfPass)
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
}
