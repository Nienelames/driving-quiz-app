using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrivingQuizApp.Server.Entities;

public record Answer()
{
    public int Id { get; init; }

    [Required]
    [Column(TypeName = "varchar(255)")]
    public string Text { get; init; }
    
    [Required]
    public bool IsCorrect { get; init; }
}