using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SO.Model.Models
{
    [Table("MenuGroups")]
    public class MenuGroup
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual IEnumerable<Menu> Menus { get;set;}
}
}