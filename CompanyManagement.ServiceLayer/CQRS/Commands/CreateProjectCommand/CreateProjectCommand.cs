using FluentValidation;
using MediatR;
using Shared.Constants;
using Shared.Database;
using Shared.Database.Entities;
using Shared.Types;

namespace CompanyManagement.ServiceLayer.CQRS.Commands.CreateProjectCommand;

public class CreateProjectCommand : IRequest<ModelWrapper>
{
    public string Name { get; set; }
    public DateOnly? DueDate { get; set; }
}

public class CreateProjectCommandHandler(CompanyDbContext context) : IRequestHandler<CreateProjectCommand, ModelWrapper>
{
    public async Task<ModelWrapper> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
    {
        Project project = new Project() { Name = request.Name, DueDate = request.DueDate, ProjectTeams = new () };
        context.Projects.Add(project);
        await context.SaveChangesAsync(cancellationToken);
        return new ModelWrapper("Success!");
    }
}

public class CreateProjectCommandValidator : AbstractValidator<CreateProjectCommand>
{
    public CreateProjectCommandValidator()
    {
        RuleFor(p => p.Name)
            .Must(name => name.Length <= IntConsts.NAME_MAX_LENGHT)
            .WithMessage($"Project name too long, choose name with at most {IntConsts.NAME_MAX_LENGHT} characters!")
            .WithErrorCode(ErrorCodes.UnprocessableContent.ToString());
    }
}