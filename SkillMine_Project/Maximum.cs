using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project
{
    class Maximum
    {
     static void Main(string[]args)
        {

            int  num1, num2, num3;
            Console.WriteLine("Enter the first number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            num3= int.Parse(Console.ReadLine());
            if (num1>num2 && num2>num3)
            {
                Console.WriteLine("number 1 is greatest nuumber");
            }
            else if(num2>num1 && num2>num3)
            {
                Console.WriteLine("number 2 is greatest number");
            }

            else
            {
                Console.WriteLine("number 3 isgratest number");
            }
        }

    }

    class LeapYear
    {
        static void Main(string[]args)
        {
            int year;
            Console.WriteLine("Enter the year to be checked which is leap or not");
            year = int.Parse(Console.ReadLine());
            if(year%4==0 && year%100==0)
            {
                Console.WriteLine("given year is leap year");
            }
        }
    }

    class Percentage
    {
        static void Main(string[]args)
        {
            int phy, che, math, bio, geo;
            Console.WriteLine("Enter the physics marks");
            phy = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the chemistry marks");
            che = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the mathematics marks");
            math = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Biology marks");
            bio = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Geography marks");
            geo = int.Parse(Console.ReadLine());

            int percentage = ((phy + che + math + bio + geo) *100)/500;

            Console.WriteLine(percentage);

            if(percentage>70)
            {
                Console.WriteLine("You got distinction");
            }
            else if(percentage>60 && percentage<70)
            {
                Console.WriteLine("You got First class");
            }
            else if (percentage > 50 && percentage < 60)
            {
                Console.WriteLine("You got second class");
            }
            else if (percentage > 35 && percentage < 50)
            {
                Console.WriteLine("You got pass class");
            }
            else
            {
                Console.WriteLine("You are failed");
            }






        }
    }

    class MaxUsingTernary
    {
        static void Main(string[]args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter the first number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            num3 = int.Parse(Console.ReadLine());

            int max= (num1 > num2 && num1 > num3) ?
                num1 : (num2 > num3) && (num2 > num1) ? num2 : num3;

            Console.WriteLine("Largest number amongst these three numbers are " +max);
        }
    
    }




}
