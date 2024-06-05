using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Application.ViewModels
{
    public class BookDetailsViewModel
    {
        public BookDetailsViewModel(string id, string title, string author, string isbn, int publishYear)
        {
            Id = id;
            Title = title;
            Author = author;
            Isbn = isbn;
            this.publishYear = publishYear;
        }

        public string Id { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Isbn { get; private set; }
        public int publishYear { get; private set; }
    }
}
