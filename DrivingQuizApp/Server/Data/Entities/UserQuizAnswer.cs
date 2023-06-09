using System.ComponentModel.DataAnnotations;

namespace DrivingQuizApp.Server.Data.Entities;

public record UserQuizAnswer()
{
    public int Id { get; init; }
    
    public Answer Answer { get; init; }
    
    [Required]
    public bool IsMarked { get; init; }
}