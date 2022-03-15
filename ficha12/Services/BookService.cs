using ficha12.Models;
using Microsoft.EntityFrameworkCore;

namespace ficha12.Services
{
    public class BookService: IBookService
    {
        public readonly LibraryContext context;

        public BookService(LibraryContext context) 
        { 
            this.context = context;
        }

        public Book Create(Book newBook)
        {
            Publisher pub = context.Publisher.Find(newBook.Publisher.Id);
            if(pub == null)
            {
                throw new NullReferenceException("Publisher does not exist");
            }
            else
            {
                newBook.Publisher = pub;
                context.Books.Add(newBook);
                context.SaveChanges();
                return newBook;
            }
        }

        public void DeleteByISBN(string isbn)
        {
            throw new NotImplementedException();
        }

        public void Download()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetALL()
        {
             var books = context.Books
                .Include(p => p.Publisher);
             return books;
            
        }

        public Book GetByAuthor(string author)
        {
           
        }

        public Book? GetByISBN(string isbn)
        {
            var book = context.Books
                .Include(b => b.Publisher)
                .SingleOrDefault(b => b.ISBN == isbn);
            return book;
        }

        public void Update(string isbn, Book book)
        {
            throw new NotImplementedException();
        }

        public void UpdatePublisher(string isbn, int publisherId)
        {
            throw new NotImplementedException();
        }
    }
}
