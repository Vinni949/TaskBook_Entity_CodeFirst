using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskBook_Entity_CodeFirst.Migrations
{
    public partial class AddTableExecutor_AddTableConsumer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ConsumersId",
                table: "TaskBooks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExecutorsId",
                table: "TaskBooks",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Consumers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consumers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Executors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Executors", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TaskBooks_ConsumersId",
                table: "TaskBooks",
                column: "ConsumersId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskBooks_ExecutorsId",
                table: "TaskBooks",
                column: "ExecutorsId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskBooks_Consumers_ConsumersId",
                table: "TaskBooks",
                column: "ConsumersId",
                principalTable: "Consumers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskBooks_Executors_ExecutorsId",
                table: "TaskBooks",
                column: "ExecutorsId",
                principalTable: "Executors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskBooks_Consumers_ConsumersId",
                table: "TaskBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskBooks_Executors_ExecutorsId",
                table: "TaskBooks");

            migrationBuilder.DropTable(
                name: "Consumers");

            migrationBuilder.DropTable(
                name: "Executors");

            migrationBuilder.DropIndex(
                name: "IX_TaskBooks_ConsumersId",
                table: "TaskBooks");

            migrationBuilder.DropIndex(
                name: "IX_TaskBooks_ExecutorsId",
                table: "TaskBooks");

            migrationBuilder.DropColumn(
                name: "ConsumersId",
                table: "TaskBooks");

            migrationBuilder.DropColumn(
                name: "ExecutorsId",
                table: "TaskBooks");
        }
    }
}
