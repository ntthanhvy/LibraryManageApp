using System;
using System.Collections.Generic;
using System.Text;

namespace LibManage
{
    class Lookup
    {
        public static void ViewList(Books b)
        {
            Console.WriteLine("Ten sach: " + b.BookName + "    Ma sach: " + b.ISBN);
        }
        public static List<Books> FindByName(string name, List<Books> list)
        {
            List<Books> MatchName = new List<Books>();
            for (int i = 0; i < list.Count; i += 1)
            {
                if (list[i].BookName.Contains(name))
                {
                    MatchName.Add(list[i]);
                }
            }

            MatchName.ForEach(ViewList);
            return MatchName;
        }
    }
}
