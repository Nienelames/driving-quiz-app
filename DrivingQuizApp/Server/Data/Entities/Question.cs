using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrivingQuizApp.Server.Entities;

public record Question()
{
    public int Id { get; init; }

    [Required]
    [Column(TypeName = "varchar(255)")]
    public string Text { get; init; }
    
    public string? ImageUrl { get; init; }
    
    public Explanation? Explanation { get; init; }
    
    public Category Category { get; init; }

    public IEnumerable<Answer> Answers { get; init; }
}