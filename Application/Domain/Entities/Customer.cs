namespace Application.Domain.Entities;
public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalCode { get; set; } 

    public IList<Reserve> Reserves { get; set; }
}