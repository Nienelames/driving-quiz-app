using DrivingQuizApp.Server.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrivingQuizApp.Server.Data;

public class QuizDbContext : DbContext
{
    public QuizDbContext(DbContextOptions<QuizDbContext> options) : base(options)
    {
        
    }
   
    public DbSet<Answer> Answers { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Explanation> Explanations { get; set; }
    public DbSet<Rule> Rules { get; set; }
    public DbSet<RuleReference> RuleReferences { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserAnswerStat> UserAnswerStats { get; set; }
    public DbSet<UserQuiz> UserQuizzes { get; set; }
    public DbSet<UserPermission> UserPermissions { get; set; }
    public DbSet<UserQuizAnswer> UserQuizAnswers { get; set; }
    public DbSet<UserQuizQuestion> UserQuizQuestions { get; set; }
    public DbSet<UserQuestionBookmark> UserQuestionBookmarks { get; set; }
    
}