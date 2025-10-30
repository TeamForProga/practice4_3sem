using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace practice4_3sem
{
    public class ObservableDemo
    {
        public static void DemoObservable()
        {
            Console.WriteLine("\n===== Пункт 4. ObservableCollection =====\n");

            // Создаём наблюдаемую коллекцию объектов ElecScooter
            ObservableCollection<ElecScooter> scooters = new();

            // Подписываемся на событие изменения коллекции
            scooters.CollectionChanged += Scooters_CollectionChanged;

            // Добавляем элементы — событие сработает автоматически
            Console.WriteLine("Добавляем элементы...");
            scooters.Add(new ElecScooter(true));
            scooters.Add(new ElecScooter(false));

            // Удаляем элемент — снова срабатывает событие
            Console.WriteLine("\nУдаляем элемент...");
            scooters.RemoveAt(0);

            // Просмотр текущего содержимого коллекции
            Console.WriteLine("\nТекущее содержимое коллекции:");
            foreach (var s in scooters)
            {
                s.Print();
            }
        }

        // Метод-обработчик события — будет вызван при любом изменении коллекции
        private static void Scooters_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Console.WriteLine("Добавлен новый элемент в коллекцию.");
                    break;

                case NotifyCollectionChangedAction.Remove:
                    Console.WriteLine("Элемент удалён из коллекции.");
                    break;

                case NotifyCollectionChangedAction.Replace:
                    Console.WriteLine("Элемент заменён.");
                    break;

                case NotifyCollectionChangedAction.Reset:
                    Console.WriteLine("Коллекция очищена.");
                    break;
            }
        }
    }
}
