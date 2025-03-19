// array, IEnumerable, IQuearyable

using LinqExample;

List<string> names = new List<string> { "Apple", "Banana", "Mango" };

List<Order> orders = new List<Order>
{
    new Order { Item = "Banana", Quantity = 10},
    new Order { Item = "Mango", Quantity = 20},
    new Order {Item = "Jackfruit", Quantity = 5}
};

 from o in orders
 join n in names

