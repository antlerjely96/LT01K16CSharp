using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorWeb.Models;

public class Product
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "Fill name")]
    public String Name { get; set; }
    [Required(ErrorMessage = "Fill Quantity")]
    public int Quantity { get; set; }
    [Required(ErrorMessage = "Fill Price")]
    public double Price { get; set; }
    public int CategoryId { get; set; }
    
    [ForeignKey("CategoryId")]
    public Category? category { get; set; }
}