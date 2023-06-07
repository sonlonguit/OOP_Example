using System;

namespace Project3
{
    class Program
    {
        static void Main()
        {
            BanNhac newBanNhac = new BanNhac();
            newBanNhac.Nhap();
            newBanNhac.Xuat();
            Console.Write("\nSo luong dau lang = {0}\n", newBanNhac.DemSoDauLang());
            Console.Write("\nCao do lon nhat = {0}\n", newBanNhac.CaoDoMax());
        }
    }
}
