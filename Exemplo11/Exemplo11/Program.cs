using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema:
            //O que acontece com o algoritmo quando aninhamos for simultaneamente...
            //for aninhado
            int[] num;
            num = new int[10];
            Console.WriteLine("Vamos preencher um array de numeros");
            for (int i = 0; i < num.Length; i++)
            {
                //Populando o array
                string num1 = Console.ReadLine();
                int x = Convert.ToInt32(num1);
                num[i] = x;

                //Mostrando resultado
                for (int z = 0; z <= i; z++)
                {
                    Console.WriteLine("\n#");
                    Console.WriteLine(num[z]);
                    for (int w = 0; w <= i; w++)
                    {
                        Console.WriteLine("\n*");
                        Console.WriteLine(num[w]);
                        for (int y = 0; y <= i; y++)
                        {
                            Console.WriteLine("\n.");
                            Console.WriteLine(num[y]);
                        }
                    }
                }
            }
        }
    }
}
