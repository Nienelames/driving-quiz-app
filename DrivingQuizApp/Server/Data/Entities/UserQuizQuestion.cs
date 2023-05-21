using System.ComponentModel.DataAnnotations;

namespace DrivingQuizApp.Server.Entities;

public record UserQuizQuestion()
{
    public int Id { get; init; }

    public Question Question { get; init; }
    
    public IEnumerable<UserQuizAnswer> Answers { get; init; } 
}