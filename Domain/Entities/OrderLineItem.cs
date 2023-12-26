using System.Net.Http.Headers;

namespace Domain.Entities;

public class OrderLineItem
{
    public Guid Id {get; set;} = new Guid();

    public Order? Order {get; set;}

    public Product? Product {get; set;}
    public int Qty {get; set;}

    public decimal UnitCost {get; set;} = 0;
}
