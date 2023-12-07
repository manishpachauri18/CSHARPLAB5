using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5prac6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("outer try box");
            try
            {
               
                int[] arr = { 1, 2, 3 };
              
                try
                {
                    Console.WriteLine("inner try box");
                    arr[4] = 12;
                }
                catch (Exception innerx) { 
                Console.WriteLine($"{innerx.Message}");
                }
                int z = 1;
                int y = 0;
                Console.WriteLine(z / y);


            }

            catch (Exception outerx)
            {
                Console.WriteLine($"{outerx.Message}");
            }
            finally
            {
                Console.WriteLine("MAIN TO PRINT HUNGA HI DAM H TO ROK LO");
            }
        }
    }
}
