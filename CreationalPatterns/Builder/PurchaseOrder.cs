namespace CreationalPatterns.Builder
{
    public class PurchaseOrder
    {
        public string Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public DateTime RequestDate { get; set; }
        public Models.Supplier Supplier { get; set; }
        public IEnumerable<Models.LineItem> LineItems { get; set; }

        public decimal TotalCost => LineItems.Select(item => item.Qty * item.UnitCost).Sum();
    }
}
