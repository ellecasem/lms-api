namespace LmsApi.Models;

public class Book
{
    public long Id { get; set; }
    public String? Name { get; set; }
    public String? Author { get; set; }
    public String? Genre { get; set; }
    public int Quantity { get; set; }
    public String? ShelfLocation { get; set; }
}