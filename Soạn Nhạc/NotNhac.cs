using System;

namespace Project3
{
    class NotNhac : KiHieu
    {
        public void Nhap()
        {
            base.Nhap();
            isDauLang = false;
            do
            {
                Console.Write("Nhap cao do: ");
                Console.Write("\n\t1.Do (C)");
                Console.Write("\n\t2. Re (D)");
                Console.Write("\n\t3. Mi (E)");
                Console.Write("\n\t4. Fa (F)");
                Console.Write("\n\t5. Son (G)");
                Console.Write("\n\t6. La (A)");
                Console.Write("\n\t7. Si (B)");
                Console.Write("\nNhap lua chon: ");
                CaoDo = int.Parse(Console.ReadLine());
                if (CaoDo < 1 || CaoDo > 7)
                    Console.Write("Lua chon khong hop le. Nhap lai!!");
            } while (CaoDo < 1 || CaoDo > 7);
        }
        public void Xuat()
        {
            Console.Write("\nType: Not nhac");
            
            base.Xuat();
            Console.Write("Cao do = ");

            switch (CaoDo)
            {
                case 1:
                    Console.Write("C");
                    break;
                case 2:
                    Console.Write("D");
                    break;
                case 3:
                    Console.Write("E");
                    break;
                case 4:
                    Console.Write("F");
                    break;
                case 5:
                    Console.Write("G");
                    break;
                case 6:
                    Console.Write("A");
                    break;
                case 7:
                    Console.Write("B");
                    break;
            }
        }
    }
}
