namespace ChatWeb.Api.Features.User;

public record DeleteUserCommand(int UserId);

public static class DeleteUserCommandHandler
{
    public static async Task Handle(DeleteUserCommand command)
    {
        
    }
}

