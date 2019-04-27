

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibManage
{
    class Program
    {
        static void Main(string[] args)
        {

            Sach.listsach a = new Sach.listsach();
            a = AddListBook.Nhaplistsach("Danh sach sach trong thu vien");

            int n;
            do
            {
            chuongtrinhquanli:
                Console.WriteLine(" --- CHUONG TRINH QUAN LY THU VIEN --- \n");
                Console.WriteLine("Danh sach cac chuc nang: \n");
                Console.WriteLine("1.Them sach");
                Console.WriteLine("2.Xoa sach");
                Console.WriteLine("3.Sua sach");
                Console.WriteLine("4.Tim kiem sach");
                Console.WriteLine("5.Them doc gia");
                Console.WriteLine("6.Xoa doc gia");
                Console.WriteLine("7.Sua doc gia");
                Console.WriteLine("8.Tim kiem doc gia");
                Console.WriteLine("9.Lap phieu muon sach");
                Console.WriteLine("10.Lap phieu tra sach");
                Console.WriteLine("11.Liet ke danh sach muon sach tre han");
                Console.WriteLine("0.Thoat");
                Console.Write("Vui long chon chuc nang can thuc hien: ");
                n = int.Parse(Console.ReadLine());


                switch (n)
                {
                    case 0:
                        System.Environment.Exit(0);
                        break;
                    case 1:
                        Sach.sach NewBook = AddBook.Themsachmoi(a);
                        Console.WriteLine(NewBook.Tacgia);
                        a.dssach[a.dssach.GetUpperBound(0)] = NewBook;
                        break;
                    case 2:
                        DelBook.Xoasach(a);
                        break;
                    // case 3:
                    //     Sachuasach(a, n);
                    //     break;
                    // case 4: 
                    //     Inchitietsach(a, n, MS); 
                    //     break;
                    // case 5:
                    //     Themdocgia(b, n);
                    //     break;
                    // case 6:
                    //     Xoadocgia(b, n); 
                    //     break;
                    // case 7:
                    //     Suadocgia(b, n); 
                    //     break;
                    // case 8:
                    //     Inchitietdocgia(b, n, MDG); 
                    //     break;
                    default:
                        Console.WriteLine("Vui long nhap lua chon phu hop!");
                        break;
                }
                Sach.ViewListsach(a);
                goto chuongtrinhquanli;
            }
            while (n >= 12);
            //Console.ReadKey();
        }
    }
}
