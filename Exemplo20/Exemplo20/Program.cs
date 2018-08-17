using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo20
{
    class Program
    {
        static void Main(string[] args)
        {  
            //Problemas:
            //Automatize a troca de um arquivo entre pastas no C#...
            //Manipulando Arquivos
            string[] diretorios = Directory.GetDirectories("C:\\Users\\Sergio\\Desktop");
            
            Console.WriteLine("Diretórios:");
            foreach (string dir in diretorios)
            {
                Console.WriteLine(dir);
            }

            //string localInicial = @"C:\Users\Sergio\Desktop\esta\Nome-do-Arquivo Ex:texto.doc";
            
            //string localFinal = @"C:\Users\Sergio\Desktop\vai\Nome-do-Arquivo Ex:texto.doc";

            //System.IO.File.Move(localInicial, localFinal);
            Console.ReadLine();
        }
    }
}
