namespace WellnessGrocery.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product>? Products { get; set; }
        public int Quantity { get; set; }
        public bool Availablity { get; set; }
        public string Location { get; set; }
    }
}
