namespace Variabel_Oppgaver.Oppgaver.Oppgave8
{
    internal class Krokodillespillet
    {
        public static void CrocoGame(int poeng)
        {
            Random number = new Random();
            int rndNmbr = number.Next(1, 11);
            int rndNmbr2 = number.Next(1, 11);
            
            Console.Write($"Hva blir svaret på dette: {rndNmbr} _ {rndNmbr2} ? ");
            var answer = Console.ReadLine();

            if (answer == "<" && rndNmbr < rndNmbr2 || 
                answer == ">" && rndNmbr > rndNmbr2 || 
                answer == "=" && rndNmbr == rndNmbr2)
            {
                poeng++;
                Console.Write("Riktig! ");
                Console.WriteLine($"Dine poeng: {poeng}\n");
                CrocoGame(poeng);
            }

            else if (answer != "<" && answer != ">" && answer != "=")
            {
                Environment.Exit(1);
            }

            else
            {
                poeng--;
                Console.WriteLine("Feil..");
                Console.WriteLine($"Dine poeng: {poeng}");
                Console.WriteLine();
                CrocoGame(poeng);
            }
        }
    }
}
