using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            //POO
            //Problema:
            //Modele uma pessoa usando POO e mostre os dados dessa pessoa...
            Console.WriteLine("Escolha seu filho virtual:");

            string nome;
            string sobrenome;
            int idade;
            double altura;

            Console.WriteLine("Escolha meu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Escolha o meu sobrenome:");
            sobrenome = Console.ReadLine();

            Console.WriteLine("Escolha minha idade:");
            string idadeFilho = Console.ReadLine();
            idade = Convert.ToInt32(idadeFilho);

            Console.WriteLine("Escoha minha altura:");
            string alturaFilho = Console.ReadLine();
            altura = Convert.ToDouble(alturaFilho);

            Pessoa pessoa = new Pessoa(nome,sobrenome,idade,altura);
            Console.WriteLine(" ");
            Console.WriteLine(
                pessoa.nome + " " 
                + pessoa.sobrenome + "   " +
                "\n" + pessoa.idade + "   " +
                "\n" + pessoa.altura
                );

            Console.WriteLine(" ");
            Console.WriteLine("Parabens papai");
            Console.ReadLine();
        }
    }
}
