using System.ComponentModel.DataAnnotations;

namespace Shared.Database.Entities;

public class ProjectTeam
{
    [Required]
    public int Id { get; set; }
    public Project Project { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; }

    public string? Description { get; set; }

    public List<UserProjectTeam> Members { get; set; }
}