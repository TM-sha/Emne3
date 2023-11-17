namespace Variabel_Oppgaver.Oppgaver.Oppgave5
{
    internal class Oppgave5b
    {

        public static int ReturnNumberIfNotEqualAndIfEqual(int numb, int numb2)
        {
            if (numb != numb2)
            {
                Console.Write("Tallene er ulike => Sum = ");
                return numb + numb2;
            }
            else
            {
                Console.Write("Tallene er like => Sum = ");
                return numb * numb2;
            }
        }
    }
}
