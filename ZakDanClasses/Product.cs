using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZakDanClasses
{
    public class Product
    {
        //поля
        private string name;
        private string description;
        private double price;
        private int quantity;

        //свойства
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public double Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        //методы
        public void AddQuantity(int quantity)
        {
            this.quantity += quantity;
            Console.WriteLine($"ADDED {quantity} TO {name}");
        }
        public void SellProduct(int quantity)
        {
            if (this.quantity > quantity)
            {
                this.quantity -= quantity;
                Console.WriteLine($"SELL {quantity} ITEMS FROM {name}");
            }
            else
            {
                Console.WriteLine("Not Enough Quantity Of This Product");
            }
        }
        public void SetNewPrice(int price)
        {
            if (price >= 0)
            {
                this.price = price;
                Console.WriteLine($"UPDATED PRICE = {price} FOR {name}");
            }
            else
            {
                Console.WriteLine("Set Correct Price");
            }
        }

        public void Info()
        {
            Console.WriteLine($"\n==================================================================" +
                $"\nName = {name},\nDescription = {description}\nPrice = {price},\nQuantity = {quantity}\n");

        }

        //конструкторы
        public Product()
        {

        }
        public Product(string Name, string Description, double Price, int Quantity)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Quantity = quantity;
        }

    }
}
