using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo4
{
    public class Carro
    {
        //Acesso tradicional Getters and Setters
        private string modelo;

        public void setMarca(string marcaRecebida)
        {
            this.modelo = marcaRecebida;
        }

        public string getMarca()
        {
            return this.modelo;
        }
        //Acesso automatico C# --Comando  propfull--
        private string moTor;

        //public string Motor { get;private set; } modelo reduzido
        public string MoTor
        {
            get { return moTor; }
            set { moTor = value; }
        }

       
    }
}
