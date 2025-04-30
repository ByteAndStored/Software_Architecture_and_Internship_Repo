using System.ComponentModel.DataAnnotations;
namespace Routing.Models;

public class Product
{
    [Required]
    public string Name { get; set; } 
    [Range (1,100000)]
    public decimal Price { get; set; }
    [Range (1,100)]
    public int Stock { get; set; } 
    /* property hem okunabilir (get)
     hem de değiştirilebilir (set) */
    
}