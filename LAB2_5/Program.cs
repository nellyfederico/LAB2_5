using System;

namespace LAB2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.WriteLine("Enter a number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            int TotalResult = num1 + num2;
            Console.WriteLine("The answer is:");
            Console.WriteLine(TotalResult);

            TotalResult = num1 - num2;
            Console.WriteLine("The answer is:");
            Console.WriteLine(TotalResult);


            TotalResult = num1 * num2;
            Console.WriteLine("The answer is:");
            Console.WriteLine(TotalResult);

            double results2 = (double)num1 / (double)num2; 
            double results3 = num1 % num2; 
            Console.WriteLine("The answer is:");
            Console.WriteLine(results2); 
            Console.WriteLine(results3);
        }
    }
}
