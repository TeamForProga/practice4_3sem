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

        public static void Point2ForElecScooter()
        {
            Dictionary<string, ElecScooter> dictionary = new()
            {
                {"First", new ElecScooter()},
                { "Second", new ElecScooter(true)},
                {"Third", new ElecScooter(false)}
            };

            Console.WriteLine("\nПервая коллекция: ");
            foreach (var keys in dictionary) Console.WriteLine($"{keys.Key} {keys.Value.Seat}");
            Console.WriteLine();

            int n = 2;
            if (n < dictionary.Count)
            {
                for (int i = 0; i < n; i++) dictionary.Remove(dictionary.First().Key);
            }

            dictionary.Add("A", new ElecScooter());
            dictionary.TryAdd("B", new ElecScooter(true));
            dictionary["C"] = new();


            Console.WriteLine("\nПервая коллекция после удаления: ");
            foreach (var keys in dictionary) Console.WriteLine($"{keys.Key} {keys.Value.Seat}");
            Console.WriteLine();

            Stack<ElecScooter> stack = [];

            Console.WriteLine("\nВторая коллекция: ");
            foreach (var key in dictionary)
            {
                stack.Push(key.Value);
            }
            foreach (var s in stack)
            {
                Console.WriteLine(s.Seat);
            }

            var ToFind = new ElecScooter(false);

            n = 0;
            if (stack.Contains(ToFind))
            {
                foreach (var key in stack)
                {
                    if (key.Seat == ToFind.Seat) ;
                    n++;
                }
            }
            Console.WriteLine($"\nИндекс искомого: {n}");

        }
    }

}
