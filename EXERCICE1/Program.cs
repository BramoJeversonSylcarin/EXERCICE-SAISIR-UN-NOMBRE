using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICE1
{
    class Program
    {
        public static void Main()
        {
            int n = 5, a = 0;
            for (int i = 1; i <= n; i++) {
                if (n % i == 0) {
                    a++;

                }
            }
            if (a == 2)
            {
                Console.WriteLine("{0} est un nombre premier, n");

            } else { 
                Console.WriteLine("n'est pas un nombre premier");
            }
            Console.ReadLine();
        }
    }
}
