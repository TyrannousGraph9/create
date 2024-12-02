using System;

namespace Create
{
    public class MainProgram
    {
        static void Main()
        {
            Myprogram myprogram = new Myprogram();
            myprogram.Main();
            Car car = new Car();
            Console.WriteLine("Wat is het merk van je auto?");
            car.brand = Console.ReadLine();
            myprogram.Log("Merk: " + car.brand);
            Console.WriteLine("Wat is het model van je auto?");
            car.model = Console.ReadLine();
            myprogram.Read();
        }
    }
}