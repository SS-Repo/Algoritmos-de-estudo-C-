using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema:
            //Deixe o usuario escolher um numero e imprima nomes de mulheres respectivos a opcao do usuario...
            //switch exemplo
            Console.WriteLine("Digite um numero de 1 a 3");
            string numero = Console.ReadLine();

            switch (numero)
            {
                case "1":
                    string nome = "Samanta";
                    Console.WriteLine(nome);
                    break;
                case "2":
                    nome = "Rose";
                    Console.WriteLine(nome);
                    break;
                case "3":
                    nome = "Bruna";
                    Console.WriteLine(nome);
                    break;
            }
            Console.ReadLine();
        }
    }
}
