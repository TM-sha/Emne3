using System.Diagnostics;
using Variabel_Oppgaver.Oppgave1;
using Variabel_Oppgaver.Oppgaver.Oppgave1;
using Variabel_Oppgaver.Oppgaver.Oppgave12;
using Variabel_Oppgaver.Oppgaver.Oppgave2;
using Variabel_Oppgaver.Oppgaver.Oppgave3;
using Variabel_Oppgaver.Oppgaver.Oppgave4;
using Variabel_Oppgaver.Oppgaver.Oppgave5;
using Variabel_Oppgaver.Oppgaver.Oppgave6;
using Variabel_Oppgaver.Oppgaver.Oppgave7;
using Variabel_Oppgaver.Oppgaver.Oppgave8;

namespace Variabel_Oppgaver
{
    public class Program
    {
        public static void Main()
        {
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hei på deg! Velkommen til min oversikt over oppgaver i Moodle Emne 3 \n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Skriv inn et tall fra 1 til 16 for å velge oppgaven du vil se på: \n" +
                                  "\t\t\t\t1 => \"PrintInputFromUser\"\n\t\t\t\t2 => \"Make 8 variables\"\n\t\t\t\t3 => \"Consoll-application that creates 3 variables\"\n" +
                                  "\t\t\t\t4 => \"ReturnSumOfToNumbers\"\n\t\t\t\t5 => \"ReturnsNothing\"\n\t\t\t\t6 => \"RandomHobbyGenerator\"\n" +
                                  "\t\t\t\t7 => \"GuessTheNumber\"\n\t\t\t\t8 => \"ReturnTrueIfNumbersEqual\"\n\t\t\t\t9 => \"ReturnNumberIfNotEqualAndIfEqual\"\n" +
                                  "\t\t\t\t10 => \"ifElseReturnTrueReturnFalse\"\n\t\t\t\t11 => \"WhichDayInWeekend\"\n\t\t\t\t12 => \"WhichDayInWeekend2 - ReadLine\"\n" +
                                  "\t\t\t\t13 => \"MakeForLoopPrintFiveTimes\"\n\t\t\t\t14 => \"PrintEveryCharInAString\"\n\t\t\t\t15 => \"PrintNumberOfRounds - ReadLine\"\n" +
                                  "\t\t\t\t16 => \"CrocoGame\"\n\t\t\t\t17 => \"OverloadsAndDefaultValues\"");


                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Tast inn tall og trykk Enter\t");
                Console.ForegroundColor = ConsoleColor.White;
                var taskNr = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"Vil du se på oppgave {taskNr}? ja/nei: ");
                Console.ForegroundColor = ConsoleColor.White;
                if (Console.ReadLine().ToLower() == "ja")

