using System;

namespace Project2
{
    class CNgay
    {
        private int Ngay, Thang, Nam;
        public void Nhap(){
            Console.Write("\tNhap ngay: ");
            Ngay = int.Parse(Console.ReadLine());

            Console.Write("\tNhap thang: ");
            Thang = int.Parse(Console.ReadLine());

            Console.Write("\tNhap nam: ");
            Nam = int.Parse(Console.ReadLine());
            
        }
        public void Xuat(){
            Console.WriteLine("Ngay {0} thang {1} nam {2}", Ngay, Thang, Nam);
            
        }
    }
}
