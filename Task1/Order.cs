namespace Task1
{
    public class Order
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public int Quantity { get; set; }
        public decimal TotalPrice => Products.Sum(p => p.Price * Quantity);
        public string Status { get; set; }
    }

}