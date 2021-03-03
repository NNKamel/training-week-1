using System;

namespace FizzBuzzy
{
    class Fizzy
    {
        // methods must have a return type
        public static void Main(string[] args)
        {
            // a user should be able to enter the starting and ending count
            // a user should be able to enter these values in any order
            // a user should be able to get the number of times fizz, buzz and fizzbuzz appear
            // a user should be able to set new values for fizz, buzz and fizzbuzz

            var startPoint = 0;
            var endPoint = 0;

            Console.WriteLine("Please enter the first number");
            startPoint = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            endPoint = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter a value for fizz");
            var fizz = Console.ReadLine();
            var fizzCount = 0;
            Console.WriteLine("please enter a value for buzz");
            var buzz = Console.ReadLine();
            var buzzCount = 0;
            Console.WriteLine("please enter a value for buzz");
            string fizzbuzz = "fizzbuzz";
            var fizzbuzzCount = 0;

            if (startPoint > endPoint)
            {
                var temp = endPoint;
                startPoint = temp;

            }

            for (int value = startPoint; value < endPoint; value++)
            {
                if (value % 3 == 0 && value % 5 == 0)
                {
                    fizzCount++;
                    Console.WriteLine(fizzbuzz);
                }
            }
        }

        private int GetInput()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        private void GetEndpoint()
        {
            Console.WriteLine("enter a number:");
            var input1 = GetInput();
        }

        private void GetEntry()
        {
            return;
        }

        private void FizzBuzz(int a, int b)
        {

        }

    }
}