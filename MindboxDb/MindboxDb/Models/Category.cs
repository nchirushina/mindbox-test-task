using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MindboxDb.Models
{
    [Table("t_categories")]
    public class Category
    {
        [Key]
        public Guid Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
