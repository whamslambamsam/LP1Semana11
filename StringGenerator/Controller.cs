using System;
using System.Text;

namespace StringGenerator
{
    public class Controller
    {
        public static string Generate(int seed, int length = 16)
        {
            Random rng = new Random(seed);

            StringBuilder result = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                int index = rng.Next(Model.chars.Length);
                result.Append(Model.chars[index]);
            }

            return result.ToString();
        }
    }
}