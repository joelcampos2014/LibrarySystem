namespace LibrarySystem.Api.Models
{
    public class CreateBookModel : BaseEntity
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        public int publishDate { get; set; }
    }
}
