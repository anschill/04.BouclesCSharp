using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0; // On crée une variable de type int qu'on initialise à 0.
            while ( i < 10)
            {
                Console.WriteLine("Bonjour, je ne suis qu'un simple message.");
                i++; // On incrémente.
            }
            Console.ReadKey();
        }
    }
}
