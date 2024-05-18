using System.ComponentModel.DataAnnotations;

namespace Shared.Database.Entities;

public class User
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(20)]
    public string Name { get; set; }

    [Required]
    [MaxLength(20)]
    public string? MiddleName { get; set; }

    [Required]
    [MaxLength(30)]
    public string LastName { get; set; }
    public string UniqueIdentifier { get; set; }

    [EmailAddress]
    public string Email { get; set; }

    [Phone]
    public string Phone { get; set; }
    public BasicRole BasicRole { get; set; }

    public List<UserProjectTeam> Teams { get; set; }
}