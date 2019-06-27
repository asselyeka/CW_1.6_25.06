using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*6.	Дано четырехзначное число. Найти:
a.сумму его цифр;
b.произведение его цифр.
*/
namespace CW_1._6_25._06
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, digit;
            var sum = 0;
            var multi = 1;
            Console.WriteLine("Введите четырехзначное число:");
            string textAsNum = Console.ReadLine();
            num = int.Parse(textAsNum);

            foreach(char symbol in textAsNum)
            {
                digit = num % 10;
                sum += digit;
                multi *= digit;
                num /= 10;
            }

            Console.Write("a.	сумму его цифр: ");
            Console.WriteLine(sum);

            Console.Write("b.	произведение его цифр: ");
            Console.WriteLine(multi);

            Console.ReadKey();
        }
    }
}
