// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



public class Item
{
    public string Description { get; set; }
    public int Rate { get; set; }
}

public class Company
{
    public List<Item> Items { get; set; } = new List<Item>();
    public List<Customer> Customers { get; set; } = new List<Customer>();

    public double GetTotalWorthOfOrdersPlaced()
    {
        double total = 0;
        // calculate

        // for each customer
        foreach (Customer customer in Customers)
        {
            // for each order
            foreach (Order order in customer.Orders)
            {
                // for each ordered item
                foreach (OrderedItem oItem in order.OrderedItems)
                {
                    total += oItem.Qty * oItem.Item.Rate;
                }
            }

            if (customer is RegCustomer)
            {
                // down cast to access the discount
                RegCustomer reg = customer as RegCustomer;
                double totDiscount = 0;
                totDiscount = reg.Discount * total / 100;

                total = total - totDiscount;
            }
        }

        return total;
    }
}

public class Customer
{
    public List<Order> Orders { get; set; } = new List<Order>();
}

public class RegCustomer : Customer
{
    public double Discount { get; set; }
}

public class Order
{
    public List<OrderedItem> OrderedItems { get; set; } = new List<OrderedItem>();
}

public class OrderedItem
{
    public int Qty { get; set; }
    public Item Item { get; set; }
}