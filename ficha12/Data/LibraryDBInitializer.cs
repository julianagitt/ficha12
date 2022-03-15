using ficha12.Models;

namespace ficha12.Data
{
    public class LibraryDBInitializer
    {
		public static void InsertData(LibraryContext context)
		{
			//adds a publisher
			var publisher = new Publisher
			{
				Name = "Mariner Books"
			};
			context.Publisher.Add(publisher);
			context.SaveChanges();

			//adds some books
			context.Books.Add(new Book
			{
				ISBN = "978-0544003415",
				Title = "The Lord of the Rings",
				Author = "J.R.R. Tolkien",
				Language = "English",
				Pages = 1216,
				Publisher = publisher
			});

			context.SaveChanges();
		}

	}
}
