namespace Variabel_Oppgaver.Oppgaver.Oppgave4
{
    internal class RandomHobbyGenerator
    {
        public static void GenerateRandomHobbies()
        {
            Console.WriteLine("Hvem vil ha en ny hobby?");
            Console.WriteLine();
            var answer = Console.ReadLine();
            Console.WriteLine();
            Random hobby = new Random();
            var rndHobby = hobby.Next(0, 5);
            if (rndHobby == 0)
            {
                Console.WriteLine($"{answer} sin nye hobby er: Sying");
            }
            else if (rndHobby == 1)
            {
                Console.WriteLine($"{answer} sin nye hobby er: Fotball");
            }
            else if (rndHobby == 2)
            {
                Console.WriteLine($"{answer} sin nye hobby er: Klatring");
            }
            else if (rndHobby == 3)
            {
                Console.WriteLine($"{answer} sin nye hobby er: Fugletitting");
            }
            else
            {
                Console.WriteLine($"{answer} sin nye hobby er: Jogging");
            }
            Console.WriteLine();
        }
    }
}
