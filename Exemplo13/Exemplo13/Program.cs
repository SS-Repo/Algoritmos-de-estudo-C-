using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema:
            //Faca um contador usando recursividade e imprima esses numeros na tela...
            //Exemplo de recursividade
            int m = 0;
            int n = 5;
            Program pro = new Program();
            pro.soma(m,n);
            Console.ReadLine();
        }

        public int soma(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("return if:" + num1);
                return num1;
            }
            else
            {
                Console.WriteLine("return else:" + num1 + ":" + num2);
                return num1 + soma(num1 + 1, num2);
            }
        }
    }
}
