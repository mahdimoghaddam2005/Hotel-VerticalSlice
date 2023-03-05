namespace Application.Domain.Entities;
public class Reserve
{
    public int Id { get; set; }
    public string Description { get; set; }

    public Customer Customer { get; set;}
    public Room Room { get; set; }
}