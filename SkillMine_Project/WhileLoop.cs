using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project
{
    class WhileLoop
    {

        static void Main(string[]args)
        {
            int sum = 0;
            int i = 0;
            while (i<= 20)
            {
                if (i % 2 != 0)
                {
                    sum = sum + i;
                    
                }
                
                i++;
            }
            Console.WriteLine(sum);
        }
    }

    class CountNumbers
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            while(num>0)
            {
                int digit = num % 10;
                sum = sum + digit;
                num = num / 10;
            }

            Console.WriteLine("sum of digits= " + sum);
        }
    }

    class SkipNumber
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 50)
            {
                if (i % 5 == 0)
                {
                    i++;
                    continue;
                }



                Console.WriteLine(i);
                i++;






                /* for (int i = 1; i <= 50; i++)
                 {
                     if (i % 5 == 0)
                         continue;
                     Console.WriteLine(i);
                 }*/

            }
        }

    }
           


        

        class SumOf
        {
            static void Main(string[]args)
            {
                int i = 0;
                int sum = 0;
                while( i<=20)
                        {
                    sum = sum + i;
                    if(sum>10)
                    {
                        break;
                    }
                    i++;


                }
                Console.WriteLine(sum);
            }
        }

    class SpyNumber
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine);
        }
    }
    }



