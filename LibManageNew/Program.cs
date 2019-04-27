

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
            List<Books> Booklist = new List<Books>();
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
                        Books book = BooksMethod.AddBooks(Booklist);
                        Booklist.Add(book);
                        Console.WriteLine("Them sach thanh cong! \n");
                        break;
                    case 2:
                        BooksMethod.RemoveBook(Booklist);
                        Console.WriteLine("Xoa sach thanh cong. \n");
                        break;
                    case 3:
                        BooksMethod.ModifyBook(Booklist);
                        Console.WriteLine("Cap nhap sach thanh cong! \n");
                        break;
                    case 4:
                        BooksMethod.LookupBook(Booklist);

                        break;
                    default:
                        Console.WriteLine("Vui long nhap lua chon phu hop! \n");
                        break;
                }
                Booklist.ForEach(display);
                goto chuongtrinhquanli;
            }
            while (n >= 12);
        }

        static void display(Books book)
        {
            Console.WriteLine(book.BookName + "    " + book.ISBN);
        }
    }
}
