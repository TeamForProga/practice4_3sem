using System.Collections;

namespace practice4_3sem
{
    public class NotGenCollection
    {
        public static void ArList()
        {
            // Создание коллекции ArrayList
            ArrayList list = new ArrayList();
            // Заполнение ее 5-ю случайными целыми числами
            for (int i = 0; i < 5; i++)
            {
                var rand = new Random();
                list.Add(rand.Next(10));
            }
            list.Add("AS");     // Добавление строки

            Console.WriteLine("Список: ");
            foreach (var i in list) { Console.Write("{0} ", i); }
            Console.WriteLine();

            Console.Write("Введите элемент для удаления: ");
            int delNum = Convert.ToInt32(Console.ReadLine());
            list.Remove(delNum);       // Удаление элемента

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
