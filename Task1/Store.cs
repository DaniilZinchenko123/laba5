namespace Task1
{
    public class Store : ISearchable<Product>
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public List<User> Users { get; set; } = new List<User>();
        public List<Order> Orders { get; set; } = new List<Order>();

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public void PlaceOrder(User user, List<Product> products, int quantity)
        {
            Order order = new Order
            {
                Products = products,
                Quantity = quantity,
                Status = "Pending"
            };

            user.PurchaseHistory.Add($"Order ID: {Orders.Count + 1}, Status: {order.Status}, Total Price: {order.TotalPrice:C}");
            Orders.Add(order);
        }

        public List<Product> Search(Func<Product, bool> criteria)
        {
            return Products.Where(criteria).ToList();
        }
    }

}