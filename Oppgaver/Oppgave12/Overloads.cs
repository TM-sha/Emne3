namespace Variabel_Oppgaver.Oppgaver.Oppgave12
{
    internal class Overloads
    {
        //PrintWelcomeMessage();                        - Hei og velkommen Terje
        //PrintWelcomeMessage("Tommy");                 - Hei og velkommen Tommy
        //PrintWelcomeMessage("Gå vekk");               - Hei og velkommen Gå vekk
        //PrintWelcomeMessage("Kom tilbake", "Stian");  - Kom tilbake, Stian

        public static void PrintWelcomeMessage(string name = "Terje")
        {
            Console.WriteLine($"Hei og velkommen {name}");
        }

        public static void PrintWelcomeMessage(string greeting, string name)
        {
            Console.WriteLine(greeting + " " + name);
        }
    }
}
