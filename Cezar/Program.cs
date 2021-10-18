using System;

namespace Cezar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input text: ");
            string text = Console.ReadLine();
            Console.Write("Input step: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Encode: "+Cypher.Encode(text,n));
            Console.Write("Decode: "+ Cypher.Decode(text,n));
        }
    }
}
