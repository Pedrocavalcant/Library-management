using System.ComponentModel.DataAnnotations;

namespace Library_Management_Api.Models;

public class BookModel
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public double Price { get; set; } 
    public int Stock { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}
