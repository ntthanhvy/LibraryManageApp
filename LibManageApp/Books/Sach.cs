using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LibManage
{
    public class Sach
    {
        public struct sach
        {
            public string Masach_ISBN;
            public string Tensach;
            public string Tacgia;
            public string Nhaxuatban;
            public int Giasach;
            public string Loaisach;
            public int Tongsoluong;
            public int Slhientai;
            public int Slmuon;
        }
        public struct listsach
        {
            public sach[] dssach;
        }

        public static void ViewListsach(listsach a)
        {
            if (a.dssach.Length > 0)
            {
                for (int i = 0; i < a.dssach.Length; i = i + 1)
                {
                    sach sach = a.dssach[i];
                    Console.WriteLine("Ten sach: ", sach.Tensach);
                    Console.WriteLine("Ma sach IBNS: ", sach.Masach_ISBN);
                    Console.WriteLine();

                }
            }else
            {
                Console.WriteLine("Khong co sach trong thu vien");
            }
        }

    }
}