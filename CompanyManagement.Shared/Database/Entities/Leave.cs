using System.ComponentModel.DataAnnotations;

namespace Shared.Database.Entities;

public class Leave
{
    [Key]
    public int Id { get; set; }
    [Required]
    public User User { get; set; }
    [Required]
    public DateOnly DateFrom { get; set; }
    [Required]
    public DateOnly DateTo { get; set; }
    [Required]
    public bool Paid { get; set; }
    [Required]
    public bool Approved { get; set; }
}