using System;

namespace Opgaver
{
    public class Loops
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Velkommen til opgaver omkring Loops både med og uden datastrukturer!");
            //Loop1();
            //Loop2();
            //Loop3();
            //Loop4();
            //Loop5();
            //Loop6();
            //Loop7();
            //Loop8();
            //Loop9();
            //Loop10();
            BankeBøf();
            //MiniProjektLommeregner();
        }

        public static void Loop1()
        {
            Console.WriteLine("Opgave 1:");
            Console.WriteLine("Brug et loop til at udskrive tallene fra 1 til 10.");
            // Lav opgaven herunder!
            
            Console.WriteLine();
            for(int i = 1; i <= 10; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n");
        }

        public static void Loop2()
        {
            Console.WriteLine("Opgave 2:");
            Console.WriteLine("Brug et loop og en if-betingelse til at udskrive alle lige tal fra 2 til 20.");
            // Lav opgaven herunder!

            Console.WriteLine();
            for(int i = 1; i <= 20; i++)
            {
                if(i % 2 == 1)
                {
                    continue;
                }
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n");
        }

        public static void Loop3()
        {
            Console.WriteLine("Opgave 3:");
            Console.WriteLine("Brug et loop til at lægge alle tal fra 1 til 100 sammen og udskriv resultatet.");
            // Lav opgaven herunder!
            int sum = 0;
            
            Console.WriteLine();
            for(int i = 1; i <= 100; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine($"Summen er: \"{sum}\"\n");
        }

        public static void Loop4()
        {
            Console.WriteLine("Opgave 4:");
            Console.WriteLine("Bed brugeren om at indtaste sit navn og et tal. Udskriv navnet det antal gange ved hjælp af et loop.");
            // Lav opgaven herunder!
            bool isValid = false;
            Console.WriteLine($"\nIndtast dit navn:\n");
            string userName = Console.ReadLine();
            Console.WriteLine($"\nIndtast det antal gange dit navn skal vises (som et heltal):\n");
            string userInput = Console.ReadLine();
            int tal = 0;
            
            while(!isValid)
            {
                if(int.TryParse(userInput, out tal))
                {
                    Console.WriteLine();
                    for (int i = 0; i < tal; i++)
                    {
                        Console.Write($"{userName} ");
                    }
                    Console.WriteLine("\n");
                    isValid = true;
                }
                else
                {
                    Console.WriteLine($"\nDet indtastede er ikke et heltal, prøv venligst igen:\n");
                    userInput = Console.ReadLine();
                }
            }
        }

        public static void Loop5()
        {
            Console.WriteLine("Opgave 5:");
            Console.WriteLine("Bed brugeren om at indtaste et tal. Brug et loop til at udskrive alle tal fra det indtastede tal og ned til 1.");
            // Lav opgaven herunder!
            Console.WriteLine($"\nIndtast et heltal:\n");
            bool isValid = false;
            string userInput = Console.ReadLine();
            int tal = 0;

            while (!isValid)
            {
                if(int.TryParse(userInput,out tal))
                {
                    Console.WriteLine();
                    for (int i = tal; i > 0; i--)
                    {
                        Console.Write($"{i} ");
                    }
                    Console.WriteLine("\n");
                    isValid = true;
                }
                else
                {
                    Console.WriteLine($"\nDet indtastede \"{userInput}\" er ikke et heltal, prøv venligst igen:\n");
                    userInput = Console.ReadLine();
                }

            }
        }

        public static void Loop6()
        {
            Console.WriteLine("Opgave 6:");
            Console.WriteLine(@"Brug et loop til at udskrive alle bogstaverne i dit navn (ét bogstav pr. linje). 
            Navnet skal være gemt i en string variabel.");
            // Lav opgaven herunder!
            Console.WriteLine($"\nIndtast navn");
            string userName = Console.ReadLine();
            Console.WriteLine();
            
            foreach(char c in userName)
            {
                Console.Write($"{c} ");
            }
            Console.WriteLine("\n");
        }

        public static void Loop7()
        {
            Console.WriteLine("Opgave 7:");
            Console.WriteLine("Brug et loop til at tælle, hvor mange gange bogstavet 'a' optræder i en tekst, som brugeren indtaster.");
            // Lav opgaven herunder!
            int counter = 0;
            Console.WriteLine("\nIndtast en tekst:");
            string userInput = Console.ReadLine().ToLower();

            foreach(char c in userInput)
            {
                if(c.Equals('a'))
                {
                    counter += 1;
                }
            }
            Console.WriteLine($"\nDen indtastede tekst indeholder {counter} \"a'er\".\n");
        }

        public static void Loop8()
        {
            Console.WriteLine("Opgave 8:");
            Console.WriteLine("Brug et loop til at udskrive alle ulige tal mellem 1 og 50.");
            // Lav opgaven herunder!
            Console.WriteLine();
            
            for(int i = 0; i <= 50; i++)
            {
                if(i %  2 == 0)
                {
                    continue;
                }
                else
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine("\n");
        }

        public static void Loop9()
        {
            Console.WriteLine("Opgave 9:");
            Console.WriteLine("Bed brugeren om at indtaste 5 tal (ét ad gangen). Brug et loop til at lægge dem sammen og udskriv summen til sidst.");
            // Lav opgaven herunder!
            bool isInt = false;
            int[] numbers = new int[5];
            int count = 0;

            Console.WriteLine($"\nDu skal nu indtaste 5 tal, som lægges sammen. Indtast første tal:");
            string brugerInput = Console.ReadLine();

            while (!isInt)
            {
                if(int.TryParse(brugerInput, out count))
                {

                }
                else
                {
                    Console.WriteLine($"\nDet indtastede er ikke et heltal, prøv igen:\n");
                    brugerInput = Console.ReadLine();
                }
            }

        }

        public static void Loop10()
        {
            Console.WriteLine("Opgave 10:");
            Console.WriteLine("Lav et program, hvor brugeren skal gætte et hemmeligt tal mellem 1 og 10. Brug et loop, så brugeren kan gætte indtil det rigtige tal er fundet.");
            // Lav opgaven herunder!
        }

        public static void BankeBøf()
        {
            Console.WriteLine(@"Lav et program med et loop, som udskriver tallene fra 1 til 30. 
            Udskriv 'Banke' hvis tallet er deleligt med 3, 'Bøf' hvis tallet er deleligt med 5 
            og 'BankeBøf' hvis tallet er deleligt med både 3 og 5.");
            // Lav opgaven herunder!
            Console.WriteLine();

            for(int i = 1;i <= 30; i++)
            {
                if( i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write($"Bankebøf ");
                }
                else if( i % 3 == 0)
                {
                    Console.Write($"Banke ");
                }
                else if(i % 5 == 0)
                {
                    Console.Write($"Bøf ");
                }
                else
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine("\n");
        }
        public static void MiniProjektLommeregner()
        {
            Console.WriteLine("\nMini-projekt: Simpel lommeregner (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine("Lav et program, hvor brugeren indtaster to tal og vælger en regneart (+, -, * eller /).");
            Console.WriteLine("Programmet skal udregne og udskrive resultatet.");
            Console.WriteLine("Tip: Brug if/else eller switch til at vælge regnearten.");
            // Lav opgaven herunder!
        }
    }
}