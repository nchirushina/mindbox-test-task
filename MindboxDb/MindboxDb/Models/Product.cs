using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MindboxDb.Models
{
    [Table("t_products")]
    public class Product
    {
        [Key]
        public Guid Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        public ICollection<Category> Categories { get; set; }
    }
}