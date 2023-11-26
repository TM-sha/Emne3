namespace Variabel_Oppgaver.Oppgaver.Oppgave6
{
    internal class Oppgave6a
    {
        public static void WhichDay(int nmb)                          //her legger du inn parameter fra hvor du kjører den
        {
            Console.WriteLine("Which day do you want to see? 1-7");     
            Console.WriteLine();                                        

            var result = nmb switch //ekspressiv
            {
                1 => "Monday",
                2 => "Tuesday",
                3 => "Wednesday",
                4 => "Thursday",
                5 => "Friday",
                6 => "Saturday",
                7 => "Sunday",
                _ => "Unknown input",
            };
            Console.WriteLine(result);
        }
    }
}
