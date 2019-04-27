using System;
using System.Collections.Generic;
using System.Text;

namespace LibManage
{
    class AddListBook
    {
        public static Sach.listsach Nhaplistsach(string ghichu)
        {
            Sach.listsach a;
            Console.WriteLine(ghichu);
            Console.Write("Nhap so luong dau sach: ");
            int N = int.Parse(Console.ReadLine());
            a.dssach = new Sach.sach[N];
            for (int i = 0; i < N; i++)
            {
                a.dssach[i] = AddBook.Nhapsach(a, "Them sach vao danh sach");
                for (int j = 0; j < i; j++)
                {
                    if (a.dssach[i].Masach_ISBN == a.dssach[j].Masach_ISBN)
                    {
                        Console.WriteLine("Ma sach da ton tai, vui long nhap lai.");
                        --i;
                        break;
                    }
                }
            }
            return a;
        }
    }
}
