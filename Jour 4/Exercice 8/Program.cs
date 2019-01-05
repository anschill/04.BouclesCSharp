using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pairs = new int[20];
            for (int i = 0; i < pairs.Length; i++)
            {
                pairs[i] = i + 1;
            }

            foreach (int pair in pairs)
            {
                if (pair % 2 == 0)
                    Console.WriteLine(pair);
            }

            Console.ReadKey();
        }

    }
}

/*int j = 1;
while ( j < 20)
{
    Console.WriteLine(pairs[j]);
    j = j + 2;
}*/
