using Microsoft.EntityFrameworkCore;
using VjezbaZaIspit.Data;
using VjezbaZaIspit.Models.Dbo;

namespace VjezbaZaIspit.Service
{
    public class BookService : IBookService
    {
        private readonly ApplicationDbContext db;

        public async Task<Book> Add(string title, ApplicationUser applicationUser)
        {
            var dbo = new Book
            {

                Title = title,
                ApplicationUser = applicationUser,
                Author = await db.Author.FirstOrDefaultAsync(),
                Publisher = await db.Publisher.FirstOrDefaultAsync()

            };

            db.Book.Add(dbo);
            await db.SaveChangesAsync();
            return dbo;


        }

        public async Task<Book> Add(string title, string applicationUserId)
        {
            var user = await db.ApplicationUser.FirstOrDefaultAsync(x => x.Id == applicationUserId);
            return await Add(title, user);

        }


    }
}
