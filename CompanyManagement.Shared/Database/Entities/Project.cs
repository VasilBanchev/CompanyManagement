using System.ComponentModel.DataAnnotations;

namespace Shared.Database.Entities;

public class Project
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public DateTime? DueDate { get; set; }
    public List<ProjectTeam> ProjectTeams { get; set; }
}