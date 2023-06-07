using System;

namespace Project2
{
    class DocGia
    {
        protected string HoTen;
        protected CNgay NgayLapThe = new CNgay();
        protected int SoThangHieuLuc;
        public void Nhap()
        {
            Console.Write(" + Nhap vao ho ten: ");
            HoTen = Console.ReadLine();

            Console.Write(" + Nhap vao ngay lap the:\n");
            NgayLapThe.Nhap();

            do
            {
                Console.Write(" + Nhap so thang co hieu luc: ");
                SoThangHieuLuc = int.Parse(Console.ReadLine());
                if(SoThangHieuLuc<=0){
                    Console.WriteLine("Nhap lai!!!");
                }
            }while(SoThangHieuLuc<=0);



        }
        public void Xuat()
        {
            Console.WriteLine("\n + Ho ten: {0}", HoTen);
            Console.Write(" + Ngay lap the: ");
            NgayLapThe.Xuat();
            Console.WriteLine(" + So thang hieu luc: {0}", SoThangHieuLuc);
        }
    }
}
