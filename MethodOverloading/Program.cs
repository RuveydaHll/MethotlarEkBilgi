using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiply(2,8));
            Console.WriteLine(Multiply(2, 14, 8));


        }
       
        static int Multiply(int number1, int number2)
        {

            return number1 * number2;
        }
        
        static int Multiply(int number1, int number2, int number3)
        {

            return number1 * number2 * number3;
        }
    }
       

   
}
