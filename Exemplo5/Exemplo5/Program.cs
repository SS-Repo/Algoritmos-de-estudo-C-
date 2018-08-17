using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema
            //Faca a troca de valores para que:
            //num1 seja igual a num2 e num2 igual a num1 e imprima os valores na tela...
            int num1;
            int num2;
            int num3;

            Console.WriteLine("Digite um numero");
            string numero1 = Console.ReadLine();

            Console.WriteLine("Digite outro numero");
            string numero2 = Console.ReadLine();

            num1 = Convert.ToInt32(numero1);
            num2 = Convert.ToInt32(numero2);
            //num3 = 1
            num3 = num1;
            //num1 = 2
            num1 = num2;
            //num2 = 1;
            num2 = num3;

            Console.WriteLine("Resultado:" + num2 + ", " + num1);
            Console.ReadLine();
        }
    }
}
