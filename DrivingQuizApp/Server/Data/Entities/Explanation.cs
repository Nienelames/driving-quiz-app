using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrivingQuizApp.Server.Data.Entities;

public record Explanation()
{
    public int Id { get; init; }

    [Required]
    [Column(TypeName = "varchar(1000)")]
    public string Text { get; init; }

    [Column(TypeName = "varchar(255)")]
    public string? VideoUrl { get; init; }
}