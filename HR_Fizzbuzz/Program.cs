using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Fizzbuzz
{
    /*
    Coding problem, taken from : https://www.hackerrank.com/challenges/fizzbuzz/problem

   Write a short program that prints each number from 1 to 100 on a new line. 

    For each multiple of 3, print "Fizz" instead of the number. 

    For each multiple of 5, print "Buzz" instead of the number. 

    For numbers which are multiples of both 3 and 5, print "FizzBuzz" instead of the number.
         
    */

    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hello world");
            for(int number = 1; number <= 100; number++)
            {
                Console.WriteLine(number);

                if ( number % 3 == 0)
                {
                    Console.WriteLine(number + "Fizz");
                }
                if (number % 5== 00)
                {
                    Console.WriteLine(number + "Buzz");
                }
                if ( (number % 3 == 0) && (number % 5 == 00) )
                {
                    Console.WriteLine(number + "FizzBuzz");
                }
            }
            Console.WriteLine("Push any key to exit...");
            Console.ReadKey();
        }
    }
}
