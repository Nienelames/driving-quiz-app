using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrivingQuizApp.Server.Data.Entities;

public record UserQuestionBookmark()
{
    public int Id { get; init; }
    
    [Column(TypeName = "nvarchar(4000)")]
    public string? Note { get; init; }
    
    public Question Question { get; init; }
}