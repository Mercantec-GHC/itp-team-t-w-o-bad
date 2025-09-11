using System;
using System.Diagnostics;

namespace Opgaver
{
    public class ControlFlow
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(
                @"Velkommen til opgaver omkring Control Flow med if, else if og else, 
            Switch og Ternary operator!"
            );
            If1();
            If2();

            Switch1();
            Ternary1();

            MiniProjektQuiz();
            MiniProjektKarakterFeedback();
        }

        public static void If1()
        {
            //Console.WriteLine("Lav et program som tjekker om en given værdi er højere eller lavere end 18");
            // Lav opgaven herunder!
            Console.WriteLine("\n---\"If opgave 1\"---\n");

            double tal = 0;
            bool isValid = false;
            Console.WriteLine("\nIndtast et tal:\n");
            string talInput = Console.ReadLine();

            while (!isValid)
            {
                if (double.TryParse(talInput, out tal))
                {
                    tal = Convert.ToDouble(talInput);
                    if (tal > 18)
                    {
                        Console.WriteLine($"\nDet indtastede tal \"{tal}\" er større end 18.\n");
                    }
                    else if(tal < 18)
                    {
                        Console.WriteLine($"\nDet indtastede tal \"{tal}\" er mindre end 18.\n");
                    }
                    else
                    {
                        Console.WriteLine($"\nDet indtastede tal \"{tal}\" er lig med 18.\n");
                    }
                    isValid = true;
                }
                else
                {
                    Console.WriteLine($"\n\"{talInput}\" er ikke et tal, prøv venligst igen:\n");
                    talInput = Console.ReadLine();
                }
            }
        }

        public static void If2()
        {
            //Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
            Console.WriteLine("\n---\"If opgave 2\"---\n");

            bool isValid = false;
            int tal = 0;
            Console.WriteLine("\nIndtast et heltal:\n");
            string talInput = Console.ReadLine();

            while (!isValid)
            {
                if (int.TryParse(talInput, out tal))
                {
                    tal = Convert.ToInt32(talInput);
                    if (tal % 2 == 0)
                    {
                        Console.WriteLine($"\nDet indtastede tal \"{tal}\" er lige.\n");
                    }
                    else
                    {
                        Console.WriteLine($"\nDet indtastede tal \"{tal}\" er ulige.\n");
                    }
                    isValid = true;
                }
                else
                {
                    Console.WriteLine($"\n\"{talInput}\" er ikke et heltal, prøv venligst igen:\n");
                    talInput = Console.ReadLine();
                }
            }
        }

        public static void Switch1()
        {
            //Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
            Console.WriteLine("\n---\"Switch opgave\"---\n");

            bool isValid = false;
            int caseInput = 0;
            Console.WriteLine("\nIndtast et heltal:\n");
            string brugerInput = Console.ReadLine();

            while (!isValid)
            {
                if (int.TryParse(brugerInput, out caseInput))
                {
                    caseInput = Convert.ToInt32(brugerInput);
                    switch (caseInput % 2)
                    {
                        case 0:
                            Console.WriteLine($"\nDet indtastede tal \"{caseInput}\" er lige.\n");
                            isValid = true;
                            break;

                        case 1:
                            Console.WriteLine($"\nDet indtastede tal \"{caseInput}\" er ulige.\n");
                            isValid = true;
                            break;
                    }
                    
                }
                else
                {
                    Console.WriteLine($"\n\"{brugerInput}\" er ikke et heltal, prøv venligst igen:\n");
                    brugerInput = Console.ReadLine();
                }
            }
        }

        public static void Ternary1()
        {
            //Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
            Console.WriteLine("\n---\"Ternary opgave\"---\n");
            
            bool isValid = false;
            int tal = 0;
            Console.WriteLine("\nIndtast et heltal:\n");
            string talInput = Console.ReadLine();

            while (!isValid)
            {
                if (int.TryParse(talInput, out tal))
                {
                    tal = Convert.ToInt32(talInput);
                    
                    string resultat = (tal % 2 == 0) ?  "lige": "ulige";

                    Console.WriteLine($"\nDet indtastede tal \"{tal}\" er {resultat}.\n");
                    isValid = true;
                }
                else
                {
                    Console.WriteLine($"\n\"{talInput}\" er ikke et heltal, prøv venligst igen:\n");
                    talInput = Console.ReadLine();
                }
            }
        }

        public static void MiniProjektQuiz()
        {
            /*
            Console.WriteLine("\nMini-projekt: Simpelt quiz-spil (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                "Lav et program, der stiller brugeren tre spørgsmål (du vælger selv spørgsmål og svar)."
            );
            Console.WriteLine("Brugeren skal indtaste sit svar til hvert spørgsmål.");
            Console.WriteLine(
                "Programmet skal tjekke, om svaret er rigtigt eller forkert, og til sidst udskrive, hvor mange rigtige brugeren fik."
            );
            Console.WriteLine(
                "Tip: Brug variabler til at gemme point og svar, og if/else til at tjekke svarene."
            );
            // Lav opgaven herunder!
            */
            Console.WriteLine("\n---\"Miniprojekt 1 - Quiz opgave\"---\n");

            int point = 0;
            string question1 = "Er himlen blå?";
            string question2 = "Hvad er 2 + 2?";
            string question3 = "Er hunde bedre end katte?";
            string answer1 = "ja";
            string answer2 = "4";
            string answer3 = "ja";

            //Spørgsmål 1
            Console.WriteLine($"\nSpørgsmål 1: {question1}\n");
            string userAnswer1 = Console.ReadLine().ToLower();
            if(answer1 == userAnswer1)
            {
                point++;
                Console.WriteLine($"\nDet er korrekt, du er blevet tildelt 1 point\n");
            }
            else
            {
                Console.WriteLine($"\nDet er desværre forkert, du har ikke fået point\n");
            }

            //Spørgsmål 2
            Console.WriteLine($"\nSpørgsmål 2: {question2}\n");
            string userAnswer2 = Console.ReadLine().ToLower();
            if(answer2 == userAnswer2)
            {
                point++;
                Console.WriteLine($"\nDet er korrekt, du er blevet tildelt 1 point\n");
            }
            else
            {
                Console.WriteLine($"\nDet er desværre forkert, du har ikke fået point\n");
            }

            //Spørgsmål 3
            Console.WriteLine($"\nSpørgsmål 3: {question3}\n");
            string userAnswer3 = Console.ReadLine().ToLower();
            if (answer3 == userAnswer3)
            {
                point++;
                Console.WriteLine($"\nDet er korrekt, du er blevet tildelt 1 point\n");
            }
            else
            {
                Console.WriteLine($"\nDet er desværre forkert, du har ikke fået point\n");
            }
            Console.WriteLine($"\nQuizzen er overstået, din endelige score er: {point} point\n");
        }

        public static void MiniProjektKarakterFeedback()
        {
            /*
            Console.WriteLine("\nMini-projekt: Karakter-feedback (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                "Lav et program, hvor brugeren indtaster en karakter (fx 12, 10, 7, 4, 02, 00 eller -3)."
            );
            Console.WriteLine(
                @"Programmet skal give en passende feedback baseret på karakteren, 
            fx 'Super flot!', 'Godt klaret', 'Du kan gøre det bedre' osv."
            );
            Console.WriteLine("Brug if/else eller switch til at vælge feedbacken.");

            Console.WriteLine(
                @"Ekstra opgave: Lav så man indtaster flere karaktere 
            for en bruger og man regner gennemsnittet ud."
            );
            // Lav opgaven herunder!
            */
            Console.WriteLine("\n---\"Miniprojekt 2 - Karakter opgave\"---\n");

            bool isValid = false;
            int caseInput = 0;
            Console.WriteLine("\nIndtast en karakter som heltal:\n");
            string brugerInput = Console.ReadLine();

            while (!isValid)
            {
                if (int.TryParse(brugerInput, out caseInput))
                {
                    caseInput = Convert.ToInt32(brugerInput);
                    switch (caseInput)
                    {
                        case 12:
                            Console.WriteLine($"\nDu har indtastet karakteren \"{caseInput}\". Det er højeste karakter - super flot klaret.\n");
                            isValid = true;
                            break;

                        case 10:
                            Console.WriteLine($"\nDu har indtastet karakteren \"{caseInput}\". Det er en rigtig flot karakter.\n");
                            isValid = true;
                            break;

                        case 7:
                            Console.WriteLine($"\nDu har indtastet karakteren \"{caseInput}\". Det er en god karakter.\n");
                            isValid = true;
                            break;

                        case 4:
                            Console.WriteLine($"\nDu har indtastet karakteren \"{caseInput}\". Det er en middel karakter.\n");
                            isValid = true;
                            break;

                        case 2:
                            Console.WriteLine($"\nDu har indtastet karakteren \"0{caseInput}\". Det er kun lige tilstrækkeligt til at bestå.\n");
                            isValid = true;
                            break;

                        case 0:
                            Console.WriteLine($"\nDu har indtastet karakteren \"0{caseInput}\". Det er under middel og du er ikke bestået.\n");
                            isValid = true;
                            break;

                        case -3:
                            Console.WriteLine($"\nDu har indtastet karakteren \"{caseInput}\". Det er en ringe karakter og du er ikke bestået.\n");
                            isValid = true;
                            break;

                        default:
                            Console.WriteLine($"\nDet indtastede: \"{caseInput}\", er ikke genkendt som en karakter på 7-trins skalaén, prøv venligst igen.\n");
                            brugerInput = Console.ReadLine();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine($"\n\"{brugerInput}\" er ikke et heltal, prøv venligst igen:\n");
                    brugerInput = Console.ReadLine();
                }
            }
        }
    }
}
