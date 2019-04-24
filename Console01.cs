using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMCSharp
{
    class Console01
    {
        static void Main(string[] args)
        {
            double y;
            Console.WriteLine("Введите  a ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите  b ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите  x ");
            double x = Convert.ToDouble(Console.ReadLine());
            y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);
            Console.WriteLine("y = " +y );
        }
    }
}
