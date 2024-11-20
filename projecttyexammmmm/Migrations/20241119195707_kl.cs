using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projecttyexammmmm.Migrations
{
    /// <inheritdoc />
    public partial class kl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Authorphone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdentitycartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookPublishedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "Geners",
                columns: table => new
                {
                    GenerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenerName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Geners", x => x.GenerId);
                });

            migrationBuilder.CreateTable(
                name: "Creadcarts",
                columns: table => new
                {
                    CreadcartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreadcartName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Creadcarts", x => x.CreadcartId);
                    table.ForeignKey(
                        name: "FK_Creadcarts_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Identitycarts",
                columns: table => new
                {
                    IdentitycartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentitycartExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identitycarts", x => x.IdentitycartId);
                    table.ForeignKey(
                        name: "FK_Identitycarts_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuthorBook",
                columns: table => new
                {
                    authorsAuthorId = table.Column<int>(type: "int", nullable: false),
                    booksBookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorBook", x => new { x.authorsAuthorId, x.booksBookId });
                    table.ForeignKey(
                        name: "FK_AuthorBook_Authors_authorsAuthorId",
                        column: x => x.authorsAuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorBook_Books_booksBookId",
                        column: x => x.booksBookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookGener",
                columns: table => new
                {
                    booksBookId = table.Column<int>(type: "int", nullable: false),
                    genersGenerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookGener", x => new { x.booksBookId, x.genersGenerId });
                    table.ForeignKey(
                        name: "FK_BookGener_Books_booksBookId",
                        column: x => x.booksBookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookGener_Geners_genersGenerId",
                        column: x => x.genersGenerId,
                        principalTable: "Geners",
                        principalColumn: "GenerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBook_booksBookId",
                table: "AuthorBook",
                column: "booksBookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookGener_genersGenerId",
                table: "BookGener",
                column: "genersGenerId");

            migrationBuilder.CreateIndex(
                name: "IX_Creadcarts_AuthorId",
                table: "Creadcarts",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Identitycarts_AuthorId",
                table: "Identitycarts",
                column: "AuthorId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorBook");

            migrationBuilder.DropTable(
                name: "BookGener");

            migrationBuilder.DropTable(
                name: "Creadcarts");

            migrationBuilder.DropTable(
                name: "Identitycarts");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Geners");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
