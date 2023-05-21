using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrivingQuizApp.Server.Entities;

public record RuleReference()
{
    public int Id { get; init; }
    
    [Required]
    [Column(TypeName = "varchar(255)")]
    public string Text { get; init; }
    
    [Column(TypeName = "varchar(255)")]
    public string? Url { get; init; }
    
    [Column(TypeName = "varchar(25)")]
    public string? Chapter { get; init; }
    
}