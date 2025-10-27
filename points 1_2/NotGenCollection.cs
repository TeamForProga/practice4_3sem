using System.Collections;

namespace practice4_3sem
{
    public class NotGenCollection
    {
        public static void ArList()
        {
            // Создание коллекции ArrayList
            ArrayList list = [];
            // Заполнение ее 5-ю случайными целыми числами
            for (int i = 0; i < 5; i++)
            {
                var rand = new Random();
                list.Add(rand.Next(10));
            }
            list.Add("AS");     // Добавление строки

            Console.Write("Введите элемент для удаления: ");
            string con = Console.ReadLine();
            list.Remove(con);       // Удаление элемента

            Console.WriteLine("Список: ");
            foreach (var i in list) { Console.Write("{0} ", i); }
            Console.WriteLine();

            Console.WriteLine($"Количество элементов: {list.Count}");      // Вывод количества элементов

            Console.Write("Введите элемент для поиска: ");
            int search = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(list.Contains(search) ? "Найден" : "Не найден");       // Удаление элемента

        }
    }
}
