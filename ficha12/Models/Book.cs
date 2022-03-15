using Microsoft.EntityFrameworkCore;
namespace ficha12.Models
{
    public class Book
    {
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Language { get; set; }
        public int Pages { get; set; }
        public virtual Publisher Publisher { get; set; }
        public string Title { get; set; }
    }
}
