using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw__8
{
    public class LibraryServise
    {
        private LibraryDb _context;
        public LibraryServise()
        {
            _context = new LibraryDb();
        }
        //Task 1
        public IEnumerable<Book> GetBooksByPages()
        {
            return _context.Books.Where(b => b.Pages >= 50);
        }
        //Task 2
        public IEnumerable<Book> GetBooks()
        {
            return _context.Books.Where(b => b.Name.StartsWith("K", StringComparison.OrdinalIgnoreCase) );
        }
        //Task 3
        public IEnumerable<Book> GetBooksByAuthor()
        {
            return _context.Books.Where(b => b.Author.Name == "William" && b.Author.Surname == "Shakespeare");
        }
        //Task 4 
        public IEnumerable<Book> GetBooksByLanguage()
        {
            return _context.Books.Where(b => b.Language.Name == "English");
        }

        //Task 5
        public IEnumerable<Book> GetBooksByNameLenght()
        {
            return _context.Books.Where(b => b.Name.Split(' ').Length < 10);
        }

        //Task 6
        //public IEnumerable<Book> GetBooksByMaxPages()
        //{
        //    return _context.Books.OrderByDescending(b => b.Pages).First();
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {

            LibraryServise libraryServise = new LibraryServise();

            foreach (var item in libraryServise.GetBooksByPages())
            {
                Console.WriteLine($"Book [{item.Name}] {item.Pages} ");
            }

            foreach (var item in libraryServise.GetBooks())
            {
                Console.WriteLine($"Book [{item.Name}] {item.Pages} ");
            }

            foreach (var item in libraryServise.GetBooksByAuthor())
            {
                Console.WriteLine($"Book [{item.Name}] {item.Pages} ");
            }

            foreach (var item in libraryServise.GetBooksByLanguage())
            {
                Console.WriteLine($"Book [{item.Name}] {item.Pages} ");
            }


        }
    }
}
