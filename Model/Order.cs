using System;
using System.Collections.Generic;

namespace CodeFirstEF.Model
{
    public partial class Order
    {
        public int OrderId { get; set; }
        
        public DateTime Date { get; set; }
        
        public float Value { get; set; }
        
        public int Payed { get; set; }
        
        public int ClientId { get; set; }
        
        public Client Client { get; set; }
        
        public int Deleted { get; set; }

        public ICollection<OrderDetails> OrderDetails { get; set; }

        protected Order() {}
    }
}
