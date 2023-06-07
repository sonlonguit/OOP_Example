using System;
using System.Collections.Generic;
namespace Project3
{
    class BanNhac
    {
        private List<KiHieu> ListKiHieu = new List<KiHieu>();
        public void Nhap()
        {
            int LuaChon;
            do
            {
                Console.Write("-- BAT DAU VIET NHAC ------\n");
                Console.Write("1. Tao ki hieu\n");
                Console.Write("2. Hoan thanh\n");
                Console.Write("---------------------------\n");
                Console.Write("Nhap lua chon: ");
                LuaChon = int.Parse(Console.ReadLine());
                do
                {
                    if (LuaChon < 1 || LuaChon > 2) Console.Write("Lua chon khong hop le!");
                } while (LuaChon < 1 || LuaChon > 2);

                if (LuaChon == 1)
                {
                    int LuaChonKiHieu;
                    Console.Write("-- Chon loai ki hieu:");
                    Console.Write("\n\t1. Not nhac");   
                    Console.Write("\n\t2. Dau lang");
                    Console.Write("\nNhap lua chon: ");
                    LuaChonKiHieu = int.Parse(Console.ReadLine());
                    if (LuaChonKiHieu == 1)
                    {
                        NotNhac newNotNhac = new NotNhac();
                        newNotNhac.Nhap();
                        ListKiHieu.Add(newNotNhac);
                    }
                    if (LuaChonKiHieu == 2)
                    {
                        DauLang newDauLang = new DauLang();
                        newDauLang.Nhap();
                        ListKiHieu.Add(newDauLang);
                    }
                }

            } while (LuaChon != 2);
        }
        public void Xuat(){
            Console.Write("\n--------- PHAT NHAC -----------\n");
            for (int i = 0; i < ListKiHieu.Count; i++)
            {
                ListKiHieu[i].Xuat();
            }
        }
        public int DemSoDauLang(){
            int count = 0;
            for (int i = 0; i < ListKiHieu.Count; i++)
            {
                if(ListKiHieu[i].isDauLang == true) count++;
            }
            return count;
        }
        public int CaoDoMax(){
            int max = 0;
            for (int i = 0; i < ListKiHieu.Count; i++)
            {
                if(ListKiHieu[i].CaoDo >= max) {
                    max = ListKiHieu[i].CaoDo;
                }
            }
            return max;
        }
    }
}
