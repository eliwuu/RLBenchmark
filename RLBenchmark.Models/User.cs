using Microsoft.Extensions.Logging;

namespace RLBenchmark.Models.User;

public enum Role
{
    Client,
    Manager,
    Admin
}
public record LoginDto (string Email, string Password);
public record RegisterDto (string First, string Last, string Email, string Password);
public record Model (string Id, string First, string Last, byte[] Salt, byte[] Hash, string Email, Role Role);

public interface IAction
{
    Task<bool> Exist (string email);
    Task<Model> Create (RegisterDto userRegister);
    Task<Model> Update(Model user);
    Task<bool> Delete (string email);
    Task<Model> Authenticate(LoginDto userLogin);
    Task<Role> Authorize(Model user);
    Task<Model> Get(string email);
}

public class Action : IAction
{
    private readonly ILogger<Action> _logger;
    private readonly Manager.IPassword _passwordManager;
    private readonly Data.ISource<User.Model> _dataSource;

    public Action(
        ILogger<Action> logger, 
        Manager.IPassword passwordManager, 
        Data.ISource<User.Model> dataSource)
    {
        _logger = logger;
        _passwordManager = passwordManager;
        _dataSource = dataSource;
    }
    public Task<Model> Authenticate(LoginDto userLogin)
    {
        throw new NotImplementedException();
    }

    public Task<Role> Authorize(Model user)
    {
        throw new NotImplementedException();
    }

    public Task<Model> Create(RegisterDto userRegister)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete(string email)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Exist(string email)
    {
        throw new NotImplementedException();
    }

    public Task<Model> Get(string email)
    {
        throw new NotImplementedException();
    }

    public Task<Model> Update(Model user)
    {
        throw new NotImplementedException();
    }
}