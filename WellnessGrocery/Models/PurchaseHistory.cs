namespace WellnessGrocery.wwwroot.Models
{
    public class PurchaseHistory
    {
        public int PurchaseHistoryId { get; set; }
        public int PurchaseHistoryNumOrders { get; set; }
        public DateTime PurchaseHistoryDate { get; set; }
        public string PurchaseHistoryPaymentType { get; set; }
        public List<Customer>? PurchaseHistoryCustomers { get; set; }
    }
}
