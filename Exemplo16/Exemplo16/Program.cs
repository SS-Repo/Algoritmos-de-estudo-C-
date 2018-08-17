using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo16
{
    class Program
    {
        //Problema:
        //O codigo esta bugando use o bloco try,catch e finally para resolver este problema...
        //implementacao do bloco try e catch
        static void Main(string[] args)
        {
            try
            {
                int num1;
                int num2;

                Console.WriteLine("Digite um valor:");
                string numConvert1 = Console.ReadLine();
                Console.WriteLine("Digite um valor:");
                string numConvert2 = Console.ReadLine();

                num1 = Convert.ToInt32(numConvert1);
                num2 = Convert.ToInt32(numConvert2);

                int resposta = num1 * num2;
                Console.WriteLine(resposta);
                Console.ReadLine();
            }
            //sempre ultima exception
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + ":" + "bloco catch");
                Console.ReadLine();
            }
            //opcional se necessitar execucao de codigo obrigatorio
            finally
            {
                Console.WriteLine("Este codigo sempre sera executado", "bloco finally");
                Console.ReadLine();
            }
        }
    }
}
