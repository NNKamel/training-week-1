using System;

namespace FizzBuzzy
{
    class Fizzy
    {
        private string _fizzbuzz = "fizzbuzz";
        private string _fizz = "fizz";
        private string _buzz = "buzz";
        // methods must have a return type
        public static void Main(string[] args)
        {
            // a user should be able to enter the starting and ending count
            // a user should be able to enter these values in any order
            // a user should be able to get the number of times fizz, buzz and fizzbuzz appear
            // a user should be able to set new values for fizz, buzz and fizzbuzz

            // var startPoint = 0;
            // var endPoint = 0;

            // Console.WriteLine("Please enter the first number");
            // startPoint = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Please enter the second number");
            // endPoint = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("please enter a value for fizz");
            // var fizz = Console.ReadLine();
            // var fizzCount = 0;
            // Console.WriteLine("please enter a value for buzz");
            // var buzz = Console.ReadLine();
            // var buzzCount = 0;
            // Console.WriteLine("please enter a value for buzz");
            // string fizzbuzz = "fizzbuzz";
            // var fizzbuzzCount = 0;

            // if (startPoint > endPoint)
            // {
            //     var temp = endPoint;
            //     startPoint = temp;

            // }

            // for (int value = startPoint; value < endPoint; value++)
            // {
            //     if (value % 3 == 0 && value % 5 == 0)
            //     {
            //         fizzCount++;
            //         Console.WriteLine(fizzbuzz);
            //     }
            // }

            var p = new Fizzy();

            bool repeat = true;
            do
            {
                Console.WriteLine("enter a value for fizz, or press enter to exit");
                p._fizz = p.getStringInput();
                if (string.IsNullOrWhiteSpace(p._fizz))
                {
                    Console.WriteLine("exiting");
                    repeat = false;
                    break;
                }
                Console.WriteLine("enter a value for buzz");
                p._buzz = p.getStringInput();
                Console.WriteLine("enter a value for fizzbuzz");
                p._fizzbuzz = p.getStringInput();
                p.GetEntry();
            } while (repeat == true);

        }


        // private string ValidateInputString()
        // {
        //     bool error = false;
        //     string s = "";
        //     do
        //     {
        //         try
        //         {
        //             s = getStringInput();
        //             error = false;
        //         }
        //         catch (Exception)
        //         {
        //             error = true;
        //         }

        //     } while (error == true);
        // }
        private string getStringInput()
        {
            return Console.ReadLine();
        }

        private int GetInput()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        private int GetEndpoint()
        {
            Console.WriteLine("enter a number:");
            return GetInput();
        }

        private void GetEntry()
        {

            var point1 = ValidateInputNumber();
            var point2 = ValidateInputNumber();

            if (point1 < point2)
            {
                FizzBuzz(point1, point2);
            }
            else
            {
                FizzBuzz(point2, point1);
            }
        }

        private void FizzBuzz(int startPoint, int endPoint)
        {
            var fizzCount = 0;
            var buzzCount = 0;
            var fizzbuzzCount = 0;
            for (int value = startPoint; value <= endPoint; value++)
            {
                if (value % 3 == 0 && value % 5 == 0)
                {
                    Console.WriteLine(_fizzbuzz);
                    fizzbuzzCount++;
                }
                else if (value % 3 == 0)
                {
                    Console.WriteLine(_fizz);
                    fizzCount++;
                }
                else if (value % 5 == 0)
                {
                    Console.WriteLine(_buzz);
                    buzzCount++;
                }
                else
                {
                    Console.WriteLine(value);
                }
            }
            printCount(_fizz, fizzCount);
            printCount(_buzz, buzzCount);
            printCount(_fizzbuzz, fizzbuzzCount);
        }

        void printCount(string type, int count)
        {
            Console.WriteLine("the number of times " + type + " appeared: " + count);
        }

        private int ValidateInputNumber()
        {

            var point = 0;
            var error = false;
            do
            {
                try
                {
                    Console.WriteLine("please enter a number");
                    point = GetEndpoint();
                    error = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("only numbers are allowed");
                    error = true;
                }

            } while (error == true);
            return point;
        }
    }
}