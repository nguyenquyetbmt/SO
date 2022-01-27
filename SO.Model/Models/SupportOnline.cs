using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SO.Model.Models
{
    [Table("SupportOnlines")]
    public class SupportOnline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Department { get; set; }

        [MaxLength(50)]
        public string Skype { get; set; }

        [MaxLength(50)]
        public string Moblie { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(50)]
        public string Yahoo { get; set; }

        [MaxLength(50)]
        public string FaceBook { get; set; }

        public bool Status { get; set; }
        public int? DisplayOrder { get; set; }
    }
}