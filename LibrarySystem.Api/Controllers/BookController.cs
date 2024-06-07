using LibrarySystem.Application.InputModels;
using LibrarySystem.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LibrarySystem.Api.Controllers
{
    /// <summary>
    /// Book api Controller
    /// </summary>
    [Consumes("application/json")]
    [Produces("application/json")]
    [Route("api/books")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }


        /// <summary>
        /// Retrieves all books
        /// </summary>
        /// <returns>Returns all books</returns>
        /// <response code="200">Books returned.</response>
        /// <response code="404">Books not found.</response>
        /// <response code="500">Unexpected Error.</response>
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public IActionResult GetAll(string query)
        {
            var books = _bookService.GetAll(query);
            return Ok(books);
        }

        /// <summary>
        /// Retrieves a specific book
        /// </summary>
        /// <returns>Returns a book found or not.</returns>
        /// <response code="200">Book found.</response>
        /// <response code="404">Book not found.</response>
        /// <response code="500">Unexpected Error.</response>
        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public IActionResult GetById(string id)
        {
            var book = _bookService.GetById(id);
            return Ok(book);
        }
        /// <summary>
        /// Creates a book
        /// </summary>
        /// <returns>Returns a book created successfully.</returns>
        /// <param name="request">Represents the request of create book</param>
        /// <response code="201">Creates a Book success.</response>
        /// <response code="500">Unexpected Error.</response>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(500)]
        public IActionResult Create([FromBody] NewBookInputModel request)
        {
            var id = _bookService.Create(request);
            return CreatedAtAction(nameof(GetById), new { id = id }, request);
        }
        /// <summary>
        /// Deletes a book
        /// </summary>
        /// <returns>Book deleted successfully.</returns>
        /// <param name="request">Represents the request of create book</param>
        /// <response code="204">Creates a Book success.</response>
        /// <response code="500">Unexpected Error.</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(201)]
        [ProducesResponseType(500)]
        public IActionResult Delete(string id)
        {
            _bookService.Delete(id);
            return NoContent();
        }
    }
}
