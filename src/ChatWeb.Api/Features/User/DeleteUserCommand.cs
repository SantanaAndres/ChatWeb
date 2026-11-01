using FluentValidation;
using Wolverine;
using Wolverine.Http;

namespace ChatWeb.Api.Features.User;

public record DeleteUserCommand(int UserId);

public static class DeleteUserCommandHandler
{
    public static async Task Handle(DeleteUserCommand command)
    {
        
    }
}

public class DeleteUserCommandValidator: AbstractValidator<DeleteUserCommand>
{
    public DeleteUserCommandValidator()
    {
        RuleFor(x => x.UserId).GreaterThan(0).WithMessage("User ID must be greater than 0.");
    }
}

public static class DeleteUserEndpoint
{
    [WolverineDelete("/user", Description = "Deletes a user by their unique identifier.")]
    [Tags("User")]
    public static ValueTask Delete(DeleteUserCommand command, IMessageBus bus)
    {
        return bus.SendAsync(command);
    }
}

