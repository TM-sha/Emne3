using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabel_Oppgaver.Oppgaver.Oppgave7
{
    internal class Oppgave7c
    {
        public static void PrintNumberOfRounds()
        {
            bool condition = true;
            int i = 1;
            while (condition)
            {
                if (i < 10 + 1)
                {
                    Console.WriteLine("Runde nummer: " + i);
                    i++;
                }
                else
                {
                    condition = false;
                }
            }
            
        }
    }
}
