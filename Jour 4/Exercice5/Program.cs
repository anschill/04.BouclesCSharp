using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] week = new string[]
            {
                "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche",

            };

            int i = 0;
            while(i < week.Length)
            {
                Console.WriteLine(week[i]);
                i++;               
            }
        }
    }
}




/* for ( int i = 0; i < week.Length; i++)
 * {Console.WriteLine(week[i]);
 * }
 * Console.ReadKet();
 * 