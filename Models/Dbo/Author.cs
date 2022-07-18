using System.ComponentModel.DataAnnotations;
using VjezbaZaIspit.Models.Dbo.Base;
using VjezbaZaIspit.Models.Dbo.Interface;

namespace VjezbaZaIspit.Models.Dbo
{
    public class Author : IApplicationUser, IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Book> Books { get; set; }
       
    }
}
