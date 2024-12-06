using System;
using System.IO;
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

            Console.WriteLine("Opdracht 4");
            int uitkomst = 0;
            Opdracht_4(uitkomst);

            Console.WriteLine("Opdracht 5");
            string uitkomst_2 = "";
            Opdracht_5(uitkomst_2);

            Console.WriteLine("Opdracht 6");
            Opdracht_6();

            Console.WriteLine("Opdracht 7");
            Opdracht_7();

            Console.WriteLine("Opdracht 8");
            Opdracht_8();
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
            else if(leeftijd > 18)
            {
                Console.WriteLine("Je bent meerderjarig.");
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
            int max_aantal = aantal;

            for (int i = 0; i < aantal; i++)
            {
            Console.WriteLine("Dit is regel " + (i + 1));
            }

            aantal = max_aantal;
            do
            {
            Console.WriteLine("Dit is regel " + aantal);
            aantal--;
            } while (aantal > 0);

            aantal = max_aantal;

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
                    if(numb1 == 0 || numb2 == 0)
                    {
                        Console.WriteLine("0");
                    }
                    else
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
        static void Opdracht_4(int uitkomst)
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
                    if(numb1 == 0 || numb2 == 0)
                    {
                        Console.WriteLine("0");
                    }
                    else
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

        static void Opdracht_5(string uitkomst)
        {
            Console.WriteLine("Geef een getal in");
            int numb1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef nog een getal in");
            int numb2 = Convert.ToInt32(Console.ReadLine());
            
            uitkomst = Calculate_3(numb1, numb2);
            Console.WriteLine(uitkomst);
        }

        public static string Calculate_3(int numb1, int numb2)
        {
            string uitkomst = "";
            uitkomst = "Als ik deze getallen optel krijg ik: " + (numb1 + numb2);
            return uitkomst;
        }

        static void Opdracht_6()
        {
            List<int> list = new List<int>();
            
            for (int i = 1; i < 6; i++)
            {
                list.Add(i);
            }

            Console.WriteLine("Welk getal wil je verwijderen?");
            int numb = Convert.ToInt32(Console.ReadLine());
            if(numb > 6 || numb < 1)
            {
                Console.WriteLine("Dit getal staat niet in de lijst.");
                return;
            }
            else
            {
                list.Remove(numb);
                Console.WriteLine("Het getal is verwijderd, dit blijft er over:");
                foreach (int i in list)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Opdracht_7()
        {
            int[] numbArray = [1,2,3,4,5,6];
            
            Console.WriteLine("Welk getal wil je verwijderen?");
            int numb = Convert.ToInt32(Console.ReadLine());
            if(numb > 6 || numb < 1)
            {
                Console.WriteLine("Dit getal staat niet in de lijst.");
                return;
            }
            else
            {
                int[] newArray = numbArray.Take(numb).ToArray();
                newArray = numbArray.Where(x => x != numb).ToArray();
                Console.WriteLine("Het getal is verwijderd, dit blijft er over:");
                foreach (int i in newArray)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void MaakTekstBestand()
        {
            File.Create("namen.txt");
    
            string[] names = {"Jan", "Piet", "Joris", "Korneel"};
            File.WriteAllLines("namen.txt", names);
        }
        static void Opdracht_8()
        {
            MaakTekstBestand();
            Console.WriteLine("Wat wil je doen? (add, remove, display)");
            string keuze = Console.ReadLine();

            switch(keuze)
            {
                case "add":
                    Add();
                    break;
                case "remove":
                    Remove();
                    break;
                case "display":
                    Display();
                    break;
                default:
                    Console.WriteLine("Ongeldige keuze");
                    Opdracht_8();
                    break;
            }
        }


        static void Add()
        {
            Console.WriteLine("Welke naam wil je toevoegen?");
            string naam = Console.ReadLine();
            string fileContents = File.ReadAllText("namen.txt");
            if(fileContents.Contains(naam))
            {
                Console.WriteLine("Deze naam staat al in het bestand");
                return;
            }
            else
            {
                File.Open("namen.txt", FileMode.Append);

                File.AppendAllText("namen.txt", naam + Environment.NewLine);
                Console.WriteLine("Naam toegevoegd");
                Opdracht_8();
            }
        }

        static void Remove()
        {
            Console.WriteLine("Welke naam wil je verwijderen?");
            string naam = Console.ReadLine();
            string fileContents = File.ReadAllText("namen.txt");
            if(fileContents.Contains(naam))
            {
                fileContents = fileContents.Replace(naam, "");
                File.WriteAllText("namen.txt", fileContents);
                Console.WriteLine("Naam verwijderd");
            }
            else
            {
                Console.WriteLine("Naam niet gevonden");
            }

        }

        static void Display()
        {
            Console.WriteLine("Welke naam wil je zien?");
            string naam = Console.ReadLine();   
            string fileContents = File.ReadAllText("namen.txt");
            if(fileContents.Contains(naam))
            {
                Console.WriteLine(naam);
                Opdracht_8();
            }
            else
            {
                Console.WriteLine("Naam niet gevonden");
            }
        }
    }
}