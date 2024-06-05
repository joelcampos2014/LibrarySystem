using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Application.ViewModels
{
    public class BookViewModel
    {
        public BookViewModel(string id, string title, string author)
        {
            Id = id;
            Title = title;
            Author = author;
        }

        public string Id { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }
    }
}
