using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49729
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez votre nom");
            string nom = Console.ReadLine();
            Console.WriteLine("Entrez votre prenom");
            string prenom = Console.ReadLine();
            Console.WriteLine("Entrez votre statut martial");
            string smartial = Console.ReadLine();
            Console.WriteLine("Entrez votre nombre d'enfants");
            int nbenfants = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
        }
    }
}
