using System.ComponentModel.DataAnnotations;

namespace Shared.Database.Entities;

public class Shift
{
    [Key]
    public int Id { get; set; }
    public User User { get; set; }
    public ProjectTeamRole ProjectTeamRole { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
}