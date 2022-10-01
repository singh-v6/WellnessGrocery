namespace WellnessGrocery.wwwroot.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerEmail { get; set; }
        public List<Order>? CustomerOrders { get; set; }
        public PurchaseHistory? CustomerPurchaseHistory { get; set; }
        public int? CustomerPurchaseHistoryId { get; set; }
    }
}
