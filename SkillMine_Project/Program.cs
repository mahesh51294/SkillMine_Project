using System;

namespace SkillMine_Project
{
    class Program
    {
        static void Main(string[] args)
           
        {
            int num1, num2, addition, substraction, division, multiplication,length,width;
                int radius;
            double pi = 3.142;
            double areaOfCircle;
            double areaOfRectangle;

            num1 = 20;
            num2 = 40;
            radius = 6;
            length = 4;
            width = 5;
            addition = num1 + num2;
            substraction = num1 - num2;
            division = num1 / num2;
            multiplication = num1 * num2;
            areaOfCircle = pi *radius * radius;
            areaOfRectangle = length * width;


            Console.WriteLine(addition);
            Console.WriteLine(substraction);
            Console.WriteLine(division);
            Console.WriteLine(multiplication);

            Console.WriteLine("area of circle is" + areaOfCircle);

            Console.WriteLine("area of rectangle is" + areaOfRectangle);






        }
    }
}
