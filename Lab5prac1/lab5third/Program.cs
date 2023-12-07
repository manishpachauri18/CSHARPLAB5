using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5third
{
    internal class Program
    {
        public class MyException : Exception

        {
            public MyException(string message) : base(message) 
            {

            }
        }
        static void Main(string[] args)
        {
            int y = 123;
           String  z = y.ToString();
            Console.WriteLine(z.GetType());
            String name = "manish pachauri";
            try
            {
                int x = int.Parse(name);
            } catch (Exception e)
            
            {
                Console.WriteLine(e.Message+"string is is not numeric please check your string");
            }
        }
    }
}
