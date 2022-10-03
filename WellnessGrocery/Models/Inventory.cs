<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> e81d8d9c89c79c993c9f52b7e8be95bededbb375
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
<<<<<<< HEAD
=======
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
>>>>>>> e81d8d9c89c79c993c9f52b7e8be95bededbb375
    }
}
