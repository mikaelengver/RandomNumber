using System;

namespace RandomNumber
{
    class Program
    {
        static int hemligtTal;

        static void Main(string[] args)
        {

            var gissning = 0;
            var körIgen = false;

            StartText();

            while (hemligtTal != gissning)
            {
                var inmatning = Console.ReadLine();
                if (int.TryParse(inmatning, out gissning))
                {
                    if (hemligtTal == gissning && !körIgen)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Grattis du gissade rätt som var: " + hemligtTal);
                        Console.ResetColor();
                        Console.WriteLine("Vill du köra igen (j/n)");
                        var readkey = Console.ReadKey();
                        körIgen = readkey.KeyChar.Equals('j');
                        if (körIgen)
                        {
                            Console.WriteLine();
                            StartText();
                        }

                    }
                    else if (gissning > hemligtTal)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Du gissade på ett för stort tal.");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Du gissade på ett för litet tal.");
                        Console.ResetColor();
                    }
                }
            }

        }

        static void StartText()
        {
            var random = new Random();
            hemligtTal = (int)(random.NextDouble() * 1000);
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Hej, jag har slumpat ett hemligt tal mellan 1-1000.");
            Console.WriteLine("Gissa vilket tal det är?");
        }
    }
}
