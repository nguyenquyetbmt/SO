﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SO.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public string URL { get; set; }

        public int? DisplayOrder { get; set; }

        public int GroupId { get; set; }

        [ForeignKey("GroupId")]
        public virtual MenuGroup MenuGroup { get; set; }

        public string Taget { get; set; }

        public bool? Status { get; set; }
    }
}