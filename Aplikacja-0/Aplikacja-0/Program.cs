using System;

namespace Aplikacja_0
{
    class Program
    {
        static void Main(string[] args)
        {
            bool CanCalculate = true;
            
            Console.WriteLine("Program is multiplicating 'multiplicant' by 'factor'");
            
            Console.WriteLine("\nPlease enter multiplicand:");
            int multA = 1;
            string Input1 = Console.ReadLine();
            if (int.TryParse(Input1, out multA))
                multA = Convert.ToInt32(multA);
            else
                CanCalculate = false;

            Console.WriteLine("\nPlease enter factor:");
            int multB = 1;
            string Input2 = Console.ReadLine();
            if (int.TryParse(Input2, out multB))
                multB = Convert.ToInt32(Input2);
            else
                CanCalculate = false;

            if (CanCalculate == true)
            {
                int MyResult = Multiply(multA, multB);
                Console.WriteLine($"The result is: {MyResult}");
            }
            else
                Console.WriteLine($"WRONG VALUES ENTERED!");
        }

        public static int Multiply (int multiplicand, int factor)
        {
            int result = 0;
            if (multiplicand != 0 && factor > 0)
            {
                for (int i = 0; i < factor; i++)
                    result += multiplicand;
            }
            else if (factor == 0 || multiplicand == 0)
                result = 0;
            else if (factor < 0 && multiplicand < 0)
            {
                multiplicand /= -1;
                factor /= -1;
                for (int i = 0; i < factor; i++)
                    result += multiplicand;
            }
            else if (factor < 0 && multiplicand > 0)
            {
                for (int i = factor; i < 0; i++)
                    result -= multiplicand;
            }
            return result;
        }
    }
}
