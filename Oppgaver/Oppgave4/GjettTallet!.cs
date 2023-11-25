using System.Runtime.InteropServices;

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
            Console.WriteLine("Guess a number between 1 and 100");
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
                Console.WriteLine("Correct! You wanna play again? y/n ");
                Console.WriteLine();
                if (Console.ReadLine() == "y")
                {
                    Console.WriteLine();
                    GuessTheNumber();
                }
                else
                {
                    Program.Main();
                    //Environment.Exit(0);
                }
            }
            Console.WriteLine();
            anotherGuessTheNumber(rndNumber);
        }
    }
}
