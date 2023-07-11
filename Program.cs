using System.Runtime.CompilerServices;

namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Examples of Explicit Casting
            double x = 24;
            int y = 12;
            float z = 6;
            char t = '+';

            string s = x.ToString();
            s = z.ToString();
            s = t.ToString();
            s = y.ToString();

            Console.WriteLine(s.GetType());   
        }
    }
}