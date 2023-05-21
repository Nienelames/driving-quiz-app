using DrivingQuizApp.Server.DTOs.Requests;

namespace DrivingQuizApp.Server.Contracts;

public interface IAccountService
{
    Task AddAsync(int userId);
    Task WhitelistAsync(int userId);
    Task BlacklistAsync(int userId);
    Task AddPermissionsAsync(UserPermissionRequestDto userPermissionRequestDto);
    Task UpdatePermissionsAsync(UserPermissionRequestDto userPermissionRequestDto);
}