


//fluent api 
class MenuItem
{
    public string Name { get; set; }
}
class Order
{
        public List<OrderItem> OrderItems { get; set; }
 }
class OrderItem
{
        public MenuItem MenuItem  { get; set; }
        public int MenuItemId { get; set; }

}