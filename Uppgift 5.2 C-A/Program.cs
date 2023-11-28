using System;

namespace Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många heltal vill du skriva in?");
            int x = int.Parse(Console.ReadLine());
            int[] v = new int[x];
            Console.WriteLine("Skriv in " + x + " heltal");
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Här är  talen du skrev in");
            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine("Tal " + (i+1) + ": " + v[i]);
            }
        }
    }
}