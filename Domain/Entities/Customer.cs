namespace Domain.Entities;

public class Customer
{
    public Guid Id {get; set;} = new Guid();
    public string Name {get; set;} = "";
    public int Terms {get; set;} = 30;
}


