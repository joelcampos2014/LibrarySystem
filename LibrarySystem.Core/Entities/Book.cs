using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Core.Entities
{
    public class Book : BaseEntity
    {
        public Book(string title, string author, string isbn, int publishYear)
        {
            IsDeleted = false;
            Title = title;
            Author = author;
            Isbn = isbn;
            this.publishYear = publishYear;
        }

        public bool IsDeleted { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Isbn { get; private set; }
        public int publishYear { get; private set; }

        public void Delete()
        {
            IsDeleted = true;
        }
    }
}
