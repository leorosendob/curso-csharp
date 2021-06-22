using System;
using System.Globalization;
using System.Collections.Generic;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Atchim");
            list.Add("Leonardo");
            list.Add("Joao");
            list.Add("Beto");
            list.Add("Ana");
            list.Insert(3, "FDP");

            

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            string s1 = list.Find(x => x[0] == 'B');

            Console.WriteLine("Nome com a primeira letra A: " + s1);


            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira posição que começa com a letra A: " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Ultima posição que começa com a letra A: " + pos2);

           
            list.RemoveAll(x => x[0] == 'F');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }


        }
    }
}
