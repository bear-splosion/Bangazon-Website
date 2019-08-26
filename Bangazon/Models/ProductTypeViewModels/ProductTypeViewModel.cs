using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bangazon.Models.ProductTypeViewModels
{
    public class ProductTypeViewModel
    {
        [Key]
        public int ProductTypeId { get; set; }

        public int ProductId { get; set; }

        public List<ProductType> ProductTypes { get; set; }

        public virtual List<GroupedProducts> GroupedProducts { get; set; }
    }
}
