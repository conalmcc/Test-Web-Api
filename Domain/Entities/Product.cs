namespace Domain.Entities;

public class Product
{
    public Guid Id {get; set;} = new Guid();

    public string Sku {get; set;} = "";
    public string Description {get; set;} = "";
}
