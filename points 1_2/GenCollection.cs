namespace practice4_3sem
{
    public class  GenCollection
    {
        public static void Collections()
        {
            Dictionary<string, string> dictionary = new()
            {
                {"First", "Sam"},
                { "Second", "Greg"},
                {"Third", "Emmy"}
            };

            Console.WriteLine("\nПервая коллекция: ");
            foreach ( var keys in dictionary) Console.WriteLine($"{keys.Key} {keys.Value}");
            Console.WriteLine();

            int n = 2;
            if (n < dictionary.Count) 
            {
                for (int i = 0; i < n; i++) dictionary.Remove(dictionary.First().Key);
            }

            dictionary.Add("A", "Sam");
            dictionary.TryAdd("B", "Dod");
            dictionary["C"] = "as";

            
            Console.WriteLine("\nПервая коллекция после удаления: ");
            foreach (var keys in dictionary) Console.WriteLine($"{keys.Key} {keys.Value}");
            Console.WriteLine();

            Stack<string> stack = [];

            Console.WriteLine("\nВторая коллекция: ");
            foreach (var key in dictionary)
            {
                stack.Push(key.Value);
            }
            foreach (var s in stack)
            {
                Console.WriteLine(s );
            }

            string ToFind = "Sam";

            n = 0;
            if (stack.Contains(ToFind))
            {
                foreach (var key in stack)
                {
                    if (key.Equals(ToFind)) break;
                    n++;
                }
            }
            Console.WriteLine($"\nИндекс искомого: {n}");

        }
    }
}
