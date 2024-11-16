using System.ComponentModel.DataAnnotations;

namespace LibraryMgmtSystem.Entities
{
    public class Author
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }

    }
}
