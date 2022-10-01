namespace WellnessGrocery.wwwroot.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int OrderQuantity { get; set; }
        public string OrderStatus { get; set; }
        public string OrderTrackingNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderPaymentType { get; set; }
        public Customer OrderCustomer { get; set; }
        public int? OrderCustomerId { get; set; }
        public List<Product> OrderProducts { get; set; }
    }
}
