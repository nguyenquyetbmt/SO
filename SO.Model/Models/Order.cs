using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SO.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [Required]
        public string CustomerName { get; set; }

        [Required]
        public string CustomerAddress { get; set; }

        [Required]
        public string CustomerEmail { get; set; }

        [Required]
        public string CustomerMobile { get; set; }

        [Required]
        public string CustomerMessage { get; set; }

        public DateTime? CreatedDate { get; set; }
        public string CreateBy { get; set; }
        public bool? Status { get; set; }

        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}