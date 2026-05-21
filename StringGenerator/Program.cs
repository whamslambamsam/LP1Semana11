using System;
using System.Text;

namespace StringGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int seed = int.Parse(args[0]);

            string output = Controller.Generate(seed);

            Console.WriteLine(output);
        }
    }
}