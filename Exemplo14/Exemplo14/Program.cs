using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema:
            //Use a tecnica de recursividade para executar um fatorial de um numero qualquer...
            //Exemplo de recursividade de um numero fatorial
            int num = 5;
            Program pro = new Program();
            Console.WriteLine("O fatorial de (5) é:" + pro.fatorial(num));
            Console.ReadLine();
        }

        int fatorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                Console.WriteLine("var" + n);
                return n * fatorial(n - 1);
            }
        }
    }
}
