using System;

namespace Task_03
{
    internal struct Notebook
    {
        string model;
        string producer;
        double price;

        public Notebook(string model, string producer, double price)
        {
            this.model = model;
            this.producer = producer;
            this.price = price;
        }

        public void Show()
        {
            Console.WriteLine($"Ноутбук, модель {model}, производитель {producer}, цена {price}");
        }
    }
}
