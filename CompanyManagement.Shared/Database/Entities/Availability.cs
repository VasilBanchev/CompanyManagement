using System.ComponentModel.DataAnnotations;

namespace Shared.Database.Entities;

public class Availability
{
    [Key]
    public int Id { get; set; }
    [Required]
    public DateOnly StartPeriodDate { get; set; }
    [Required]
    public DateOnly EndPeriodDate { get; set; }
    public bool[]? DaysOfWeek { get; set; }
    [Required]
    public bool Repeatable { get; set; }
    [Required]
    public bool AllDay { get; set; }
    public DateTime? StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    public string? Reason { get; set; }
    [Required]
    public User User { get; set; }
}