using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5prac4
{
    public  class Program
    {
        public class MyException : Exception
        {
            public MyException(string message)
            {
                Console.WriteLine(message);
            }
        }
        public void checkAge( int age)
        {
            if(age<18)
            {
                throw new MyException("you are under 18");
            }
            else
            {
                Console.WriteLine("Your are eligible to drive");
            }

        }

        static void Main(string[] args)
        {
            Program p =new Program();
            p.checkAge(5);
        }
    }
}
