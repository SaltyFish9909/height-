using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] gender = { "男", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "男", "女", "男", "男", "男", "女", "女", "男", "男", "女", "男", "女", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "女", "男", "男", "女", "女", "男", "男", "女", "女", "男", "男", "男", "男", "男", "男", "女", "男", "女", "女", "女", "女", "女", "女", "男", "女", "女", "女", "女", "女", "男", "男", "女", "女", "女", "男" };
            int[] height = { 173, 0, 179, 155, 183, 170, 163, 174, 165, 189, 177, 180, 154, 167, 170, 173, 165, 158, 180, 165, 153, 175, 162, 165, 0, 160, 165, 173, 164, 177, 177, 180, 170, 151, 176, 180, 168, 152, 666, 2147483647, 165, 155, 777, 173, 169, 170, 169, 171, 0, 170, 150, 160, 155, 164, 163, 165, 184, 165, 155, 0, 168, 160, 169, 0, 150, 163, 168, 173 };
            int sum = 0;
            int count=0;

            for(int i =0; i<height.Length;i++)
            {
                if (height[i]>100 && height[i] < 200)
                {
                    if(gender[i] == "女")
                    {
                        sum = sum + height[i];
                    }
                }
            }
            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] > 100 && height[i] < 200)
                {
                    if (gender[i] == "女")
                    {
                        count++;
                    }
                }
            }

            int max = 0;
            int min = 200;

            for(int u =0; u < height.Length; u++)
            {
                if (height[u] > 100 && height[u] < 200)
                {
                    if (height[u] < max)
                    {
                        max = height[u];
                    }

                    if (min > height[u])
                    {
                        min = height[u];
                    }
                }
            }

            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine("girl student's total height:"+sum);
            Console.WriteLine("girl student's average height:" + sum/count);
            Console.ReadKey();
        }
    }
}
