namespace Task1
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<string> PurchaseHistory { get; set; } = new List<string>();
    }

}