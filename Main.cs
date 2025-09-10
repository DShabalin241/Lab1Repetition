using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициент a ");
            double cofA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите коэффициент b ");
            double cofB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координату x для точки О1 ");
            double coordX1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y для точки О1");
            double coordY1 = Convert.ToDouble(Console.ReadLine());

            double testcoord;

            Console.WriteLine("Введите координату x для точки О2 ");
            double coordX2 = Convert.ToDouble(Console.ReadLine());

            double coordY2 = cofA * coordX2 + cofB;
            Console.WriteLine("Координата Y для точки О2 = " + coordY2);
        }
    }
}
