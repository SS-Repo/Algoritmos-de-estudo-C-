using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema:
            //Use consultas mais elegantes com Linq e Lambda Expressions...
            //Consultas com Linq e Lambda Expressions
            List<string> cidades = new List<string>();

            cidades.Add("Sao Paulo");
            cidades.Add("Campinas");
            cidades.Add("Sao Carlos");
            cidades.Add("Sao Joao");
            cidades.Add("Aguai");

            //Console.WriteLine(consultaCidadesForEach(cidades,"Sao Paulo"));

            //Console.WriteLine(consultaCidadesLinq(cidades,"Sao Paulo"));

            //var city = cidades.Where(x => x == "Sao Paulo").First();
            //Console.WriteLine(city);
            
            //Console.WriteLine(consultaCidadesLambda(cidades,"Sao Paulo"));

            //consultaCidadesLinqList(cidades, "Sa").ForEach(x =>Console.WriteLine(x));

            consultaCidadesLambdaList(cidades, "Sa").ForEach(x =>Console.WriteLine(x));
            Console.ReadLine();
        }
        //forma convencional
        static string consultaCidadesForEach(List<string> cidades, string parametro) {
            foreach (var item in cidades)
            {
                if (item.Equals(parametro)) {
                    return item;
                }
            }
            return null;
        }
        //forma utilizando linq
        static string consultaCidadesLinq(List<string> cidades, string parametro) {
            return (from item in cidades where item.Equals(parametro) select item).First();
        }
        //forma utilizando lambda expressions
        static string consultaCidadesLambda(List<string> cidades, string parametro) {
            return cidades.First(x => x.Equals(parametro));
        }
        //lista utilizando linq
        static List<string> consultaCidadesLinqList(List<string> cidades, string parametro)
        {
            return (from item in cidades where item.Contains(parametro) select item).ToList();
        }
        //lista utilizando lambda
        static List<string> consultaCidadesLambdaList(List<string> cidades, string parametro)
        {
            return cidades.Where(x => x.Contains(parametro)).ToList();
        }
    }
}
