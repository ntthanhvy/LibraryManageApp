using System;
using System.Collections.Generic;
using System.Text;

namespace LibManage
{
    class AddBook
    {
        public static Sach.sach Nhapsach(Sach.listsach a, string ghichu)
        {
            Console.WriteLine(ghichu);
            Sach.sach book;
            Console.Write("Ma sach_ISBN: ");
        nhapmasach:
            string isbn = Console.ReadLine();
            if (FindBook.Tramasach(a, isbn) == -1)
            {
                book.Masach_ISBN = isbn;
            }
            else
            {
                Console.WriteLine("Sach da ton tai.");
                Console.Write("Nhap lai ma sach ISBN: ");
                goto nhapmasach;
            }
            Console.Write("Ten sach: ");
            book.Tensach = Console.ReadLine();
            Console.Write("Tac gia: ");
            book.Tacgia = Console.ReadLine();
            Console.Write("Nha xuat ban: ");
            book.Nhaxuatban = Console.ReadLine();
            Console.Write("Gia sach: ");
            book.Giasach = int.Parse(Console.ReadLine());
        nhaploaisach:
            Console.WriteLine("(Sach Tieng Viet - 0; Sach Ngoai van - 1)");
            Console.Write("Loai sach: ");
            int k;
            k = int.Parse(Console.ReadLine());
            if (k == 0)
            {
                book.Loaisach = "Sach Tieng Viet";
            }
            else if (k == 1)
            {
                book.Loaisach = "Sach Ngoai van";
            }
            else
            {
                Console.WriteLine("Loai sach khong ton tai moi nhap lai");
                goto nhaploaisach;
            }
            
            Console.WriteLine(book.Loaisach);
            Console.Write("So luong: ");
            book.Tongsoluong = int.Parse(Console.ReadLine());
            book.Slmuon = 0;

            book.Slhientai = book.Tongsoluong;
            return book;
        }

        public static Sach.sach Themsachmoi(Sach.listsach listSach)
        {
            Console.WriteLine("Them dau sach moi vao thu vien: ");
            Sach.sach book = Nhapsach(listSach, "Them sach vao danh sach");
            Console.WriteLine("Them sach thanh cong! \n");
            return book;
        }

    }
}
