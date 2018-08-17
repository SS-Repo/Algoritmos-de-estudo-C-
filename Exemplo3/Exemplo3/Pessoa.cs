using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo3
{
    public class Pessoa
    {
        public string nome;
        public string sobrenome;
        public int idade;
        public double altura;

        public Pessoa(string nome,string sobrenome,int idade,double altura) {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.idade = idade;
            this.altura = altura;
        }
    }
}
