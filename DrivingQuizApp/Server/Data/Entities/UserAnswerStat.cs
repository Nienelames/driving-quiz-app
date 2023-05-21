using System.ComponentModel.DataAnnotations;

namespace DrivingQuizApp.Server.Entities;

public record UserAnswerStat()
{
    public int Id { get; init; }

    [Required]
    public int CorrectCount { get; init; }

    [Required]
    public int IncorrectCount { get; init; }

    [Required]
    public int ConsecutiveCorrectCount { get; init; }

    public Answer Answer { get; init; }
}