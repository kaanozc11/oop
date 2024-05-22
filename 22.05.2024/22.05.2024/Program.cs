namespace _22._05._2024 //Kaan ÖZCAN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
           // Sinif sinif = new Sinif(); (Abstract classlarda doğrudan örnekleme oluşturulamaz.)

            Lisans lisans = new Lisans();
            lisans.study("Lisans");

            Master master = new Master();
            master.study("Yüksek Lisans");

            Master master2 = new Master();
            master2.study("Yüksek Lisans");
             
        }
    }
}
