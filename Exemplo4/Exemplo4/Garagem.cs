using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo4
{
    public class Garagem
    {
        private Carro carro;
        //getters and setters tradiconal
        public void setCarro(Carro car) {
            this.carro = car;
        }

        public Carro getCarro() {
            return this.carro;
        }
        //getters and setters C#
        private Carro car;

        //public Carro car { get;private set; } modelo reduzido
        public Carro Car
        {
            get { return car; }
            set { car = value; }
        }

    }
}
