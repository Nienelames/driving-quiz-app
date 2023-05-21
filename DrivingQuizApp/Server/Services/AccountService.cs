using DrivingQuizApp.Server.Contracts;
using DrivingQuizApp.Server.DTOs.Requests;

namespace DrivingQuizApp.Server.Services;

public class AccountService : IAccountService
{
    public Task AddAsync(int userId)
    {
        throw new NotImplementedException();
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