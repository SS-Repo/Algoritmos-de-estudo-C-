using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema:
            //Trabalhe com diferentes tipos de coleções em c# e teste,veja como cada lista tem
            //sua particularidade...
            //Trabalhado com colecoes
            Random rnd = new Random();
            int[] array = new int[50];
            int[] ar = {10,2,3,5,1,0};
            List<int> num = new List<int>();
            Stack<int> num1 = new Stack<int>();

            for (int i = 0; i < 50; i++)
            {
                array[i] = rnd.Next(0,100);
                Console.WriteLine(array[i]);
            }

            Stack<int> num2 = new Stack<int>(array);

            foreach (var item in num1)
            {
                Console.WriteLine(item);
            }
           
            SortedList<int,int> ordenada = new SortedList<int, int>();
            ordenada.Add(0,3);
            ordenada.Add(1,5);
            ordenada.Add(3,7);
            ordenada.Add(5,10);

            foreach (var item in ordenada)
            {
                Console.WriteLine("{0} : {1}",item.Key,item.Value);
                
            }
            Console.ReadLine();
        }
    }
}
