namespace WellnessGrocery.wwwroot.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public Order ProductOrder { get; set; }
        public int ProductOrderId { get; set; }
        public Inventory ProductInventory { get; set; }
        public int ProductInventoryId { get; set; }
    }
}
