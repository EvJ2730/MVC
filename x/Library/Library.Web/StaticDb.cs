using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Web
{
    public static class StaticDb
    {
        public static List<Book> Books = new List<Book>()
 
        Book book1 = new Book
        {
            Id = 1,
            Title = "Harry Potter 1"
        };

        Book book2 = new Book
        {
            Id = 2,
            Title = "Harry Potter 2"
        };
        List<Book> books = new List<Book>();
    }
}
