namespace DrivingQuizApp.Server.Data.Entities;

public record User()
{
    public int Id { get; init; }
    
    public IEnumerable<UserQuiz>? Quizzes { get; init; } 
    
    public UserPermission Permissions { get; init; }
    
    public IEnumerable<UserQuestionBookmark>? Bookmarks { get; init; } 
}