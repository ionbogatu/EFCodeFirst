namespace CodeFirstEF.Model
{
    public partial class OrderDetails
    {
        public int OrderDetailsId { get; set; }
        
        public int ProductId { get; set; }
        
        public Product Product { get; set; }
        
        public double Qty { get; set; }
        
        public double Price { get; set; }
        
        public int Deleted { get; set; }
        
        public int OrderId { get; set; }
        
        public Order Order { get; set; }
    }
}
