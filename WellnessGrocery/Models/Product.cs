<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> e81d8d9c89c79c993c9f52b7e8be95bededbb375
﻿namespace WellnessGrocery.Models
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
<<<<<<< HEAD
=======
=======
﻿namespace WellnessGrocery.wwwroot.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public Order ProductOrder { get; set; }
        public int ProductOrderId { get; set; }
        public Inventory ProductInventory { get; set; }
        public int ProductInventoryId { get; set; }
>>>>>>> 3b671bcda0ec55ae50bffaa4dd2e059c5ceaadf0
>>>>>>> e81d8d9c89c79c993c9f52b7e8be95bededbb375
    }
}
