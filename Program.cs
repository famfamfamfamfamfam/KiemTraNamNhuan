using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace CAULENHDIEUKIEN
{
    class KiemTraNamNhuan
    {
        static void Main(string[] args)
        {
            int nam;
            bool namnhuan = false;

            Console.WriteLine("Nhap nam can xet:");
            nam = int.Parse(Console.ReadLine());

            bool chiahetcho4 = nam % 4 == 0;
            bool chiahetcho100 = nam % 100 == 0;
            bool chiahetcho400 = nam % 400 == 0;

            if (chiahetcho4)
            {
                if (chiahetcho100)
                {
                    if (chiahetcho400)
                    {
                        namnhuan = true;
                    }
                }
                else
                {
                    namnhuan = true;
                }
            }

            if (namnhuan)
            {
                Console.WriteLine("{0} la nam nhuan", nam);
            }
            else Console.WriteLine("{0} la nam khong nhuan", nam);
        }
    }
}
