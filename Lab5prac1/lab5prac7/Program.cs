using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5prac7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
          

            try
            {
                Console.WriteLine("enter quit to stop the program else enter no");
                Console.WriteLine("enter the value of number1 ");
               String number1 = Console.ReadLine();
                Console.WriteLine("enter the value of number2 ");
                String number2 = Console.ReadLine();
               


                while ( number1!= "quit" || number2 != "quit")
                {
                    if (number1 == "quit" || number2 == "quit")
                    {
                        break;
                    }

                    int x= Convert.ToInt32(number1) ;
                    int y = Convert.ToInt32(number2);
                    int result = x / y;

                    Console.WriteLine("result is here ");
                    Console.WriteLine(result);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("please enter valid number");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("infinity");
            }

            }
        }
    }

