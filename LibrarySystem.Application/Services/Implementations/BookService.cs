using LibrarySystem.Application.InputModels;
using LibrarySystem.Application.Services.Interfaces;
using LibrarySystem.Application.ViewModels;

namespace LibrarySystem.Application.Services.Implementations
{
    public class BookService : IBookService
    {
        public int Create(NewBookInputModel inputModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<BookViewModel> GetAll(string query)
        {
            throw new NotImplementedException();
        }

        public BookDetailsViewModel GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
