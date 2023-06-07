using System;

namespace Project3
{
    class KiHieu
    {
        protected int _CaoDo;
        public int CaoDo
        {
            get { return _CaoDo; }
            set { _CaoDo = value; }
        }
        protected double _TruongDo;
        public double TruongDo
        {
            get { return _TruongDo; }
            set { _TruongDo = value; }
        }
        protected bool _isDauLang;
        public bool isDauLang {
            get{ return _isDauLang; }
            set{ _isDauLang = value; }
        }
        public void Nhap()
        {
            int LuaChon;
            do
            {
                Console.Write("Nhap truong do: ");
                Console.Write("\n\t1.Tron");
                Console.Write("\n\t2. Trang");
                Console.Write("\n\t3. Den");
                Console.Write("\n\t4. Moc don");
                Console.Write("\n\t5. Moc doi");
                Console.Write("\n\t6. Moc ba");
                Console.Write("\n\t7. Moc tu");
                Console.Write("\nNhap lua chon: ");
                LuaChon = int.Parse(Console.ReadLine());
                if (LuaChon < 1 || LuaChon > 7)
                    Console.Write("Lua chon khong hop le. Nhap lai!!");
            } while (LuaChon < 1 || LuaChon > 7);

            switch (LuaChon)
            {
                case 1:
                    TruongDo = 4;
                    break;
                case 2:
                    TruongDo = 2;
                    break;
                case 3:
                    TruongDo = 1;
                    break;
                case 4:
                    TruongDo = 0.5;
                    break;
                case 5:
                    TruongDo = 0.25;
                    break;
                case 6:
                    TruongDo = 0.0125;
                    break;
                case 7:
                    TruongDo = 0.00625;
                    break;
            }
        }
        public void Xuat() {
            Console.Write("\n\tTruong do = {0}", TruongDo);
            Console.Write("\n\tCao do = {0}\n", CaoDo);
            
        }
    }
}
