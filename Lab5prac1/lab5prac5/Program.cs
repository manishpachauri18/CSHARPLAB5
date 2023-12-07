using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5prac5
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size of array;");
            int size=int.Parse(Console.ReadLine());
            if (size > 6)
            {
                throw new InvalidOperationException("this is not right");
            }
            try
            {
                int[] arr = new int[size];

                for(int i=0;i<arr.Length+1;i++)
                {
                    Console.WriteLine("please enter the value ");
                    arr[i] = int.Parse(Console.ReadLine());
                }
                
            }
            catch (IndexOutOfRangeException e) {
                Console.WriteLine("array index is not in his limit ");
            }
            catch(FormatException e)
            {
                Console.WriteLine("please enter a valid input");
            }

        }
    }
}
