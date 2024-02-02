using System;
using System.Collections.Generic;
namespace inlämnings_uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namn = new List<string>();
            Console.WriteLine("Skriv in namn och när du vill avsluta programet skriv ett mellanslag");
            string nyttnamn = " ";
                while (nyttnamn != "")
                {
                Console.WriteLine("Skriv in ett namn");
                nyttnamn = Console.ReadLine();
                if(nyttnamn != "")
                {
                    namn.Add(nyttnamn);
                }
            }
            Console.WriteLine("Dina namn i omvänd bokstav ordning är:");
            namn.Sort();
            namn.Reverse();
            foreach (string namnet in namn)
            {
                Console.WriteLine(namnet);
            }
        }
    }
}

