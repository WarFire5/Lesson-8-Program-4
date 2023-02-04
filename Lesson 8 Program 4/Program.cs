using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_Program_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дано квадратное уравнение стандартного вида: AX^2+BX+C=0."); 
            
            string A, B, C;

            Console.WriteLine("Введите число 'A':");
            A = Console.ReadLine();

            Console.WriteLine("Введите число 'B':");
            B = Console.ReadLine();

            Console.WriteLine("Введите число 'C':");
            C = Console.ReadLine();

            int a = Convert.ToInt32(A);

            int b = Convert.ToInt32(B);

            int c = Convert.ToInt32(C);

            int d = b * b - 4 * a * c;

            double x = (- b + Math.Sqrt(d)) / 2 * a;

            double y = (- b - Math.Sqrt(d)) / 2 * a;

            if (d > 0)
            {
                Console.WriteLine("Два разных корня: " + x + " " + "и" + " " + y);            
            }
            
            else if (d == 0)
            {
                Console.WriteLine("Один корень или, точнее, два одинаковых корня: " + x);
            }

            else if (d < 0)
            {
                Console.WriteLine("Действительных корней нет");
            }

            Console.ReadLine();
        }
    }
}
