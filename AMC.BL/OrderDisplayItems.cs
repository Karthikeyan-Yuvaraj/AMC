namespace AMC.BL
{
    public class OrderDisplayItems
    {
        public int OrderItemId { get; private set; }
        public int OrderQuantity { get; set; }

        public string ProductName { get; set; }

        public decimal? PurchasePrice { get; set; }

    }
}