using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace blog.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "blogCategories",
                columns: table => new
                {
                    categoryId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    categoryName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogCategories", x => x.categoryId);
                });

            migrationBuilder.CreateTable(
                name: "myBlogs",
                columns: table => new
                {
                    blogId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    blogTitle = table.Column<string>(nullable: false),
                    imagePath = table.Column<string>(nullable: true),
                    blogDescription = table.Column<string>(nullable: false),
                    blogDateTime = table.Column<DateTime>(nullable: false),
                    isPublished = table.Column<bool>(nullable: false),
                    blogCategorycategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_myBlogs", x => x.blogId);
                    table.ForeignKey(
                        name: "FK_myBlogs_blogCategories_blogCategorycategoryId",
                        column: x => x.blogCategorycategoryId,
                        principalTable: "blogCategories",
                        principalColumn: "categoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "comments",
                columns: table => new
                {
                    authorId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    commentAuthor = table.Column<string>(nullable: false),
                    commentDate = table.Column<DateTime>(nullable: false),
                    isHidden = table.Column<bool>(nullable: false),
                    commentAuthorEmail = table.Column<string>(nullable: false),
                    commentDescription = table.Column<string>(nullable: false),
                    blogId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comments", x => x.authorId);
                    table.ForeignKey(
                        name: "FK_comments_myBlogs_blogId",
                        column: x => x.blogId,
                        principalTable: "myBlogs",
                        principalColumn: "blogId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_comments_blogId",
                table: "comments",
                column: "blogId");

            migrationBuilder.CreateIndex(
                name: "IX_myBlogs_blogCategorycategoryId",
                table: "myBlogs",
                column: "blogCategorycategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "comments");

            migrationBuilder.DropTable(
                name: "myBlogs");

            migrationBuilder.DropTable(
                name: "blogCategories");
        }
    }
}
