using System;

namespace Create
{
    public class Opdrachten
    {
        static void Main()
        {
            Console.WriteLine("Opdracht 1");
            Opdracht_1();

            Console.WriteLine("Opdracht 2");
            Opdracht_2();
        
            Console.WriteLine("Opdracht 3");
            Opdracht_3();
        }

        static void Opdracht_1()
        {
            Console.WriteLine("Wat is je naam?");
            string naam = Console.ReadLine();
            Console.WriteLine("Hoe oud ben je?");
            int leeftijd = Convert.ToInt32(Console.ReadLine());

            if(leeftijd == 18)
            {
                Console.WriteLine("Je bent volwassen.");
            }
            else
            {
                Console.WriteLine("Je bent minderjarig.");
            }
        }

        static void Opdracht_2()
        {
            Console.WriteLine("Hoevaak wil je een tekst hebben herhaald?");

            int aantal = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < aantal; i++)
            {
            Console.WriteLine("Dit is regel " + (i + 1));
            }

            do
            {
            Console.WriteLine("Dit is regel " + aantal);
            aantal--;
            } while (aantal > 0);

            aantal = Convert.ToInt32(Console.ReadLine());
            while (aantal > 0)
            {
            Console.WriteLine("Dit is regel " + aantal);
            aantal--;
            }
        }

        public static void Opdracht_3()
        {
            Console.WriteLine("Geef een getal in");
            int numb1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef nog een getal in");
            int numb2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wat wil je doen? (+, -, *, /)");
            string operation = Console.ReadLine();
            Calculate(numb1, numb2, operation);
        }

        static void Calculate(int numb1, int numb2, string operation)
        {
            switch(operation)
            {
                case "+":
                    Console.WriteLine(numb1 + numb2);
                    break;
                case "-":
                    Console.WriteLine(numb1 - numb2);
                    break;
                case "*":
                    Console.WriteLine(numb1 * numb2);
                    break;
                case "/":
                    Console.WriteLine(numb1 / numb2);
                    break;
                default:
                    Console.WriteLine("Ongeldige operatie");
                    break;
            }
        }
        void Opdracht_4(int uitkomst)
        {
            Console.WriteLine("Geef een getal in");
            int numb1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef nog een getal in");
            int numb2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wat wil je doen? (+, -, *, /)");
            string operation = Console.ReadLine();
            
            uitkomst = Calculate_2(numb1, numb2, operation);
            Console.WriteLine(uitkomst);
        }

        static int Calculate_2(int numb1, int numb2, string operation)
        {
            int uitkomst = 0;
            switch(operation)
            {
                case "+":
                    uitkomst = numb1 + numb2;
                    break;
                case "-":
                    uitkomst = numb1 - numb2;
                    break;
                case "*":
                    uitkomst = numb1 * numb2;
                    break;
                case "/":
                    uitkomst = numb1 / numb2;
                    break;
                default:
                    Console.WriteLine("Ongeldige operatie");
                    break;
            }
            return uitkomst;
        }

        public void DisplayAnwser(int uitkomst)
        {
            Console.WriteLine("Het antwoord is: " + uitkomst);
        }



    }
}