using System.ComponentModel.DataAnnotations;
using VjezbaZaIspit.Models.Dbo.Base;

namespace VjezbaZaIspit.Models.Dbo
{
    public class Book: IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
        public Publisher Publisher { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
