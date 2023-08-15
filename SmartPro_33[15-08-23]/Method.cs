using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_33_15_08_23_
{
    internal class Method
    {
        public string YaziGirisi()
        {
            string text = string.Empty;
            bool error = true;
            do
            {
                Console.Write("Değer giriniz: ");
                text = Console.ReadLine();
                if (text.Length == 0)
                {
                    Console.Write("\nBoş Bırakılamaz.\n");
                    error = true;
                }
                else
                {
                    error = false;
                }

            } 
            while (error);
            return text;
        }
    }
}
