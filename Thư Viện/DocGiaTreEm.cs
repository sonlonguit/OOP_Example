using System;

namespace Project2
{
    class DocGiaTreEm : DocGia
    {
        private string NguoiDaiDien;
        public void DGTENhap(){
            base.Nhap();
            Console.Write(" + Nhap ten nguoi dai dien: ");
            NguoiDaiDien = Console.ReadLine();
        }
        public void DGTEXuat(){
            base.Xuat();
            Console.Write(" + Ho ten nguoi dai dien: {0}", NguoiDaiDien);
        }
        public float TinhTienLamThe(){
            return 20000;
        }
    }
}
