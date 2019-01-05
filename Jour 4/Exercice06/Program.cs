using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice06
{
    class Program
    {
        static void Main(String[] args)
        {
            String[] months = new String[] // Declaration d'un nouveau tableau de chaines de caractères
            {
                "Janvier","Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Décembre"
            };

            foreach (String month in months)
            {
                Console.WriteLine(month);
            }
            Console.ReadKey();
        }
    }
}
