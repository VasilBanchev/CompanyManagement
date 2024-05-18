using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
