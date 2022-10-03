namespace WellnessGrocery.Models
{
    public class Order
    {
        public int Id { get; set; }
        public User? User { get; set; }
        public int UserId { get; set; }
        public int Quantity { get; set; }
        public string TrackingNumber { get; set; }
        public DateTime Date { get; set; }
        public string PaymentType { get; set; }       
        public List<Orderdetail>? Orderdetail { get; set; }

    }
}
