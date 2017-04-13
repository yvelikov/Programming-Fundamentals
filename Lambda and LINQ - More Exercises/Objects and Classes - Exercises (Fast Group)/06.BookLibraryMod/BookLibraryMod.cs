namespace _06.BookLibraryMod
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
    }

    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }

    public class BookLibraryMod
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var booksList = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                var currentBook = ReadBook();

                booksList.Add(currentBook);
            }

            var bookLibrary = new Library()
            {
                Name = "Fantasy",
                Books = new List<Book>()
            };

            var releasedAfter = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            booksList = booksList.Where(x => x.ReleaseDate > releasedAfter).OrderBy(x => x.ReleaseDate).ThenBy(x => x.Title).ToList();

            foreach (var book in booksList)
            {
                Console.WriteLine($"{book.Title} -> {book.ReleaseDate:dd.MM.yyyy}");
            }
        }

        public static Book ReadBook()
        {
            var bookParams = Console.ReadLine().Split(' ').ToArray();

            return new Book
            {
                Title = bookParams[0],
                Author = bookParams[1],
                Publisher = bookParams[2],
                ReleaseDate = DateTime.ParseExact(bookParams[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                ISBN = bookParams[4],
                Price = decimal.Parse(bookParams[5])
            };
        }
    }
}
