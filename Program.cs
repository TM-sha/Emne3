using System.ComponentModel.Design;
using System.Diagnostics;
using Variabel_Oppgaver.Oppgave1;
using Variabel_Oppgaver.Oppgaver.Oppgave1;
using Variabel_Oppgaver.Oppgaver.Oppgave2;
using Variabel_Oppgaver.Oppgaver.Oppgave3;
using Variabel_Oppgaver.Oppgaver.Oppgave4;
using Variabel_Oppgaver.Oppgaver.Oppgave5;
using Variabel_Oppgaver.Oppgaver.Oppgave6;
using Variabel_Oppgaver.Oppgaver.Oppgave7;
using Variabel_Oppgaver.Oppgaver.Oppgave8;
using Variabel_Oppgaver.Oppgaver.Oppgave12;

namespace Variabel_Oppgaver
{
    public class Program
    {
        public static void Main()
        {
            DisplayMenu();

            //forslag fra Stian:
            //lag en DisplayMenu() metode som viser all den teksten du har lenger opp, istedenfor å ha det i Main
            //lag en GetTaskNumber() som tar for seg input delen
            //lag en ExecuteTask(int taskNr) som inneholder switch statementen
        }

        private static void DisplayMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hei på deg! Velkommen til min oversikt over oppgaver i Moodle Emne 3 \n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Skriv inn et tall fra 1 til 17 for å velge oppgaven du vil se på: \n" +
                              "\t\t\t\t1 => \"PrintInputFromUser\"\n\t\t\t\t2 => \"Make 8 variables\"\n\t\t\t\t3 => \"Consoll-application that creates 3 variables\"\n" +
                              "\t\t\t\t4 => \"ReturnSumOfToNumbers\"\n\t\t\t\t5 => \"ReturnsNothing\"\n\t\t\t\t6 => \"RandomHobbyGenerator\"\n" +
                              "\t\t\t\t7 => \"GuessTheNumber\"\n\t\t\t\t8 => \"ReturnTrueIfNumbersEqual\"\n\t\t\t\t9 => \"ReturnNumberIfNotEqualAndIfEqual\"\n" +
                              "\t\t\t\t10 => \"ifElseReturnTrueReturnFalse\"\n\t\t\t\t11 => \"WhichDay\"\n\t\t\t\t12 => \"WhichDay2 - ReadLine\"\n" +
                              "\t\t\t\t13 => \"MakeForLoopPrintFiveTimes\"\n\t\t\t\t14 => \"PrintEveryCharInAString\"\n\t\t\t\t15 => \"PrintNumberOfRounds - ReadLine\"\n" +
                              "\t\t\t\t16 => \"CrocoGame\"\n\t\t\t\t17 => \"OverloadsAndDefaultValues\"");


            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Tast inn tall og trykk Enter\t");
            Console.ForegroundColor = ConsoleColor.White;
            var taskNr = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;

            GetTaskNumber(taskNr);
        }


        private static void GetTaskNumber(int taskNr)
        {
            Console.Write($"Vil du se på oppgave {taskNr}? ja/nei: ");
            if (Console.ReadLine().ToLower() == "ja")
            {
                ExecuteTask(taskNr);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Programmet avsluttes.");
            }
        }


        private static void ExecuteTask(int taskNr)
        {

            switch (taskNr)
            {
                case 1:
                    ExectueTask(KonsollApp.Oppgave);
                    break;
                case 2:
                    ExectueTask(Variabler.Oppgave);
                    break;
                case 3:
                    ExectueTask(KonsollAppVariabel.Oppgave);
                    break;
                case 4:
                    ExecuteTask(() => SumAvToTall.ReturnerSumAvToTall(5, 25)); //Skriv inn forskjellig tall
                    break;
                case 5:
                    ExectueTask(SumAvToTallOppgave2.HarIngenting);
                    break;
                case 6:
                    ExectueTask(RandomHobbyGenerator.GenerateRandomHobbies);
                    break;
                case 7:
                    ExectueTask(GjettTallet.GuessTheNumber);
                    break;
                case 8:
                    ExectueTask(() => Oppgave5a.ReturnTrueIfNumbersEqual(4, 4)); //Skriv inn forskjellig tall
                    break;
                case 9:
                    ExectueTask(() => Oppgave5b.ReturnNumberIfNotEqualAndIfEqual(5, 45)); //Skriv inn forskjellig tall
                    break;
                case 10:
                    ExectueTask(() => Oppgave5c.ifElseReturnTrueReturnFalse(10, 20)); //Skriv inn forskjellig tall
                    break;
                case 11:
                    ExectueTask(Oppgave6a.WhichDay, 5); //Skriv et annet tall for å printe ut annen dag
                    break;
                case 12:
                    ExectueTask(Oppgave6b.WhichDay2);
                    break;
                case 13:
                    ExectueTask(Oppgave7a.MakeForLoopPrintFiveTimes);
                    break;
                case 14:
                    ExectueTask(Oppgave7b.PrintEveryCharInAString);
                    break;
                case 15:
                    ExectueTask(Oppgave7c.PrintNumberOfRounds);
                    break;
                case 16:
                    ExectueTask(Krokodillespillet.CrocoGame, 0); //Exiter loopen når man skriver inn en bokstav
                    break;
                case 17:
                    //PrintWelcomeMessage(); -> Hei og velkommen Terje
                    //PrintWelcomeMessage("Tommy"); -> Hei og velkommen Tommy
                    ExectueTask(() => Overloads.PrintWelcomeMessage("Tommy"));
                    break;
                default:
                    Console.Write("Ugyldig oppgavenummer. Vil du prøve på nytt? ja/nei: ");
                    if (Console.ReadLine() != "ja")
                    {
                        Environment.Exit(0);
                    }
                    break;
            }
        }


        #region ExecuteTask
        //kjører oppgaver som ikke har noen parametere, som ikke returnerer en verdi
        private static void ExectueTask(Action oppgave)
        {
            Console.Clear();
            Console.WriteLine();
            oppgave.Invoke();// =>
            SeFlereOppgaver();
        }

        //kjører oppgaver som har ett parameter, som ikke returnerer en verdi
        private static void ExectueTask<T>(Action<T> oppgave, T param)
        {
            Console.Clear();
            Console.WriteLine();
            oppgave.Invoke(param);
            SeFlereOppgaver();
        }

        //kjører oppgaver som har to parametere, som ikke returnerer en verdi
        private static void ExecuteTask<T1, T2>(Action<T1, T2> oppgave, T1 param1, T2 param2)
        {
            Console.Clear();
            Console.WriteLine();
            oppgave.Invoke(param1, param2);
            SeFlereOppgaver();
        }

        //kjører oppgaver som returnerer en verdi
        private static void ExecuteTask<TResult>(Func<TResult> oppgave)
        {
            Console.Clear();
            Console.WriteLine();
            TResult result = oppgave.Invoke();
            Console.WriteLine($"Result: {result}");
            SeFlereOppgaver();
        }

        private static bool SeFlereOppgaver() //trengs det en 'bool' her Stian? Erstattes den med en void og man fjerner 'return true' fungerer det likevel..
        {
            Console.WriteLine();
            Console.Write("Vil du se flere oppgaver? ja/nei: ");
            if (Console.ReadLine() == "ja")
            {
                DisplayMenu();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Programmet avsluttes.");
                Environment.Exit(0);
            }
            return true;
        }
        #endregion
    }
}


