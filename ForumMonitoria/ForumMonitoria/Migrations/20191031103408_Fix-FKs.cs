using Microsoft.EntityFrameworkCore.Migrations;

namespace ForumMonitoria.Migrations
{
    public partial class FixFKs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mensagem_AspNetUsers_ApplicationUserId",
                table: "Mensagem");

            migrationBuilder.DropForeignKey(
                name: "FK_Topico_AspNetUsers_ApplicationUserId",
                table: "Topico");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Topico",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Topico_ApplicationUserId",
                table: "Topico",
                newName: "IX_Topico_UserId");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Mensagem",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Mensagem_ApplicationUserId",
                table: "Mensagem",
                newName: "IX_Mensagem_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mensagem_AspNetUsers_UserId",
                table: "Mensagem",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Topico_AspNetUsers_UserId",
                table: "Topico",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mensagem_AspNetUsers_UserId",
                table: "Mensagem");

            migrationBuilder.DropForeignKey(
                name: "FK_Topico_AspNetUsers_UserId",
                table: "Topico");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Topico",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Topico_UserId",
                table: "Topico",
                newName: "IX_Topico_ApplicationUserId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Mensagem",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Mensagem_UserId",
                table: "Mensagem",
                newName: "IX_Mensagem_ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mensagem_AspNetUsers_ApplicationUserId",
                table: "Mensagem",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Topico_AspNetUsers_ApplicationUserId",
                table: "Topico",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
