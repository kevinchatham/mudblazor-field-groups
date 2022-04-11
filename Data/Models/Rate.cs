namespace FieldGroups.Data.Models;

public class Rate
{
    public int Id { get; set; }
    public decimal Price { get; set; }
    public Interval Interval { get; set; }
}