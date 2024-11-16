namespace LibraryMgmtSystem.Models
{
    public class AddBook
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
    }
}
