namespace Task1
{
    public class Program
    {
        static void Main()
        {
            Store myStore = new Store();

            myStore.AddProduct(new Product { Name = "Laptop", Price = 1200, Description = "High-performance laptop", Category = "Electronics" });
            myStore.AddProduct(new Product { Name = "Smartphone", Price = 600, Description = "Latest smartphone model", Category = "Electronics" });

            myStore.AddUser(new User { Username = "testlogin", Password = "password" });

            List<Product> electronics = myStore.Search(p => p.Category == "Electronics");

            Console.WriteLine("Electronics in the store:");
            foreach (var product in electronics)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price:C}");
            }

            User currentUser = myStore.Users.First();
            List<Product> selectedProducts = myStore.Products.Take(2).ToList();

            myStore.PlaceOrder(currentUser, selectedProducts, 2);

            Console.WriteLine($"Purchase history for {currentUser.Username}:");
            foreach (var purchase in currentUser.PurchaseHistory)
            {
                Console.WriteLine(purchase);
            }
        }
    }

}