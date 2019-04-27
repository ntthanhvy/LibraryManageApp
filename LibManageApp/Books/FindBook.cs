using System;
using System.Collections.Generic;
using System.Text;

namespace LibManage
{
    class FindBook
    {
        public static int Tramasach(Sach.listsach dssach, string Masach)
        {
            if (dssach.dssach == null)
            {
                return -1;
            }
            for (int i = 0; i < dssach.dssach.Length; i = i + 1)
            {
                string masach = dssach.dssach[i].Masach_ISBN;
                if (string.Compare(masach, Masach) == 1)
                {
                    return i;
                } else {
                    continue;
                }
            }
            return -1;
        }

        public static Sach.sach Timsach(Sach.listsach a)
        {
            Console.WriteLine("Nhap ma sach can tra cuu: ");
            string MaTam = Console.ReadLine();
            int vitri = Tramasach(a, MaTam);
            if (vitri >= 0)
            {
                return a.dssach[vitri];
            }
            else
            {
                Console.WriteLine("Sach khong ton tai.");
                return a.dssach[0];
            }
        }


    }
    }
