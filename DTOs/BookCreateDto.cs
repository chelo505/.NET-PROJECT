namespace BookstoreAPI.DTOs
{
    public class BookCreateDto
    {
        public string Title { get; set; }
        public int YearOfPublication { get; set; }
        public string AuthorName { get; set; }
    }
}