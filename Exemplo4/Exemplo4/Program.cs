using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo4
{
    class Program
    {
        static void Main(string[] args)
        {
            //POO
            //Problema:
            //Encapsule o objeto usando get/set para obter mais seguranca ao acesso de atributos em seu projeto... 
            Carro carro = new Carro();
            carro.setMarca("Volkswagem");
            carro.MoTor = "V8";

            //carro.getMarca() é acessado como metodo
            Console.WriteLine(carro.getMarca());
            //Carro.MoTor é acessado como atributo
            Console.WriteLine(carro.MoTor);
            //Relacionamento entre classe agregacao
            Garagem gar = new Garagem();
            gar.setCarro(carro);
            Console.WriteLine(gar.getCarro().MoTor + " " + gar.getCarro().getMarca());
            Console.ReadLine();
        }
    }
}
