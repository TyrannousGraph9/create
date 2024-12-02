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
            File.Delete(filePath);
        }
    }
    class Car
    {
        public string brand;
        public string model;
    }
}
