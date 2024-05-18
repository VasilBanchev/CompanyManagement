using System.ComponentModel.DataAnnotations;

namespace Shared.Database.Entities;

public class BasicRole
{
    [Key]
    public int Role { get; set; }
    [Required]
    public string Name { get; set; }
}