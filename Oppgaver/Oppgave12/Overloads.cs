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

        //public static void PrintWelcomeMessage(string greeting, string name)
        //{
        //    Console.WriteLine(greeting + " " + name);
        //}
    }

    //internal class MathOverloads
    //{
    //    //var result = Add(1, 2)
    //    public static int Add(int a, int b)
    //    {
    //        return a + b;
    //    }

    //    //var result = Add(1, 2, 3)
    //    public static int Add(int a, int b, int c)
    //    {
    //        return a + b + c;
    //    }

    //    //var result = Add(1.5, 2.5)
    //    public static double Add(double a, double b)
    //    {
    //        return a + b;
    //    }
    //}
}
