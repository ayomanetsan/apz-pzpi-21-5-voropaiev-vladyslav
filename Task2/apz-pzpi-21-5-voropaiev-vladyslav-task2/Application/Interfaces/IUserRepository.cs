namespace Application.Interfaces;

public interface IUserRepository : IRepository<User>
{
    Task<string> LoginAsync(string login, string password, CancellationToken cancellationToken);
    
    Task<string> RegisterUserAsync(User user, string password, CancellationToken cancellationToken);
}