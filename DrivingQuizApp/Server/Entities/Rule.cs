using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrivingQuizApp.Server.Entities;

public record Rule()
{
    public int Id { get; init; }
    
    [Required]
    [Column(TypeName = "varchar(255)")]
    public string Text { get; init; }
    
    public RuleReference? RuleReference { get; init; }
}