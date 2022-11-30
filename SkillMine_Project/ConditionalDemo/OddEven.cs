using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project.ConditionalDemo
{
    class OddEven
    {
        static void Main(string[]args)
        {
            int num;
            Console.WriteLine("Enter the number");
            num = int.Parse(Console.ReadLine());
            if(num%2==0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }

        }


    }

    class Divisible
    {
        static void Main(string[]args)
        {
            int x;
            Console.WriteLine("Enter the number to be checked which is divisible by 5");
            x = int.Parse(Console.ReadLine());
            if (x % 5 == 0)
            {
                Console.WriteLine("number is divisible by 5");
            }
            else
            {
                Console.WriteLine("number is not divisible by 5");
            }
        }

    }
    class DivisibleByThreeOrNine
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Enter the number to be checked which is divisible by 3 and 9");
            x = int.Parse(Console.ReadLine());
            if (x % 3 == 0)
            {
                Console.WriteLine("number is divisible by 3");
            }
            else if(x % 9 ==0)
            {
                Console.WriteLine("number is divisible by 9");
            }
            else
            {
                Console.WriteLine("number is not divisible");
            }
        }

    }

}
