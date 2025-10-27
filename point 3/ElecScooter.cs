namespace practice4_3sem
{
    public class ElecScooter
    {
        private bool _Seat;
        public bool Seat  // Есть ли сиденье (True = есть, False = нет)
        {
            get { return _Seat; }
            set
            {
                if (value == false || value == true) _Seat = value;
                else throw new ArgumentException("Сиденье имеет неверное значение.");
            }
        }

        public ElecScooter(bool seat = true) => Seat = seat;

        public void Print()
        {
            Console.WriteLine($"Имеется ли сиденье: {(Seat == true ? "Да" : "Нет")}");
        }
    }

}
