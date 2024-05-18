using System.ComponentModel.DataAnnotations;

namespace Shared.Database.Entities;

public class ProjectTeamRole
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(30)]
    public string Name { get; set; }

    [Required]
    public int Level { get; set; }
}