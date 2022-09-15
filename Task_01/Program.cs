using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Используя Visual Studio, создайте проект по шаблону Console Application. 
             * Требуется: Описать структуру с именем Train, содержащую следующие поля: название пункта назначения, номер поезда, время отправления. 
             * Написать программу, выполняющую следующие действия:  ввод с клавиатуры данных в массив, состоящий из восьми элементов типа Train (записи должны быть упорядочены по номерам поездов);  
             * вывод на экран информации о поезде, номер которого введен с клавиатуры (если таких поездов нет, вывести соответствующее сообщение). 
             */

            Train[] train = new Train[8];

            HandlerTrain.Add(train);
            HandlerTrain.Sort(train);
            HandlerTrain.Show(train);

            HandlerTrain.Find(train, 12);


            Console.ReadKey();
        }
    }
}
