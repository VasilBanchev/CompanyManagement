using CompanyManagement.ServiceLayer.CQRS.Commands.CreateProjectCommand;
using MediatR;
using Microsoft.AspNetCore.Components;

namespace CompanyManagement.Components.Pages
{
    public partial class Home
    {
        [Inject]
        public IMediator _mediator { get; set; }

        CreateProjectCommand projectCreate = new();

        string TextProject, TextProjectTeam;

        private async Task CreateProjectAsync()
        {
            var result = await _mediator.Send(projectCreate);
            TextProject = result.Message;
        }

        private async Task CreateProjectTeamAsync()
        {
            var result = await _mediator.Send(new CreateProjectTeamCommand { Name = "CompanyManager", ProjectId = 7, Description = null });
            TextProjectTeam = result.Message;
        }
    }
}
