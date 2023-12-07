using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5prac1
{
    internal class Program
    {
        static void Main(string[] args)


        {
            try
            {
                int x = 5;
                int y = 0;
                Console.WriteLine(x / y);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); return;

            }
        }
    }
}

