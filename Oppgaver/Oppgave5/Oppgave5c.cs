namespace Variabel_Oppgaver.Oppgaver.Oppgave5
{
    internal class Oppgave5c
    {
        public static bool ifElseReturnTrueReturnFalse(int nmbr1, int nmbr2)
        {

            if (nmbr1 == 30 || nmbr2 == 30)
            {
                Console.Write("Ett av tallene er \"30\". Dermed returneres => true");
                return true;
            }
            else if (nmbr1 + nmbr2 == 30)
            {
                Console.Write("Summen av tallene blir \"30\". Dermed returneres => true");
                return true;
            }
            else
            {
                Console.Write("Ingen av tallene er \"30\".\nSummen av tallene (multiplisert) blir ikke \"30\". Dermed returneres => false");
                return false;
            }
        }
    }
}
