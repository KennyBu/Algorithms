using System;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            var unsorted = new []{ 10, 3, 5 ,-1, 0 ,12 ,8};

            Console.WriteLine("Unsorted");
            Console.WriteLine("________");
            Console.WriteLine("");

            foreach (var i in unsorted)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Sorted");
            Console.WriteLine("________");

            var sorted = Sort(unsorted);

            foreach (var i in sorted)
            {
                Console.Write("{0} ", i);
            }

            Console.Read();
        }

        static int[] Sort(params int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                // Loop operating over the unsorted part of the array
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    var num1 = numbers[i];
                    var num2 = numbers[j];
                    
                    // Swapping the values
                    if (numbers[i] > numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            } // End of the sorting logic
            return numbers;
        }
    }


}
