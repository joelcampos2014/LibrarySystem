using LibrarySystem.Application.InputModels;
using LibrarySystem.Application.ViewModels;

namespace LibrarySystem.Application.Services.Interfaces
{
    public interface IBookService
    {
        List<BookViewModel> GetAll(string query);
        BookDetailsViewModel GetById(string id);
        int Create(NewBookInputModel inputModel);
        void Delete(string id);
    }
}
