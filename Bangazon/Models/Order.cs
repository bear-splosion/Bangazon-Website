using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Bangazon.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Display(Name = "Order Created")]
        public DateTime DateCreated { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Order Completed")]
        public DateTime? DateCompleted { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public ApplicationUser User { get; set; }

        public int? PaymentTypeId { get; set; }

        [Display(Name = "Payment")]
        public PaymentType PaymentType { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
