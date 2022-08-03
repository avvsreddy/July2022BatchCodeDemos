// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Company company = new Company();
Item i1 = new Item { Rate = 10 };
Item i2 = new Item { Rate = 120 };
Item i3 = new Item { Rate = 102 };
Item i4 = new Item { Rate = 12 };
Item i5 = new Item { Rate = 190 };
Item i6 = new Item { Rate = 120 };

company.Items.Add(i1);
company.Items.Add(i2);
company.Items.Add(i3);
company.Items.Add(i4);
company.Items.Add(i5);
company.Items.Add(i6);

RegCustomer c1 = new RegCustomer();
c1.Discount = 10;
company.Customers.Add(c1);

Order o1 = new Order();
c1.Orders.Add(o1);
OrderedItem orderedItem = new OrderedItem { Qty = 1, Item = i1 };
o1.OrderedItems.Add(orderedItem);

Console.WriteLine($"Total Worth {company.GetTotalWorthOfOrdersPlaced()}");

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
            //foreach (Order order in customer.Orders)
            //{
            //    // for each ordered item
            //    foreach (OrderedItem oItem in order.OrderedItems)
            //    {
            //        total += oItem.Qty * oItem.Item.Rate;
            //    }
            //}
            //if (customer is RegCustomer)
            //{
            //    // down cast to access the discount
            //    RegCustomer reg = customer as RegCustomer;
            //    double totDiscount = 0;
            //    totDiscount = reg.Discount * total / 100;

            //    total = total - totDiscount;
            //}
            total += customer.GetOrderedAmount();
        }
        return total;
    }
}

public class Customer
{
    public List<Order> Orders { get; set; } = new List<Order>();
    public virtual double GetOrderedAmount()
    {
        double totAmt = 0;
        foreach (Order order in Orders)
        {
            totAmt += order.GetOrderAmount();
        }
        return totAmt;
    }
}

public class RegCustomer : Customer
{
    public double Discount { get; set; }

    public override double GetOrderedAmount()
    {
        double totAmt = base.GetOrderedAmount();
        double totDisc = totAmt * Discount / 100;
        return totAmt - totDisc;
    }
}

public class Order
{
    public List<OrderedItem> OrderedItems { get; set; } = new List<OrderedItem>();
    public int GetOrderAmount()
    {
        int amount = 0;
        foreach (OrderedItem orderedItem in OrderedItems)
        {
            amount += orderedItem.GetAmount();
        }
        return amount;
    }
}

public class OrderedItem
{
    public int Qty { get; set; }
    public Item Item { get; set; }

    public int GetAmount()
    {
        return Qty * Item.Rate;
    }

}