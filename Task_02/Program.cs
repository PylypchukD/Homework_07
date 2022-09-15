using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Создайте класс MyClass и структуру MyStruct, которые содержат в себе поля public string change. 
             * В классе Program создайте два метода:  static void ClassTaker(MyClass myClass), который присваивает полю change экземпляра myClass значение «изменено».  
             * static void StruktTaker(MyStruct myStruct), который присваивает полю change экземпляра myStruct значение «изменено». 
             * Продемонстрируйте разницу в использовании классов и структур, создав в методе Main() экземпляры структуры и класса. 
             * Измените, значения полей экземпляров на «не изменено», а затем вызовите методы ClassTaker и StruktTaker. Выведите на экран значения полей экземпляров. 
             * Проанализируйте полученные результаты. 
             */

            Console.WriteLine("Класс");
            
            MyClass myClass = new MyClass();   
            myClass.change = "не изменено";
            Console.WriteLine($"Было: {myClass.change}");

            ClassTaker(myClass);
            Console.WriteLine($"Стало: {myClass.change}");

            Console.WriteLine("Структура");
            
            MyStruct myStruct = new MyStruct();
            myStruct.change = "не изменено";
            Console.WriteLine($"Было: {myStruct.change}");

            StruktTaker(myStruct);
            Console.WriteLine($"Стало: {myStruct.change}");

            Console.ReadKey();
        }

        static void ClassTaker(MyClass myClass) 
        {
            myClass.change = "изменено";
        }

        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }
    }
}