                {
                    switch (taskNr)
                    {
                        case 1:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            KonsollApp.Oppgave();
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("Vil du se flere oppgaver? ja/nei: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            if (Console.ReadLine().ToLower() != "ja")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Programmet avsluttes.");
                                return;
                            }
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine();
                            Variabler.Oppgave();
                            Console.WriteLine();
                            Console.Write("Vil du se flere oppgaver? ja/nei: ");
                            if (Console.ReadLine() != "ja")
                            {
                                Console.WriteLine("Programmet avsluttes.");
                                return;
                            }
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine();
                            KonsollAppVariabel.Oppgave();
                            Console.WriteLine();
                            Console.Write("Vil du se flere oppgaver? ja/nei: ");
                            if (Console.ReadLine() != "ja")
                            {
                                Console.WriteLine("Programmet avsluttes.");
                                return;
                            }
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine();
                            var sum = SumAvToTall.ReturnerSumAvToTall(5, 25); //Skriv inn ulike tall for ulikt resultat
                            Console.WriteLine(sum);
                            Console.WriteLine();
                            Console.Write("Vil du se flere oppgaver? ja/nei: ");
                            if (Console.ReadLine() != "ja")
                            {
                                Console.WriteLine("Programmet avsluttes.");
                                return;
                            }
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine();
                            SumAvToTallOppgave2.HarIngenting();
                            Console.WriteLine();
                            Console.Write("Vil du se flere oppgaver? ja/nei: ");
                            if (Console.ReadLine() != "ja")
                            {
                                Console.WriteLine("Programmet avsluttes.");
                                return;
                            }
                            break;
                        case 6:
                            Console.Clear();
                            Console.WriteLine();
                            RandomHobbyGenerator.GenerateRandomHobbies();
                            Console.WriteLine();
                            Console.Write("Vil du se flere oppgaver? ja/nei: ");
                            if (Console.ReadLine() != "ja")
                            {
                                Console.WriteLine("Programmet avsluttes.");
                                return;
                            }
                            break;
                        case 7:
                            Console.Clear();
                            Console.WriteLine();
                            GjettTallet.GuessTheNumber();
                            Console.WriteLine();
                            Console.Write("Vil du se flere oppgaver? ja/nei: ");
                            if (Console.ReadLine() != "ja")
                            {
                                Console.WriteLine("Programmet avsluttes.");
                                return;
                            }
                            break;
                        case 8:
                            Console.Clear();
                            Console.WriteLine();
                            Oppgave5a.ReturnTrueIfNumbersEqual(4, 4);
                            Console.WriteLine();
                            Console.Write("Vil du se flere oppgaver? ja/nei: ");
                            if (Console.ReadLine() != "ja")
                            {
                                Console.WriteLine("Programmet avsluttes.");
                                return;
                            }
                            break;
                        case 9:
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine(
                                Oppgave5b.ReturnNumberIfNotEqualAndIfEqual(5, 10)); //Skriv inn ulike tall for ulikt resultat
                            Console.WriteLine();
                            Console.Write("Vil du se flere oppgaver? ja/nei: ");
                            if (Console.ReadLine() != "ja")
                            {
                                Console.WriteLine("Programmet avsluttes.");
                                return;
                            }
                            break;
                        case 10:
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine(
                                Oppgave5c.ifElseReturnTrueReturnFalse(10, 20)); //Skriv inn ulike tall for ulikt resultat
                            Console.WriteLine();
                            Console.Write("Vil du se flere oppgaver? ja/nei: ");
                            if (Console.ReadLine() != "ja")
                            {
                                Console.WriteLine("Programmet avsluttes.");
                                return;
                            }
                            break;
                        case 11:
                            Console.Clear();
                            Console.WriteLine();
                            Oppgave6a.WhichDayInWeekend(5); //Skriv inn et tall for hvilken dag du vil se
                            Console.WriteLine();
                            Console.Write("Vil du se flere oppgaver? ja/nei: ");
                            if (Console.ReadLine() != "ja")
                            {
                                Console.WriteLine("Programmet avsluttes.");
                                return;
                            }
                            break;
                        case 12:
                            Console.Clear();
                            Console.WriteLine();
                            Oppgave6b.WhichDayInWeekend2();
                            Console.WriteLine();
                            Console.Write("Vil du se flere oppgaver? ja/nei: ");
                            if (Console.ReadLine() != "ja")
                            {
                                Console.WriteLine("Programmet avsluttes.");
                                return;
                            }
                            break;
                        case 13:
                            Console.Clear();
                            Console.WriteLine();
                            Oppgave7a.MakeForLoopPrintFiveTImes();
                            Console.WriteLine();
                            Console.Write("Vil du se flere oppgaver? ja/nei: ");
                            if (Console.ReadLine() != "ja")
                            {
                                Console.WriteLine("Programmet avsluttes.");
                                return;
                            }
                            break;
                        case 14:
                            Console.Clear();
                            Console.WriteLine();
                            Oppgave7b.PrintEveryCharInAString();
                            Console.WriteLine();
                            Console.Write("Vil du se flere oppgaver? ja/nei: ");
                            if (Console.ReadLine() != "ja")
                            {
                                Console.WriteLine("Programmet avsluttes.");
                                return;
                            }
                            break;
                        case 15:
                            Console.Clear();
                            Console.WriteLine();
                            Oppgave7c.PrintNumberOfRounds();
                            Console.WriteLine();
                            Console.Write("Vil du se flere oppgaver? ja/nei: ");
                            if (Console.ReadLine() != "ja")
                            {
                                Console.WriteLine("Programmet avsluttes.");
                                return;
                            }
                            break;
                        case 16:
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Velkommen til Krokodillespillet!\n");
                            int poeng = 0;
                            Krokodillespillet.CrocoGame(poeng);
                            Console.Write("Vil du se flere oppgaver? ja/nei: ");
                            if (Console.ReadLine() != "ja")
                            {
                                Console.WriteLine("Programmet avsluttes.");
                                return;
                            }
                            break;
                        case 17:
                            Console.Clear();
                            Console.WriteLine();
                            Overloads.PrintWelcomeMessage();// Skriv inn navn for å endre utfall
                            Console.Write("Vil du se flere oppgaver? ja/nei: ");
                            if (Console.ReadLine() != "ja")
                            {
                                Console.WriteLine("Programmet avsluttes.");
                                return;
                            }
                            break;
                        default:
                            Console.Write("Ugyldig oppgavenummer. Vil du prøve på nytt? ja/nei: ");
                            if (Console.ReadLine() != "ja")
                            {
                                Console.WriteLine("Programmet avsluttes.");
                                return;
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Programmet avsluttes.");
                    return;
                }

            } while (true);
        }
    }
}


