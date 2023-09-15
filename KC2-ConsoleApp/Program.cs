using System;
using System.Collections.Generic;

namespace petsRus
{
    // Define the base class Product
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price:C}, Quantity: {Quantity}, Description: {Description}";
        }
    }

    // Define the CatFood class inheriting from Product
    class CatFood : Product
    {
        public double WeightPounds { get; set; }
        public bool KittenFood { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", Weight (lbs): {WeightPounds}, Kitten Food: {KittenFood}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<CatFood>();

            for (int i = 0; i < numberOfRecords; i++)
            {
                Console.Write("Enter CatFood Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter CatFood Price: ");
                decimal price = decimal.Parse(Console.ReadLine());

                Console.Write("Enter CatFood Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Console.Write("Enter CatFood Description: ");
                string description = Console.ReadLine();

                Console.Write("Enter CatFood Weight (in pounds): ");
                double weight = double.Parse(Console.ReadLine());

                Console.Write("Is it Kitten Food? (true or false): ");
                bool isKittenFood = bool.Parse(Console.ReadLine());

                // Create a CatFood object
                CatFood catFood = new CatFood
                {
                    Name = name,
                    Price = price,
                    Quantity = quantity,
                    Description = description,
                    WeightPounds = weight,
                    KittenFood = isKittenFood
                };

                recordList.Add(catFood);
            }

            // Print the objects in recordList
            foreach (var catFood in recordList)
            {
                Console.WriteLine(catFood.ToString());
            }

            // Continue with your Git upload steps here
        }
    }
}
