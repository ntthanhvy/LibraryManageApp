using System;
using System.Collections.Generic;
using System.Text;

namespace LibManage
{
    public class BooksMethod
    {
        // add one more book to the list
        public static Books AddBooks(List<Books> listBooks)
        {
            Books b = new Books();
            Console.WriteLine("Them sach moi");

            // add ISBN code
            Console.Write("Ma sach ISBN: ");
            string isbn = Console.ReadLine();
            while (FindBook(listBooks, isbn) >= 0)
            {
                Console.WriteLine("Ma sach da ton tai.");
                Console.Write("Nhap lai ma ISBN: ");
                isbn = Console.ReadLine();
            }
            b.ISBN = isbn;

            // add book's name
            Console.Write("Nhap ten sach: ");
            b.BookName = Console.ReadLine();

            // add book's author
            Console.Write("Nhap ten tac gia: ");
            b.Author = Console.ReadLine();

            // add book's publisher
            Console.Write("Ten nha xuat ban: ");
            b.Publisher = Console.ReadLine();

            // define book's price 
            Console.Write("Gia sach: ");
            int price = int.Parse(Console.ReadLine());
            while (price < 1000)
            {
                Console.WriteLine("Gia sach khong dung.");
                Console.Write("Nhap lai gia sach: ");
                price = int.Parse(Console.ReadLine());
            }
            b.Price = price;

            // add book's category
            Console.WriteLine("(Sach Tieng Viet - 0; Sach Ngoai van - 1)");
            Console.Write("Nhap load sach: ");
            int cate = int.Parse(Console.ReadLine());
            while (cate > 1 || cate < 0)
            {
                Console.WriteLine("Loai sach khong dung.");
                Console.WriteLine("(Sach Tieng Viet - 0; Sach Ngoai van - 1)");
                Console.Write("Nhap lai loai sach: ");
                cate = int.Parse(Console.ReadLine());
            }
            switch (cate)
            {
                case 1:
                    b.Category = "Sach Ngoai van";
                    break;
                case 0:
                    b.Category = "Sach tieng viet";
                    break;
            }

            // add book's amount
            Console.Write("Nhap so luong: ");
            int amount = int.Parse(Console.ReadLine());
            while (amount <= 0)
            {
                Console.WriteLine("So luong khong dung.");
                Console.Write("Nhap lai so luong: ");
                amount = int.Parse(Console.ReadLine());
            }
            b.TotalAmount = amount;

            b.CurrBooksAmount = b.TotalAmount;
            b.BorrBooksAmount = 0;

            
            return b;
        }

        // remove a book from list books
        public static List<Books> RemoveBook(List<Books> list)
        {
            Console.WriteLine("XOA THONG TIN SACH");
            Console.Write("Nhap vao Ma so cua sach: ");
            string isbn = Console.ReadLine();
            int pos = FindBook(list, isbn);
            if (pos == -1)
            {
                Console.WriteLine("Ma sach khong ton tai. \n");
                return list;
            } else
            {
                list.RemoveAt(pos);
            }
            return list;
        }

        // modify book in list
        public static List<Books> ModifyBook(List<Books> list)
        {
            Console.WriteLine("Chinh sua sach");
            Console.Write("Nhap ma so tra cuu sach: ");
            string isbn = Console.ReadLine();
            int pos = FindBook(list, isbn);
            while (pos != -1)
            {
                Console.WriteLine("Ma sach khong ton tai. \n");
                Console.Write("Nhap lai ma sach: ");
                isbn = Console.ReadLine();
                pos = FindBook(list, isbn);
            }

            // get book at wanted position
            Books modBook = list[pos];
            BookDetail(modBook);

            list[pos] = UpdateBook(modBook, list);

            return list;
        }

