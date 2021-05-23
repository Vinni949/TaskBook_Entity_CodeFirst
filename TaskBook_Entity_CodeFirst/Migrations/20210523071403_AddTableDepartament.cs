using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskBook_Entity_CodeFirst.Migrations
{
    public partial class AddTableDepartament : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "departamensID",
                table: "Executors",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "departamensID",
                table: "Consumers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Departamens",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamens", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Executors_departamensID",
                table: "Executors",
                column: "departamensID");

            migrationBuilder.CreateIndex(
                name: "IX_Consumers_departamensID",
                table: "Consumers",
                column: "departamensID");

            migrationBuilder.AddForeignKey(
                name: "FK_Consumers_Departamens_departamensID",
                table: "Consumers",
                column: "departamensID",
                principalTable: "Departamens",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Executors_Departamens_departamensID",
                table: "Executors",
                column: "departamensID",
                principalTable: "Departamens",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consumers_Departamens_departamensID",
                table: "Consumers");

            migrationBuilder.DropForeignKey(
                name: "FK_Executors_Departamens_departamensID",
                table: "Executors");

            migrationBuilder.DropTable(
                name: "Departamens");

            migrationBuilder.DropIndex(
                name: "IX_Executors_departamensID",
                table: "Executors");

            migrationBuilder.DropIndex(
                name: "IX_Consumers_departamensID",
                table: "Consumers");

            migrationBuilder.DropColumn(
                name: "departamensID",
                table: "Executors");

            migrationBuilder.DropColumn(
                name: "departamensID",
                table: "Consumers");
        }
    }
}
