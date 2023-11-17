namespace Variabel_Oppgaver.Oppgaver.Oppgave4
{
    internal class GjettTallet
    {
        public static void GuessTheNumber()
        {
            Random number = new Random();
            int rndNumber = number.Next(1, 101);
            anotherGuessTheNumber(rndNumber);
        }

      
        static void anotherGuessTheNumber(int rndNumber)
        {
            Console.WriteLine("Gjett et tall mellom 1 og 100");
            Console.WriteLine();
            int guessedNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (guessedNumber < rndNumber)
            {
                Console.WriteLine("Higher...");
            }
            else if (guessedNumber > rndNumber)
            {
                Console.WriteLine("Lower...");
            }
            else
            {
                Console.WriteLine("Riktig! Vil du spille på nytt? y/n");
                Console.WriteLine();
                if (Console.ReadLine() == "y")
                {
                    Console.WriteLine();
                    GuessTheNumber();
                }
                else
                {
                    Environment.Exit(1);
                }
            }
            Console.WriteLine();
            anotherGuessTheNumber(rndNumber);
        }
    }
}
