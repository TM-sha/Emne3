namespace Variabel_Oppgaver.Oppgaver.Oppgave6
{
    internal class Oppgave6b
    {
        public static void WhichDayInWeekend2()
        {
           // while(true) Looper funskjonen
           // {
                Console.WriteLine("Which day do you want to see? 1-7");
                Console.WriteLine();
                var nmb = Console.ReadLine();
                Console.WriteLine();
                switch(nmb)
                {
                case "1":
                    Console.WriteLine("Monday");
                    break;
                case "2":
                    Console.WriteLine("Tuesday");
                    break;
                case "3":
                    Console.WriteLine("Wednesday");
                    break;
                case "4":
                    Console.WriteLine("Thursday");
                    break;
                case "5":
                    Console.WriteLine("Friday");
                    break;
                case "6":
                    Console.WriteLine("Saturday");
                    break;
                case "7":
                    Console.WriteLine("Sunday");
                    break;
                default:
                    WhichDayInWeekend2();
                    break;
                };
                Console.WriteLine();   
           // }
        }
    }
}
