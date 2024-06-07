using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Application.InputModels
{
    public class NewBookInputModel
    {
        public string Title { get; set; }
        public string Author { get;  set; }
        public string Isbn { get;  set; }
        public int publishYear { get; set; }
    }
}
