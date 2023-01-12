using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_Project
{
    class SortArray
    {
        static void Main(string[] args)
        {
            int[] n = new int[10]; 
            int i, j;

            
            for (i = 0; i < 10; i++)
            {
                n[i] = i + 1;
                //Console.WriteLine(i);
            }

            
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("Element[{0}] = {1}", j, n[j]);
            }
           // Console.ReadKey();
        }
    }
}
    

