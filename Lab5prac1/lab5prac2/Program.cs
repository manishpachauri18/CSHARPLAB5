using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5prac2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] x = new int[6];
            try
            {
                for (int i = 0; i < 7; i++)
                {
                    x[i] = i;

                }
            }catch (Exception e)
            {
                Console.WriteLine("You Are Trying To Acess The Index Out Of Bound Length");
            }
        }
    }
}
