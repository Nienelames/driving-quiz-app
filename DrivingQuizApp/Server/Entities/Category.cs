using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrivingQuizApp.Server.Entities;

public record Category()
{
    public int Id { get; init; }

    [Required]
    [Column(TypeName = "varchar(25)")]
    public string Name { get; init; }
}