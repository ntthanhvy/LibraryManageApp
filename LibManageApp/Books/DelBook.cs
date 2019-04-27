using System;
using System.Collections.Generic;
using System.Text;

namespace LibManage
{
    class DelBook
    {
        public static void Xoasach(Sach.listsach a)
        {
            string MS;
            int vitri;
            Console.WriteLine("XOA THONG TIN SACH");
            Console.Write("Nhap vao Ma so cua sach:");
            MS = Console.ReadLine();
            vitri = FindBook.Tramasach(a, MS);
            if (vitri == -1)
            {
                Console.WriteLine("Khong co ma sach nay.");
            }
            else
            {
                int n = a.dssach.Length;
                for (int i = vitri; i <= n; i++)
                {
                    a.dssach[i] = a.dssach[i + 1];
                    n--;
                }
            }

        }
    }
}
