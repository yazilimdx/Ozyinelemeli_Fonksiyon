using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ozyinelemeli_Fonksiyon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Faktoriyel(5));
            Console.ReadKey();
        }

        public static int Faktoriyel(int n)
        {
            if(n==0)
            {
                return 1;
            }

            return n * Faktoriyel(n - 1);
        }
    }
}
