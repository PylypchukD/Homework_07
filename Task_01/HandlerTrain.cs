using System;

namespace Task_01
{
    static class HandlerTrain
    {
        public static void Sort(Train[] trains)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                for (int j = 0; j < trains.Length; j++)
                {
                    if (trains[i].Number <= trains[j].Number)
                    {
                        Train temp = trains[i];
                        trains[i] = trains[j];
                        trains[j] = temp;
                    }
                }
            }
        }
        public static void Show(Train[] trains)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine($"Поезд №{trains[i].Number}, пункт назначения: {trains[i].Destination}, дата прибытия: {trains[i].DepartureTime}");
            }
        }
        public static void Add(Train[] trains)
        {
            string destination;
            int number;
            DateTime departureTime;

            for (int i = 0; i < trains.Length; i++)
            {
                Console.Write("Введите номер поезда: ");

                int.TryParse(Console.ReadLine(), out number);

                Console.Write("Введите место назначение поезда: ");
                string answer = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(answer))
                    destination = "<>";
                else
                    destination = answer;

                Console.Write("Введите дату отправления: ");
                answer = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(answer))
                    departureTime = DateTime.MinValue;
                else
                    departureTime = DateTime.Parse(answer);

                trains[i] = new Train(destination, number, departureTime);
            }
        }
        public static void Find(Train[] trains, int number)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                if (trains[i].Number == number)
                {
                    Console.WriteLine($"Найден поезд №{trains[i].Number}, пункт назначения: {trains[i].Destination}, дата прибытия: {trains[i].DepartureTime}");
                    break;
                }

            }
            Console.WriteLine($"Поезд №{number} не найден");
        }
    }
}
