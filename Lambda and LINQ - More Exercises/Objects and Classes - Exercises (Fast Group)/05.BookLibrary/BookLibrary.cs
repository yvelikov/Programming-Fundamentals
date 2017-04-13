namespace _05.BookLibrary
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

    public class BookLibrary
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

            var booksByAuthor = CreateDict(booksList);

            foreach (var book in booksByAuthor.OrderByDescending(x => x.Value.Select(y => y.Price).Sum()).ThenBy(x => x.Key))
            {
                var author = book.Key;
                Console.WriteLine($"{author} -> {book.Value.Select(x=>x.Price).Sum():F2}");

            }

        }

        private static Dictionary<string,List<Book>> CreateDict(List<Book> booksList)
        {
            var booksByAuthor = new Dictionary<string, List<Book>>();

            foreach (var book in booksList)
            {
                if (!booksByAuthor.ContainsKey(book.Author))
                {
                    booksByAuthor[book.Author] = new List<Book>();
                }

                booksByAuthor[book.Author].Add(book);
            }
            return booksByAuthor;
        }

        public static Book ReadBook()
        {
            var bookParams = Console.ReadLine().Split(' ').ToArray();

            return new Book
            {
                Title = bookParams[0],
                Author = bookParams[1],
                Publisher = bookParams[2],
                ReleaseDate = DateTime.ParseExact(bookParams[3],"dd.MM.yyyy",CultureInfo.InvariantCulture),
                ISBN = bookParams[4],
                Price = decimal.Parse(bookParams[5])
            };
        }
    }
}
