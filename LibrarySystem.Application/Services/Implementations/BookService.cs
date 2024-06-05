using LibrarySystem.Application.InputModels;
using LibrarySystem.Application.Services.Interfaces;
using LibrarySystem.Application.ViewModels;
using LibrarySystem.Core.Entities;
using LibrarySystem.Infrastructure.Persistense;

namespace LibrarySystem.Application.Services.Implementations
{
    public class BookService : IBookService
    {
        private readonly LibrarySystemDbContext _dbContext;
        public BookService(LibrarySystemDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public string Create(NewBookInputModel inputModel)
        {
            var book = new Book(inputModel.Title, inputModel.Author, inputModel.Isbn, inputModel.publishYear);

            _dbContext.Books.Add(book);

            return book.Id;
        }

        public void Delete(string id)
        {
            var book = _dbContext.Books.FirstOrDefault(b => b.Id == id);

            book.Delete();
        }

        public List<BookViewModel> GetAll(string query)
        {
            var books = _dbContext.Books.Where(b => !b.IsDeleted);

            var bookViewModel = books
                .Select(b => new BookViewModel(b.Id, b.Title, b.Author))
                .ToList();

            return bookViewModel;
        }

        public BookDetailsViewModel GetById(string id)
        {
            var book = _dbContext.Books.SingleOrDefault(b => b.Id == id && !b.IsDeleted);

            var bookDetailsViewModel = new BookDetailsViewModel(
                book.Id,
                book.Title,
                book.Author,
                book.Isbn,
                book.publishYear);

            return bookDetailsViewModel;
        }
    }
}
