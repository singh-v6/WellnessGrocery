namespace WellnessGrocery.wwwroot.Models
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public string InventoryLocation { get; set; }
        public int InventoryProductQuantity { get; set; }
        public bool InventoryProductAvailablity { get; set; }
        public List<Product> InventoryProducts { get; set; }
    }
}
