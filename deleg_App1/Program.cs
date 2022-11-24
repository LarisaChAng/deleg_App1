using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deleg_App1
{
    class Program
    {
        delegate double MyDel(double r);
        static void Main(string[] args)
        {
            MyDel mDel = Length;
            double p=mDel(5.5);
            Console.WriteLine($"Длина окружности при радиусе = 5,5: {p:.00}");

            mDel = Sq;
            p = mDel(5.5);
            Console.WriteLine($"Площадь круга при радиусе = 5,5: {p:.00}");

            //mDel = Vol;
            //p = mDel(5);
            //Console.WriteLine($"Объем шара {p:.00}");

            mDel = Vol;
            Console.WriteLine("Введите радиус");
            p = mDel(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine($"Результат: объем шара {p:.00}");

            //mDel += Sq;
            //mDel += Vol;
            // Console.WriteLine("Введите радиус");
            //MyDel
            //  Length(); (double r);= Convert.ToDouble(Console.ReadLine());


            // Console.WriteLine($"радиус {mDel} {mDel2} {mDel3}");

            Console.ReadKey();
        }

        static double Length(double r)
        {
            return 2 * Math.PI * r;
        }
        static double Sq(double r) => (double)Math.PI * r * r;

        static double Vol(double r)
        {
            Console.WriteLine("Расчет объема шара");            
            return (4.0/3)* Math.PI * Math.Pow(r, 3);           
        }
    }
}
