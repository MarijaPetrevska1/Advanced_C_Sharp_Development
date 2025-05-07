namespace StaticClasses.Entities.Models
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Address { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();

        public User(int id, string username, string address):base(id)
        {
            UserName = username;
            Address = address;
        }

        public void PrintOrders()
        {
            for(int i = 0; i < Orders.Count; i++)
            {
                Console.WriteLine($"{i+1}) {Orders[i].GetOrderInfo()}");
            }
        }
    }
}