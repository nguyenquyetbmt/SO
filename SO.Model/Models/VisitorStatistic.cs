using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SO.Model.Models
{
    [Table("VisitorStatistics")]
    public class VisitorStatistic
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime VisitedDate { get; set; }

        [Required]
        public string IPAddress { get; set; }
    }
}