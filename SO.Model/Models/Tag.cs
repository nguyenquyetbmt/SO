using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SO.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }
        public string Type { get; set; }

        public virtual IEnumerable<PostTag> PostTags { get; set; }
    }
}