namespace WellnessGrocery.Models
{
    public class Orderdetail
    {
        public int Id { get; set; }
        public Order? Order { get; set; }
        public int OrderID  { get; set; }
        public Product? Product { get; set; }
        public int ProductID { get; set; }
        public string Status { get; set; }



    }
}
