using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskBook_Entity_CodeFirst.Migrations
{
    public partial class AddStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Deadlines",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deadlines", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Prioritys",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prioritys", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TaskBooks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskName = table.Column<string>(nullable: true),
                    TechnicalSpecification = table.Column<string>(nullable: true),
                    PrioritiesID = table.Column<int>(nullable: true),
                    StatusID = table.Column<int>(nullable: true),
                    DeadlineID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskBooks_Deadlines_DeadlineID",
                        column: x => x.DeadlineID,
                        principalTable: "Deadlines",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TaskBooks_Prioritys_PrioritiesID",
                        column: x => x.PrioritiesID,
                        principalTable: "Prioritys",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TaskBooks_Status_StatusID",
                        column: x => x.StatusID,
                        principalTable: "Status",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TaskBooks_DeadlineID",
                table: "TaskBooks",
                column: "DeadlineID");

            migrationBuilder.CreateIndex(
                name: "IX_TaskBooks_PrioritiesID",
                table: "TaskBooks",
                column: "PrioritiesID");

            migrationBuilder.CreateIndex(
                name: "IX_TaskBooks_StatusID",
                table: "TaskBooks",
                column: "StatusID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskBooks");

            migrationBuilder.DropTable(
                name: "Deadlines");

            migrationBuilder.DropTable(
                name: "Prioritys");

            migrationBuilder.DropTable(
                name: "Status");
        }
    }
}
