namespace Variabel_Oppgaver.Oppgaver.Oppgave5
{
    internal class Oppgave5a
    {
        public static bool ReturnTrueIfNumbersEqual(int number1, int number2)
        {

            if (number1 == number2)
            {
                Console.WriteLine("Tallene er like");
                return true;
            }
            Console.WriteLine("Tallene er ulike");
            return false;
        }
    }
}
