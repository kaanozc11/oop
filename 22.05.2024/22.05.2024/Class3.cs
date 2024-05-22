using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._05._2024
{
    internal class Master : Ogrenci
    {
        public override void study(string ogrenciTipi)
        {
            Console.WriteLine($"{ogrenciTipi} iki kere çalışır.");
        }
    }
}
