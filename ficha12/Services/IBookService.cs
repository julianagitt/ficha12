using ficha12.Models;

namespace ficha12.Services
{
    public interface IBookService
    {
        public abstract IEnumerable<Book> GetALL();
        public abstract Book? GetByISBN(string isbn);
        public abstract Book Create(Book newBook);
        public abstract Book GetByAuthor(string author);
        public abstract void Download();
        public abstract void DeleteByISBN(string isbn);
        public abstract void Update(string isbn, Book book);
        public abstract void UpdatePublisher(string isbn, int publisherId);

    }
}
