namespace Domain.Entities;

public class Order
{
    public Guid Id {get; set;} = new Guid();

    public Customer? Customer {get; set;}

    public string OrderNumber {get; set;} = "";

    public DateTime OrderDate {get; set;} = DateTime.Now;

    public IEnumerable<OrderLineItem>? LineItems {get; set;}


}
