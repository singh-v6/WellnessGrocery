<<<<<<< HEAD
﻿namespace WellnessGrocery.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product>? Products { get; set; }
        public int Quantity { get; set; }
        public bool Availablity { get; set; }
        public string Location { get; set; }
=======
﻿namespace WellnessGrocery.wwwroot.Models
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public string InventoryLocation { get; set; }
        public int InventoryProductQuantity { get; set; }
        public bool InventoryProductAvailablity { get; set; }
        public List<Product> InventoryProducts { get; set; }
>>>>>>> 3b671bcda0ec55ae50bffaa4dd2e059c5ceaadf0
    }
}
