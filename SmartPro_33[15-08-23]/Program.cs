using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_33_15_08_23_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Method method = new Method();
            Console.Write("\nGirdiğiniz değer: {0}",method.YaziGirisi());
            Console.ReadKey();
        }
    }
}
