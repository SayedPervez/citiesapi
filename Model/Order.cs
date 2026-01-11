namespace citiesapi.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string? ProductName { get; set; }
        public int Quantity { get; set; }
    }
}
