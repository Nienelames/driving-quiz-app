using System.ComponentModel.DataAnnotations;

namespace DrivingQuizApp.Server.Data.Entities;

public record UserPermission()
{
    public int Id { get; init; }

    [Required]
    public bool IsWhitelisted { get; init; } = false;

    [Required]
    public bool CanWhitelist { get; init; } = false;
}