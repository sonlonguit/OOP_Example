using System;

namespace Project2
{
    class Program
    {
        static void Main()
        {
            ThuVien x = new ThuVien();
            x.Nhap();
            x.Xuat();
            Console.Write("\n=> Tong so tien lam the = {0}", x.TinhTongTien());
            
            
            Console.ReadKey();
        }
    }
}
