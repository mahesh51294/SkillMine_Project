using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project
{
    class Looping
    {
        static void Main(string[] args)
        {

            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
              if(i%2==0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);



    }

}

    class Factorial
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            for(int i=1;i<=num;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
    }

    class number
    {
        static void Main(string[]args)
        {
            Console.WriteLine("numbers between 1 to 10 are ");
            for (int i=1;i<=10;i++)
            {
                
                Console.WriteLine(i);
            }
        }
    }


    class number2
    {
        static void Main(string[]args)
        {
            Console.WriteLine("numbers between 75 to 61 are");
            for(int i=75;i>=61;i--)
            {
                Console.WriteLine(i);
            }
        }
    }
    class number3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("numbers between 120 to 200 are ");
            for (int i = 120; i <= 200; i++)
            {

                Console.WriteLine(i);
            }
        }
    }

    class sum
    {
        static void Main(string[]args)
        {
            int sum = 0;
            for(int i=0;i<=10;i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
        

    }

    class OddBetween
    {
        static void Main(string[]args)
        {
            for(int i=120;i>=81;i--)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }

    class CountOdd
    {
        static void Main(string[]args)
        {
            int count = 0;
            for(int i=0;i<=20;i++)
            {
                if(i%2==0)
                {
                    count = count + i;
                    
                    
                }
                
            }
            Console.WriteLine(count);
        }
    }

    class Table
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter the number ");
            int temp = 0;
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("table of entered numnbers are");
            for(int i=1;i<=10;i++)
            {
                temp = num * i;
                Console.WriteLine(temp);
            }
            
        }
    }

    class Factor
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter the number whose factor to be find out");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i=1;i<=number;i++)
            {
                if(number%i==0)
                {
                    sum = sum + i;
                   
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("sum of these numbers are " + sum);

        }
    }

    class DivisibleBy
    {
        static void Main(string[]a)
        {

            /* Console.WriteLine("Enter the number");
             int num = int.Parse(Console.ReadLine());*/
            Console.WriteLine("NUmber which is divisible by 5 and 3 in the range of 1 to 50 are following ");
            for(int i=1;i<=50;i++)
            {
                if(i%5==0 && i%3==0)
                {
                    Console.WriteLine(i);
                }
            }


        }
    }
}
