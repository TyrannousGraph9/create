using System;
using System.IO;
namespace Create
{
    public class Myprogram
    {
        public void Main()
        {
            Console.WriteLine("Wat is je naam?");
            string naam = Console.ReadLine();
            Log("Naam: " + naam);
            Car car = new Car();
            Console.WriteLine("Wat is het merk van je auto?");
            car.brand = Console.ReadLine();
            Log("Merk: " + car.brand);
            Console.WriteLine("Wat is het model van je auto?");
            car.model = Console.ReadLine();
            Log("Model: " + car.model);
            Read();
        }

        public void Log(string message)
        {
            string filePath = "log.txt";
            File.AppendAllText(filePath, message + Environment.NewLine);
        }

        public void Read()
        {
            string filePath = "log.txt";
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
    class Car
    {
        public string brand;
        public string model;
    }
}
