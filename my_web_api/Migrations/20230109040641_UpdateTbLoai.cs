using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace my_web_api.Migrations
{
    public partial class UpdateTbLoai : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HangHoa_Loais_MaLoai",
                table: "HangHoa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Loais",
                table: "Loais");

            migrationBuilder.RenameTable(
                name: "Loais",
                newName: "Loai");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Loai",
                table: "Loai",
                column: "MaLoai");

            migrationBuilder.AddForeignKey(
                name: "FK_HangHoa_Loai_MaLoai",
                table: "HangHoa",
                column: "MaLoai",
                principalTable: "Loai",
                principalColumn: "MaLoai");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HangHoa_Loai_MaLoai",
                table: "HangHoa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Loai",
                table: "Loai");

            migrationBuilder.RenameTable(
                name: "Loai",
                newName: "Loais");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Loais",
                table: "Loais",
                column: "MaLoai");

            migrationBuilder.AddForeignKey(
                name: "FK_HangHoa_Loais_MaLoai",
                table: "HangHoa",
                column: "MaLoai",
                principalTable: "Loais",
                principalColumn: "MaLoai");
        }
    }
}
