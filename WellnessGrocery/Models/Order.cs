<<<<<<< HEAD
﻿namespace WellnessGrocery.Models
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

=======
﻿namespace WellnessGrocery.wwwroot.Models
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
>>>>>>> 3b671bcda0ec55ae50bffaa4dd2e059c5ceaadf0
    }
}
