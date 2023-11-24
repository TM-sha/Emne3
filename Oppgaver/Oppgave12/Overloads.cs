namespace Variabel_Oppgaver.Oppgaver.Oppgave12
{
    internal class Overloads
    {
        public static void PrintWelcomeMessage()
        {
            Console.WriteLine($"Hei og velkommen");
        }

        public static void PrintWelcomeMessage(string greeting, string name = "Terje")
        {
            Console.WriteLine(greeting + " " + name);
        }
    }
}
