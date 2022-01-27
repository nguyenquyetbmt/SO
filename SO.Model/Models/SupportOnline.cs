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

        public string Name { get; set; }

        public string Department { get; set; }

        public string Skype { get; set; }

        public string Moblie { get; set; }

        public string Email { get; set; }

        public string Yahoo { get; set; }

        public string FaceBook { get; set; }

        public bool? Status { get; set; }
    }
}