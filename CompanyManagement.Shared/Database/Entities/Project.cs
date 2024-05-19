using System.ComponentModel.DataAnnotations;

namespace Shared.Database.Entities;

public class Project
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(30)]
    public string Name { get; set; }
    public DateOnly? DueDate { get; set; }
    public List<ProjectTeam> ProjectTeams { get; set; }
}