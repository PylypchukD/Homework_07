using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Используя Visual Studio, создайте проект по шаблону Console Application. 
             * Создайте структуру с именем - Notebook. Поля структуры: модель, производитель, цена. 
             * В структуре должен быть реализован конструктор для инициализации полей и метод для вывода содержимого полей на экран.
             */

            Notebook notebook = new Notebook("Zenbook", "Asus", 35000.00);
            notebook.Show();

            Console.ReadKey();

        }
    }
}
