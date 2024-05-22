using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _22._05._2024
{
    public abstract class Ogrenci
    {
        public string ogrenciTipi;

        

        public int ad(int ad)
        {
            return ad;


        }

        public virtual void study(string ogrenciTipi)
        {
            Console.WriteLine($"{ogrenciTipi} Ogrencisi çalışır");
        }

        public void sinav()
        {
            Console.WriteLine("Öğrenci sınava girer");

        }

    }
}
