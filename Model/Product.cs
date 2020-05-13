using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstEF.Model
{
    public partial class Product
    {
        public int ProductId { get; set; }

        [MaxLength(20)]
        public string ProductName { get; set; }

        public double Stock { get; set; }

        public double Price { get; set; }

        public int Deleted { get; set; }

        public List<OrderDetails> OrderDetails { get; set; }
    }
}
