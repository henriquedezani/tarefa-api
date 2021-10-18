using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoBackEnd.Migrations
{
    public partial class AddTarefaModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tarefas",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Texto = table.Column<string>(type: "text", nullable: true),
                    Finalizada = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarefas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tarefas");
        }
    }
}
