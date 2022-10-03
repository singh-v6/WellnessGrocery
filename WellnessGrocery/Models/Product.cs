namespace WellnessGrocery.Models
{
    public class Product
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public List<Orderdetail>? Orderdetail { get; set; }
        public Inventory? Inventory { get; set; }
        public int InventoryId { get; set; }
        public string? picture { get; set; }
    }
}
