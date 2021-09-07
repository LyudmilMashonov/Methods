using System;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int min = GetMinimalSum(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(min);
        }

        private static int GetMinimalSum(int firstNumber,  int secondNumber, int thirdNumber)
        {
            int min = Math.Min(Math.Min(firstNumber, secondNumber)
                , thirdNumber);
            return min;
        }
    }
}
