using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema:
            //Faca if reduzidos para dimiuir a complexidade do codigo...
            //Exemplo de if reduzido 
            int input = Convert.ToInt32(Console.ReadLine());
            string classify;

            // if-else construction.  
            if (input > 0)
                classify = "positive";
            else
                classify = "negative";

            // ?: conditional operator.  
            classify = (input > 0) ? "positive" : "negative";
            Console.WriteLine(classify);
            Console.ReadLine();

            string test = (input == 0) ? "Testando if reduzido" : "nao deu certo";
            Console.WriteLine(test);
            Console.ReadLine();
        }
    }
}
