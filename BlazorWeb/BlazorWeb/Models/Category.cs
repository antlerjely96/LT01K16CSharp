using System.ComponentModel.DataAnnotations;

namespace BlazorWeb.Models;

public class Category
{
    [Key]
    public int Id { get; set; }
    [Required (ErrorMessage = "Không được để trống")]
    public String Name { get; set; }
    [Required (ErrorMessage = "Không được để trống")]
    public String Description { get; set; }

    public ICollection<Product> Products { get; set; } = new List<Product>();
}