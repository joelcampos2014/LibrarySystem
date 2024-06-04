using LibrarySystem.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibrarySystem.Api.Controllers
{
    /// <summary>
    /// Book api service
    /// </summary>
    [Consumes("application/json")]
    [Produces("application/json")]
    [Route("api/books")]
    public class BookController : ControllerBase
    {
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
        public IActionResult GetBooks(string query)
        {
            return Ok();
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
        public IActionResult GetBookbyId(string id)
        {
            return Ok();
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
        public IActionResult CreateBook([FromBody] CreateBookModel request)
        {
            return CreatedAtAction(nameof(GetBookbyId), request);
        }
    }
}
