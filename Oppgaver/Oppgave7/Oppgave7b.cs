namespace Variabel_Oppgaver.Oppgaver.Oppgave7
{
    internal class Oppgave7b
    {
        public static void PrintEveryCharInAString()
        {
            string charInSentence = "onomatopoetikon";
            foreach (var character in charInSentence)
            {
                Console.WriteLine(character);
            }

            //string charInSentence = "onomatopoetikon"; Ville gjort det samme
            //foreach (char a in charInSentence)
            //{
            //    Console.WriteLine(a.ToString());
            //}
        }
    }
}
