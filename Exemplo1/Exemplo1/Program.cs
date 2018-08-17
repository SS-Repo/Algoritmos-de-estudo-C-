using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo1
{
    class Program
    {
        //Problema:
        //Faca um registro de notas n1,n2,n3 calcule a media e retorne qual aluno passou e qual nao.....
        static void Main(string[] args)
        {
            double n1 = 0;
            double n2 = 0;
            double n3 = 0;
            string sn1;
            string sn2;
            string sn3;
            double resultado;

            Console.WriteLine("Sistema de registro de notas");
            Console.WriteLine("");

            Console.WriteLine("Digite a nota da primeira prova:");
            sn1 = Console.ReadLine();
            n1 = Convert.ToDouble(sn1) / 3;

            Console.WriteLine("Digite a nota da segunda prova:");
            sn2 = Console.ReadLine();
            n2 = Convert.ToDouble(sn2) / 3;

            Console.WriteLine("Digite a nota da terceira prova:");
            sn3 = Console.ReadLine();
            n3 = Convert.ToDouble(sn3) / 4;

            resultado = n1 + n2 + n3;
            Console.WriteLine(resultado);

            if (resultado > 5.5)
            {
                Console.WriteLine("Passou de ano");
            }
            else {
                Console.WriteLine("Recuperacao");
            }
            Console.ReadLine();
        }
    }
}
