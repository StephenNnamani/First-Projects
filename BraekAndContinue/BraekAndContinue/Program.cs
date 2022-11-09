using System.Collections;

namespace BreakAndContinue
{
    class Program
    {
        static void Main(string[] arg)
        {
            for (double i =0; i < 100; i++)
            {
                if (i % 2 == 0.0)
                    continue;
                else if (i % 3 == 0.0)
                    Console.WriteLine(i);
                else if (i==91)
                    break;

            }
        }
    }
}