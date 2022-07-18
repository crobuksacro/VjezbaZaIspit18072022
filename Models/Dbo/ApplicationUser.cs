using Microsoft.AspNetCore.Identity;
using VjezbaZaIspit.Models.Dbo.Interface;

namespace VjezbaZaIspit.Models.Dbo
{
    public class ApplicationUser : IdentityUser, IApplicationUser
    {
        //Vlastita svojstva
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
