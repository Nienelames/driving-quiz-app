using DrivingQuizApp.Server.Contracts;
using DrivingQuizApp.Server.DTOs.Requests;
using DrivingQuizApp.Server.Data.Entities;

namespace DrivingQuizApp.Server.Data.Repositories;

public class AccountRepository : IAccountRepository
{
    private readonly QuizDbContext _quizDbContext;
    
    public AccountRepository(QuizDbContext quizDbContext)
    {
        _quizDbContext = quizDbContext;    
    }
    
    public async Task AddAsync(int userId)
    {
        await _quizDbContext.Users.AddAsync(new User { Id = userId });
        
        await _quizDbContext.SaveChangesAsync();
    }

    public Task WhitelistAsync(int userId)
    {
        throw new NotImplementedException();
    }

    public Task BlacklistAsync(int userId)
    {
        throw new NotImplementedException();
    }

    public Task AddPermissionsAsync(UserPermissionRequestDto userPermissionRequestDto)
    {
        throw new NotImplementedException();
    }

    public Task UpdatePermissionsAsync(UserPermissionRequestDto userPermissionRequestDto)
    {
        throw new NotImplementedException();
    }
}