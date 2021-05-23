using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskBook_Entity_CodeFirst.Migrations
{
    public partial class AddTableSpecialization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consumers_Departamens_departamensID",
                table: "Consumers");

            migrationBuilder.DropForeignKey(
                name: "FK_Executors_Departamens_departamensID",
                table: "Executors");

            migrationBuilder.RenameColumn(
                name: "departamensID",
                table: "Executors",
                newName: "DepartamensID");

            migrationBuilder.RenameIndex(
                name: "IX_Executors_departamensID",
                table: "Executors",
                newName: "IX_Executors_DepartamensID");

            migrationBuilder.RenameColumn(
                name: "departamensID",
                table: "Consumers",
                newName: "DepartamensID");

            migrationBuilder.RenameIndex(
                name: "IX_Consumers_departamensID",
                table: "Consumers",
                newName: "IX_Consumers_DepartamensID");

            migrationBuilder.AddColumn<int>(
                name: "SpecializationsID",
                table: "Executors",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SpecializationsID",
                table: "Consumers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Specializations",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specializations", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Executors_SpecializationsID",
                table: "Executors",
                column: "SpecializationsID");

            migrationBuilder.CreateIndex(
                name: "IX_Consumers_SpecializationsID",
                table: "Consumers",
                column: "SpecializationsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Consumers_Departamens_DepartamensID",
                table: "Consumers",
                column: "DepartamensID",
                principalTable: "Departamens",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Consumers_Specializations_SpecializationsID",
                table: "Consumers",
                column: "SpecializationsID",
                principalTable: "Specializations",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Executors_Departamens_DepartamensID",
                table: "Executors",
                column: "DepartamensID",
                principalTable: "Departamens",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Executors_Specializations_SpecializationsID",
                table: "Executors",
                column: "SpecializationsID",
                principalTable: "Specializations",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consumers_Departamens_DepartamensID",
                table: "Consumers");

            migrationBuilder.DropForeignKey(
                name: "FK_Consumers_Specializations_SpecializationsID",
                table: "Consumers");

            migrationBuilder.DropForeignKey(
                name: "FK_Executors_Departamens_DepartamensID",
                table: "Executors");

            migrationBuilder.DropForeignKey(
                name: "FK_Executors_Specializations_SpecializationsID",
                table: "Executors");

            migrationBuilder.DropTable(
                name: "Specializations");

            migrationBuilder.DropIndex(
                name: "IX_Executors_SpecializationsID",
                table: "Executors");

            migrationBuilder.DropIndex(
                name: "IX_Consumers_SpecializationsID",
                table: "Consumers");

            migrationBuilder.DropColumn(
                name: "SpecializationsID",
                table: "Executors");

            migrationBuilder.DropColumn(
                name: "SpecializationsID",
                table: "Consumers");

            migrationBuilder.RenameColumn(
                name: "DepartamensID",
                table: "Executors",
                newName: "departamensID");

            migrationBuilder.RenameIndex(
                name: "IX_Executors_DepartamensID",
                table: "Executors",
                newName: "IX_Executors_departamensID");

            migrationBuilder.RenameColumn(
                name: "DepartamensID",
                table: "Consumers",
                newName: "departamensID");

            migrationBuilder.RenameIndex(
                name: "IX_Consumers_DepartamensID",
                table: "Consumers",
                newName: "IX_Consumers_departamensID");

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
    }
}
