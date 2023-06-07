using System;

namespace Project3
{
    class DauLang : KiHieu
    {
        public void Nhap(){
            base.Nhap();
            isDauLang = true;
            CaoDo = 0;
        }
        public void Xuat(){
            Console.Write("\nType: Dau lang");
            base.Xuat();
        }
    }
}
