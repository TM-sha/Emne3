using System.Reflection.Metadata;
using Variabel_Oppgaver.Oppgave1;
using Variabel_Oppgaver.Oppgaver.Oppgave1;
using Variabel_Oppgaver.Oppgaver.Oppgave2;
using Variabel_Oppgaver.Oppgaver.Oppgave3;
using Variabel_Oppgaver.Oppgaver.Oppgave4;
using Variabel_Oppgaver.Oppgaver.Oppgave5;
using Variabel_Oppgaver.Oppgaver.Oppgave6;
using Variabel_Oppgaver.Oppgaver.Oppgave7;
using Variabel_Oppgaver.Oppgaver.Oppgave8;

namespace Variabel_Oppgaver
{
    internal class Program
    {
        private static void Main(string[] args)

        {
            Console.WriteLine("Hei på deg! Velkommen til min oversikt over oppgaver i Moodle Emne 3");
            Console.WriteLine();
            Console.WriteLine("...");
            Console.WriteLine();
            Console.Write("Skriv inn et tall fra 1 til 16 for å velge oppgaven du vil se på: ");

            var taskNr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (taskNr)
            {
                case 1:
                    KonsollApp.Oppgave();
                    Console.WriteLine();
                    break;
                case 2:
                    Variabler.Oppgave();
                    Console.WriteLine();
                    break;
                case 3:
                    KonsollAppVariabel.Oppgave();
                    Console.WriteLine();
                    break;
                case 4:
                    var sum = SumAvToTall.ReturnerSumAvToTall(5, 25);//Skriv inn ulike tall for ulikt resultat
                    Console.WriteLine(sum);
                    Console.WriteLine();
                    break;
                case 5:
                    SumAvToTallOppgave2.HarIngenting();
                    Console.WriteLine();
                    break;
                case 6:
                    RandomHobbyGenerator.GenerateRandomHobbies();
                    Console.WriteLine();
                    break;
                case 7:
                    GjettTallet.GuessTheNumber();
                    Console.WriteLine();
                    break;
                case 8:
                    Oppgave5a.ReturnTrueIfNumbersEqual(4, 4);
                    Console.WriteLine();
                    break;
                case 9:
                    Console.WriteLine(Oppgave5b.ReturnNumberIfNotEqualAndIfEqual(5, 10));//Skriv inn ulike tall for ulikt resultat
                    Console.WriteLine();
                    break;
                case 10:
                    Console.WriteLine(Oppgave5c.ifElseReturnTrueReturnFalse(10, 4));//Skriv inn ulike tall for ulikt resultat
                    Console.WriteLine();
                    break;
                case 11:
                    Oppgave6a.WhichDayInWeekend(5);//Skriv inn et tall for hvilken dag du vil se
                    Console.WriteLine();
                    break;
                case 12:
                    Oppgave6b.WhichDayInWeekend2();
                    Console.WriteLine();
                    break;
                case 13:
                    Oppgave7a.MakeForLoopPrintFiveTImes();
                    Console.WriteLine();
                    break;
                case 14:
                    Oppgave7b.PrintEveryCharInAString();
                    Console.WriteLine();
                    break;
                case 15:
                    Oppgave7c.PrintNumberOfRounds();
                    Console.WriteLine();
                    break;
                case 16:
                    Console.WriteLine("Velkommen til Krokodillespillet!\n");
                    int poeng = 0;
                    Krokodillespillet.CrocoGame(poeng);
                    break;
                default:
                    Environment.Exit(1);
                    break;
            }
        }
    }
}

            //-------------------------------------------------------------------------------------------|
            //FJERN KOMMENTAR PÅ DEN DU VIL KJØRE.
            //-------------------------------------------------------------------------------------------|

            //------------------------------------MOODLE EMNE 3------------------------------------------|

            //-------------------------------------------------------------------------------------------|
            // KonsollApp.Oppgave();                                                    //<- OPPGAVE 1(a)
            // Variabler.Oppgave();                                                     //<- OPPGAVE 1(b)
            //-------------------------------------------------------------------------------------------|


            //-------------------------------------------------------------------------------------------|
            // KonsollAppVariabel.Oppgave();                                            //<- OPPGAVE 2
            //-------------------------------------------------------------------------------------------|


            //-------------------------------------------------------------------------------------------|
            // var sum = SumAvToTall.ReturnerSumAvToTall(5, 25);                        //<- OPPGAVE 3(a)
            // Console.WriteLine(sum);
            // SumAvToTallOppgave2.HarIngenting();                                      //<- OPPGAVE (3b)
            //-------------------------------------------------------------------------------------------|


            //-------------------------------------------------------------------------------------------|
            // RandomHobbyGenerator.GenerateRandomHobbies();                            //<- OPPGAVE 4(a)
            // GjettTallet.GuessTheNumber();                                            //<- OPPGAVE 4(b)
            //-------------------------------------------------------------------------------------------|


            //-------------------------------------------------------------------------------------------|
            // if (Oppgave5a.ReturnTrueIfNumbersEqual(4, 4))                            //<- OPPGAVE 5(a)
            // {                                                                                        
            //     Console.WriteLine("Tallene er like");                                                    
            // }
            // else
            // {
            //     Console.WriteLine("Tallene er ulike");
            // }
            // Console.WriteLine(Oppgave5b.ReturnNumberIfNotEqualAndIfEqual(5, 4));      //<- OPPGAVE 5(b)
            // Console.WriteLine(Oppgave5c.ifElseReturnTrueReturnFalse(30, 4));          //<- OPPGAVE 5(c)
            //--------------------------------------------------------------------------------------------|


            //--------------------------------------------------------------------------------------------|
            // Oppgave6a.WhichDayInWeekend(3);                                           //<- OPPGAVE 6(a)
            // Oppgave6b.WhichDayInWeekend2();                                           //<- OPPGAVE 6(b)
            //--------------------------------------------------------------------------------------------|

            //--------------------------------------------------------------------------------------------|
            // Oppgave7a.MakeForLoopPrintFiveTImes();                                    //<- OPPGAVE 7(a)
            // Oppgave7b.PrintEveryCharInAString();                                      //<- OPPGAVE 7(b)
            // Oppgave7c.PrintNumberOfRounds();                                          //<- OPPGAVE 7(c)
            //--------------------------------------------------------------------------------------------|


            //--------------------------------------------------------------------------------------------|
            // Console.WriteLine("Velkommen til Krokodillespillet!\n");                  //<- OPPGAVE 8
            // int poeng = 0;
            // Krokodillespillet.CrocoGame(poeng);
            //--------------------------------------------------------------------------------------------|
        
    
