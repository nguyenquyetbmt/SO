using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SO.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        public string Id { get; set; }

        public string Content { get; set; }
    }
}