namespace WellnessGrocery.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Type { get; set; }
        public List<Order>? Orders { get; set; }
        public string? picture { get; set; }

    }
}
