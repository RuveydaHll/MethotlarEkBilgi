using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 20;
            int number2 = 100;
            var result = Add2(ref number1, number2);   //Out Keyword: Değer tipi referans tipe yönlendirir.

            Console.WriteLine(result);
            Console.WriteLine(number1);
            Console.ReadLine();                        //Ref ile Out arasındaki fark: Ref kullanırken number1'nın değeri olması gerekmektedir.
                                                      //Out için değer atamak zorunda değilsiniz.
                                                     //Dikkat:Out kullanmadan önce yollanan değerin mutlaka ama mutlaka yollanan yerde bir değer alması
        }

        static int Add2(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;


        } 
    }
}
 