using System;

namespace Opgaver
{
    public class Inputs
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Velkommen til opgaver omkring Expressions, Operators og Inputs!");
            String1();
            Int1();
            Double1();
            Bool1();

            // Mini-projekter til inspiration:
            MiniProjekt1();
            MiniProjekt2();
        }
        
        public static void String1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som en string og skriver strengen ud i konsollen"
            );

            Console.WriteLine("Indtast en streng: ");
            // Lav opgaven herunder!
            string tekst = Console.ReadLine();
            Console.WriteLine($"\nDu har indtastet: {tekst}\n");
        }

        public static void Int1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som et tal og skriver tallet ud i konsollen"
            );

            Console.WriteLine("Indtast et tal: ");
            // Lav opgaven herunder!
            int tal = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine($"\nDu har indtastet: {tal}\n");
        }

        public static void Double1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som et decimaltal og skriver tallet ud i konsollen"
            );

            Console.WriteLine("Indtast et decimaltal: ");
            // Lav opgaven herunder!
            float tal = Convert.ToSingle( Console.ReadLine() );
            Console.WriteLine($"\nDu har indtastet: {tal}\n");
        }

        public static void Bool1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som en sandhedsværdi og skriver værdien ud i konsollen"
            );

            Console.WriteLine("Indtast en sandhedsværdi (true/false): ");
            // Lav opgaven herunder!
            //bool boolVar = Convert.ToBoolean( Console.ReadLine() );
            //Console.WriteLine($"\nDu har indtastet: {boolVar}\n");
            string input = Console.ReadLine();
            bool boolVar;

            if (bool.TryParse(input, out boolVar))
            {
                Console.WriteLine($"\nDu har indtastet: {boolVar}\n");
            }
            else
            {
                Console.WriteLine($"\nUgyldigt input. Du skrev: {input}. Skriv enten true eller false.\n");
            }
        }
        
        // Mini-projekt: Personlig profil (skabelon)
        public static void MiniProjekt1()
        {
            Console.WriteLine("\nMini-projekt: Personlig profil (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine("Lav et program, hvor brugeren indtaster sit navn, alder og hjemby.");
            Console.WriteLine(
                "Gem oplysningerne i variabler og udskriv en præsentationstekst, der bruger alle oplysningerne."
            );
            //Console.WriteLine("Eksempel: Hej, jeg hedder X, er X år gammel og kommer fra X!");
            // Lav opgaven herunder!
            int alder = 0;

            Console.WriteLine("\nIndtast dit navn:");
            string navn = Console.ReadLine();

            Console.WriteLine("\nIndtast din alder");
            alder = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nIndtast din hjemby");
            string hjem = Console.ReadLine();

            Console.WriteLine($"Hej, jeg hedder {navn}, jeg er {alder} år gammel og kommer fra {hjem}.");
        }

        // Mini-projekt 2: BMI-beregner (skabelon)
        public static void MiniProjekt2()
        {
            Console.WriteLine("\nMini-projekt 2: BMI-beregner (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                "Lav et program, hvor brugeren indtaster sin vægt (i kg) og højde (i meter)."
            );
            Console.WriteLine("Programmet skal beregne brugerens BMI og udskrive resultatet.");
            Console.WriteLine(
                "Tip: BMI beregnes som vægt divideret med højde i anden (BMI = vægt / (højde * højde))."
            );
            
            Console.WriteLine("\nIndtast din højde i meter:");
            float højde = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\nIndtast din vægt i Kg");
            float vægt = Convert.ToSingle(Console.ReadLine());
            
            float bmi = vægt / (højde * højde);
            Console.WriteLine($"\nDit BMI-tal er: {bmi}\n");
            
            /*
            Console.WriteLine("\nIndtast din højde i meter:");
            string højde = Console.ReadLine();
            float fHøjde;

            Console.WriteLine("\nIndtast din vægt i Kg:");
            string vægt = Console.ReadLine();
            float fVægt;

            if(float.TryParse(højde, out fHøjde) && float.TryParse(vægt, fVægt))
            {
                float bmi = fVægt / (fHøjde * fHøjde);
                Console.WriteLine($"\nDit BMI-tal er: {bmi}\n");
            }
            else
            {
                Console.WriteLine("Input kunne ikke konverteres til decimal-tal, prøv igen");
            }
            */
        }
    }
}
