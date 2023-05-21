using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DrivingQuizApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "varchar(25)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Explanations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(type: "varchar(1000)", nullable: false),
                    VideoUrl = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Explanations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RuleReferences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(type: "varchar(255)", nullable: false),
                    Url = table.Column<string>(type: "varchar(255)", nullable: true),
                    Chapter = table.Column<string>(type: "varchar(25)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RuleReferences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserPermissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CanAccessApp = table.Column<bool>(type: "INTEGER", nullable: false),
                    CanGrantAccessToApp = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPermissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(type: "varchar(255)", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    ExplanationId = table.Column<int>(type: "INTEGER", nullable: true),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questions_Explanations_ExplanationId",
                        column: x => x.ExplanationId,
                        principalTable: "Explanations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Rules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(type: "varchar(255)", nullable: false),
                    RuleReferenceId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rules_RuleReferences_RuleReferenceId",
                        column: x => x.RuleReferenceId,
                        principalTable: "RuleReferences",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PermissionsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_UserPermissions_PermissionsId",
                        column: x => x.PermissionsId,
                        principalTable: "UserPermissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(type: "varchar(255)", nullable: false),
                    IsCorrect = table.Column<bool>(type: "INTEGER", nullable: false),
                    QuestionId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserQuestionBookmarks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Note = table.Column<string>(type: "nvarchar(4000)", nullable: true),
                    QuestionId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserQuestionBookmarks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserQuestionBookmarks_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserQuestionBookmarks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserQuizzes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateTaken = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserQuizzes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserQuizzes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserAnswerStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CorrectCount = table.Column<int>(type: "INTEGER", nullable: false),
                    IncorrectCount = table.Column<int>(type: "INTEGER", nullable: false),
                    ConsecutiveCorrectCount = table.Column<int>(type: "INTEGER", nullable: false),
                    AnswerId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAnswerStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAnswerStats_Answers_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "Answers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserQuizQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    QuestionId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserQuizId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserQuizQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserQuizQuestions_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserQuizQuestions_UserQuizzes_UserQuizId",
                        column: x => x.UserQuizId,
                        principalTable: "UserQuizzes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserQuizAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AnswerId = table.Column<int>(type: "INTEGER", nullable: false),
                    IsMarked = table.Column<bool>(type: "INTEGER", nullable: false),
                    UserQuizQuestionId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserQuizAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserQuizAnswers_Answers_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "Answers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserQuizAnswers_UserQuizQuestions_UserQuizQuestionId",
                        column: x => x.UserQuizQuestionId,
                        principalTable: "UserQuizQuestions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_CategoryId",
                table: "Questions",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ExplanationId",
                table: "Questions",
                column: "ExplanationId");

            migrationBuilder.CreateIndex(
                name: "IX_Rules_RuleReferenceId",
                table: "Rules",
                column: "RuleReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswerStats_AnswerId",
                table: "UserAnswerStats",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_UserQuestionBookmarks_QuestionId",
                table: "UserQuestionBookmarks",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserQuestionBookmarks_UserId",
                table: "UserQuestionBookmarks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserQuizAnswers_AnswerId",
                table: "UserQuizAnswers",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_UserQuizAnswers_UserQuizQuestionId",
                table: "UserQuizAnswers",
                column: "UserQuizQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserQuizQuestions_QuestionId",
                table: "UserQuizQuestions",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserQuizQuestions_UserQuizId",
                table: "UserQuizQuestions",
                column: "UserQuizId");

            migrationBuilder.CreateIndex(
                name: "IX_UserQuizzes_UserId",
                table: "UserQuizzes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PermissionsId",
                table: "Users",
                column: "PermissionsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rules");

            migrationBuilder.DropTable(
                name: "UserAnswerStats");

            migrationBuilder.DropTable(
                name: "UserQuestionBookmarks");

            migrationBuilder.DropTable(
                name: "UserQuizAnswers");

            migrationBuilder.DropTable(
                name: "RuleReferences");

            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "UserQuizQuestions");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "UserQuizzes");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Explanations");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserPermissions");
        }
    }
}