        static Books UpdateBook(Books b, List<Books> listBooks)
        {
            // add ISBN code
            Console.Write("Cap nhap ma sach ISBN: ");
            string isbn = Console.ReadLine();
            while (FindBook(listBooks, isbn) >= 0)
            {
                Console.WriteLine("Ma sach da ton tai.");
                Console.Write("Nhap lai ma ISBN: ");
                isbn = Console.ReadLine();
            }
            b.ISBN = isbn;

            // add book's name
            Console.Write("Cap nhap ten sach: ");
            b.BookName = Console.ReadLine();

            // add book's author
            Console.Write("Cap nhap ten tac gia: ");
            b.Author = Console.ReadLine();

            // add book's publisher
            Console.Write("Cap nhap ten nha xuat ban: ");
            b.Publisher = Console.ReadLine();

            // define book's price 
            Console.Write("Cap nhap gia sach: ");
            int price = int.Parse(Console.ReadLine());
            while (price < 1000)
            {
                Console.WriteLine("Gia sach khong dung.");
                Console.Write("Nhap lai gia sach: ");
                price = int.Parse(Console.ReadLine());
            }
            b.Price = price;

            // add book's category
            Console.WriteLine("(Sach Tieng Viet - 0; Sach Ngoai van - 1)");
            Console.Write("Cap nhap load sach: ");
            int cate = int.Parse(Console.ReadLine());
            while (cate > 1 || cate < 0)
            {
                Console.WriteLine("Loai sach khong dung.");
                Console.WriteLine("(Sach Tieng Viet - 0; Sach Ngoai van - 1)");
                Console.Write("Nhap lai loai sach: ");
                cate = int.Parse(Console.ReadLine());
            }
            switch (cate)
            {
                case 1:
                    b.Category = "Sach Ngoai van";
                    break;
                case 0:
                    b.Category = "Sach tieng viet";
                    break;
            }

            // add book's amount
            Console.Write("Cap nhap so luong: ");
            int amount = int.Parse(Console.ReadLine());
            while (amount <= 0)
            {
                Console.WriteLine("So luong khong dung.");
                Console.Write("Nhap lai so luong: ");
                amount = int.Parse(Console.ReadLine());
            }
            b.TotalAmount = amount;

            b.CurrBooksAmount = b.TotalAmount - b.BorrBooksAmount;

            return b;
        }

        // view book's detail
        public static void BookDetail(Books book)
        {
            Console.WriteLine("   Thong tin chi tiet sach    ");
            Console.WriteLine("Ma sach                :" + book.ISBN);
            Console.WriteLine("Ten sach               :" + book.BookName);
            Console.WriteLine("Tac gia                :" + book.Author);
            Console.WriteLine("Nha xuat ban           :" + book.Publisher);
            Console.WriteLine("Gia sach               :" + book.Price);
            Console.WriteLine("Loai sach              :" + book.Category);
            Console.WriteLine("Tong so luong          :" + book.TotalAmount);
            Console.WriteLine("So luong hien tai      :" + book.CurrBooksAmount);
            Console.WriteLine("So luong dang duoc muon:" + book.BorrBooksAmount);
        }

        // Lock up for a book in list
        public static List<Books> LookupBook(List<Books> list)
        {
            Console.WriteLine("     Tim kiem sach     ");
            Console.WriteLine("Chon loai tim kiem");
            Console.WriteLine("1. Tim theo ma sach ISBN");
            Console.WriteLine("2. Tim theo ten sach");
            Console.WriteLine("3. Tim theo ten tac gia");
            Console.WriteLine("4. Tim theo nha xuat ban");
            Console.WriteLine("5. Tim theo gia sach");
            Console.Write("Lua chon: ");
            int n = int.Parse(Console.ReadLine());

            List<Books> result = new List<Books>();

            switch (n)
            {
                case 2:
                    Console.Write("Nhap ten sach: ");
                    string name = Console.ReadLine();
                    result = Lookup.FindByName(name, list);
                    break;
            }

            return result;
        }

        // Check weather the book exist in the list books
        public static int FindBook(List<Books> list, string isbn)
        {
            for (int i = 0; i < list.Count; i += 1)
            {
                string masach = list[i].ISBN;
                if (masach.Equals(isbn))
                {
                    return i;
                }
                continue;
            }
            return -1;
        }
    }
}
