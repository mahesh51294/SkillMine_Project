using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project
{
    class NestedIfElse
    {
        static void Main(string[] args)
        {
            int year, marks;
            Console.WriteLine("enter the year");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the marks");
            marks = int.Parse(Console.ReadLine());

            if (year == 2022)
            {
                if (marks >= 60)
                {
                    Console.WriteLine("candidate is selected");
                }

                else
                {
                    Console.WriteLine("mark is leass than 60 is not selected");
                }
            }



            else
            {
                Console.WriteLine("Candidate is not selected");
            }
            }
        }
    }

