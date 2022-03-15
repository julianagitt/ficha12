using ficha12.Models;

namespace ficha12.Data
{
        public static class LibraryExtension
        {
            public static void CreateDBIfNotExists(this IHost host)
            {
                {
                    using (var scope = host.Services.CreateScope())
                    {
                        var services = scope.ServiceProvider;
                        var context = services.GetRequiredService<LibraryContext>();

                        //Creates the database if not exists
                        if (context.Database.EnsureCreated())
                        {
                            LibraryDBInitializer.InsertData(context); ;
                        }

                    }
                }
            }
        }
}

