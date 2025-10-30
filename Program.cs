using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace practice4_3sem
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("===== Работа с необобщённой коллекцией ArrayList (пункт 1) =====");
            NotGenCollection.ArList();

            Console.WriteLine("\n===== Работа с обобщённой коллекцией Dictionary<string, string> и Stack<string> (пункт 2) =====");
            GenCollection.Collections();


            Console.WriteLine("===== Работа с пользовательским классом ElecScooter (пункт 3) =====");


            // Создаём несколько объектов вручную
            ElecScooter scooter1 = new ElecScooter(true);
            ElecScooter scooter2 = new ElecScooter(false);

            Console.WriteLine("\nДемонстрация метода Print():");
            scooter1.Print();
            scooter2.Print();

            Console.WriteLine("\nСравнение объектов (CompareTo):");
            int result = scooter1.CompareTo(scooter2);
            if (result > 0) Console.WriteLine("Первый электросамокат 'больше' (имеет сиденье)");
            else if (result < 0) Console.WriteLine("Второй электросамокат 'больше' (не имеет сиденья)");
            else Console.WriteLine("Оба электросамоката равны");

            Console.WriteLine("\nКлонирование объекта:");
            var clone = (ElecScooter)scooter1.Clone();
            clone.Print();
            Console.WriteLine($"Клон равен оригиналу? {clone.Equals(scooter1)}");

            // Вызов основной демонстрации из пункта 3
            Console.WriteLine("\n===== Демонстрация работы коллекций (пункт 3) =====");
            ElecScooter.Point2ForElecScooter();


            // === пункт 4 ===
            Console.WriteLine("\n===== Демонстрация ObservableCollection (пункт 4) =====");
            ObservableDemo.DemoObservable();

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
