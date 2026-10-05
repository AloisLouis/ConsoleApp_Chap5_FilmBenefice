namespace ConsoleApp_Chap5_FilmBenefice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indiquez le coût de production de votre film (en millions):");
            int cout = int.Parse(Console.ReadLine());
            Console.WriteLine("Combien de dollars a généré votre film lors de la première semaine (en millions)?");
            decimal recette = decimal.Parse(Console.ReadLine());
            int semaine = 0;
            Console.WriteLine(" ");
            decimal benefice = recette;
            while (benefice < cout)
            {
                recette = recette * 0.8m;
                benefice = benefice + recette;
                benefice = Math.Round(benefice, 2);
                Console.WriteLine(benefice);
                semaine++;
            }
            Console.WriteLine("Votre film sera rentable dans {0} semaines.", semaine);
        }
    }
}
