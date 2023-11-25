namespace Variabel_Oppgaver.Oppgaver.Oppgave5
{
    internal class Oppgave5b
    {

        public static int ReturnNumberIfNotEqualAndIfEqual(int numb, int numb2)
        {
            var sum = numb + numb2;
            var sum2 = numb * numb2;

            if (numb != numb2)
            {
                Console.Write("Tallene er ulike => Sum = " + sum);
                return numb + numb2;
            }
            else
            {
                Console.Write("Tallene er like => Sum = " + sum2);
                return numb * numb2;
            }
        }
    }
}
