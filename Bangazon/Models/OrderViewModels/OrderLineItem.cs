using System.ComponentModel.DataAnnotations;

namespace Bangazon.Models.OrderViewModels {
    public class OrderLineItem {

        [Key]
        public int OrderId { get; set; }

        public Product Product { get; set; }
        public int Units { get; set; }
        public double Cost { get; set; }
    }
}