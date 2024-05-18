using System.ComponentModel.DataAnnotations;

namespace Shared.Database.Entities
{
    public class UserProjectTeam
    {
        [Key]
        public int Id { get; set; }
        public User User { get; set; }
        public ProjectTeam ProjectTeam { get; set; }
        public ProjectTeamRole Role { get; set; }
    }
}
