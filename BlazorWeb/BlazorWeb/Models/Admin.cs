using System.ComponentModel.DataAnnotations;

namespace BlazorWeb.Models;

public class Admin
{
    [Key]
    public int Id { get; set; }
    public String Email { get; set; }
    public String Password { get; set; }
}