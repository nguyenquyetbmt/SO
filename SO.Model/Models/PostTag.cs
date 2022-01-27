using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SO.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        public int PostId { get; set; }

        [ForeignKey("PostId")]
        public virtual Post Post { get; set; }

        [Key]
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string TagId { get; set; }

        [ForeignKey("TagId")]
        public virtual Tag Tag { get; set; }
    }
}