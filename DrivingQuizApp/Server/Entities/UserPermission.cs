using System.ComponentModel.DataAnnotations;

namespace DrivingQuizApp.Server.Entities;

public record UserPermission()
{
    public int Id { get; init; }

    [Required]
    public bool CanAccessApp { get; init; }

    [Required]
    public bool CanGrantAccessToApp { get; init; }
}