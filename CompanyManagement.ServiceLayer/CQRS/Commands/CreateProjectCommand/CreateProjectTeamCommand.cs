using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Shared.Constants;
using Shared.Database;
using Shared.Database.Entities;
using Shared.Types;

namespace CompanyManagement.ServiceLayer.CQRS.Commands.CreateProjectCommand;
public class CreateProjectTeamCommand : IRequest<ModelWrapper>
{
    public int ProjectId { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
}

public class CreateProjectTeamCommandHandler(CompanyDbContext context) : IRequestHandler<CreateProjectTeamCommand, ModelWrapper>
{
    public async Task<ModelWrapper> Handle(CreateProjectTeamCommand request, CancellationToken cancellationToken)
    {
        Project project = await context.Projects.FirstAsync(p => p.Id == request.ProjectId, cancellationToken: cancellationToken);

        ProjectTeam team = new() { Name = request.Name, Project = project, Description = request.Description, Members = [] };

        context.ProjectTeams.Add(team);
        await context.SaveChangesAsync(cancellationToken);

        return new ModelWrapper("Success");
    }
}

public class CreateProjectTeamCommandValidator : AbstractValidator<CreateProjectTeamCommand>
{
    public CreateProjectTeamCommandValidator()
    {
        RuleFor(pt => pt.Name)
            .Must(name => name.Length < IntConsts.NAME_MAX_LENGHT)
            .WithMessage($"Project team must have name shorter than {IntConsts.NAME_MAX_LENGHT} characters.")
            .WithErrorCode(ErrorCodes.UnprocessableContent.ToString());
    }
}