using System.Runtime.CompilerServices;

namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Examples of Explicit Casting
            double x = 24;
            int y;

            y = Convert.ToInt32(x);

            Console.WriteLine($"The value of x cast an an INT = {y}");
        }
    }
}