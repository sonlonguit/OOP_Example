using System;

namespace Project2
{
    class DocGiaNguoiLon : DocGia
    {
        private string _CMND;
        public string CMND{
            get { return _CMND; }
            set { _CMND = value; }
        }
        public void DGNLNhap(){
            base.Nhap();
        }
        public void DGNLXuat(){
            base.Xuat();
            Console.Write(" + CMND: {0}", CMND);
        }
        public float TinhTienLamThe(){
            return SoThangHieuLuc*10000;
        }
    }
}
