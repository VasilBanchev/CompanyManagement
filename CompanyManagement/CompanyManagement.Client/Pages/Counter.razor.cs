using Shared.TeamMembers.Models;
using Shared.TeamMembers.Services;

namespace CompanyManagement.Client.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;

            Member member = new();
            MembersService service = new();
        }
    }
}
