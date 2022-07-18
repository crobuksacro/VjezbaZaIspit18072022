using System.ComponentModel.DataAnnotations;
using VjezbaZaIspit.Models.Dbo.Base;

namespace VjezbaZaIspit.Models.Dbo
{
    public class Publisher: IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
