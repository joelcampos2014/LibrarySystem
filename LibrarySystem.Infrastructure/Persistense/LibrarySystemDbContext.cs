using LibrarySystem.Core.Entities;
using System.Collections.Generic;

namespace LibrarySystem.Infrastructure.Persistense
{
    public class LibrarySystemDbContext
    {
        public LibrarySystemDbContext()
        {
            Books = new List<Book>()
            {
                new Book("Memórias póstumas de Braz Cubas", "Machado de Assis", "0367373", 1968),
                new Book("A culpa é das estrelas", "Jhon Green", "2541581", 2012),
                new Book("As crônicas de Nárnia", "C. S. Lewis", "84155154", 1961)
            };
        }

        public List<Book> Books { get; set; }
    }
}
