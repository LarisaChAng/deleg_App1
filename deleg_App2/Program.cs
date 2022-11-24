using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deleg_App2
{
    class Program
    {
        delegate void MyDel(double r);
        static void Main(string[] args)
        {
            MyDel mDel = Length;
            mDel += Sq;
            mDel += Vol;
            mDel(5.5);

            Console.ReadKey();
        }

        static void Length(double r)
        {
            Console.WriteLine(2 * Math.PI * r);
        }
        static void Sq(double r)
        {
            Console.WriteLine(Math.PI * r * r);
        }

        static void Vol(double r)
        {
            Console.WriteLine((4.0 / 3) * Math.PI * Math.Pow(r, 3));
        }
    }
}
