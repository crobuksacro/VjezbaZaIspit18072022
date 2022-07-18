using VjezbaZaIspit.Models.Dbo;

namespace VjezbaZaIspit.Service
{
    public interface IBookService
    {
        Task<Book> Add(string title, ApplicationUser applicationUser);
        Task<Book> Add(string title, string applicationUserId);
    }
}