using System;
using System.Collections.Generic;

namespace Project2
{
    class ThuVien
    {
        private List<DocGiaTreEm> ListDGTE = new List<DocGiaTreEm>();
        private List<DocGiaNguoiLon> ListDGNL = new List<DocGiaNguoiLon>();
        public void Nhap()
        {
            int LuaChon;
            do
            {
                Console.Write("----------- MENU -----------\n");
                Console.Write("1. Doc gia tre em\n");
                Console.Write("2. Doc gia nguoi lon\n");
                Console.Write("0. Thoat\n");
                Console.Write("----------------------------\n");
                Console.Write("Nhap lua chon: ");
                LuaChon = int.Parse(Console.ReadLine());
                do
                {
                    if (LuaChon < 0 || LuaChon > 2) Console.Write("Lua chon khong hop le!");
                } while (LuaChon < 0 || LuaChon > 2);

                if (LuaChon == 1)
                {
                    DocGiaTreEm newTreEm = new DocGiaTreEm();
                    newTreEm.DGTENhap();
                    ListDGTE.Add(newTreEm);
                }
                else if (LuaChon == 2)
                {
                    bool Check;
                    DocGiaNguoiLon newNguoiLon = new DocGiaNguoiLon();
                    string cmnd;
                    newNguoiLon.DGNLNhap();

                    do
                    {
                        Console.Write(" + Nhap so CMND: ");
                        cmnd = Console.ReadLine();
                        Check = true;
                        int size = ListDGNL.Count;
                        for (int i = 0; i < size; i++)
                        {
                            if (ListDGNL[i].CMND == cmnd)
                            {
                                Check = false;
                                break;
                            }

                        }
                        if (Check == false) Console.Write("CMND da ton tai. Vui long nhap lai!!");

                    } while (Check == false);
                    newNguoiLon.CMND = cmnd;
                    ListDGNL.Add(newNguoiLon);
                }

            } while (LuaChon != 0);
        }
        public void Xuat(){
            Console.Write("------ Danh sach doc gia tre em ------\n");
            for(int i = 0; i < ListDGTE.Count; i++){
                Console.Write("\nDoc gia tre em {0}: ", i+1);
                ListDGTE[i].DGTEXuat();
            }
            Console.Write("\n----- Danh sach doc gia nguoi lon -----\n");
            for(int i = 0; i < ListDGNL.Count; i++){
                Console.Write("\nDoc gia nguoi lon {0}:", i+1);
                ListDGNL[i].DGNLXuat();
            }
        }
        public float TinhTongTien(){
            float Tong = 0;
            for(int i = 0; i < ListDGTE.Count; i++){
                Tong += ListDGTE[i].TinhTienLamThe();
            }
            for(int i = 0; i < ListDGNL.Count; i++){
                Tong += ListDGNL[i].TinhTienLamThe();
            }
            return Tong;
        }
    }
}
